namespace Faculdade.Models
{
    public class CursoUnidade
    {
        public int ID_Curso { get; set; }
        public int ID_Unidade { get; set; }

        public Curso Curso { get; set; }
        public Unidade Unidade { get; set; }
    }
}
