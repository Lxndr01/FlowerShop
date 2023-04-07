using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViragokAPI.Models
{
    [Table("ertekesites")]
    public class Ertekesites
    {
        [Key]
        public int id { get; set; }
        [ForeignKey("email")]
        public string email { get; set; }
        [ForeignKey("viragid")]
        public int viragid { get; set; }
        public int mennyiseg { get; set; }

    }
}
