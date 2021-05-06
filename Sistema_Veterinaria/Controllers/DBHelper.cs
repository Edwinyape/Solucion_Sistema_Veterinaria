using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Configuration;
using System.Data;
//using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using MySql.Data;

public class DBHelper
    {
        static string CAD_CN =
            ConfigurationManager.ConnectionStrings["cn1"].ConnectionString;

    private static void LlenarParametros(MySqlCommand comando, params object[] parametros)
    {
        int indice = 0;
        MySqlCommandBuilder.DeriveParameters(comando);
        //
        foreach (MySqlParameter item in comando.Parameters)
        {
            if (item.ParameterName != "@RETURN_VALUE")
            {
                item.Value = parametros[indice];
                indice++;
            }
        }
    }

    public static MySqlDataReader ExecuteReader(string NombreSP, params object[] Parametros)
        {
            MySqlConnection cnx = new MySqlConnection(CAD_CN);
            cnx.Open();
            //
            MySqlCommand cmd = new MySqlCommand(NombreSP, cnx);
            cmd.CommandType = CommandType.StoredProcedure;

            if (Parametros.Length > 0)
                LlenarParametros(cmd, Parametros);
            
            MySqlDataReader lector = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            return lector;
        }

        public static void ExecuteNonQuery(string NombreSP, params object[] Parametros)
        {
            MySqlConnection cnx = new MySqlConnection(CAD_CN);
            cnx.Open();
            //
            MySqlCommand cmd = new MySqlCommand(NombreSP, cnx);
            cmd.CommandType = CommandType.StoredProcedure;

            if (Parametros.Length > 0)
                LlenarParametros(cmd, Parametros);
            
            cmd.ExecuteNonQuery();

            cnx.Close();
        }

    public static void ExecuteNonQueryTrx(string NombreSP, params object[] Parametros)
    {
        MySqlConnection cnx = new MySqlConnection(CAD_CN);
        cnx.Open();
        //
        MySqlTransaction trx = cnx.BeginTransaction();
        try
        {
            //
            MySqlCommand cmd = new MySqlCommand(NombreSP, cnx, trx);
            cmd.CommandType = CommandType.StoredProcedure;

            if (Parametros.Length > 0)
                LlenarParametros(cmd, Parametros);

            cmd.ExecuteNonQuery();
            //
            trx.Commit();
            //
            cnx.Close();
        }
        catch 
        {
            trx.Rollback();
        }
        
    }

    public static object ExecuteScalar(string NombreSP, params object[] Parametros)
        {
            MySqlConnection cnx = new MySqlConnection(CAD_CN);
            cnx.Open();
            //
            MySqlCommand cmd = new MySqlCommand(NombreSP, cnx);
            cmd.CommandType = CommandType.StoredProcedure;

            if (Parametros.Length > 0)
                LlenarParametros(cmd, Parametros);

            object rpta = cmd.ExecuteScalar();

            cnx.Close();

            return rpta;
        }

    }
