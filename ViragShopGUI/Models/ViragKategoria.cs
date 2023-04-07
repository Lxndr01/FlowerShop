using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViragShopGUI.Models
{
        
    public class ViragKategoria
    {
        public int id { get; set; }
        public string nev { get; set; }
        public string megjegyzes { get; set; }
    }
}
