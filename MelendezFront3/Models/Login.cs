using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MelendezFront3.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Usuario Requerido")]
        [Display(Name ="Usuario")]
        public string User { get; set; }

        [Required(ErrorMessage = "Contraseña Requerida")]
        [Display(Name = "Contraseña")]
        public string Pass { get; set; }
    }
}