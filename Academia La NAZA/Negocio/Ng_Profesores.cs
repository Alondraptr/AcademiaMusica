using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public class Ng_Profesores
    {
        Datos.Dt_Profesores dtp = new Datos.Dt_Profesores();

        public List<Entidades.Profesores> ObtenerProfesor()
        {
            return dtp.ObtenerProfesores();
        }

    }
}
