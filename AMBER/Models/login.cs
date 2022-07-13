using System.ComponentModel.DataAnnotations;

namespace AMBER.Models
{
    public class login
    {
        [Key]
        public string username { get; set; }
        public string password { get; set; }

    }
}
