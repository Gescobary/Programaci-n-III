using Colas.clases.Cola_Arreglo;
using Colas.clases.Pila_Lista;
using System;
using System.Collections;

namespace Colas
{
    class Program
    {
        private static bool valid(string numero)
        {
            bool sw = true;
            int i = 0;
            while (sw && (i < numero.Length))
            {
                char c;
                c = numero[i++];
                sw = (c >= '0' && c <= '9');
            }
            return sw;
        }

        static void Main(string[] args)
        {

            //PROGRAMA CAPICUA
            // programa capicua
            Ejercicio1();
            bool capicua;
            string numero;

            PilaLista pila = new PilaLista();
            ColaCircular circula_Cola = new ColaCircular();

           
            static void Ejercicio1()
            {

                bool capicua;
                String numero;
                Stack pila = new Stack(); //Stack
                Queue cola_circular = new Queue();

                try
                {
                    capicua = false;
                    while (!capicua)
                    {
                        do
                        {
                            Console.WriteLine("Teclea un número");
                            numero = Console.ReadLine();
                        } while (!valid(numero));
                        
                        for (int i = 0; i < numero.Length; i++)//ACA PONE EN LA COLA Y EN LA PILA CADA DIGITO
                        {
                            char c;
                            c = numero[i];
                            cola_circular.Enqueue(c);
                            pila.Push(c);
                        }
                        //DESENCOLA, SE RETIRA LA COLA Y LA PILA PARA COMPARAR
                        do
                        {
                            char d;
                            d = (Char)cola_circular.Dequeue();
                            capicua = d.Equals(pila.Pop());//COMPARA LA IGUALDAD
                        } while (capicua && cola_circular.Count != 0);
                        if (capicua)
                        {
                            Console.WriteLine($"Numero {numero} es capicua =)");
                        }
                        else
                        {
                            Console.WriteLine($"El numero {numero} no es capicua =(");
                            Console.WriteLine("Intente otro :/");
                        }
                        cola_circular.Clear();
                        pila.Clear();
                    }
                }
                catch (Exception errores)
                {
                    Console.WriteLine($"Error en{errores.Message} ");
                }
            }

            //Queue qt = new Queue();
            //qt.Enqueue("Hola");
            //qt.Enqueue("Esta");
            //qt.Enqueue("es");
            //qt.Enqueue("una");
            //qt.Enqueue("prueba");

            //Console.WriteLine($"La cola tiene {qt.Count} elementos");

            //qt.Dequeue();//quita el primer elemento
            //Console.WriteLine($"La cola tiene {qt.Count} elementos");

            //qt.Dequeue();//quita el primer elemento
            //Console.WriteLine($"La cola tiene {qt.Count} elementos");

            //qt.Dequeue();//quita el primer elemento
            //Console.WriteLine($"La cola tiene {qt.Count} elementos");

            //qt.Dequeue();//quita el primer elemento
            //Console.WriteLine($"La cola tiene {qt.Count} elementos");

            //qt.Dequeue();//quita el primer elemento
            //Console.WriteLine($"La cola tiene {qt.Count} elementos");

            //Console.ReadLine();

        }
    }
}
