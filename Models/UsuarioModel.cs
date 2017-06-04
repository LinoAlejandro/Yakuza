using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Yakuza.Models
{
    public class UsuarioModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Ingrese un nickname")]
        [Display(Name = "NickName")]
        public string nickName { get; set; }

        [Required(ErrorMessage = "Incluya su nombre")]
        [Display(Name = "Nombre")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "Incluya su apellido")]
        [Display(Name = "Apellido Paterno")]
        public string apellidoPaterno { get; set; }

        [Required(ErrorMessage = "Incluya su apellido")]
        [Display(Name = "Apellido Paterno")]
        public string apellidoMaterno { get; set; }

        [Required(ErrorMessage = "Incluya su fecha de nacimiento")]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime fechaNacimiento { get; set; }
    }
}