using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;
using Sistema_Veterinaria.Models;

namespace Sistema_Veterinaria.Controllers
{
    public class ProductoDAO
    {
        public List<Productos> ListarProductos()
        {
            List<Productos> lista = new List<Productos>();

            MySqlDataReader dr = DBHelper.ExecuteReader("MostrarProductos");
            while (dr.Read())
            {
                Productos p = new Productos();
                p.codigo = dr.GetInt32(0);
                p.nombre = dr.GetString(1);
                p.precio = dr.GetDecimal(2);
                p.codigoSerie = dr.GetInt32(3);
                p.marca = dr.GetString(4);
                p.descripcion = dr.GetString(5);
                p.descripcionHtml = dr.GetString(6);
                p.foto1 = dr.GetString(7);
                p.foto2 = dr.GetString(8);
                p.foto3 = dr.GetString(9);

                lista.Add(p);

            }

            dr.Close();

            return lista;
        }

        public string AgregarProducto(Productos p)
        {
            string mensaje = "";
            try
            {
                string cod = DBHelper.ExecuteScalar("RegistrarProductos", p.nombre, p.precio, p.codigoSerie, 
                             p.marca, p.descripcion, p.descripcionHtml, "img", "img", "img", 1, 1).ToString();
                mensaje = "Nuevo Producto: " + cod + " grabado corectamente";
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }

            return mensaje;
        }

        public string ActualizarProducto(Productos p)
        {
            string mensaje = "";
            try
            {
                string cod = DBHelper.ExecuteScalar("ModificarProductos", p.codigo, p.nombre, p.precio, p.codigoSerie,
                             p.marca, p.descripcion, p.descripcionHtml, "img", "img", "img", 1, 1).ToString();
                mensaje = "Producto: " + cod + " actualizado correctamente";
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }

            return mensaje;
        }

        public string EliminarProducto(int cod)
        {
            string mensaje = "";
            try
            {
                DBHelper.ExecuteNonQuery("EliminarProductos", cod);
                mensaje = "Producto: " + cod + " fue eliminado correctamente";
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }

            return mensaje;
        }
    }
}