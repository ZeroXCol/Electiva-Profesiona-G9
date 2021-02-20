using System;
using System.Collections.Generic;
using System.Text;


namespace Aprendiendo_.Net
{
    class Ejercicio5
    {

        public void Estacion_climatica()
        {

            int tempmax ;
            int tempmin;
            int[] dias;
            int entradadias;            
            int generatempmax = 0;
            int generatempmin = 0;
            int cuentaerror = 0;
            int cuentaok = 0;
            double promedioerror;
            double promediook;

            Console.WriteLine("Digita la temperatura minima");
            tempmin = int.Parse(Console.ReadLine());
            Console.WriteLine("Digita la temperatura máxima");
            tempmax = int.Parse(Console.ReadLine());
            Console.WriteLine("Digita el numero de días a medir");
            entradadias = int.Parse(Console.ReadLine());
            dias = new int[entradadias];

            for (int i = 0; i < dias.Length; i++)
            {
                Random Rnd = new Random();
                generatempmax = Rnd.Next(tempmin,tempmax);
                generatempmin = Rnd.Next(tempmin, generatempmax + 1);

                Console.WriteLine("/////////////////////////////////////////////////////////////////" );

                Console.WriteLine("Temperatura máxima del día "+i+" es: " + generatempmax);
                Console.WriteLine("Temperatura mínima del día " + i + " es: " + generatempmin);

                Console.WriteLine("/////////////////////////////////////////////////////////////////");


                if (generatempmax == 9 && generatempmin == 9)
                {
                    cuentaerror++;

                }
                else { 
                
                    cuentaok++;

                }

                


            }

            Console.WriteLine("El numero de errores es: " + cuentaerror);
            Console.WriteLine("El numero de temperaturas ok es: " + cuentaok);
            Console.WriteLine("El numero de días es: " + entradadias);

            promedioerror = (cuentaerror * 100 ) / entradadias ;
            promediook = (cuentaok * 100) / entradadias;
            Console.WriteLine("-------------------------------------------------------\n");
            Console.WriteLine("El porcentaje de error es: %"+promedioerror);
            Console.WriteLine("El porcentaje de temperaturas validas es: %" + promediook);





        }






    }
}
