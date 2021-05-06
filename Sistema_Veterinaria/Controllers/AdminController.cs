using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sistema_Veterinaria.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Mantenimiento()
        {
            return View();
        }

        public ActionResult Usuario()
        {
            return View();
        }
    }
}