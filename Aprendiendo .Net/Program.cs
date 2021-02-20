using System;

namespace Aprendiendo_.Net
{
    class Program
    {
        static void Main(string[] args)
        {

            int Opcion;
            string Entrada;

            do
            {




                Console.WriteLine("Universidad Ecci");
                Console.WriteLine("Soluciones .Net Guia 12");
                Console.WriteLine("Señor usuario digite la solucion a ejecutar");

                Console.WriteLine("1. Operaciones Matematicas");
                Console.WriteLine("2. Funciones Matematicas");
                Console.WriteLine("3. Validador de Respuestas");
                Console.WriteLine("4. Promedio de Produccion");
                Console.WriteLine("5. Estacion Climatica");
                Console.WriteLine("6. Caracterizacion de Numeros");
                Console.WriteLine("7. Estadistica de Pesos");
                Console.WriteLine("8. Proceso de Produccion de Huevos");
                Console.WriteLine("9. Sistema de Calificaciones - Indira, Universidad Ecci ");
                Console.WriteLine("10. Nomina de Empleados Universidad Ecci");




                Entrada = Console.ReadLine();
                Opcion = int.Parse(Entrada);

                switch (Opcion)
                {

                    case 1:
                        Ejercicio1 Ej1 = new Ejercicio1();
                        Ej1.Programas();
                        break;

                    case 2:
                        Ejercicio2 Ej2 = new Ejercicio2();
                        
                        break;

                    case 3:
                        break;
                    case 4:

                        Ejercicio4 Ej4 = new Ejercicio4();
                        Ej4.Salario();

                        break;

                    case 5:

                        Ejercicio5 Ej5 = new Ejercicio5();
                        Ej5.Estacion_climatica();

                        break;

                    case 6:
                        break;
                    case 7:
                        break;

                    case 8:
                        break;

                    case 9:
                        break;

                    case 10:

                        break;

    
                    default: Console.WriteLine("La opcion no se encuentra en el menú");
                        break;

                }

                Console.WriteLine("¿Desea Realizar Otra Operacion? Digite Si o No");
                Entrada = Console.ReadLine();

            } while (Entrada == "Si");




        }
    }
}

