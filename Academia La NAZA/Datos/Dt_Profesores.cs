using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
   public class Dt_Profesores
    {
       Conection con = new Conection();

       public List<Entidades.Profesores> ObtenerProfesores(int idprof = 0)
       {
           List<Entidades.Profesores> listProf = new List<Entidades.Profesores>();
           IDataReader idr = null;
           StringBuilder sb = new StringBuilder();
           sb.Append("SELECT * FROM Profesores");

           if (idprof != 0)
           {
               sb.Append("WHERE ID_Profesor='" + idprof + "'");

           }
           try
           {
               con.Open();
               idr = con.Leer(CommandType.Text, sb.ToString());
               while (idr.Read())
               {
                   Entidades.Profesores p = new Entidades.Profesores
                   {
                       ID_Profesor = (Int32)idr["ID_Profesor"],
                       Cedula=idr["Cedula"].ToString(),
                       Nombre1 = idr["Nombre1"].ToString(),
                       Nombre2 = idr["Nombre2"].ToString(),
                       Apellido1=idr["Apellido1"].ToString(),
                       Apellido2 = idr["Apellido2"].ToString(),
                       Cel_Claro = idr["Cel_Claro"].ToString(),
                       Cel_Mov = idr["Cel_Mov"].ToString(),
                       Telefono = idr["Telefono"].ToString(),
                       Email = idr["Email"].ToString(),
                       Direccion = idr["Direccion"].ToString(),
                       Estado=(Boolean)idr["Estado"]
                      
                   };
                   listProf.Add(p);

               }
               idr.Close();
               return listProf;
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
