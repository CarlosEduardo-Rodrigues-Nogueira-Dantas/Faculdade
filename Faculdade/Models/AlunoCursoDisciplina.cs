namespace Faculdade.Models
{
    public class AlunoCursoDisciplina
    {
        public int ID_Aluno { get; set; }
        public int ID_Curso { get; set; }
        public int ID_Disciplina { get; set; }
        public DateTime DataMatricula { get; set; }
        public decimal? Nota { get; set; }

        // Chaves estrangeiras e navegação
        public Aluno Aluno { get; set; }
        public Curso Curso { get; set; }
        public Disciplina Disciplina { get; set; }
    }
}
