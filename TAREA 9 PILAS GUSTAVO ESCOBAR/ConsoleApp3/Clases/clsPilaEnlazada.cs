using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Clases
{
    class clsPilaEnlazada
    {
        public class clsPilaLineal
        {
            //Indicará la cima de la pila
            private Nodo primero;
            Object ultimoNodo;
            int size = -1;
            public clsPilaLineal()
            {
                primero = null;
            }
            public bool pilaVacia()
            {
                return primero == null;
            }
            public bool pilaLlena()
            {
                return primero != null;
            }
            //Inserta los datos a nuestra pila.
            public void insertarNodo(Object elemento)
            {
                Nodo Nuevo = new Nodo();
                Nuevo.Dato = elemento;
                Nuevo.Siguiente = primero;
                primero = Nuevo;
                Console.WriteLine("Nodo insertado :)");
                size++;
            }
            public void buscarNodo()
            {
                //Recorre la pila desde el primero
                Nodo Actual = new Nodo();
                Actual = primero;
                bool encontrado = false;
                Console.WriteLine("Ingrese el dato del nodo a buscar: ");
                Object nodoBuscado = int.Parse(Console.ReadLine());
                if (primero != null)
                {
                    while (Actual != null && encontrado != true)
                    {
                        if (Actual.Dato == nodoBuscado)
                        {
                            Console.WriteLine("Nodo con el dato{0} : Ecnontrado" + nodoBuscado);
                        }
                        Actual = Actual.Siguiente;
                    }
                    if (!encontrado)
                    {
                        Console.WriteLine("Nodo no encontrado");
                    }
                }
                else
                {
                    Console.WriteLine("La Pila se encuentra vacía :(");
                }
            }
            public Object primerNodo()
            {
                if (pilaVacia())
                {
                    throw new Exception("Pila vacia");
                }
                return primero;
            }
            //Recorre la pila y la despliega.
            public void desplegarPila()
            {
                //Recorre la pila desde el primero
                Nodo Actual = new Nodo();
                Actual = primero;
                if (primero != null)
                {
                    while (Actual != null)
                    {
                        Console.WriteLine(" " + Actual.Dato);
                        Actual = Actual.Siguiente;
                    }
                }
                else
                {
                    Console.WriteLine("La Pila se encuentra vacía :(");
                }
            }//Fin de desplegarPila
            public void inversa()
            {
                Nodo prev = null;
                Nodo Actual = primero;
                Nodo nextNode = null;
                while (Actual != null)
                {
                    nextNode = Actual.Siguiente;
                    Actual.Siguiente = prev;
                    prev = Actual;
                    Actual = nextNode;
                }
                Console.WriteLine(primero = prev);
            }
            public Object quitarChar()
            {
                Object aux;
                Nodo Actual = new Nodo();
                if (pilaVacia())
                {
                    Console.WriteLine("Nel está vacía");
                }
                aux = primero.Dato;
                primero = primero.Siguiente;
                return aux;
            }
            public void LimpiarPila()
            {
                primero = null;
            }
            public void quitar()
            {
                if (primero == null)
                {
                    Console.WriteLine("Lista vacía, no se puede quitar");
                }
                else
                {
                    primero = primero.Siguiente;
                }
                size--;
            }
        }
    }
}
