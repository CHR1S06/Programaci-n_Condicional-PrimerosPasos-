using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Programacion_Condicional.Clases
{
    public class App1
    {
        public static double PrimerNum, SegundoNum;
        public static void Programa1()
        {
            Console.Clear();
            Console.WriteLine("Bienvenido al primer Progama.\n");
            Console.Write("Favor introduzca el primer numero: ");

            while(true)
            {
                try
                {
                    PrimerNum = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }

            Console.Write("\nFavor introduzca el segundo numero: ");

            while (true)
            {
                try
                {
                    SegundoNum = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }

            ValidacionDeNum();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nPara volver al menu presione cualquier tecla");
            Console.ResetColor();
            Console.ReadKey();
            Menu.MenuProgram();
        }

        public static void ValidacionDeNum()
        {
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("Ahora se van a validar las entradas:");

            if(PrimerNum>SegundoNum)
            {
                Console.WriteLine("El Primer Numero es mayor, por lo tanto:");
                double Suma = PrimerNum + SegundoNum;
                double Resta = PrimerNum - SegundoNum;

                Console.WriteLine($"\nLa Suma de los Numeros es:");
                Console.WriteLine($"{Suma}");

                Console.WriteLine($"\nLa Resta de los Numeros es:");
                Console.WriteLine($"{Resta}");
            }
            else if(SegundoNum>PrimerNum || PrimerNum==SegundoNum)
            {
                Console.WriteLine("El Segundo Numero es mayor, o los numeros son iguales, por lo tanto:");
                double Producto = PrimerNum * SegundoNum;

                Console.WriteLine($"\nEl Producto de los Numeros es:");
                Console.WriteLine($"{Producto}");
                try
                {
                    double Cociente = PrimerNum / SegundoNum;

                    Console.WriteLine($"\nEl Cociente de los Numeros es:");
                    Console.WriteLine($"{Cociente}");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
