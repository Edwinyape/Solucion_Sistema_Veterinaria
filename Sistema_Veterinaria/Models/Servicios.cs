using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_Veterinaria.Models
{
    public class Servicios
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public decimal precio { get; set; }
        public string descripcion { get; set; }
        public string horario { get; set; }
        public DateTime fechas { get; set; }
    }
}