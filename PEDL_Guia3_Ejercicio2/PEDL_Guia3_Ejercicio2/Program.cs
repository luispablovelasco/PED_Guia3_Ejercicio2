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

            ConsoleKeyInfo op;
            Queue<string> cajero1 = new Queue<string>();
            Queue<string> cajero2 = new Queue<string>();
            Queue<string> cajero3 = new Queue<string>();
            Queue<string> cajero4 = new Queue<string>();


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
                string pos = "Ocupado";

                switch (op.Key)
                {

                    case ConsoleKey.A:

                        Console.WriteLine("\tEntrar a una fila");
                        Console.WriteLine("");
                        

                        break;

                    default:
                        Console.WriteLine("\tElija una opción valida");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }


            } while (true);
            
        }
    }
}
