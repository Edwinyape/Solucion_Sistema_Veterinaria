using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Sistema_Veterinaria.Models;
using System.IO;

namespace Sistema_Veterinaria.Controllers
{
    public class ProductosController : Controller
    {
        ProductoDAO pdao = new ProductoDAO();
        // GET: Productos
        public ActionResult Index()
        {
            List<Productos> lista = pdao.ListarProductos();
            return View(lista);
        }

        public ActionResult AgregarProducto()
        {
            Productos p = new Productos();
            return View(p);
        }

        [HttpPost]
        public ActionResult AgregarProducto(Productos p)
        {
            if (ModelState.IsValid == true)
            {
                //var filename1 = Path.GetFileName(foto1.FileName);
                //var filename2 = Path.GetFileName(foto2.FileName);
                //var filename3 = Path.GetFileName(foto3.FileName);

                //var path1 = Path.Combine(Server.MapPath("~/Imagenes"), filename1);
                //var path2 = Path.Combine(Server.MapPath("~/Imagenes"), filename2);
                //var path3 = Path.Combine(Server.MapPath("~/Imagenes"), filename3);

                //foto1.SaveAs(path1);
                //foto2.SaveAs(path2);
                //foto3.SaveAs(path3);

                //p.foto1 = filename1;
                //p.foto2 = filename2;
                //p.foto3 = filename3;

                ViewBag.MENSAJE = pdao.AgregarProducto(p);
            }

            return RedirectToAction("Mantenimiento", "Admin");
        }

        //public ActionResult ActualizarProducto(int cod)
        //{
        //    Productos s = pdao.ListarProductos().Find(x => x.codigo == cod);
        //    return View(s);
        //}

        [HttpPost]
        public ActionResult ActualizarProducto(Productos p)
        {
            if (ModelState.IsValid == true)
            {
                ViewBag.MENSAJE = pdao.ActualizarProducto(p);
            }

            return RedirectToAction("Mantenimiento", "Admin");
        }

        //public ActionResult EliminarServicio(int cod)
        //{
        //    Productos p = pdao.ListarProductos().Find(x => x.codigo == cod);
        //    return View(p);
        //}

       
        public ActionResult EliminarProducto(int cod)
        {
            ViewBag.MENSAJE = pdao.EliminarProducto(cod);

            return RedirectToAction("Mantenimiento", "Admin");
        }
    }
}