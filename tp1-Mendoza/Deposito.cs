using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1_Mendoza
{
    public class Deposito
    {
        public int Iddepo { get; set; }
        public string Direccion { get; set; }
        public string NommbreDeposito { get; set; }
        public int cantPasillos { get; set; }

        Pasillo pasillos = new Pasillo();

    }
}
