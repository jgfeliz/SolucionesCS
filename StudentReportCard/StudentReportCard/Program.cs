using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentReportCard
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Incerte la cantidad de estudiantes: ");
            int cantidadEstudiantes = int.Parse(Console.ReadLine());

            string[,] array_notas = new string[cantidadEstudiantes,5];

            for (int i = 0; i < cantidadEstudiantes; i++)
            {
                Console.Write("Introduzca el nombre del estudiante: ");
                array_notas[i,0] = Console.ReadLine();
                Console.Write("Ingrese la nota de ingles: ");
                array_notas[i,1] = Console.ReadLine();
                Console.Write("Ingrese la nota de matematicas: ");
                array_notas[i,2] = Console.ReadLine();
                Console.Write("Ingrese la nota de computacion: ");
                array_notas[i,3] = Console.ReadLine();
                Console.WriteLine("*******************************");
                int nota = int.Parse(array_notas[i, 1]) + int.Parse(array_notas[i, 2]) + int.Parse(array_notas[i, 3]);
                array_notas[i, 4] = Convert.ToString(nota);
                
            }
            Console.WriteLine("");
            Console.WriteLine("****************Report Card********************");
                       
            //ordenando array
            for (int j =0; j < cantidadEstudiantes; j++)
            {
                for (int k=0;k<cantidadEstudiantes - 1; k++)
                {
                    if (int.Parse(array_notas[k, 4]) > int.Parse(array_notas[(k+1), 4]))
                    {
                        int guardarNumero = 0;
                        guardarNumero = int.Parse(array_notas[k, 4]);
                        int numero = int.Parse((array_notas[(k+1), 4]));
                        array_notas[k, 4] = Convert.ToString(numero);
                        array_notas[(k + 1), 4] = Convert.ToString(guardarNumero);
                    }
                }
            }
            //Console.WriteLine(array_notas.Length);
            //Console.WriteLine(array_notas);
            //Console.ReadKey();

            //Aquí hacemos un bucle que corre el arreglo                                     
            for (int l=0; l<cantidadEstudiantes; l++)
            {
                Console.WriteLine(array_notas[l, 4]);
               
                Console.WriteLine("Nombre del estudiante: " + array_notas[l, 0] + ", Posicion: " + (l+1) + " Con un promedio de: " + array_notas[l,4] + "/300");
                
            }
                
            Console.ReadKey();
        }
    }
}
