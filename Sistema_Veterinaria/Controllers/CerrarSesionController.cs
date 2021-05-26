using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sistema_Veterinaria.Controllers
{
    public class CerrarSesionController : Controller
    {
        // GET: CerrarSesion
        public ActionResult Cerrar_Sesion()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Menu");
        }
    }
}