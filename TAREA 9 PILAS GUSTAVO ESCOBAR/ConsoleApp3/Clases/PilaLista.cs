using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Clases
{
    class PilaLista
    {
        private static int TAMPILA = 49;
        private int cima;
        private List<object> ListaPila;

        public PilaLista()
        {
            cima = -1;//condicion de pila vacia
            ListaPila = new List<object>();
        }

        public void insertar(object elemento)
        {
            cima++;
            ListaPila.Add(elemento);
        }

        public object quitar()
        {
            object aux;
            if (pilaVacia())
            {
                throw new Exception("Pila Vacia");
            }

            aux = ListaPila.ElementAt(cima);
            ListaPila.RemoveAt(cima);
            cima--;
            return aux;
        }

        public Object cimaPila()
        {
            if (pilaVacia())
            {
                throw new Exception("Pila vacia");
            }
            return ListaPila.ElementAt(cima);
        }

        public bool pilaVacia()
        {
            return cima == -1;
        }

        public void limpiarPila()
        {
            while (!pilaVacia())
            {
                quitar();
            }
        }
    }
}
