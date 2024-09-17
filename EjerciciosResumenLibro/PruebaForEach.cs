
namespace EjerciciosResumenLibro
{
    // Fig. 8.12: PruebaForEach.cs
    // Uso de la instrucción foreach para totalizar los enteros en un arreglo.

    public class PruebaForEach
    {
        public static void EjecutarPrueba()
        {
            int[] arreglo = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };
            int total = 0;

            // suma el valor de cada elemento a total
            foreach (int numero in arreglo)
                total += numero;

            Console.WriteLine("Total de elementos en el arreglo: {0}", total);
        } // fin de Main
    } // fin de la clase PruebaForEach
}
