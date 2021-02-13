using System;
using System.Collections.Generic;
using System.Text;

namespace Aprendiendo_.Net
{
    class Ejercicio1
    {
        public void Programas()
        {
            double Numero1, Numero2, Suma = 0, Resta = 0, Producto, Division = 0, Multiplicacion = 0;

            string Entrada;
            Console.WriteLine("Opcion uno Operaciones Matematicas");
            Console.WriteLine("Selecciona la Operacion");
            Console.WriteLine("+");
            Console.WriteLine("-");
            Console.WriteLine("*");
            Console.WriteLine("/");

            Entrada = Console.ReadLine();

            Console.WriteLine("Digite el primer numero " );
            Numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite el segundo numero ");
            Numero2 = double.Parse(Console.ReadLine());


            if (Entrada == "+")
            {
            

                Suma = Numero1 + Numero2;
                Console.WriteLine("Valor de la Suma es " + Suma);

            }
            if (Entrada == "-")
            {
                Console.WriteLine("Resta \n");

                Resta = Numero1 - Numero2;
                Console.WriteLine("Valor de la Resta es " + Resta);
            }
            if (Entrada == "/")
            {

                if (Numero2 != 0) {

                    Division = Numero1 / Numero2;
                    Console.WriteLine("Valor de la División es " + Division);
                }
                else
                {
                    Console.Write("El segundo numero debe ser diferente a 0");
                    while (Numero2 == 0)
                    {
                        Console.WriteLine("Digite el segundo numero");
                        Numero2 = double.Parse(Console.ReadLine());

                    }

                    Division = Numero1 / Numero2;
                    Console.WriteLine("Valor de la División es " + Division);

                }

            }
            if (Entrada == "*")
            {

                Multiplicacion = Numero1 * Numero2;
                Console.WriteLine("Valor de la Multiplicación es " + Multiplicacion);

            }

            
           
           

















        }

    }
}
