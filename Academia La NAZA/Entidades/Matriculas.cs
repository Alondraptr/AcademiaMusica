using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Matriculas
    {
        public int ID_Matricula { get; set; }
        public DateTime Fecha { get; set; }
        public int ID_Alumno { get; set; }
        public float Monto { get; set; }
    }
}
