using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Sistema_Veterinaria.Models;

namespace Sistema_Veterinaria.Controllers
{
    public class DeliveryController : Controller
    {
        DeliveryDAO delidao = new DeliveryDAO();
        // GET: Delivery

        public ActionResult Index()
        {

            //if (ModelState.IsValid == true)
            //{
            //    int codusr = int.Parse(Session["codigo"].ToString());
            //    string cod = delidao.AgregarPedido(codusr, total);

            //}
            return View();
        }

        [HttpPost]
        public ActionResult Registro(string direccion, string informacion, string correo, string telefono, double total)
        {

            if (ModelState.IsValid == true)
            {
                int codusr = int.Parse(Session["codigo"].ToString());
                string cod = delidao.AgregarPedido(codusr, total);
                string xcod=delidao.AgregarEntregaPedidos(int.Parse(cod), direccion, informacion, correo, telefono);
                
            }
            return RedirectToAction("Index", "Menu");
        }
    }
}