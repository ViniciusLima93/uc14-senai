
using System.ComponentModel.DataAnnotations;

namespace Chapter.ViewModels
{
    public class LoginViewModel
    {
        [Required (ErrorMessage ="E-mail requerido")]

        public string  Email { get; set; }

        [Required(ErrorMessage ="Senha Requerida")]

        public string Senha { get; set; }
    }
}
