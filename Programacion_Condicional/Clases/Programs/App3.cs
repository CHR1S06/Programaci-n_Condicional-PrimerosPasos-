using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Programacion_Condicional.Clases
{
    public class App3
    {
        public static int CantidadPreguntas, CantidadRespCorrect;
        public static void Programa3()
        {
            Console.Clear();
            Console.WriteLine("Bienvenido al Tercer Progama.\n");
            Console.Write("Favor introducir la cantidad de Preguntas del test: ");

            while(true)
            {
                try
                {
                    CantidadPreguntas = Convert.ToInt32(Console.ReadLine());
                    if(CantidadPreguntas>=0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Por favor Ingrese un numero valido");
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.Write("\nFavor introducir la cantidad de respuestas correctas: ");

            while (true)
            {
                try
                {
                    CantidadRespCorrect = Convert.ToInt32(Console.ReadLine());
                    if (CantidadRespCorrect >= 0 && CantidadRespCorrect <= CantidadPreguntas)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Por favor Ingrese un numero valido");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            ValidacionDeAprobacion();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nPara volver al menu presione cualquier tecla");
            Console.ResetColor();
            Console.ReadKey();
            Menu.MenuProgram();
        }

        public static void ValidacionDeAprobacion()
        {
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("El nivel del postulante es:\n");

            double PorcentajeDeAcierto = (double)CantidadRespCorrect / CantidadPreguntas * 100;

            if (PorcentajeDeAcierto >= 90)
            {
                Console.WriteLine("Nivel Maximo");
                Console.WriteLine($"\nPorcentaje del postulante: {PorcentajeDeAcierto:F1}");
            }
            else if (PorcentajeDeAcierto >= 75 && PorcentajeDeAcierto <= 89.9)
            {
                Console.WriteLine("Nivel Medio");
                Console.WriteLine($"\nPorcentaje del postulante: {PorcentajeDeAcierto:F1}");
            }
            else if (PorcentajeDeAcierto >= 50 && PorcentajeDeAcierto < 75)
            {
                Console.WriteLine("Nivel Regular");
                Console.WriteLine($"\nPorcentaje del postulante: {PorcentajeDeAcierto:F1}");
            }
            else if (PorcentajeDeAcierto < 50)
            {
                Console.WriteLine("Fuera de Nivel");
                Console.WriteLine($"\nPorcentaje del postulante: {PorcentajeDeAcierto:F1}");
            }
        }
    }
}
