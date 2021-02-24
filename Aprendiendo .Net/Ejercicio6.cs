using System;
using System.Collections.Generic;
using System.Text;

namespace Aprendiendo_.Net
{
    class Ejercicio6
    { 
    public void Caracterizacion_programas()
    {
        
        {
            //Caracterizacion de numeros
            int cant, positivos = 0, negativos = 0, neutros = 0;
            double numero, SumaPositivos = 0, SumaNegativos = 0;
            string entrada;
            do
            {
                Console.Clear();
                Console.WriteLine("UNIVERSIDAD ECCI");
                Console.WriteLine("SOLUCIONES .NET");
                Console.WriteLine("6. Caracterizacion de numeros");
                Console.Write("Digite la cantidad de numeros a ingresar: ");
                cant = int.Parse(Console.ReadLine());

                for (int i = 1; i <= cant; i++)
                {
                    Console.Write("Digite el numero " + i + ":");
                    numero = int.Parse(Console.ReadLine());

                    if (numero < 0)
                    {
                        SumaNegativos = (SumaNegativos + numero);
                        negativos++;
                    }
                    else if (numero > 0)
                    {
                        SumaPositivos = (SumaPositivos + numero);
                        positivos++;
                    }
                    else
                    {
                        neutros++;
                    }
                }

                Console.WriteLine("Cantidad de numeros negativos: " + negativos);
                Console.WriteLine("Cantidad de numeros positivos: " + positivos);
                Console.WriteLine("Cantidad de numeros neutros: " + neutros);

                Console.WriteLine("Suma de los numeros positivos: " + SumaPositivos);
                Console.WriteLine("Suma de los numeros negativos: " + SumaNegativos);

                //Inicializar variables
                cant = 0;
                positivos = 0;
                negativos = 0;
                neutros = 0;
                numero = 0;
                SumaPositivos = 0;
                SumaNegativos = 0;
                entrada = "";

                Console.WriteLine("Digite si / no para repetir este programa ====> ");
                entrada = Console.ReadLine();

            } while (entrada == "si");
        }
    }
}

}


