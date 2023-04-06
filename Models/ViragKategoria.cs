using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViragokAPI.Models
{
    [Table("viragkategoriak")]
    public class ViragKategoria
    {
        [Key]
        public int id { get; set; } 
        public string nev { get; set; }
        public string megjegyzes { get; set;}
    }
}
