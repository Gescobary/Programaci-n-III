using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Clases
{
    class ClsListEnlazada
    {
        public NodoLE primero;
        public NodoLE ultimo;
        public int cima;

        public ClsListEnlazada()
        {
            primero = null;
            ultimo = null;
            cima = 0;

        }
        public bool listallena()
        {
            return primero == null;
        }
        public bool ListaVacia()
        {
            if (primero == null)
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }

        public void insertarprimero(object dato)
        {
            NodoLE aux = new NodoLE(dato);
            aux.siguiente = primero;
            primero = aux;
            cima++;
        }

        public void limpiarLista()
        {
            cima = -1;
        }

        public object quitarchar()
        {
            Object aux;
            if (ListaVacia())
            {
                throw new Exception("PILA VACIA NO HAY DATA");
            }
            aux = (Object)primero.elemento;
            primero = primero.siguiente;
            cima--;
            return aux;
        }

        public void imprimeTodosLosNodos()
        {
            NodoLE actual = primero;
            while (actual != null)
            {
                Console.WriteLine(actual.elemento);
                actual = actual.siguiente;
            }
        }

    }
}
