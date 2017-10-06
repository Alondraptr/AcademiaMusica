using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Importamos las librerias necesarias
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Conection
    {
        #region Variables y Atributos

        private String cadena = String.Empty;
        public SqlConnection con { get; set; }
        public SqlCommand sc { get; set;}
        public IDataReader idr { get; set; }
        
        #endregion

        #region Constructor 
        public Conection()
        {
            cadena = "Data Source=localhost;Initial Catalog=BDNAZA;User ID=sa;Password=123";
            con = new SqlConnection();
            sc = new SqlCommand();
        }
        #endregion

        #region Metodos

        public void Open()
        {
            if (con.State == ConnectionState.Open)
            {
                return;
            }
            else
            {
                con.ConnectionString = cadena;
                try
                {
                    con.Open();
                    Console.WriteLine("Se conecto a la base de datos con exito!!!");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.StackTrace);
                }
            }
        }

        public void Close()
        {
            if (con.State == ConnectionState.Closed)
            {
                return;
            }
            else
            {
                con.Close();
            }
        }

        public Int32 Ejecutar(CommandType ct, String consulta)
        {
            int retorno = 0;
            sc.Connection = con;
            sc.CommandType = ct;
            sc.CommandText = consulta;
            try
            {
                retorno = sc.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            return retorno;
        }

        public IDataReader Leer(CommandType ct, String consulta)
        {
            idr = null;
            sc.Connection = con;
            sc.CommandType = ct;
            sc.CommandText = consulta;

            try
            {
                idr = sc.ExecuteReader();
            }
            catch
            {
                throw;
            }
            return idr;
        }
        #endregion
    }

}
