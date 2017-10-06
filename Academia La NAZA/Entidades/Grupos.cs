using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grupos
    {
        public int ID_Grupo { get; set; }
        public String Dia { get; set; }
        public String Hora_Entrada { get; set; }
        public String Hora_Salida { get; set;}
        public Boolean Estado { get; set; }
    }
}
