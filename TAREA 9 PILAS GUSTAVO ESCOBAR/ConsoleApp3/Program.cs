using ConsoleApp3.Clases;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {

        //clases


    

        static void EjemploPilaLineal()
        {
            PilaLineal pila = new PilaLineal();
            int x;
            int Clave = -1;

            Console.WriteLine("Ingrese un numero y para terminar -1");
            try
            {
                do
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    pila.insertar(x);
                } while (x != Clave);

                Console.WriteLine("Estos son los elementos");

                while (!pila.pilaVacia())
                {
                    x = (int)(pila.quitar());
                    Console.WriteLine($"elemento:{x}");
                }

            }
            catch (Exception error)
            {
                Console.WriteLine("Error = " + error.Message);
            }
            Console.ReadLine();
        }



        //NUMERO CON PILALIST
        //solo se adapto el codigo visto en clase a la pila lista
        static void numPilaLista()
        {
            PilaLista PilaL;
            int x;
            int CLAVE = -1;

            Console.WriteLine("Ingrese numeros, y para terminar -1");
            try
            {
                PilaL = new PilaLista();
                do
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    if (x != -1)
                    {
                        PilaL.insertar(x);
                    }
                } while (x != CLAVE);

                Console.WriteLine("ESTOS SON LOS ELEMENTOS DE LA PILA:");


                while (!PilaL.pilaVacia())
                {
                    x = (int)(PilaL.quitar());
                    Console.WriteLine($"elemento:{x}");
                }

            }
            catch (Exception error)
            {
                Console.WriteLine("Error= " + error.Message);
            }
        }//x1


        //NUMERO CON LISTA ENLAZADA
        //codigo visto en clase se adapto con lista enlazada
        
        static void numerosLista()
        {
            ClsListEnlazada pilaLista;
            int x;
            int CLAVE = -1;

            Console.WriteLine("Ingrese numeros, y para terminar -1");
            try
            {
                pilaLista = new ClsListEnlazada();
                do
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    if (x != -1)
                    {
                        pilaLista.insertarprimero(x);
                    }
                } while (x != CLAVE);

                Console.WriteLine("ESTOS SON LOS ELEMENTOS DE LA PILA:");


                while (!pilaLista.ListaVacia())
                {
                    x = (int)(pilaLista.quitarchar());
                    Console.WriteLine($"elemento:{x}");
                }

            }
            catch (Exception error)
            {
                Console.WriteLine("Error= " + error.Message);
            }
        }




        //PALINDROMO 

        //PILA LINEAL
        // eliminamos caracteres especiales
        //pasa quitar las tildes 
        static void palindromo()
        {
            PilaLineal pilaChar;
            bool esPalindromo;
            string pal;

            try
            {
                pilaChar = new PilaLineal();
                Console.WriteLine("Ingrese una palabra para someterla a evaluacion");
                pal = Console.ReadLine();


                pal = pal.ToLower().Replace(" ", String.Empty); //permite eliminar todos los espacios entre las palabras
                Console.WriteLine("Sin espacios: " + pal);
                //aca se eliminan las tildes
                pal = eliminarCaracteresEspeciales(pal);
                Console.WriteLine("Sin Tildes: " + pal);//muestra resuldado sin tildes


                //creamos la pila chars
                for (int i = 0; i < pal.Length;)
                {
                    char c;
                    c = pal[i++];
                    pilaChar.insertar(c);
                }
                //verifica si es palindromo o no
                esPalindromo = true;
                for (int j = 0; esPalindromo && !pilaChar.pilaVacia();)
                {
                    char c;
                    c = (char)pilaChar.quitarChar();
                    esPalindromo = pal[j++] == c; //Evalua igualdad
                }

                pilaChar.limpiarPila();
                if (esPalindromo)
                {
                    Console.WriteLine("La palabra es palindromo");

                }
                else
                {
                    Console.WriteLine("La palabra no es palindromo");
                }
                

            }
            catch (Exception error)
            {

                Console.WriteLine($"tenemos error {error.Message}");
            }
        }//1
        
        //LISTA ENLAZADA
        static void Palindromo_ListaEnlazada()
        {
            PilaLineal pilaChar;
            bool esPalindromo;
            String pal;
            try
            {
                pilaChar = new PilaLineal();
                Console.WriteLine("Teclee una palabra para ser ver si es palíndromo: ");
                pal = Console.ReadLine();
                string sinTilde = eliminarCaracteresEspeciales(pal);
               

                sinTilde = sinTilde.Replace(" ", "").ToLower();
                Console.WriteLine("Nueva cadena de texto sin espacios : " + sinTilde);
                for (int i = 0; i < sinTilde.Length;)
                {
                    //Insertamos el caracter, agarrando letra por letra
                    char c;
                    c = sinTilde[i++];
                    pilaChar.insertar(c);
                }
                esPalindromo = true;
                for (int j = 0; esPalindromo && !pilaChar.pilaVacia();)
                {
                    char c;
                    //Extraer uno a uno
                    c = (char)pilaChar.quitarChar();
                    //Console.WriteLine("Valor c: " + c);
                    esPalindromo = sinTilde[j++] == c; //Evalúa si la pos es igual
                }
                if (esPalindromo)
                {
                    Console.WriteLine($"La palabra {sinTilde} es palindromo");
                }
                else
                {
                    Console.WriteLine($"No es palindromo");
                }
            }
            catch (Exception error)
            {
                Console.WriteLine($"error{error.Message}");
            }
        }//1.2
        
        // PILA LISTA
       
        static void palindromo3()
        {
            PilaLista pilaLs;
            bool esPalindromo;
            String pal;

            try
            {
                pilaLs = new PilaLista();
                Console.WriteLine("Teclee una palabra para ver si es ");
                pal = Console.ReadLine();

                string remplazada = Regex.Replace(pal, @"\s", "");
                string convertida = remplazada.ToLower();
                string textoSinAcentos = eliminarCaracteresEspeciales(convertida);
               
                //creamos la pila con los chars
                for (int i = 0; i < textoSinAcentos.Length;)
                {
                    Char c;
                    c = textoSinAcentos[i++];
                    pilaLs.insertar(c);
                }

                //comprueva si es palindromo
                esPalindromo = true;
                for (int j = 0; esPalindromo && !pilaLs.pilaVacia();)
                {
                    Char c;
                    c = (Char)pilaLs.quitar();
                    esPalindromo = textoSinAcentos[j++] == c;//evalua si la posicion es igual o no es igual

                }
                pilaLs.limpiarPila();
                if (esPalindromo)
                {
                    Console.WriteLine($"La palabra {pal} es palindromo");
                }
                else
                {
                    Console.WriteLine($"Nel, no es ");
                }

            }
            catch (Exception error)
            {
                Console.WriteLine($"ups error {error.Message}");
            }
        }//1.3






        //METODO PALINDROMO PARA ELIMINAR TILDES
        static string eliminarCaracteresEspeciales(string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);//sin tildes
            var stringBuilder = new StringBuilder(); //atraves del n.s y la variable stringbuilder para unir nuevamente nuestro string

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }




        //EXPRESIONES
        static void Expresiones_Matematicas()
        {
            clsPila miPila = new clsPila();
            int n = 0, a = 0, b = 0, r = 0;
            Console.WriteLine("Ingrese la expresión con simbolo de operación inicial");//indicamos que operación realizaremos mediente el simbolo 
            string exp = Console.ReadLine();                    
            char caracter = ' ';                               
            for (n = exp.Length - 1; n >= 0; n--)
            {
                caracter = exp[n];
                if (caracter >= '0' && caracter <= '9')
                {
                    miPila.Push(Convert.ToInt32(caracter.ToString()));
                }
                else
                {
                    a = miPila.Pop();
                    b = miPila.Pop();
                    //ménu de operaciones aritmeticas
                    if (caracter == '+')
                    {
                        r = a + b;
                        miPila.Push(r);
                    }
                    if (caracter == '-')
                    {
                        r = a - b;
                        miPila.Push(r);
                    }
                    if (caracter == '/')
                    {
                        r = a / b;
                        miPila.Push(r);
                    }
                    if (caracter == '*')
                    {
                        r = a * b;
                        miPila.Push(r);
                    }
                }
            }
            miPila.Transversa();
        }


   

        // FIFO el ultimo que entra primero en salir
        //aplicamos lo contrario al fifo primero en entrar primero en salir

        static void EjemploPilaLista()
        {
            PilaLista pl = new PilaLista();
            pl.insertar(1);
            pl.insertar(5);
            pl.insertar(16);
            pl.insertar(217);
            pl.insertar(41);
            pl.insertar(19);

            var xx = pl.quitar();
            int pau;
            pau = 0;
        }


        //MAIN
        static void Main(string[] args)
        {
            //palindromo3();
            //numerosLista();
            //numPilaLista();
            //ejemploPilaLineal();
             //*palindromo();
            //*Palindromo_ListaEnlazada();
            //*Expresiones_Matematicas();
            //EjemploPilaLista();
            Console.Read();
        }
    }
}
