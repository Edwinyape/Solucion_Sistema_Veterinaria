using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Sistema_Veterinaria.Models;

namespace Sistema_Veterinaria.Controllers
{
    public class LoginController : Controller
    {
        LoginDAO ldao = new LoginDAO();
        // GET: Login
        public ActionResult Validacion()
        {
            Cliente c = new Cliente();
            return View(c);
        }

        [HttpPost]
        public ActionResult Validacion(Cliente c)
        {
            if (ModelState.IsValid == true)
            {
                List<Cliente> lista = ldao.Validar(c);

                if(lista[0].rol.Equals(1))
                {
                    Session["codigo"] = lista[0].codigo;
                    Session["nombre"] = lista[0].nombre;
                    Session["apellido"] = lista[0].apellido;
                    Session["rol"] = lista[0].rol;
                    return RedirectToAction("Mantenimiento", "Admin");
                }
                else
                {
                    Session["codigo"] = lista[0].codigo;
                    Session["nombre"] = lista[0].nombre;
                    Session["apellido"] = lista[0].apellido;
                    Session["rol"] = lista[0].rol;
                    return RedirectToAction("Index", "Menu");
                }
            }

            return View();
            
        }
    }
}