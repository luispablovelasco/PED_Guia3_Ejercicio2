using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEDL_Guia3_Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            ConsoleKeyInfo op, opf;
            Queue<string> cajero1 = new Queue<string>();
            Queue<string> cajero2 = new Queue<string>();
            Queue<string> cajero3 = new Queue<string>();
            Queue<string> cajero4 = new Queue<string>();

            cajero1.Enqueue("1");
            cajero1.Enqueue("1");
            cajero1.Enqueue("1");
            cajero1.Enqueue("1");
            cajero2.Enqueue("1");
            cajero2.Enqueue("1");
            cajero2.Enqueue("1");
            cajero3.Enqueue("1");


            Console.Title = "Guia 3 Ejercicio 2";

            do
            {

                Console.WriteLine(" ");
                Console.WriteLine("\t-------------------------------------------------");
                Console.WriteLine("\t--------- Simulación de cola bancaria -----------");
                Console.WriteLine("\t-                                               -");
                Console.WriteLine("\t-         Seleccione la opción que desee        -");
                Console.WriteLine("\t-                                               -");
                Console.WriteLine("\t-     [A] Entrar a una fila                     -");
                Console.WriteLine("\t-     [B] Despachar                             -");
                Console.WriteLine("\t-     [C] Ver filas                             -");
                Console.WriteLine("\t-     [Esc] Salir del programa                  -");
                Console.WriteLine("\t-                                               -");
                Console.WriteLine("\t-------------------------------------------------");
                Console.WriteLine("\t-------------------------------------------------");
                Console.WriteLine("");


                op = Console.ReadKey(true);

                switch (op.Key)
                {

                    case ConsoleKey.A:

                        Console.WriteLine("\tEntrar a una fila");
                        Console.WriteLine("");

                        if (cajero1.Count <= cajero2.Count )
                        {
                            if (cajero1.Count <= cajero3.Count)
                            {
                                if (cajero1.Count <= cajero4.Count)
                                {
                                    cajero1.Enqueue("1");
                                    Console.WriteLine("");
                                    Console.WriteLine("\tHa entrado a la fila 1");
                                    Console.ReadKey();
                                }
                            }

                        }

                        if (cajero2.Count < cajero1.Count)
                        {
                            if (cajero2.Count < cajero3.Count)
                            {
                                if (cajero2.Count < cajero4.Count)
                                {
                                    cajero2.Enqueue("1");
                                    Console.WriteLine("");
                                    Console.WriteLine("\tHa entrado a la fila 2");
                                    Console.ReadKey();
                                }
                            }

                        }

                        if (cajero3.Count < cajero1.Count)
                        {
                            if (cajero3.Count < cajero2.Count)
                            {
                                if (cajero3.Count < cajero4.Count)
                                {
                                    cajero3.Enqueue("1");
                                    Console.WriteLine("");
                                    Console.WriteLine("\tHa entrado a la fila 3");
                                    Console.ReadKey();
                                }
                            }

                        }
                        if (cajero4.Count < cajero1.Count)
                        {
                            if (cajero4.Count < cajero2.Count)
                            {
                                if (cajero4.Count < cajero3.Count)
                                {
                                    cajero4.Enqueue("1");
                                    Console.WriteLine("");
                                    Console.WriteLine("\tHa entrado a la fila 4");
                                    Console.ReadKey();
                                }
                            }

                        }
                        break;


                    case ConsoleKey.B:

                        Console.WriteLine("");
                        Console.WriteLine("\tDe que fila quiere sacar a una persona?");

                        Console.WriteLine("");
                        Console.WriteLine("\t-------------------------------------------------");
                        Console.WriteLine("\t-------------------------------------------------");
                        Console.WriteLine("\t-                                               -");
                        Console.WriteLine("\t-           [1] Fila 1                          -");
                        Console.WriteLine("\t-           [2] Fila 2                          -");
                        Console.WriteLine("\t-           [3] Fila 3                          -");
                        Console.WriteLine("\t-           [4] Fila 4                          -");
                        Console.WriteLine("\t-                                               -");
                        Console.WriteLine("\t-------------------------------------------------");
                        Console.WriteLine("\t-------------------------------------------------");
                        Console.WriteLine("");

                        opf = Console.ReadKey(true);

                        switch (opf.Key)
                        {

                            case ConsoleKey.NumPad1:

                                if (cajero1.Count != 0)
                                {
                                    cajero1.Dequeue();
                                    Console.WriteLine("");
                                    Console.WriteLine("\tSe ha despachado a la persona del cajero 1");
                                }
                                else
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("\tNo hay personas en esta fila");
                                }
                                break;

                            case ConsoleKey.NumPad2:

                                if (cajero2.Count != 0)
                                {
                                    cajero2.Dequeue();
                                    Console.WriteLine("");
                                    Console.WriteLine("\tSe ha despachado a la persona del cajero 2");
                                }
                                else
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("\tNo hay personas en esta fila");
                                }
                                break;

                            case ConsoleKey.NumPad3:

                                if (cajero3.Count != 0)
                                {
                                    cajero3.Dequeue();
                                    Console.WriteLine("");
                                    Console.WriteLine("\tSe ha despachado a la persona del cajero 3");
                                }
                                else
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("\tNo hay personas en esta fila");
                                }
                                break;

                            case ConsoleKey.NumPad4:

                                if (cajero4.Count != 0)
                                {
                                    cajero4.Dequeue();
                                    Console.WriteLine("");
                                    Console.WriteLine("\tSe ha despachado a la persona del cajero 4");
                                }
                                else
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("\tNo hay personas en esta fila");
                                }
                                break;

                            default:

                                Console.WriteLine("\tElija una opción valida");
                                Console.ReadKey();
                                Console.Clear();

                                break;
                        }

                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case ConsoleKey.C:


                        Console.WriteLine("");
                        Console.WriteLine("\tMostrando filas de los cajeros: ");

                        Console.WriteLine("\tFila 1:");
                        foreach (string p in cajero1)
                        {

                            Console.Write("\t");
                            Console.Write("" + p + "");

                        }

                        Console.WriteLine("");
                        Console.WriteLine("\tFila 2:");
                        foreach (string p in cajero2)
                        {
                            Console.Write("\t");
                            Console.Write("" + p + "");

                        }

                        Console.WriteLine("");

                        Console.WriteLine("\tFila 3:");
                        foreach (string p in cajero3)
                        {

                            Console.Write("\t");
                            Console.Write("" + p + ""); ;

                        }

                        Console.WriteLine("");

                        Console.WriteLine("\tFila 4:");
                        foreach (string p in cajero4)
                        {

                            Console.Write("\t");
                            Console.Write("" + p + "");

                        }

                        Console.WriteLine("");


                        break;                    


                    default:
                        Console.WriteLine("\tElija una opción valida");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
                Console.ReadKey();
                Console.Clear();

            } while (op.Key != ConsoleKey.Escape);
            
        }
    }
}
