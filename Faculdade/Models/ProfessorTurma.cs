namespace Faculdade.Models
{
    public class ProfessorTurma
    {
        public int ID_Professor { get; set; }
        public int ID_Turma { get; set; }
        public Professor Professor { get; set; }
        public Turma Turma { get; set; }
    }
}
