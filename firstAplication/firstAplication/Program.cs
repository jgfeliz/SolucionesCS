﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace firstAplication

{
    class Program
    {
        class persona
        {
            public string name;
            public int age;

            public void Display()//metodo de la clase persona
            {
              Console.WriteLine("El nombre de la persona es: {0} y su edad es: {1}",  name, age);
            }
        }
        
        static void Main(string[] args)
        {
           
            Console.WriteLine("Hola Rasec, estoy programando en C#...\n");
            int resul = suma(15);
            Console.WriteLine(resul);            
            Console.WriteLine("Preciona una tecla para salir....");

            int test = Sum(1, 2, 3, 4, 5, 6, 7, 5, 4, 5, 6, 7, 8, 9, 3, 2, 3, 4, 5, 34, 23, 2, 3, 45, 5, 6, 3, 546, 3456, 5);
            Console.WriteLine("en esta operacion se suman " + test + " Sumandos y el total de la suma es: " + add);

            persona jose = new persona();
            jose.age = 34;
            jose.name = "jose";
            jose.Display();
                        
            Console.ReadKey(); //este metodo se usa para que la ventana de la consola no se cierre automaticamente..
        }

        static int add;

        public static int Sum(params int[] args2)
        {
            add = 0;
            int sumandos = 0;
            foreach (int item in args2)
            {
                add = add + item;
                sumandos = sumandos + 1;
            }

            return sumandos;            
        }

        static int suma(int a, int b=1)
        {
            int resultado = a + b;
            return resultado;
        }
    }
}