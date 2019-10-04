using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCore30WithJWT.Models
{
    public class LoginUserViewModel
    {
        [Required(ErrorMessage = "Campo {0} Obrigatório")]
        [EmailAddress(ErrorMessage = "Campo {0} no formato inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo {0} Obrigatório")]
        [StringLength(100, ErrorMessage = "Campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 6)]
        public string Password { get; set; }
    }
}
