using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Instrumento_Evaluaciones
    {
        public int ID_InstE { get; set; }
        public String Descripcion { get; set; }
        public int ID_TInst { get; set; }
        public int ID_Clase { get; set; }
        public int ID_Profesores { get; set; }
    }
}
