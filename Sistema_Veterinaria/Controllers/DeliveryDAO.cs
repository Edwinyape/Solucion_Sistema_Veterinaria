using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;

namespace Sistema_Veterinaria.Controllers
{
    public class DeliveryDAO
    {
        public string AgregarPedido(int codigo, double total)
        {
            string mensaje = "";
            try
            {
                string cod = DBHelper.ExecuteScalar("RegistrarPedidos", codigo, total).ToString();
                mensaje = cod;
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }

            return mensaje;
        }

        public string AgregarDetallePedidos(int codped, int codprod, int cant, double precio, double importe)
        {
            string mensaje = "";
            try
            {
                string cod = DBHelper.ExecuteScalar("RegistrarDetallePedidos", codped, codprod, cant, precio, importe).ToString();
                mensaje = cod;
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }

            return mensaje;
        }

        public string AgregarEntregaPedidos(int codped, string direc, string inform, string correo, string telef)
        {
            string mensaje = "";
            try
            {
                string cod = DBHelper.ExecuteScalar("RegistrarEntregaPedidos", codped, direc, inform, correo, telef).ToString();
                mensaje = cod;
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }

            return mensaje;
        }
    }
}