using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Programacion_Condicional.Clases
{
    public class App1
    {
        // Declaramos dos variables de tipo double para almacenar los números que el usuario va a ingresar
        private double PrimerNum, SegundoNum;

        // Método principal del programa
        public void Programa1()
        {
            // Limpia la pantalla antes de iniciar
            Console.Clear();
            Console.WriteLine("Bienvenido al primer Programa.\n");

            // Solicita al usuario ingresar el primer número
            Console.Write("Favor introduzca el primer numero: ");

            // Ciclo para asegurarse de que el usuario ingrese un número válido
            while (true)
            {
                try
                {
                    // Convertimos el valor ingresado a double
                    PrimerNum = Convert.ToDouble(Console.ReadLine());
                    break; // Si no hay error, sale del ciclo
                }
                catch (Exception ex)
                {
                    // Si el usuario ingresa un valor inválido, se muestra el error
                    Console.WriteLine(ex.Message);
                }
            }

            // Solicita el segundo número
            Console.Write("\nFavor introduzca el segundo numero: ");

            // Se repite el mismo proceso para validar el segundo número
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

            // Llama al método que realiza las validaciones y operaciones
            ValidacionDeNum();

            // Indicamos al usuario que puede regresar al menú presionando cualquier tecla
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nPara volver al menu presione cualquier tecla");
            Console.ResetColor();
            Console.ReadKey();

            // Instancia la clase Menu y vuelve al menú principal
            Menu menu = new Menu();
            menu.MenuProgram();
        }

        // Método para validar los números ingresados y realizar las operaciones correspondientes
        public void ValidacionDeNum()
        {
            // Pausa el programa por 3 segundos para dar tiempo al usuario de ver el resultado
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("Ahora se van a validar las entradas:");

            // Si el primer número es mayor que el segundo, se realizan la suma y la resta
            if (PrimerNum > SegundoNum)
            {
                Console.WriteLine("El Primer Numero es mayor, por lo tanto:");
                double Suma = PrimerNum + SegundoNum;
                double Resta = PrimerNum - SegundoNum;

                // Muestra los resultados de la suma y la resta
                Console.WriteLine($"\nLa Suma de los Numeros es:");
                Console.WriteLine($"{Suma}");

                Console.WriteLine($"\nLa Resta de los Numeros es:");
                Console.WriteLine($"{Resta}");
            }
            // Si el segundo número es mayor o los números son iguales, se realizan el producto y el cociente
            else if (SegundoNum > PrimerNum || PrimerNum == SegundoNum)
            {
                Console.WriteLine("El Segundo Numero es mayor, o los numeros son iguales, por lo tanto:");
                double Producto = PrimerNum * SegundoNum;

                // Muestra el resultado del producto
                Console.WriteLine($"\nEl Producto de los Numeros es:");
                Console.WriteLine($"{Producto}");

                try
                {
                    // Intenta calcular el cociente entre los dos números
                    double Cociente = PrimerNum / SegundoNum;

                    // Muestra el resultado del cociente
                    Console.WriteLine($"\nEl Cociente de los Numeros es:");
                    Console.WriteLine($"{Cociente}");
                }
                catch (Exception ex)
                {
                    // Si ocurre un error (por ejemplo, división por cero), lo muestra
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
