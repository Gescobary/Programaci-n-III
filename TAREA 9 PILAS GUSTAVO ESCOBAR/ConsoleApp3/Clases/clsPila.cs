using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Clases
{
    class clsPila
    {
     
        //Pila para usar en las expresiones
            private Nodo2 ancla;
            private Nodo2 trabajo;
            public clsPila()
            {
                ancla = new Nodo2();
                ancla.Siguiente = null;
            }
            public void Push(int pDato)
            {
                Nodo2 temp = new Nodo2();
                temp.Dato = pDato;
                temp.Siguiente = ancla.Siguiente;
                ancla.Siguiente = temp;
            }
            public int Pop()
            {
                int valor = 0;
                if (ancla.Siguiente != null)
                {
                    trabajo = ancla.Siguiente;
                    valor = trabajo.Dato;
                    ancla.Siguiente = trabajo.Siguiente;
                    trabajo.Siguiente = null;
                }
                return valor;
            }
            public void Transversa()
            {
                trabajo = ancla;
                while (trabajo.Siguiente != null)
                {
                    trabajo = trabajo.Siguiente;
                    int d = trabajo.Dato;
                    Console.WriteLine("[{0}]", d);
                }
            }
        
    }
}

