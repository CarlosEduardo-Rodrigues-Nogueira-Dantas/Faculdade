using System.Reflection.Metadata.Ecma335;

namespace Faculdade.Models
{
    public class Avaliacao
    {
        public int IdAvaliacao { get; set; }
        public int IdAluno { get; set; }
        public int IdTurma { get; set; }
        public DateTime DataAvalicao { get; set; }
        public decimal Nota { get; set; }

        // Essa propriedade é uma propriedade de navegação que representa o relacionamento 1 para 1 entre Avaliacao e Aluno
        public Aluno Aluno { get; set; }       
        
        // Essa propriedade é uma propriedade de navegação que representa o relacionamento 1 para N entre Avaliacao e Turma
        public Turma Turma { get; set; }

    }
}
