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
    public class ServiciosDAO
    {
        public List<Servicios> ListarServicios()
        {
            List<Servicios> lista = new List<Servicios>();

            MySqlDataReader dr = DBHelper.ExecuteReader("MostrarServicios");
            while (dr.Read())
            {
                Servicios s = new Servicios();
                s.codigo = dr.GetInt32(0);
                s.nombre = dr.GetString(1);
                s.precio = dr.GetDecimal(2);
                s.descripcion = dr.GetString(3);
                s.horario = dr.GetString(4);
                s.fechas = dr.GetDateTime(5);

                lista.Add(s);

            }

            dr.Close();

            return lista;
        }

        public string AgregarServicio(Servicios s)
        {
            string mensaje = "";
            try
            {
                string cod = DBHelper.ExecuteScalar("RegistrarServicios", 
                             s.nombre, s.precio, s.descripcion, s.horario, s.fechas, 1).ToString();
                mensaje = "Nuevo Servicio: " + cod + " grabado corectamente";
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }

            return mensaje;
        }

        public string ActualizarServicio(Servicios s)
        {
            string mensaje = "";
            try
            {
                string cod = DBHelper.ExecuteScalar("ModificarServicios", s.codigo,
                             s.nombre, s.precio, s.descripcion, s.horario, s.fechas, 1).ToString();
                mensaje = "Servicio: " + cod + " actualizado correctamente";
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }

            return mensaje;
        }

        public string EliminarServicio(int cod)
        {
            string mensaje = "";
            try
            {
                DBHelper.ExecuteNonQuery("EliminarServicios", cod);
                mensaje = "Servicio: " + cod + " fue eliminado correctamente";
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }

            return mensaje;
        }
    }
}