using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1_Mendoza
{
    class Empleado : Persona
    {
        public int Legajo { get; set; }

        public String MailLaboral { get; set; }

        public String Funcion { get; set; }

        public int IdDepo { get; set; }

    }
}
