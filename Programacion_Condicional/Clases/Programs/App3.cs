using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Programacion_Condicional.Clases
{
    public class App3
    {
        // Declaramos dos variables enteras: una para la cantidad de preguntas y otra para la cantidad de respuestas correctas
        private int CantidadPreguntas, CantidadRespCorrect;

        // Método principal del programa
        public void Programa3()
        {
            // Limpiamos la pantalla y damos la bienvenida al programa
            Console.Clear();
            Console.WriteLine("Bienvenido al Tercer Programa.\n");

            // Solicitamos al usuario ingresar la cantidad de preguntas del test
            Console.Write("Favor introducir la cantidad de Preguntas del test: ");

            // Ciclo para validar que el número ingresado sea válido (mayor o igual a 0)
            while (true)
            {
                try
                {
                    CantidadPreguntas = Convert.ToInt32(Console.ReadLine());
                    if (CantidadPreguntas >= 0)
                    {
                        break; // Si es válido, sale del ciclo
                    }
                    else
                    {
                        Console.WriteLine("Por favor Ingrese un número válido");
                    }
                }
                catch (Exception ex)
                {
                    // En caso de error, muestra el mensaje correspondiente
                    Console.WriteLine(ex.Message);
                }
            }

            // Solicitamos al usuario ingresar la cantidad de respuestas correctas
            Console.Write("\nFavor introducir la cantidad de respuestas correctas: ");

            // Validamos que el número de respuestas correctas sea válido y esté dentro del rango de las preguntas
            while (true)
            {
                try
                {
                    CantidadRespCorrect = Convert.ToInt32(Console.ReadLine());
                    if (CantidadRespCorrect >= 0 && CantidadRespCorrect <= CantidadPreguntas)
                    {
                        break; // Si es válido, sale del ciclo
                    }
                    else
                    {
                        Console.WriteLine("Por favor Ingrese un número válido");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            // Llamamos al método que realiza la validación del nivel de aprobación
            ValidacionDeAprobacion();

            // Mensaje para volver al menú
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nPara volver al menú presione cualquier tecla");
            Console.ResetColor();
            Console.ReadKey();

            // Volvemos al menú principal
            Menu menu = new Menu();
            menu.MenuProgram();
        }

        // Método para validar si el postulante aprobó según el porcentaje de respuestas correctas
        public void ValidacionDeAprobacion()
        {
            // Pausa el programa por 3 segundos para dar tiempo al usuario de ver el resultado
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("El nivel del postulante es:\n");

            // Calculamos el porcentaje de respuestas correctas
            double PorcentajeDeAcierto = (double)CantidadRespCorrect / CantidadPreguntas * 100;

            // Verificamos el nivel del postulante en función del porcentaje
            if (PorcentajeDeAcierto >= 90)
            {
                Console.WriteLine("Nivel Máximo");
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
