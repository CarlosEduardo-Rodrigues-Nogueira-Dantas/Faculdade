namespace Faculdade.Models
{
    public class AlunoTurma
    {
        public int ID_Aluno { get; set; }
        public int ID_Turma { get; set; }

        // Essa propriedade é uma propriedade de navegação que representa o relacionamento N para 1 entre Aluno e AlunoTurma
        public List<Aluno> Avaliacoes { get; set; } = new List<Aluno>();
        // Essa propriedade é uma propriedade de navegação que representa o relacionamento N para 1 entre Turma e AlunoTurma
        public Turma Turma { get; set; }
    }
}
