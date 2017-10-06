using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Negocio
{
    public class Ng_Usuario
    {
        Datos.Dt_Usuario dtu = new Datos.Dt_Usuario();

        public List<Entidades.Usuarios> obtenerUsuario()
        {
            return dtu.ObtenerUsuarios();
        }

        public Int32 GuardarUsuario (Entidades.Usuarios usr)
        {
            return dtu.GuardarUser(usr);

        }

    }
}
