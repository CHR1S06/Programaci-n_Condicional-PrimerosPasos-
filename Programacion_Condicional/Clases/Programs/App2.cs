using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Programacion_Condicional.Clases
{
    public class App2
    {
        // Declaramos tres variables de tipo double para almacenar las calificaciones que el usuario va a ingresar
        private double PrimerCalif, SegundaCalif, TercerCalif;

        // Método principal del programa
        public void Programa2()
        {
            // Limpia la pantalla antes de iniciar
            Console.Clear();
            Console.WriteLine("Bienvenido al Segundo Programa.\n");

            // Solicita al usuario ingresar la primera calificación
            Console.Write("Favor introduzca la primera calificacion: ");

            // Ciclo para asegurarse de que el usuario ingrese una calificación válida
            while (true)
            {
                try
                {
                    // Convertimos el valor ingresado a double y validamos que esté entre 0 y 100
                    PrimerCalif = Convert.ToDouble(Console.ReadLine());
                    if (PrimerCalif >= 0 && PrimerCalif <= 100)
                    {
                        break; // Si no hay error, sale del ciclo
                    }
                    else
                    {
                        // Mensaje en caso de que la calificación no esté en el rango válido
                        Console.WriteLine("Por favor introduzca una calificacion valida.");
                    }
                }
                catch (Exception ex)
                {
                    // Si el usuario ingresa un valor inválido, se muestra el error
                    Console.WriteLine(ex.Message);
                }
            }

            // Solicita la segunda calificación
            Console.Write("\nFavor introduzca la segunda calificacion: ");

            // Se repite el mismo proceso para validar la segunda calificación
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

            // Solicita la tercera calificación
            Console.Write("\nFavor introduzca la tercera calificacion: ");

            // Se repite el mismo proceso para validar la tercera calificación
            while (true)
            {
                try
                {
                    TercerCalif = Convert.ToDouble(Console.ReadLine());
                    if (TercerCalif >= 0 && TercerCalif <= 100)
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

            // Llama al método que realiza la validación de las calificaciones
            ValidacionDeCalif();

            // Indicamos al usuario que puede regresar al menú presionando cualquier tecla
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nPara volver al menu presione cualquier tecla");
            Console.ResetColor();
            Console.ReadKey();

            // Instancia la clase Menu y vuelve al menú principal
            Menu menu = new Menu();
            menu.MenuProgram();
        }

        // Método para validar las calificaciones ingresadas y calcular el promedio
        public void ValidacionDeCalif()
        {
            // Pausa el programa por 3 segundos para dar tiempo al usuario de ver el resultado
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("Ahora se van a promediar las notas:");

            // Calcula la suma de las calificaciones
            double SumaCalif = PrimerCalif + SegundaCalif + TercerCalif;
            // Calcula el promedio de las calificaciones
            double PromedioCalif = SumaCalif / 3;

            // Verifica si el promedio es mayor o igual a 70 para determinar si el alumno ha aprobado
            if (PromedioCalif >= 70)
            {
                Console.WriteLine("El Alumno ha aprobado");
                Console.WriteLine($"Promedio: {PromedioCalif:F1}");
            }
            else
            {
                // Si el promedio es menor a 70, indica que el alumno no ha aprobado
                Console.WriteLine("El Alumno no aprobó");
                Console.WriteLine($"Promedio: {PromedioCalif:F1}");
            }
        }
    }
}
