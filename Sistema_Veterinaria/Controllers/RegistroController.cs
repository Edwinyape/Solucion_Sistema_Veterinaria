using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sistema_Veterinaria.Models;

namespace Sistema_Veterinaria.Controllers
{
    public class RegistroController : Controller
    {
        RegistroDAO rdao = new RegistroDAO();
        // GET: Registro

        public ActionResult Cliente()
        {
            List<Cliente> lista = rdao.ListarCliente();
            return View(lista);
        }

        public ActionResult RegistrarCliente()
        {
            Cliente c = new Cliente();
            return View(c);
        }

        [HttpPost]
        public ActionResult RegistrarCliente(Cliente c)
        {
            if (ModelState.IsValid == true)
            {
                ViewBag.MENSAJE = rdao.AgregarCliente(c);
            }
            return View(c);
        }

        [HttpPost]
        public ActionResult AgregarCliente(Cliente c)
        {
            if (ModelState.IsValid == true)
            {
                ViewBag.MENSAJE = rdao.AgregarCliente(c);
            }

            return RedirectToAction("Usuario", "Admin");
        }

        [HttpPost]
        public ActionResult ActualizarCliente(Cliente c)
        {
            if (ModelState.IsValid == true)
            {
                ViewBag.MENSAJE = rdao.ActualizarCliente(c);
            }

            return RedirectToAction("Usuario", "Admin");
        }

        public ActionResult EliminarCliente(int cod)
        {
            ViewBag.MENSAJE = rdao.EliminarCliente(cod);

            return RedirectToAction("Usuario", "Admin");
        }

        public ActionResult Mascota()
        {
            List<Mascota> lista = rdao.ListarMascota();
            return View(lista);
        }

        public ActionResult RegistrarMascota()
        {
            Mascota m = new Mascota();
            return View(m);
        }

        [HttpPost]
        public ActionResult RegistrarMascota(Mascota m, int cod)
        {
            if (ModelState.IsValid == true) 
            {
                ViewBag.MENSAJE = rdao.AgregarMascota(m, cod);
            }
            return View(m);
        }

        [HttpPost]
        public ActionResult AgregarMascota(Mascota m)
        {
            if (ModelState.IsValid == true)
            {
                ViewBag.MENSAJE = rdao.AgregarMascota(m, 1);
            }

            return RedirectToAction("Usuario", "Admin");
        }

        [HttpPost]
        public ActionResult ActualizarMascota(Mascota m)
        {
            if (ModelState.IsValid == true)
            {
                ViewBag.MENSAJE = rdao.ActualizarMascota(m);
            }

            return RedirectToAction("Usuario", "Admin");
        }

        public ActionResult EliminarMascota(int cod)
        {
            ViewBag.MENSAJE = rdao.EliminarMascota(cod);

            return RedirectToAction("Usuario", "Admin");
        }
    }
}