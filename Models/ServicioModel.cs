using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Yakuza.Models
{
    public class ServicioModel
    {
        [Required (ErrorMessage = "Inserte el parametro")]
        public string parametro1 { get; set; }

        [Required(ErrorMessage = "Inserte el parametro")]
        public string parametro2 { get; set; }

        public string resultado { get; set; }
    }
}