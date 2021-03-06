﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraConsola
{
    class Program
    {
        /// <summary>
        /// Metódo principal modificado por Oscar Delgado 
        /// </summary>
        static void Main(string[] args)
        {
            Console.Title = "Calculadora";

            bool continuar = true;

            while (continuar)
            {
                Console.Clear();

                Console.WriteLine("Seleccione una operación: ");

                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Division");


                string opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    Sumar();
                }

                if (opcion == "2")
                {
                    Restar();
                }

                if (opcion == "3")
                {
                    Multiplicar();
                }

                if (opcion == "4")
                {
                    Division();
                }

                Console.WriteLine("\nSeleccione una opción: ");
                Console.WriteLine("1. Volver al menú principal");
                Console.WriteLine("2. Salir");

                opcion = Console.ReadLine();

                if (opcion != "1")
                {
                    continuar = false;
                }

            }
        }

       

        static void Multiplicar() /*este metodo multiplica*/
        {
            Console.Clear();

            Console.WriteLine("MULTIPLICAR");
            Console.WriteLine("");

            Console.WriteLine("Ingrese el primer valor: ");
            int valor1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo valor: ");
            int valor2 = Int32.Parse(Console.ReadLine());

            int resultado = valor1 * valor2;

            Console.WriteLine("El resultado es: " + resultado);
        }

        /// <summary>
        /// Método para sumar
        /// </summary>
        static void Sumar()
        {
            Console.Clear();

            Console.WriteLine("SUMA");
            Console.WriteLine("");

            Console.WriteLine("Ingrese el primer valor: ");
            int valor1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo valor: ");
            int valor2 = Int32.Parse(Console.ReadLine());

            int resultado = valor1 + valor2;

            Console.WriteLine("El resultado es: " + resultado);
        }

        /// <summary>
        /// Método para restar
        /// </summary>
        static void Restar()
        {
            Console.Clear();

            Console.WriteLine("RESTA");
            Console.WriteLine("");

            Console.WriteLine("Ingrese el primer valor: ");
            int valor1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo valor: ");
            int valor2 = Int32.Parse(Console.ReadLine());

            int resultado = valor1 - valor2;

            Console.WriteLine("El resultado es: " + resultado);
        }

        

        static void Division()
        {
            Console.Clear();

            Console.WriteLine("DIVISION");
            Console.WriteLine("");

            Console.WriteLine("Ingrese el primer valor");
            double valor1 = Double.Parse(Console.ReadLine()); // Hola Abel

            Console.WriteLine("Ingrese el segundo valor");
            double valor2 = double.Parse(Console.ReadLine());

            double resultado = valor1 / valor2;

            Console.WriteLine("El resultado es:" + resultado);

        }
        //HOLAGENTE


    }
}
