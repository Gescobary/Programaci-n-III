using System;
using System.Collections.Generic;
using System.Text;

namespace Colas.clases.Cola_Arreglo
{
    //CLASE
    class ColaLineal
    {

        protected int fin;
        private static int MAXTAMQ = 39;
        protected int frente;

        protected object[] listaCola;

        public ColaLineal()
        {
            frente = 0;
            fin = -1;
            listaCola = new object[MAXTAMQ];

        }



        public bool colaVacia()
        {
            return frente > fin;
        }

        public bool colaLlena()
        {
            return fin == MAXTAMQ - 1;

        }

        //OPERACIONES PARA TRABAJAR CON DATOS EN LA COLA
        public void insertar(object elemento)
        {

            if (!colaLlena())
            {
                listaCola[++fin] = elemento;

            }
            else
            {
                throw new Exception("Overtflow de la cola");

            }

        }

        //quitar elemento de la cola
        public Object quitar()
        {
            if (!colaVacia())
            {
                return listaCola[frente++];

            }
            else
            {
                throw new Exception("cola Vacia");
            }

        }

        //limpiar toda la cola
        public void borrarCola()
        {
            frente = 0;
            fin = -1;

        }

        //acceso a la cola
        public Object frenteCola()
        {
            if (!colaVacia())
            {
                return listaCola[frente];

            }
            else
            {
                throw new Exception("cola Vacia");

            }
        }

    }//end class
}
