namespace Faculdade.Models
{
    public class Aluno
    {
        public int IdAluno { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento  { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }

        // Essa propriedade é uma lista de objetos do tipo AlunoCursoDisciplina, que é a tabela de relacionamento entre Aluno, Curso e Disciplina
        public List<AlunoCursoDisciplina> AlunosCursosDisciplinas { get; set; } = new List<AlunoCursoDisciplina>();

        // Essa propriedade é uma lista de objetos do tipo AlunoTurma, que é a tabela de relacionamento entre Aluno e Turma
        public List<AlunoTurma> AlunosTurmas { get; set; } = new List<AlunoTurma>();
        // Essa propriedade é uma lista de objetos do tipo Avaliacao, que é a tabela de relacionamento entre Aluno e Turma
        public List<Avaliacao> Avaliacoes { get; set; } = new List<Avaliacao>();

    }
}
