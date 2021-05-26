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
    public class LoginDAO
    {
        public List<Cliente> Validar(Cliente c)
        {
            List<Cliente> lista = new List<Cliente>();
            MySqlDataReader dr = DBHelper.ExecuteReader("ValidacionLogin", c.email, c.contraseña);
            while (dr.Read())
            {
                Cliente obj = new Cliente();
                obj.codigo = dr.GetInt32(0);
                obj.nombre = dr.GetString(1);
                obj.apellido = dr.GetString(2);
                obj.rol = dr.GetInt32(6);

                lista.Add(obj);
            }

            dr.Close();

            return lista;
        }
    }
}