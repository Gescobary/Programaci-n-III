using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Clases
{
    class PilaLineal
    {
        private static int TAMPILA = 49;
        private int cima;
        private object[] ListaPila;

        public PilaLineal()
        {
            cima = -1;
            ListaPila = new object[TAMPILA];
        }

        public bool pilaLlena()
        {
            return cima == TAMPILA - 1;
        }

        //operaciones que modifican la pila
        public void insertar(object elemento)
        {
            if (pilaLlena())
            {
                throw new Exception("Desbordamiento de pila Stack Overflow");
            }
            //incrementar puntero cima y vamos a insertar elemento
            cima++;
            ListaPila[cima] = elemento;
        }

        public bool pilaVacia()
        {
            return cima == -1;
        }
        //Retorna un tipo Char

        public object quitarChar()
        {
            char aux;
            if (pilaVacia())
            {
                throw new Exception("la pila esta vacia, no hay data");
            }
            aux =(char) ListaPila[cima];
            cima--;
            return aux;
        }



        //extraer elemento de la pila (pop)
        public Object quitar()
        {
            int aux;
            if (pilaVacia())
            {
                throw new Exception("la pila esta vacia, no se puede sacar");
            }
            //guardar elemento de la cima
            aux = (int)ListaPila[cima];
            //decrementar el valor de cima y retornar elemento
            cima--;
            return aux;
        }
        public void limpiarPila()
        {
            cima = -1;
        }

        //operacion de acceso a la pila
        public Object cimaPila()
        {
            if (pilaVacia())
            {
                throw new Exception("pila vacia");
            }
            return ListaPila[cima];
        }
    }
}
