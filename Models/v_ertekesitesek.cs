using System.ComponentModel.DataAnnotations;

namespace ViragokAPI.Models
{
    public class v_ertekesitesek
    {
        [Key]
        public int id { get; set; }
        public string email { get; set; }
        public string nev { get; set; }
        public int viragid { get; set; }
        public string virágnév { get; set; }
        public int mennyiseg { get; set; }
        public string szin { get; set; }
    }
}
