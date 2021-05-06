using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_Veterinaria.Models
{
    public class Mascota
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string especie { get; set; }
        public string raza { get; set; }
        public int edad { get; set; }
        public string sexo { get; set; }
        public DateTime fechanacimiento { get; set; }
    }
}