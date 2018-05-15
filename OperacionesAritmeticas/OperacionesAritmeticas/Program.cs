using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesAritmeticas
{
    class Program
    {
        static void Main(string[] args)
        {
            bool yon = true;
            do
            {
                bool mas = true;
                int operacion = 0;

                while (mas)
                {
                    Console.WriteLine("Que operacion desea realizar?: \n1- Suma\n2- Resta\n3- Multiplicacion\n4- Division");//nos pregunta que operacion deseamos realizar
                    operacion = int.Parse(Console.ReadLine());//la consola se queda en espera de una respuesta

                    if (operacion >= 5)
                    {
                        Console.WriteLine("La solicitud es incorrecta");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        mas = false;
                    }

                }

                Console.Write("Introduzca el valor 1: ");//la consola nos pregunta por el valor 1
                int valor1 = int.Parse(Console.ReadLine());//la cantidad tipiada se almacena en la variable valor1
                Console.Write("Introduzca el valor 2: ");//la consola nos pregunta por el valor 2
                int valor2 = int.Parse(Console.ReadLine());//la cantidad tipiada se almacena en la variable valor2            
                int r;

                switch (operacion)
                {

                    case 1:
                        {
                            r = Suma(valor1, valor2);
                            Console.WriteLine("El resultado de la Suma de: " + valor1 + " + " + valor2 + " es " + r);
                            break;
                        }

                    case 2:
                        {
                            r = Resta(valor1, valor2);
                            Console.WriteLine("La diferencia de la Resta de: " + valor1 + " - " + valor2 + " es " + r);
                            break;
                        }

                    case 3:
                        {
                            r = Multiplicacion(valor1, valor2);
                            Console.WriteLine("El Producto de la Multiplicacion de: " + valor1 + " x " + valor2 + " es " + r);
                            break;
                        }

                    case 4:
                        {
                            r = Division(valor1, valor2);
                            Console.WriteLine("El Cociente de la Division de: " + valor1 + " / " + valor2 + " es " + r);
                            break;
                        }

                }
                Console.Write("Desea realizar una nueva operacion(Y/N)?");
                char siono;                
                siono = char.Parse(Console.ReadLine());
                if (siono == 'n')
                {
                    yon = false;
                }                
                Console.Clear();

            } while (yon == true);
            
        }
                
        static int Suma(int SumandoA, int SumandoB)
        {
            int ResultadoSuma = SumandoA + SumandoB;
            return ResultadoSuma;
        }

        static int Resta(int Minuendo, int Sustraendo)
        {
            int ResultadoResta = Minuendo - Sustraendo;
            return ResultadoResta;
        }

        static int Multiplicacion(int FactorA, int FactorB)
        {
            int Producto = FactorA * FactorB;
            return Producto;
        }

        static int Division(int Dividendo, int Divisor)
        {
            int Cociente = Dividendo / Divisor;
            return Cociente;
        }

    }
}
