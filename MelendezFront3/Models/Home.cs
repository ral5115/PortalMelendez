using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MelendezFront3.Models;

namespace MelendezFront3.Models
{
    public class Home
    {
        
        public string InterfazId { get; set; }

        [Required(ErrorMessage = "Debe seleccionar una Fecha Inicial...")]
        [Display(Name = "Fecha Inicial")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = false)]
        public DateTime FechaIni { get; set; }

        [Required(ErrorMessage = "Debe seleccionar una Fecha Final...")]
        [Display(Name = "Fecha Final")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = false)]
        public DateTime FechaFin { get; set; }

        //[Required(ErrorMessage = "Debe Digitar Un Lote...")]
        [Display(Name = "Lote")]
        public string Lote { get; set; }

        [Required(ErrorMessage = "Debe Seleccionar una empresa...")]
        public List<Empresa> Empresa { get; set; }

        public string Interfaz { get; set; }
    }
}