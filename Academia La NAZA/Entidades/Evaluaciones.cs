using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Evaluaciones
    {
        public int ID_Eva { get; set; }
        public int ID_InstE { get; set; }
        public int ID_Alumno { get; set; }
        public DateTime Fecha { get; set; }
        public String Obsevacion { get; set; }
    }
}
