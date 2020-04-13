using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1_Mendoza
{
    public class Compartimiento
    {

        Producto producto = new Producto();
        
        public int CantStock { get; set; }

        Cliente cliente = new Cliente();

        public int NumDeCompartimiento { get; set; }


    }
}
