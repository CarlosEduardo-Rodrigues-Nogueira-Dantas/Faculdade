namespace Faculdade.Models
{
    public class CursoUnidade
    {
        // Propriedades da classe CursoUnidade 
        public int ID_Curso { get; set; }
        public int ID_Unidade { get; set; }

        // Navegação entre as entidades Curso e Unidade
        public Curso Curso { get; set; }
        public Unidade Unidade { get; set; }
    }
}
