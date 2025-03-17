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

    }
}
