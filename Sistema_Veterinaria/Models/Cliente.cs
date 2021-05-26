using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_Veterinaria.Models
{
    public class Cliente
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string contraseña { get; set; }
        public int rol { get; set; }
    }
}