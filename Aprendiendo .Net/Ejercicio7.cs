using System;
using System.Collections.Generic;
using System.Text;

namespace Aprendiendo_.Net
{
    class Ejercicio7
    {
        public void Estadisticas_pesos()
        {
            //Estadistica de pesos
            int CantPersonas = 0, edad = 0, peso = 0, niños = 0, jovenes = 0, adultos = 0, viejos = 0;
            double PromPesoN = 0, PromPesoJ = 0, PromPesoA = 0, PromPesoV = 0;
            double SumaPesoN = 0, SumaPesoJ = 0, SumaPesoA = 0, SumaPesoV = 0;
            string entrada;

            do
            {
                Console.Clear();
                Console.WriteLine("UNIVERSIDAD ECCI");
                Console.WriteLine("SOLUCIONES .NET");
                Console.WriteLine("7. Estadistica de pesos: ");
                Console.WriteLine("");
                Console.Write("Digite el numero de personas a realizar el muestreo: ");
                CantPersonas = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                for (int i = 1; i <= CantPersonas; i++)
                {
                    edad = 0;
                    peso = 0;

                    Console.Write("Digite la edad de la persona " + i + ": ");
                    edad = int.Parse(Console.ReadLine());
                    Console.Write("Digite el peso de la persona " + i + ": ");
                    peso = int.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    if (edad >= 0 & edad <= 13)
                    {
                        SumaPesoN = (SumaPesoN + peso);
                        niños++;
                    }
                    else if (edad >= 14 & edad <= 30)
                    {
                        SumaPesoJ = (SumaPesoJ + peso);
                        jovenes++;
                    }
                    else if (edad >= 31 & edad <= 60)
                    {
                        SumaPesoA = (SumaPesoA + peso);
                        adultos++;
                    }
                    else if (edad >= 61)
                    {
                        SumaPesoV = (SumaPesoV + peso);
                        viejos++;
                    }
                }

                if (niños == 0)
                {
                    PromPesoN = 0;
                }
                else
                {
                    PromPesoN = (SumaPesoN / niños);
                }

                if (jovenes == 0)
                {
                    PromPesoJ = 0;
                }
                else
                {
                    PromPesoJ = (SumaPesoJ / jovenes);
                }

                if (PromPesoA == 0)
                {
                    PromPesoA = 0;
                }
                else
                {
                    PromPesoA = (SumaPesoA / adultos);
                }

                if (PromPesoV == 0)
                {
                    PromPesoV = 0;
                }
                else
                {
                    PromPesoV = (SumaPesoV / viejos);
                }

                Console.WriteLine("El promedio de peso de los niños es: " + PromPesoN);
                Console.WriteLine("El promedio de peso de los jovenes es: " + PromPesoJ);
                Console.WriteLine("El promedio de peso de los adultos es: " + PromPesoA);
                Console.WriteLine("El promedio de peso de los viejos es: " + PromPesoV);

                Console.WriteLine("");

                //Inicializar variables
                CantPersonas = 0;
                edad = 0;
                peso = 0;
                niños = 0;
                jovenes = 0;
                adultos = 0;
                viejos = 0;
                PromPesoN = 0;
                PromPesoJ = 0;
                PromPesoA = 0;
                PromPesoV = 0;
                SumaPesoN = 0;
                SumaPesoJ = 0;
                SumaPesoA = 0;
                SumaPesoV = 0;
                entrada = "";

                Console.Write("Digite si / no para repetir este programa ====> ");
                entrada = Console.ReadLine();

            } while (entrada == "si");
        }
    }

}

