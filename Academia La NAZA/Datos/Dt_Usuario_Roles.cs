using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Dt_Usuario_Roles
    {
        Conection con = new Conection();

        public List<Entidades.Usuarios_Roles> ObtenerRol(int idUsR = 0)
        {
            List<Entidades.Usuarios_Roles> listUserRol = new List<Entidades.Usuarios_Roles>();
            IDataReader idr = null;
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT * FROM Usuario_Roles");

            if (idUsR != 0)
            {
                sb.Append("WHERE ID_Usuario_Roles = 1 ");

            }
            try
            {
                con.Open();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read())
                {
                    Entidades.Usuarios_Roles u = new Entidades.Usuarios_Roles
                    {
                        ID_URol = (Int32)idr["ID_Usuario_Roles"],
                        ID_Usuario = (Int32)idr["ID_Usuario"],
                        Rol = idr["Rol"].ToString()
                    };
                    listUserRol.Add(u);

                }
                idr.Close();
                return listUserRol;
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
    /*
     public int guardarRolUser(Entidades.Rol_Usuario.entRU);
     * {
     *  int guardado = ;
     *  StringBuilder sb = new StringBuilder();
     *  sb.Append("exec sp_agregar_rol_usuario");
     *  sb.Append(" "+entRU.id);
     * }
     * 
     */
}
