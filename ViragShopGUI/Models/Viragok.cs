using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViragShopGUI.Models
{
        
    public class Viragok
    {
        public int id { get; set; }
        public string nev { get; set; }
        public string szin { get; set; }
            
        public int kategoriaId { get; set; }
        public int mennyiseg { get; set; }
        public double egysegar { get; set; }
    }
}
