using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Datos;

namespace Negocio
{
    public class Ng_Grupos
    {
        Datos.Dt_Grupos dtg = new Datos.Dt_Grupos();

        public List<Entidades.Grupos> obtenerGrupo()
        {
            return dtg.ObtenerGrupos();
        }
    }
}
