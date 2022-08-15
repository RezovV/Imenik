using System.ComponentModel.DataAnnotations;

namespace Aplikacija.Models
{
    public class Contact
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string surename { get; set; }
        public string tel_number { get; set; }
        public string email { get; set; }
        public string date_cre { get; set; }
        public string time_cre { get; set; }
        public string date_cha { get; set; }
    }
}
