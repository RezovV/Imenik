using System.ComponentModel.DataAnnotations;

namespace Aplikacija.Models
{
    public class Korisnik
    {
        [Key]
        public int id { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string tel_broj { get; set; }
        public string email { get; set; }
        public string datum_kre { get; set; }
        public string vrijeme_kre { get; set; }
        public string datum_pro { get; set; }
    }
}
