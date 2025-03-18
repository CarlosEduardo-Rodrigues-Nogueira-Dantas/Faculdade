namespace Faculdade.Models
{
    public class Disciplina
    {
        // Propriedades da classe Disciplina
        public int IdDisciplina { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        // Adicionando a propriedade de navegação para a relação N:N com Curso
        public List<DisciplinaCurso> DisciplinasCursos { get; set; } = new List<DisciplinaCurso>();
        public List<AlunoCursoDisciplina> AlunosCursosDisciplinas { get; set; } = new List<AlunoCursoDisciplina>();


    }
}
