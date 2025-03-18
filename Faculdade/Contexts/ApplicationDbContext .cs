using Faculdade.Models;
using Microsoft.EntityFrameworkCore;

namespace Faculdade.Contexts
{
    // Classe que representa o contexto do banco de dados da aplicação. 
    public class ApplicationDbContext : DbContext
    {
        // Construtor que recebe as opções de configuração do DbContext que serão utilizadas pelo Entity Framework Core para se conectar ao banco de dados.
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
       : base(options)
        {
        }

        // Propriedades que representam as tabelas do banco de dados que serão criadas pelo Entity Framework Core a partir dos modelos. 
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Unidade> Unidades { get; set; }
        public DbSet<Avaliacao> Avaliacoes { get; set; }
        public DbSet<DisciplinaCurso> DisciplinasCursos { get; set; }
        public DbSet<AlunoCursoDisciplina> AlunosCursosDisciplinas { get; set; }
        public DbSet<ProfessorTurma> ProfessoresTurmas { get; set; }
        public DbSet<CursoUnidade> CursosUnidades { get; set; }

        // Método que será chamado pelo Entity Framework Core para configurar o modelo do banco de dados.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuração das chaves primárias compostas
            modelBuilder.Entity<DisciplinaCurso>()
                .HasKey(dc => new { dc.ID_Disciplina, dc.ID_Curso });

            // Configuração das chaves primárias compostas 
            modelBuilder.Entity<AlunoCursoDisciplina>()
                .HasKey(acd => new { acd.ID_Aluno, acd.ID_Curso, acd.ID_Disciplina });

            // Configuração das chaves primárias compostas
            modelBuilder.Entity<ProfessorTurma>()
                .HasKey(pt => new { pt.ID_Professor, pt.ID_Turma });

            // Configuração das chaves primárias compostas
            modelBuilder.Entity<CursoUnidade>()
                .HasKey(cu => new { cu.ID_Curso, cu.ID_Unidade });

            // Configuração dos relacionamentos entre tabelas

            // Relação 1 para N entre Curso e Turma 
            modelBuilder.Entity<DisciplinaCurso>()
                .HasOne(dc => dc.Curso)
                .WithMany(c => c.DisciplinasCursos)
                .HasForeignKey(dc => dc.ID_Curso);

            // Relação N para N entre Curso e Unidade 
            modelBuilder.Entity<DisciplinaCurso>()
                .HasOne(dc => dc.Disciplina)
                .WithMany(d => d.DisciplinasCursos)
                .HasForeignKey(dc => dc.ID_Disciplina);

            // Relação N para N entre Aluno, Curso e Disciplina
            modelBuilder.Entity<AlunoCursoDisciplina>()
                .HasOne(acd => acd.Aluno)
                .WithMany(a => a.AlunosCursosDisciplinas)
                .HasForeignKey(acd => acd.ID_Aluno);

            // Relação N para N entre Aluno, Curso e Disciplina
            modelBuilder.Entity<AlunoCursoDisciplina>()
                .HasOne(acd => acd.Curso)
                .WithMany(c => c.AlunosCursosDisciplinas)
                .HasForeignKey(acd => acd.ID_Curso);

            // Relação N para N entre Aluno, Curso e Disciplina
            modelBuilder.Entity<AlunoCursoDisciplina>()
                .HasOne(acd => acd.Disciplina)
                .WithMany(d => d.AlunosCursosDisciplinas)
                .HasForeignKey(acd => acd.ID_Disciplina);

            // Relação 1 para N entre Avaliação e Aluno
            modelBuilder.Entity<Avaliacao>()
                .HasOne(a => a.Aluno)
                .WithMany(al => al.Avaliacoes)
                .HasForeignKey(a => a.IdAluno);

            // Relação 1 para N entre Avaliação e Turma
            modelBuilder.Entity<Avaliacao>()
                .HasOne(a => a.Turma)
                .WithMany(t => t.Avaliacoes)
                .HasForeignKey(a => a.IdTurma);
        }
    }
}

