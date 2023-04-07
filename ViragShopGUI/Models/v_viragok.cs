using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViragShopGUI.Models
{
    
    public class v_viragok
    {
        public int id { get; set; }
        public string virágnév { get; set; }
        public int kategoriaid { get; set; }
        public string szin { get; set; }
        public int mennyiseg { get; set; }
        public double egysegar { get; set; }
        public string nev { get; set; }

    }
}
