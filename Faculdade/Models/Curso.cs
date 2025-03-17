namespace Faculdade.Models
{
    public class Curso
    {
        public int IdCurso { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }


        public List<DisciplinaCurso> DisciplinasCursos { get; set; } = new List<DisciplinaCurso>();
        public List<AlunoCursoDisciplina> AlunosCursosDisciplinas { get; set; } = new List<AlunoCursoDisciplina>();


    }
}
