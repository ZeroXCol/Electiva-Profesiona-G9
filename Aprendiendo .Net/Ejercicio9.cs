using System;
using System.Collections.Generic;
using System.Text;

namespace Aprendiendo_.Net
{
    class Ejercicio9
    {
        public void Sistema_calificaciones()
        {

            int Fila, Columna;
            double NotasAlumno = 0, NotasMateria = 0, PromedioAlumno = 0, PromedioMateria = 0;
            double[,] Matriz;

            Console.WriteLine("Universidad ECCI");
            Console.WriteLine("Sistema de calificaciones");
            Console.WriteLine("Porfavor digite la cantidad de materias a validar");
            Fila = int.Parse(Console.ReadLine());
            Console.WriteLine("Porfavor digite la cantidad de Alumnos a validar");
            Columna = int.Parse(Console.ReadLine());

            Matriz = new double[Fila, Columna];
            int j = 0, k = 0;
            for (j = 0; j < Fila; j++)
            {
                for (k = 0; k < Columna; k++)
                {
                    Console.WriteLine("Porfavor digite la nota del alumno: [" + k + "]." + " Para la materia: [" + j + "]");
                    Matriz[j, k] = double.Parse(Console.ReadLine());
                    NotasMateria = NotasMateria + Matriz[j, k];
                }
                PromedioMateria = NotasMateria / Columna;
                Console.WriteLine("");
                Console.WriteLine("El promedio de notas de la materia [" + j + "], es igual a = " + PromedioMateria);
                PromedioMateria = 0;
                NotasMateria = 0;
                Console.WriteLine("");
            }


            for (j = 0; j < Columna; j++)
            {
                for (k = 0; k < Fila; k++)
                {
                    NotasAlumno = NotasAlumno + Matriz[k, j];
                }
                PromedioAlumno = NotasAlumno / Fila;
                Console.WriteLine("El promedio de notas del alumno [" + k + "], es igual a = " + PromedioAlumno);
                PromedioAlumno = 0;
                NotasAlumno = 0;
            }
            Console.ReadLine();


        }

    }
}
