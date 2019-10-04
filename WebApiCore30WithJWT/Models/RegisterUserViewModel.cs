using System.ComponentModel.DataAnnotations;

namespace WebApiCore30WithJWT.Models
{
    public class RegisterUserViewModel
    {
        [Required(ErrorMessage = "Campo {0} Obrigatório")]
        [EmailAddress(ErrorMessage = "Campo {0} no formato inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo {0} Obrigatório")]
        [StringLength(100, ErrorMessage = "Campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 6)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Senha não confere")]
        public string ConfirmPassword { get; set; }
    }
}
