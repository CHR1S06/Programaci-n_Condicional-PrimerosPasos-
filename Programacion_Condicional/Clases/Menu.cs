using Programacion_Condicional.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.Threading.Channels;

namespace Programacion_Condicional
{
    public class Menu
    {
        public static int RespuestaMenu;
        public static void MenuProgram()
        {
            Console.Clear();
            Console.WriteLine(@"Bienvenido al programa de Programacion Condicional

1- (App 1) Operaciones Condicionales: Suma y Resta o Producto y Cociente.
2- (App 2) Cálculo de Promedio y Verificación de Aprobación de Estudiantes.
3- (App 3) Evaluación de Nivel de Postulantes Según Resultados de Test.
4- Salir del programa");

            Console.Write("\nDigite su respuesta aqui: ");
            
            while(true)
            {
                try
                {
                    RespuestaMenu = Convert.ToInt32(Console.ReadLine());

                    if (RespuestaMenu >= 1 && RespuestaMenu <= 4)
                    {
                        switch (RespuestaMenu)
                        {
                            case 1:
                                App1.Programa1();
                                break;

                            case 2:
                                App2.Programa2();
                                break;

                            case 3:
                                App3.Programa3();
                                break;

                            case 4:
                                break;
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Por favor limitese a digitar uno de los numeros mostrados en pantalla");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
        }
    }
}
