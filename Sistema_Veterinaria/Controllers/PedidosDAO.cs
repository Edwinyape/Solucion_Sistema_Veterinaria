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
    public class PedidosDAO
    {
        public List<Pedidos> ListarPedidos(int cod)
        {
            List<Pedidos> lista = new List<Pedidos>();
            MySqlDataReader dr = DBHelper.ExecuteReader("MostrarPedidos", cod);

            while (dr.Read())
            {
                Pedidos x = new Pedidos();
                x.codigo = dr.GetInt32(0);
                x.usuario = dr.GetInt32(1);
                x.fecha = dr.GetDateTime(2);
                x.total = dr.GetDouble(3);
                x.estado = dr.GetInt32(4);
                x.direccion = dr.GetString(5);
                x.informacion = dr.GetString(6);
                x.correo = dr.GetString(7);
                x.telefono = dr.GetString(8);

                lista.Add(x);
            }

            dr.Close();

            return lista;
        }
    }
}