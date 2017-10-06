using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class Ng_Alumnos
    {
        Datos.Dt_Alumnos dta = new Datos.Dt_Alumnos();

        public List<Entidades.Alumnos> obtenerAlumno()
        {
            return dta.ObtenerAlumnos();
        }
    }
}
