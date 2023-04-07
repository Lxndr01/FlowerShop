using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViragShopGUI.Models
{
    public class Ertekesites
    {
        public int id { get; set; }
        public string email { get; set; }
        public int viragid { get; set; }
        public int mennyiseg { get; set; }

    }
}
