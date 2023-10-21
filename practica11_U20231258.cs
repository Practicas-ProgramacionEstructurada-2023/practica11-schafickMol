using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {

            int opcion;

            do
            {
                Console.WriteLine("\n\nMenú de opciones: ");
                Console.WriteLine("1. Ingresar numeros");
                Console.WriteLine("2. calcular suma de numeros");
                Console.WriteLine("3. buscar numeros");
                Console.WriteLine("4. ordenar numeros");
                Console.WriteLine("5. Salir ");
                Console.Write("Seleccione una opcion (1-5): ");
                opcion = Convert.ToInt32(Console.ReadLine());

            

            switch (opcion)
            {
                case 1:
                    ingresarNumeros();
                    Console.ReadKey();
                    break;
                
                case 2:
                    int suma = calcularSuma();
                    Console.WriteLine("\nLa suma de los numeros es: " + suma);
                    Console.ReadKey();
                    break;
                
                
                case 3:
                    buscarNumero();
                    Console.ReadKey();
                    break;
                
                case 4:
                    ordenarNumeros();
                    Console.ReadKey();
                    break;
                
                case 5:
                    Console.WriteLine("\n!Hasta luego");
                    break;
                
                default:
                    Console.WriteLine("\nOpcion no valida ingrese un numero correcto");
                    break;
            }
            }while(opcion !=5);

            


        }//fin del main

        static int[] numeros = new int[5];
        
        static int cantidadNumeros = 0;

        static void ingresarNumeros()
        {
            Console.WriteLine("\nIngrese hasta 5 numeros (ingresa -1 para finalizar:)");
            cantidadNumeros = 0;

            while (cantidadNumeros < numeros.Length)
            {
                Console.WriteLine("numero #{0}: ", cantidadNumeros + 1);
                int numero = Convert.ToInt32(Console.ReadLine());

                if( numero == -1)
                    break;
                
                numeros[cantidadNumeros] = numero ;
                cantidadNumeros++;
                

            }
        }//fin ingresar numeros

        static int calcularSuma ()
        {
            int suma = 0;
            for (int i = 0; i < cantidadNumeros; i++)
            {
                suma += numeros[i];
            }
            return suma;
        }//calcular suma

        static void buscarNumero()
        {
            Console.Write("\nIngrese el numero que deseas buscar: ");
            int numeroBuscado = Convert.ToInt32(Console.ReadLine());
            bool encontrado = false;

            for (int i = 0; i < cantidadNumeros; i++)
            {
                if (numeros[i] == numeroBuscado)
                {
                    encontrado = true;
                    break;
                }

            }

            if (encontrado)
                Console.WriteLine("\nEl numero fue encontrado en el arreglo. ");
            else
                Console.WriteLine("\nel numero no fue encontrado en el arreglo");
        }//fin buscar numero

        static void ordenarNumeros()
        {
            Array.Sort(numeros, 0, cantidadNumeros);
            Console.WriteLine("\nNumeros ordenador de manera ascendente");
            for (int i = 0; i < cantidadNumeros; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }// fin

    }
}
        
    
