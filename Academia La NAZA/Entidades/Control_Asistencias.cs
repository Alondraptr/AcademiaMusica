using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Control_Asistencias
    {
        public int ID_Control_Asistencia { get; set; }
        public DateTime Fecha { get; set; }
        public int ID_Profesor { get; set; }
        public int ID_Clase { get; set; }
        public int ID_Grupo { get; set; }
    }
}
