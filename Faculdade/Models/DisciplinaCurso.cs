namespace Faculdade.Models
{
    public class DisciplinaCurso
    {
        // Propriedades da classe DisciplinaCurso
        public int ID_Disciplina { get; set; }
        public int ID_Curso { get; set; }
        public Disciplina Disciplina { get; set; }
        public Curso Curso { get; set; }
    }
}
