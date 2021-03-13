using System;
using System.Collections.Generic;
using System.Text;

namespace Aprendiendo_.Net
{
    class Ejercicio2
    {
        public void Funciones_matematicas()
        {

            // Operaciones Matematicas

            string Entrada="";
            Double Numero;

            Console.WriteLine("Universidad ECCI");
            Console.WriteLine("Funciones Matematicas");
            Console.WriteLine("Digita el numero para calcular las 10 funciones sobre el ");
            Entrada = Console.ReadLine();
            Numero = Double.Parse(Entrada);

            Console.WriteLine("La raiz de "+ Entrada +" Es "+ Math.Sqrt(Numero)  );
            Console.WriteLine("El Seno de " + Entrada + " Es " + Math.Sin(Numero));
            Console.WriteLine("El Coseno de " + Entrada + " Es " + Math.Cos(Numero));
            Console.WriteLine("El Tangente de " + Entrada + " Es " + Math.Tan(Numero));
            Console.WriteLine("El Valor absoluto de " + Entrada + " Es " + Math.Abs(Numero));
            Console.WriteLine("El Arcotangente de " + Entrada + " Es " + Math.Atan(Numero));
            Console.WriteLine("La Raiz cubica de " + Entrada + " Es " + Math.Cbrt(Numero));
            Console.WriteLine("El Logaritmo de " + Entrada + " Es " + Math.Log(Numero));
            Console.WriteLine("El Logaritmo en base 10 de " + Entrada + " Es " + Math.Log10(Numero));
            Console.WriteLine("El Valor de " + Entrada + "Elevado al cuadrado Es " + Math.Pow(Numero,2));





        }

    }
}
