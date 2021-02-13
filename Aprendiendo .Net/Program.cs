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
                Console.WriteLine("Soluciones .Net Guia 1");
                Console.WriteLine("Señor usuario digite la solucion a ejecutar");

                Console.WriteLine("1. Operaciones Matematicas");
                Console.WriteLine("2. Funciones Matematicas");
                Console.WriteLine("3. Universidad Ecci");
                Console.WriteLine("4. Soluciones .Net Guia 1");
                Console.WriteLine("5. Operaciones Matematicas");
                Console.WriteLine("6. Funciones Matematicas");
                Console.WriteLine("7. Soluciones .Net Guia 1");
                Console.WriteLine("8. Universidad Ecci");
                Console.WriteLine("9. Soluciones .Net Guia 1");
                Console.WriteLine("10. Operaciones Matematicas");




                Entrada = Console.ReadLine();
                Opcion = int.Parse(Entrada);

                switch (Opcion)
                {

                    case 1:
                        Ejercicio1 Ej1 = new Ejercicio1();
                        Ej1.Programas();
                        break;

                    case 2:
                        break;

                    case 3:
                        break;
                    case 4:
                        break;

                    case 5:
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

                }

                Console.WriteLine("¿Desea Realizar Otra Operacion? Digite Si o No");
                Entrada = Console.ReadLine();

            } while (Entrada == "Si");




        }
    }
}

