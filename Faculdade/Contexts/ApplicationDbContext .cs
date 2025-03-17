using Faculdade.Models;
using Microsoft.EntityFrameworkCore;

namespace Faculdade.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        // Construtor que recebe as opções de configuração do DbContext que serão utilizadas pelo Entity Framework Core para acessar o banco de dados.
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
       : base(options)
        {
        }

        // Definição das tabelas do banco de dados
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuração das chaves primárias compostas
            modelBuilder.Entity<DisciplinaCurso>()
                .HasKey(dc => new { dc.ID_Disciplina, dc.ID_Curso });

            modelBuilder.Entity<AlunoCursoDisciplina>()
                .HasKey(acd => new { acd.ID_Aluno, acd.ID_Curso, acd.ID_Disciplina });

            modelBuilder.Entity<ProfessorTurma>()
                .HasKey(pt => new { pt.ID_Professor, pt.ID_Turma });

            modelBuilder.Entity<CursoUnidade>()
                .HasKey(cu => new { cu.ID_Curso, cu.ID_Unidade });

            // Configuração dos relacionamentos entre tabelas

            // Relação N para N entre Curso e Disciplina
            modelBuilder.Entity<DisciplinaCurso>()
                .HasOne(dc => dc.Curso)
                .WithMany(c => c.DisciplinasCursos)
                .HasForeignKey(dc => dc.ID_Curso);

            modelBuilder.Entity<DisciplinaCurso>()
                .HasOne(dc => dc.Disciplina)
                .WithMany(d => d.DisciplinasCursos)
                .HasForeignKey(dc => dc.ID_Disciplina);

            // Relação N para N entre Aluno, Curso e Disciplina
            modelBuilder.Entity<AlunoCursoDisciplina>()
                .HasOne(acd => acd.Aluno)
                .WithMany(a => a.AlunosCursosDisciplinas)
                .HasForeignKey(acd => acd.ID_Aluno);

            modelBuilder.Entity<AlunoCursoDisciplina>()
                .HasOne(acd => acd.Curso)
                .WithMany(c => c.AlunosCursosDisciplinas)
                .HasForeignKey(acd => acd.ID_Curso);

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

