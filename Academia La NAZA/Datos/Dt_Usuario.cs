using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Dt_Usuario
    {
        Conection con = new Conection();

        public Int32 GuardarUser (Entidades.Usuarios u)
        {
            int guardado = 0;
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO Usuarios");
            sb.Append("(Usuario, Contrasena) ");
            sb.Append("VALUES('"+u.Usuario+"','"+u.Contrasena+"')");
            try
            {
                con.Open();
                guardado = con.Ejecutar(CommandType.Text,sb.ToString());
                return guardado;
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
        
        public List<Entidades.Usuarios>ObtenerUsuarios(int idUsr=0)
    {
        List<Entidades.Usuarios> listUser = new List<Entidades.Usuarios>();
        IDataReader idr = null;
        StringBuilder sb = new StringBuilder();
        sb.Append("SELECT * FROM Usuarios");

        if (idUsr != 0)
        {
            sb.Append("WHERE ID_Usuario='" + idUsr +"'");

         }
        try
        {
            con.Open();
            idr = con.Leer(CommandType.Text, sb.ToString());
            while (idr.Read())
            {
                Entidades.Usuarios u = new Entidades.Usuarios
                {
                    ID_Usuario = (Int32)idr["ID_Usuario"],
                    Usuario = idr["Usuario"].ToString(),
                    Contrasena = idr["Contrasena"].ToString()
                };
                listUser.Add(u);

            }
            idr.Close();
            return listUser;
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
