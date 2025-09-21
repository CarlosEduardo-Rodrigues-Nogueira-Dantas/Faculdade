using Faculdade.Models;
using Faculdade.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Faculdade.Controllers
{
    [Route("api/alunos")]
    [ApiController]
    public class AlunoController : Controller
    {
        [HttpPost]
        [Route("")]
        public IActionResult PostAluno([FromServices] IOptions<ConnectionStringOptions> options, [FromBody] Aluno aluno)
        {
            using (SqlConnection Connection = new(options.Value.MyConnection))
            {
                Connection.Open();

                SqlCommand command = new();
                command.Connection = Connection;
                command.CommandText = @"insert into Aluno (CPF,Nome,Email,DataNasc,DataCriacao) values (@CPF,@Nome,@Email,@DataNasc,@DataCriacao)";
                command.CommandType = System.Data.CommandType.Text;

                command.Parameters.Add(new SqlParameter("Nome", aluno.Nome));
                command.Parameters.Add(new SqlParameter("CPF", aluno.CPF));
                command.Parameters.Add(new SqlParameter("Email", aluno.Email));
                command.Parameters.Add(new SqlParameter("DataNasc", aluno.DataNascimento));
                command.Parameters.Add(new SqlParameter("DataCriacao", aluno.Telefone));
                command.Parameters.Add(new SqlParameter("DataCriacao", aluno.Endereco));

                int IdadeAtual = Convert.ToInt32(DateTime.Today.Subtract(aluno.DataNascimento).TotalDays / 365);

                command.ExecuteNonQuery();
            }

                return Ok();
        }

        [HttpPut]
        [Route("{IdAluno}")]

        public IActionResult PutAluno([FromServices] IOptions<ConnectionStringOptions> options, [FromRoute] int IdUsuario, [FromBody] Aluno aluno)
        {
            using (SqlConnection Connection = new SqlConnection(options.Value.MyConnection))
            {
                Connection.Open();

                SqlCommand command = new();
                command.Connection = Connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = @"UPDATE Aluno SET CPF = @CPF,Nome = @Nome,Email = @Email,DataNasc = @DataNasc,DataCriacao = @DataCriacao where Id = @Id";

                command.Parameters.Add(new SqlParameter("Nome", aluno.Nome));
                command.Parameters.Add(new SqlParameter("CPF", aluno.CPF));
                command.Parameters.Add(new SqlParameter("Email", aluno.Email));
                command.Parameters.Add(new SqlParameter("DataNasc", aluno.DataNascimento));
                command.Parameters.Add(new SqlParameter("DataCriacao", aluno.Telefone));
                command.Parameters.Add(new SqlParameter("DataCriacao", aluno.Endereco));

                command.Parameters.Add(new SqlParameter("Id", IdUsuario));


                command.ExecuteNonQuery();
            }
            return Ok();
        }

        [HttpDelete]
        [Route("{IdAluno}")]

        public IActionResult DeleteAluno([FromServices] IOptions<ConnectionStringOptions> options, [FromRoute] int IdAluno)
        {
            using (SqlConnection connection = new SqlConnection(options.Value.MyConnection))
            {
                connection.Open();

                SqlCommand command = new();
                command.Connection = connection;
                command.CommandText = @"delete from Aluno where Id = @Id";

                command.Parameters.Add(new SqlParameter("Id", IdAluno));

                command.ExecuteNonQuery();
            }

            return Ok();
        }


        [HttpGet]
        [Route("{idAluno}")]
        public IActionResult GetAlunoo([FromServices] IOptions<ConnectionStringOptions> options, [FromQuery] int idUsuario)
        {
            Aluno aluno = null;

            using (SqlConnection connection = new SqlConnection(options.Value.MyConnection))
            {
                connection.Open();

                SqlCommand command = new();
                command.Connection = connection;
                command.CommandText = @"select * from Aluno where Id = @Id";
                command.CommandType = System.Data.CommandType.Text;

                command.Parameters.Add(new SqlParameter("Id", idUsuario));

                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        aluno = new()
                        {
                            CPF = dr.GetString(1),
                            Endereco = dr.GetString(5),
                            DataNascimento = dr.GetDateTime(2),
                            Email = dr.GetString(4),
                            IdAluno = dr.GetInt32(3),
                            Nome= dr.GetString(0)
                        };
                    }
                }
            }
            return Ok(aluno);
        }


        private bool VerificarAlunoExistente(IOptions<ConnectionStringOptions> options, string CPF, string Email)
        {
            using (SqlConnection connection = new SqlConnection(options.Value.MyConnection))
            {
                connection.Open();

                Aluno aluno = new();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = @"select Id from Aluno where CPF = @CPF and Email = @Email";

                command.Parameters.Add(new SqlParameter("Email", Email));
                command.Parameters.Add(new SqlParameter("CPF", CPF));

                int? id = (int?)command.ExecuteScalar();


                return id != null;

            }
        }
    }
}

