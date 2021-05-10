using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Clases
{
    class Nodo
    {
        private object dato;
        private Nodo siguiente = null;
        public object Dato { get => dato; set => dato = value; }
        public Nodo Siguiente { get => siguiente; set => siguiente = value; }
        public override string ToString()
        {
            return string.Format("[{0}]", dato);
        }
    }
}
