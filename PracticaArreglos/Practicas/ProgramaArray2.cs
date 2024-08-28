using System.Runtime.CompilerServices;

namespace PracticaArreglos.Practicas
{
    /// <summary>
    /// Escriba un programa que lea dos matrices desde la consola y verifique si son iguales 
    /// (dos matrices son iguales cuando tienen la misma longitud 
    /// y todos sus elementos, que tienen el mismo índice, son iguales).
    /// </summary>
    internal class ProgramaArray2
    {
        /// <summary>
        /// crear dos matrices
        /// leer dos matrices
        /// comparar matrices y verificar si son iguales
        /// </summary>
        public void Calcular() 
        {

            string linea = string.Empty;
            int numero = 0;

            Console.WriteLine("Cree dos matrices y el programa verificara si son identicas o no \n");

            try
            {
                Console.WriteLine("Ingrese la cantidad de elementos que tendra la matriz 1:");
                
                linea = Console.ReadLine();

                if (!int.TryParse(linea, out numero))
                {
                    Console.WriteLine("El numero introducido es invalido.");
                    return;
                }

                int[] matriz1 = new int[numero];

                Console.WriteLine("Ingrese la cantidad de elementos que tendra la matriz 2:");

                linea = Console.ReadLine();

                if (!int.TryParse(linea, out numero))
                {
                    Console.WriteLine("El numero introducido es invalido.");
                    return;
                }

                int[] matriz2 = new int[numero];

                if (matriz1.Length != matriz2.Length)
                {
                    Console.WriteLine("Las matrices no son identicas! no tienen la misma cantidad de elementos");

                    return;
                }

                Console.WriteLine("ingrese los elementos de la Matriz 1: \n");

                for (int i = 0; i < matriz1.Length; i++)
                {
                    Console.WriteLine($"ingrese el elemento del índice {i} de la matriz 1:");

                    linea = Console.ReadLine();

                    if (!int.TryParse(linea, out numero))
                    {
                        Console.WriteLine("El numero introducido es invalido.");
                        return;
                    }

                    matriz1[i] = numero;
                    
                }

                Console.WriteLine("ingrese los elementos de la Matriz 2:\n");

                for (int i = 0; i < matriz2.Length; i++)
                {
                    Console.WriteLine($"ingrese el elemento del índice {i} de la matriz 2:");

                    linea = Console.ReadLine();

                    if (!int.TryParse(linea, out numero))
                    {
                        Console.WriteLine("El numero introducido es invalido.");
                        return;
                    }

                    matriz2[i] = numero;

                }

                //comparativa elemento por elemento

                for (int i = 0; i < matriz1.Length; i++)
                {
                    if (matriz1[i] != matriz2[i])
                    {
                        Console.WriteLine($"Las matrices no son identicas! los elementos del indice { i } no son iguales!");
                        return;
                    }
                }

                Console.WriteLine("las matrices son identicas!");

                Console.WriteLine("");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"ha ocurrido el siguiente error: {ex.Message}");

            }



        }
    }
}
