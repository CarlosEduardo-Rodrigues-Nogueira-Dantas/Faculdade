namespace Faculdade.Models
{
    public class Turma
    {
        public int IdTurma { get; set; }
        public int IdDisciplina { get; set; }
        public string Name { get; set; }
        public string Semestre { get; set; }
        public int CodigoDaTurma { get; set; }
        public int AnoTurma { get; set; }

        // Essa propriedade é uma propriedade de navegação que representa o relacionamento 1 para N entre Turma e Disciplina
        public List<AlunoTurma> AlunosTurmas { get; set; } = new List<AlunoTurma>();

        // Essa propriedade é uma propriedade de navegação que representa o relacionamento 1 para N entre Turma e Professor
        public List<Avaliacao> Avaliacoes { get; set; } = new List<Avaliacao>();

    }
}
