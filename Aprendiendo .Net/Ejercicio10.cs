using System;
using System.Collections.Generic;
using System.Text;

namespace Aprendiendo_.Net
{
    class Ejercicio10
    {

        public void Nomina_empleados()
        {

            int filas = 6;
            int columnas = 11;
            int titulo = -1;
            int Opción;
            string Entrada = "";
            
            
            string [,] tabla = new string [filas,columnas];



            tabla [0,0] = "|Cedula|";
            tabla[0, 1] = "|Nombre|";
            tabla[0, 2] = "|Salario|";
            tabla[0, 3] = "|Aux. Transporte |";
            tabla[0, 4] = "|Días|";
            tabla[0, 5] = "|Sueldo|";
            tabla[0, 6] = "|H.E.D|";
            tabla[0, 7] = "|H.E.N|";
            tabla[0, 8] = "|H.E,F|";
            tabla[0, 9] = "|Recargo Nocturno|";
            tabla[0, 10] ="|Total Devengado |";


            
            

                Console.Clear();

                for (int fila = 1; fila < filas; fila++)
                {

                    for (int columna = 0; columna < columnas; columna++)
                    {
                        if (titulo != 10)
                        {

                            titulo++;

                        }
                        else
                        {
                            titulo = 0;
                        }


                        Console.WriteLine("Total devengado");
                        Console.WriteLine("Ingresa los datos solicitados a continuación");
                        Console.WriteLine("Por favor ingresa " + tabla[0, titulo]);

                        tabla[fila, columna] = Console.ReadLine();
                        Console.Clear();

                        for (int i = 0; i < filas; i++)
                        {


                            for (int j = 0; j < columnas; j++)
                            {

                                Console.Write(tabla[i, j] + " |");

                            }
                            Console.WriteLine("| \n");

                        }






                    }


                }

                Console.WriteLine("Total deducido");



           
        }
            

        
    }
}
