using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViragokAPI.Models
{
    [Table("v_viragok")]
    public class v_viragok
    {
        [Key]
        public int id { get; set; }
        public string virágnév { get; set; }
        public int kategoriaid { get; set; }
        public string szin { get; set; }
        public int mennyiseg { get; set; }
        public double egysegar { get; set; }
        public string nev { get; set; }

    }
}
