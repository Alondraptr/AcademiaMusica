using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Dt_Alumnos
    {
        Conection con = new Conection();

        public List<Entidades.Alumnos> ObtenerAlumnos(int ida = 0)
        {
            List<Entidades.Alumnos> listAlm = new List<Entidades.Alumnos>();
            IDataReader idr = null;
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT * FROM Alumnos");

            if (ida != 0)
            {
                sb.Append("WHERE ID_Alumno='" + ida + "'");

            }
            try
            {
                con.Open();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read())
                {
                    Entidades.Alumnos a = new Entidades.Alumnos
                    {
                        ID_Alumno = (Int32)idr["ID_Alumno"],
                        Nombre1 = idr["Nombre1"].ToString(),
                        Nombre2 = idr["Nombre2"].ToString(),
                        Apellido1 = idr["Apellido1"].ToString(),
                        Apellido2 = idr["Apellido2"].ToString(),
                        /**BecaPorcentaje=(int)idr["BecaPorcentaje"],
                        Cel_Claro = idr["Cel_Claro"].ToString(),
                        Cel_Mov = idr["Cel_Mov"].ToString(),
                        Telefono = idr["Telefono"].ToString(),
                        Barrio = idr["Barrio"].ToString(),
                        Departamento = idr["Departamento"].ToString(),
                        Direccion = idr["Dirección"].ToString(),
                        Estado = (Boolean)idr["Estado"]
                        **/
                    };
                    listAlm.Add(a);

                }
                idr.Close();
                return listAlm;
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
