using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
   public  class Dt_Clases
    {
        Conection con = new Conection();

        public List<Entidades.Clases> ObtenerClases(int idc = 0)
        {
            List<Entidades.Clases> listCl = new List<Entidades.Clases>();
            IDataReader idr = null;
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT * FROM Clases");

            if (idc != 0)
            {
                sb.Append("WHERE ID_Clase='" + idc + "'");

            }
            try
            {
                con.Open();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read())
                {
                    Entidades.Clases c = new Entidades.Clases
                    {
                        ID_Clase = (Int32)idr["ID_Clase"],
                        Nombre = idr["Nombre"].ToString(),
                    };
                    listCl.Add(c);

                }
                idr.Close();
                return listCl;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                throw;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
