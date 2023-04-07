using System.ComponentModel.DataAnnotations;

namespace ViragShopGUI.Models
{
    public class v_ertekesitesek
    {
        public int id { get; set; }
        public string email { get; set; }
        public string nev { get; set; }
        public int viragid { get; set; }
        public string virágnév { get; set; }
        public int mennyiseg { get; set; }
        public string szin { get; set; }
    }
}
