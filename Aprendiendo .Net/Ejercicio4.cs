using System;
using System.Collections.Generic;
using System.Text;

namespace Aprendiendo_.Net
{
    class Ejercicio4
    {
        double Base;
        double Calculo_Salario;
        double Bonificacion;
        double Salario_Total;
        string Nombre;
        string Entrada = "";
        string[] Semana = new string [] { "Lunes", "Martes","Miercoles", "Jueves", "Viernes", "Sabado" };

        int Cantidad_diaria;
        int Cantidad_acumulada;
        


        public void Salario()
        {

            do {
                Console.Clear();
                Console.WriteLine("Universidad ECCI");
                Console.WriteLine("Promedio de producción");
                Console.WriteLine("Digita el nombre del empleado");
                Nombre = Console.ReadLine();

                for (int i = 0; i < Semana.Length; i++)
                {

                Console.WriteLine("Digita la cantidad producida el día " + Semana[i]);
                Cantidad_diaria = int.Parse(Console.ReadLine());
                Cantidad_acumulada = Cantidad_acumulada + Cantidad_diaria;
                Console.WriteLine("Cantidad al momento: " + Cantidad_acumulada);


                }

                if(Cantidad_acumulada >100 && Cantidad_acumulada < 200)
                {
                    Base = 2;
                    
                    Console.WriteLine("Hola "+ Nombre);
                    Console.WriteLine("La base vale 2$ pero se te paga el 10% del total");
                    Console.WriteLine("El total producido fue: " + Cantidad_acumulada);
                    Calculo_Salario = Base * Cantidad_acumulada;
                    Bonificacion = Calculo_Salario * 0.10;
                    Console.WriteLine("Tu salario es: " + Calculo_Salario+ "$");
                    Salario_Total = Calculo_Salario + Bonificacion;
                    Console.WriteLine("Más el 10% es igual a: "+ Salario_Total+ "$");
                 




                }
                else if (Cantidad_acumulada > 200 && Cantidad_acumulada < 300)
                {
                Base = 2.5;

                    Console.WriteLine("Hola " + Nombre);             
                    Console.WriteLine("La base vale 2.5  y  se te paga el 12%");
                    Console.WriteLine("El total producido fue: " + Cantidad_acumulada);
                    Calculo_Salario = Base * Cantidad_acumulada;
                    Bonificacion = Calculo_Salario * 0.12;
                    Console.WriteLine("Tu salario es: " + Calculo_Salario + "$");
                    Salario_Total = Calculo_Salario + Bonificacion;
                    Console.WriteLine("Más el 12% es igual a: " + Salario_Total + "$");


                }
                else if (Cantidad_acumulada >=300 && Cantidad_acumulada < 400)
                {

                    Base = 3;

                    Console.WriteLine("Hola " + Nombre);
                    Console.WriteLine("La base vale 3 y se te paga el 14%");                    
                    Console.WriteLine("El total producido fue: " + Cantidad_acumulada);
                    Calculo_Salario = Base * Cantidad_acumulada;
                    Bonificacion = Calculo_Salario * 0.14;
                    Console.WriteLine("Tu salario es: " + Calculo_Salario + "$");
                    Salario_Total = Calculo_Salario + Bonificacion;
                    Console.WriteLine("Más el 14% es igual a: " + Salario_Total + "$");

                }
                else if (Cantidad_acumulada >400)
                {
                    Base = 3.5;

                    Console.WriteLine("Hola " + Nombre);                
                    Console.WriteLine("La base vale 4 y se te paga el 16%");
                    Console.WriteLine("El total producido fue: " + Cantidad_acumulada);
                    Calculo_Salario = Base * Cantidad_acumulada;
                    Bonificacion = Calculo_Salario * 0.16;
                    Console.WriteLine("Tu salario es: " + Calculo_Salario + "$");
                    Salario_Total = Calculo_Salario + Bonificacion;
                    Console.WriteLine("Más el 16% es igual a: " + Salario_Total + "$");


                }
                else if (Cantidad_acumulada < 100 && Cantidad_acumulada > 0)
                {
                    Base = 2;
                    Console.WriteLine("Hola " + Nombre);
                    Console.WriteLine("No tienes ningúna bonificación :C ");
                    Console.WriteLine("El total producido fue: " + Cantidad_acumulada);
                    Calculo_Salario = Base * Cantidad_acumulada;                
                    Console.WriteLine("Tu salario es: " + Calculo_Salario + "$");
                }






                Console.WriteLine("¿Desea Repetir la operación? digita si o no");
                Entrada = Console.ReadLine();

            }  while(Entrada == "si");
        }







    }
}
