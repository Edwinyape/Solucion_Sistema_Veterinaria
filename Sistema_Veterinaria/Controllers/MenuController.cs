using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Sistema_Veterinaria.Models;

namespace Sistema_Veterinaria.Controllers
{
    public class MenuController : Controller
    {
        ProductoDAO pdao = new ProductoDAO();
        PedidosDAO peddao = new PedidosDAO();
        // GET: Menu
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Tienda()
        {
            List<Productos> lista = pdao.ListarProductos();
            return View(lista);
        }

        public ActionResult Pedidos(int cod)
        {
            List<Pedidos> lista = peddao.ListarPedidos(cod);
            return View(lista);
        }

    }
}