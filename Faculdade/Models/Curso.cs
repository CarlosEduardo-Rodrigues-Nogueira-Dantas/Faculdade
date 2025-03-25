namespace Faculdade.Models
{
    public class Curso
    {
        // Propriedades da classe Curso
        public int IdCurso { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        // Navegação entre as entidades Curso e DisciplinaCurso e AlunoCursoDisciplina
        public List<DisciplinaCurso> DisciplinasCursos { get; set; } = new List<DisciplinaCurso>();
        public List<AlunoCursoDisciplina> AlunosCursosDisciplinas { get; set; } = new List<AlunoCursoDisciplina>();


    }
}
