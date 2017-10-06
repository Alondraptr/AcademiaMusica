using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Detalle_Asistencias
    {
        public int ID_Detalle_Asistencia { get; set; }
        public int ID_Control_Asistencia { get; set; }
        public int ID_Alumno { get; set; }
        public Boolean Asistio { get; set; }
    }
}
