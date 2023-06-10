using Microsoft.VisualBasic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Tictactoe.Entities
{
    public class Game
    {
        [Key]
        public int Id { get; set; }

        public string PlayerXid { get; set; }
        public string PlayerYid { get; set; }
        public VariantType board { get; set; }
        public int winner { get; set; }
        public DateTime date { get; set; }

    }
}