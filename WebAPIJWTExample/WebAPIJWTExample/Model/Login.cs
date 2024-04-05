using System.ComponentModel.DataAnnotations;

namespace WebAPIJWTExample.Model
{
    public class Login
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }

    }
}
