using System;
using System.Collections.Generic;
using System.Text;

namespace Aprendiendo_.Net
{
    class Ejercicio8
    {

        public void Produccion_huevos()
        {

            // PUNTO 8 //
            /*
             * X = # GALLINAS
             * N = # DE DIAS
             * Y = total
             */

            int X, N, Y;
            string Entrada = "";
            do
            {
                Console.Clear();
                Console.WriteLine("Universidad ECCI");
                Console.WriteLine("Proceso de producción de huevos");
                Console.WriteLine("Porfavor digite la cantidad de gallinas");
                X = int.Parse(Console.ReadLine());
                Console.WriteLine("Porfavor digite la cantidad de dias");
                N = int.Parse(Console.ReadLine());

                Console.WriteLine("El proceso de calculo toma como constante que el numero de huevos producidos por una gallona en un dia es 1.");
                Y = X * N;
                Console.WriteLine("El numero de producción de huevos entre gallinas * dias es igual a = " + Y + " Huevos");
                


                Console.WriteLine("Desea repetir la operación? Digite si o no");
                Entrada = Console.ReadLine();

                X = 0;
                Y = 0;
                N = 0;

            } while (Entrada == "si");



        }

    }
}
