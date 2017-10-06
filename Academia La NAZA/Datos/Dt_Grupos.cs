using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Dt_Grupos
    {
        Conection con = new Conection();

        public List<Entidades.Grupos> ObtenerGrupos(int idg = 0)
        {
            List<Entidades.Grupos> listGr= new List<Entidades.Grupos>();
            IDataReader idr = null;
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT * FROM Grupos");

            if (idg != 0)
            {
                sb.Append("WHERE ID_Grupo='" + idg + "'");

            }
            try
            {
                con.Open();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read())
                {
                    Entidades.Grupos g = new Entidades.Grupos
                    {
                        ID_Grupo = (Int32)idr["ID_Grupo"],
                        Dia = idr["Dia"].ToString(),
                        Hora_Entrada = idr["Hora_Entrada"].ToString(),
                        Hora_Salida = idr["Hora_Salida"].ToString(),
                        Estado = (Boolean)idr["Estado"]

                    };
                    listGr.Add(g);

                }
                idr.Close();
                return listGr;
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
