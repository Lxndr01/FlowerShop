using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViragokAPI.Models
{
    [Table("vevok")]
    public class Vevok
    {
        [Key]
        public string email { get; set; }
        public string nev { get; set; }
        public string lakcim { get; set; }
    }
}
