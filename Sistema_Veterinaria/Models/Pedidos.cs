using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_Veterinaria.Models
{
    public class Pedidos
    {
        public int codigo { get; set; }
        public int usuario { get; set; }
        public DateTime fecha { get; set; }
        public double total { get; set; }
        public int estado { get; set; }
        public string direccion { get; set; }
        public string informacion { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
    }
}