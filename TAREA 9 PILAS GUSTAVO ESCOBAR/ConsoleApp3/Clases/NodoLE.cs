using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Clases
{
    class NodoLE
    {
        public Object elemento;
        public NodoLE siguiente;


        public NodoLE(Object entrada)
        {
            this.elemento = entrada;
            this.siguiente = null;

        }
    }
}
