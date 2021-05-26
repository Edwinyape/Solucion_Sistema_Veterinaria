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
    public class RegistroDAO
    {
        //string con = ConfigurationManager.ConnectionStrings["cn1"].ConnectionString;

        public List<Cliente> ListarCliente()
        {
            List<Cliente> lista = new List<Cliente>();
            MySqlDataReader dr = DBHelper.ExecuteReader("MostrarUsuario");
            while (dr.Read())
            {
                Cliente c = new Cliente();
                c.codigo = dr.GetInt32(0);
                c.nombre = dr.GetString(1);
                c.apellido = dr.GetString(2);
                c.email = dr.GetString(3);
                c.telefono = dr.GetString(4);
                c.contraseña = dr.GetString(5);
                c.rol = dr.GetInt32(6);

                lista.Add(c);
            }

            dr.Close();

            return lista;
        }

        public string AgregarCliente(Cliente c)
        {
            string mensaje = "";
            try
            {
                string cod = DBHelper.ExecuteScalar("RegistrarUsuario",
                    c.nombre, c.apellido, c.email, c.telefono, c.contraseña, 2).ToString();
                mensaje = "Nuevo Cliente: " + cod + " grabado corectamente";
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }

            return mensaje;
        }

        public string ActualizarCliente(Cliente c)
        {
            string mensaje = "";
            try
            {
                string cod = DBHelper.ExecuteScalar("ModificarUsuario", c.codigo,
                             c.nombre, c.apellido, c.email, c.telefono, c.contraseña).ToString();
                mensaje = "Cliente: " + cod + " actualizado correctamente";
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }

            return mensaje;
        }

        public string EliminarCliente(int cod)
        {
            string mensaje = "";
            try
            {
                DBHelper.ExecuteNonQuery("EliminarUsuario", cod);
                mensaje = "Cliente: " + cod + " fue eliminado correctamente";
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }

            return mensaje;
        }

        public List<Mascota> ListarMascota()
        {
            List<Mascota> lista = new List<Mascota>();
            MySqlDataReader dr = DBHelper.ExecuteReader("MostrarMascota");
            while (dr.Read())
            {
                Mascota m = new Mascota();
                m.codigo = dr.GetInt32(0);
                m.nombre = dr.GetString(1);
                m.especie = dr.GetString(2);
                m.raza = dr.GetString(3);
                m.edad = dr.GetInt32(4);
                m.sexo = dr.GetString(5);
                m.fechanacimiento = dr.GetDateTime(6);

                lista.Add(m);
            }

            dr.Close();

            return lista;
        }

        public string AgregarMascota(Mascota m, int clicod)
        {
            string mensaje = "";
            try
            {
                string cod = DBHelper.ExecuteScalar("RegistrarMascota",
                    m.nombre, m.especie, m.raza, m.edad, m.sexo, m.fechanacimiento, clicod).ToString();
                mensaje = "Mascota registrada con exito";
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }

            return mensaje;
        }

        public string ActualizarMascota(Mascota m)
        {
            string mensaje = "";
            try
            {
                string cod = DBHelper.ExecuteScalar("ModificarMascota", m.codigo,
                             m.nombre, m.especie, m.raza, m.edad, m.sexo, m.fechanacimiento).ToString();
                mensaje = "Mascota actualizado correctamente";
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }

            return mensaje;
        }

        public string EliminarMascota(int cod)
        {
            string mensaje = "";
            try
            {
                DBHelper.ExecuteNonQuery("EliminarMascota", cod);
                mensaje = "Mascota eliminada correctamente";
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }

            return mensaje;
        }

    }
}