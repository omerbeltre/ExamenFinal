using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Visitas.Models
{
    public class Visit
    {
        [Key]
        public int idVisitas { get; set; }
        public String Motivo_Visita{ get; set; }

        public String Fecha_Visita { get; set; }

        public String Hora_Entrada { get; set; }

        public String Hora_Salida { get; set; }
        public String Nombre_Completo { get; set; }

        public String Contacto_que_lo_recibio { get; set; }

    }
}