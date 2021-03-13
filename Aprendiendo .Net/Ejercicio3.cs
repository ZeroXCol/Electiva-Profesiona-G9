using System;
using System.Collections.Generic;
using System.Text;

namespace Aprendiendo_.Net
{
    class Ejercicio3
    {
        public void ValidadorRespuestas() {

            int val1 = 0, val2 = 0, val3 = 0, postulante;


            Console.WriteLine("Porfavor diguite la cantidad de postulantes");
            postulante = int.Parse(Console.ReadLine());
            string cor = "";
            for (int i = 0; i < postulante; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    cor = "Correcto";
                    Console.WriteLine("Por favor La cantidad de respuestas " + cor + " del usuario " + i);
                    val1 = int.Parse(Console.ReadLine());
                    val1 = val1 * 4;

                    cor = "Incorrecto";
                    Console.WriteLine("Por favor La cantidad de respuestas " + cor + " del usuario " + i);
                    val2 = int.Parse(Console.ReadLine());
                    val2 = val2 * (-1);

                    cor = "En blanco";
                    Console.WriteLine("Por favor La cantidad de respuestas " + cor + " del usuario " + i);
                    val3 = int.Parse(Console.ReadLine());
                    val3 = val3 * 0;


                    Console.WriteLine("El usuario " + i + " tiene:");
                    Console.WriteLine(val1 + " Puntos en respuestas correctas");
                    Console.WriteLine(val2 + " Puntos en respuestas incorrectas");
                    Console.WriteLine(val3 + " Puntos en respuestas en blanco");
                    val1 = 0;
                    val2 = 0;
                    val3 = 0;
                }

            }
            Console.ReadLine();


        }



    }
}
