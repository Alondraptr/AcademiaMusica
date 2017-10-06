using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Datos;

namespace Negocio
{
    public class Ng_Clases
    {
        Datos.Dt_Clases dtcl = new Datos.Dt_Clases();

        public List<Entidades.Clases> obtenerClase()
        {
            return dtcl.ObtenerClases();
        }
    }
}
