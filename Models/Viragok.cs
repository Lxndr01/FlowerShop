using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViragokAPI.Models
{
    [Table("viragok")]
    public class Viragok
    {
        [Key]
        public int id { get; set; }
        public string nev { get; set; }
        public string szin { get; set; }
        [ForeignKey("kategoriaId")]
        public int kategoriaId { get; set; }
        public int mennyiseg{ get; set; }
        public double egysegar{ get; set; }
    }
}
