using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Programacion_Condicional.Clases
{
    public class App2
    {
        public static double PrimerCalif, SegundaCalif, TercerCalif;
        public static void Programa2()
        {
            Console.Clear();
            Console.WriteLine("Bienvenido al Segundo Progama.\n");
            Console.Write("Favor introduzca la primera calificacion: ");

            while (true)
            {
                try
                {
                    PrimerCalif = Convert.ToDouble(Console.ReadLine());
                    if(PrimerCalif>=0 && PrimerCalif<=100)
                    {
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("Por favor introduzca una calificacion valida.");
                    }
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }

            Console.Write("\nFavor introduzca la segunda calificacion: ");

            while (true)
            {
                try
                {
                    SegundaCalif = Convert.ToDouble(Console.ReadLine());
                    if (SegundaCalif >= 0 && SegundaCalif <= 100)
                    {
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("Por favor introduzca una calificacion valida.");
                    }
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }

            Console.Write("\nFavor introduzca la tercera calificacion: ");

            while (true)
            {
                try
                {
                    TercerCalif = Convert.ToDouble(Console.ReadLine());
                    if (TercerCalif >= 0 && TercerCalif <= 100)
                    {
                        break; ;
                    }
                    else
                    {
                        Console.WriteLine("Por favor introduzca una calificacion valida.");
                    }
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }

            ValidacionDeCalif();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nPara volver al menu presione cualquier tecla");
            Console.ResetColor();
            Console.ReadKey();
            Menu.MenuProgram();
        }

        public static void ValidacionDeCalif()
        {
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("Ahora se van a promediar las notas:");

            double SumaCalif = PrimerCalif + SegundaCalif + TercerCalif;
            double PromedioCalif = SumaCalif / 3;

            if (PromedioCalif>=70)
            {
                Console.WriteLine("El Alumno ha aprobado");
                Console.WriteLine($"Promedio: {PromedioCalif:F1}");
            }
            else 
            {
                Console.WriteLine("El Alumno no aprobó");
                Console.WriteLine($"Promedio: {PromedioCalif:F1}");
            }
        }
    }
}
