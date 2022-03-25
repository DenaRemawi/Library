using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class SignupModel
    {
        [Required]
        public string Name { get; set; }
        [Required]

        public string UserName { get; set; }

        [Required]

        public string Email { get; set; }
        [Required]

        public string Password { get; set; }

        [Required]
        public string Role_Id { get; set; }
    }
}