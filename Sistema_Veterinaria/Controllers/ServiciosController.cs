using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Sistema_Veterinaria.Models;

namespace Sistema_Veterinaria.Controllers
{
    public class ServiciosController : Controller
    {
        ServiciosDAO sdao = new ServiciosDAO();
        // GET: Servicios
        public ActionResult Index()
        {
            List<Servicios> lista = sdao.ListarServicios();
            return View(lista);
        }

        public ActionResult AgregarServicio()
        {
            Servicios s = new Servicios();
            return View(s);
        }

        [HttpPost]
        public ActionResult AgregarServicio(Servicios s)
        {
            if (ModelState.IsValid == true)
            {
                ViewBag.MENSAJE = sdao.AgregarServicio(s);
            }

            return RedirectToAction("Mantenimiento", "Admin");
        }

        //public ActionResult ActualizarServicio(int cod)
        //{
        //    Servicios s = sdao.ListarServicios().Find(x => x.codigo == cod);
        //    return View(s);
        //}

        [HttpPost]
        public ActionResult ActualizarServicio(Servicios s)
        {
            if (ModelState.IsValid == true)
            {
                ViewBag.MENSAJE = sdao.ActualizarServicio(s);
            }

            return RedirectToAction("Mantenimiento", "Admin");
        }

        //public ActionResult EliminarServicio(int cod)
        //{
        //    Servicios s = sdao.ListarServicios().Find(x => x.codigo == cod);
        //    return View(s);
        //}

        public ActionResult EliminarServicio(int cod)
        {
            ViewBag.MENSAJE = sdao.EliminarServicio(cod);

            return RedirectToAction("Mantenimiento", "Admin");
        }
    }
}