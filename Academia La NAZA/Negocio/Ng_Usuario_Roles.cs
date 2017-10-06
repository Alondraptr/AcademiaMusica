using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
   public class Ng_Usuario_Roles
    {
       Datos.Dt_Usuario_Roles dtur = new Datos.Dt_Usuario_Roles();

        public List<Entidades.Usuarios_Roles> obtenerRol()
        {
            return dtur.ObtenerRol();
        }

    }
}
