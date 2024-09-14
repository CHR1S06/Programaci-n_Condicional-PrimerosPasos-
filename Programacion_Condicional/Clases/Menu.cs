using Programacion_Condicional.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.Threading.Channels;

namespace Programacion_Condicional
{
    // Clase principal que maneja el menú de opciones
    public class Menu
    {
        // Variable privada que almacena la respuesta del usuario
        private int RespuestaMenu;

        // Método que despliega el menú principal y maneja las opciones
        public void MenuProgram()
        {
            // Limpia la consola para iniciar el menú
            Console.Clear();

            // Muestra el menú de opciones en la consola
            Console.WriteLine(@"Bienvenido al programa de Programacion Condicional

1- (App 1) Operaciones Condicionales: Suma y Resta o Producto y Cociente.
2- (App 2) Cálculo de Promedio y Verificación de Aprobación de Estudiantes.
3- (App 3) Evaluación de Nivel de Postulantes Según Resultados de Test.
4- Salir del programa");

            // Solicita al usuario que ingrese una opción
            Console.Write("\nDigite su respuesta aqui: ");

            // Bucle infinito para validar la entrada del usuario
            while (true)
            {
                try
                {
                    // Intenta convertir la entrada del usuario en un entero
                    RespuestaMenu = Convert.ToInt32(Console.ReadLine());

                    // Verifica si la respuesta está dentro del rango válido (1 a 4)
                    if (RespuestaMenu >= 1 && RespuestaMenu <= 4)
                    {
                        // Usa un switch para llamar a la aplicación correcta
                        switch (RespuestaMenu)
                        {
                            // Caso 1: Ejecuta App1, que realiza operaciones condicionales (suma, resta, producto, cociente)
                            case 1:
                                App1 app1 = new App1();
                                app1.Programa1();
                                break;

                            // Caso 2: Ejecuta App2, que calcula el promedio de calificaciones y verifica si se aprueba
                            case 2:
                                App2 app2 = new App2();
                                app2.Programa2();
                                break;

                            // Caso 3: Ejecuta App3, que evalúa el nivel de un postulante basado en un test
                            case 3:
                                App3 app3 = new App3();
                                app3.Programa3();
                                break;

                            // Caso 4: Sale del programa, no hace nada más
                            case 4:
                                return;
                        }
                        // Si se selecciona una opción válida, sale del bucle
                        break;
                    }
                    else
                    {
                        // Muestra un mensaje de error si la opción no está en el rango permitido
                        Console.WriteLine("Por favor limitese a digitar uno de los numeros mostrados en pantalla");
                    }
                }
                catch (Exception ex)
                {
                    // Muestra el mensaje de error si ocurre una excepción al intentar leer la entrada
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
