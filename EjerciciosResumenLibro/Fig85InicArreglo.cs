﻿
namespace EjerciciosResumenLibro
{
    internal class Fig85InicArreglo
    {
        // Fig. 8.5: SumaArreglo.cs
        // Cálculo de la suma de los elementos de un arreglo.

        public static void Calcular()
        {
            int[] arreglo = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };
            int total = 0;

            // sumar el valor de cada elemento al total
            for (int contador = 0; contador < arreglo.Length; contador++)
                total += arreglo[contador];

            Console.WriteLine("Total de los elementos del arreglo: {0}", total);
        } // fin
    } // fin de la clase Fig85InicArreglo

}
