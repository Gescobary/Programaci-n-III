using System;
using System.Collections.Generic;
using System.Text;

namespace Colas.clases.Cola_Arreglo
{
    class ColaCircular
    {

        protected int fin;
        private static int MAXTAMQ = 99;
        protected int frente;

        protected object[] listaCola;

        //avanza una posicion
        private int siguiente(int r)
        {
            return (r + 1) % MAXTAMQ;
        }

        //constructor
        public ColaCircular()
        {
            frente = 0;
            fin = MAXTAMQ - 1;
            listaCola = new Object[MAXTAMQ];
        }

        //VALIDACIONES
        public bool colaVacia()
        {
            return frente == siguiente(fin);
        }

        public bool colaLlena()
        {
            return frente == siguiente(siguiente(fin));
        }

        //operaciones de nodificacion de cola
        public void insertar(Object elemento)
        {
            if (!colaLlena())
            {
                fin = siguiente(fin);
                listaCola[fin] = elemento;

            }
            else
            {
                throw new Exception("OverFlow de la cola");
            }
        }

        //quitar elemento
        public Object quitar()
        {
            if (!colaVacia())
            {
                Object tm = listaCola[frente];
                frente = siguiente(frente);
                return tm;

            }
            else
            {
                throw new Exception("cola vacia");
            }

        }

        public void borrarCola()
        {
            frente = 0;
            fin = MAXTAMQ - 1;
        }

        //obtener el valor de frente
        public Object frenteCola()
        {
            if (!colaVacia())
            {
                return listaCola[frente];
            }
            else
            {
                throw new Exception("Cola Vacia");
            }
        }

    }//end class
}
