using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_Veterinaria.Models
{
    public class Productos
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public decimal precio { get; set; }
        public int codigoSerie { get; set; }
        public string marca { get; set; }
        public string descripcion { get; set; }
        public string descripcionHtml { get; set; }
        public string foto1 { get; set; }
        public string foto2 { get; set; }
        public string foto3 { get; set; }
    }
}