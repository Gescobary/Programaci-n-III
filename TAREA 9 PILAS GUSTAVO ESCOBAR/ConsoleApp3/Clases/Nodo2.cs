using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Clases
{
    class Nodo2
    {
        private int dato;
        private Nodo2 siguiente = null;
        public int Dato { get => dato; set => dato = value; }
        public Nodo2 Siguiente { get => siguiente; set => siguiente = value; }
        public override string ToString()
        {
            return string.Format("[{0}]", dato);
        }
    }
}
