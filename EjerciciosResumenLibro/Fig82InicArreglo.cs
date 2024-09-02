namespace EjerciciosResumenLibro
{
    internal class InicArreglo
    { 
            public static void Calcular()
            {
                int[] arreglo; //declara un arreglo llamado arreglo

                //crea el espacio para el arreglo y lo inicializa con ceros predeterminadamente
                arreglo = new int[10]; // 10 elementos int

                Console.WriteLine("{0}{1,8}", "Indice", "Valor"); //encabezados

                //imprime en pantalla el valor de cada elemento del arreglo
                for (int contador = 0; contador < arreglo.Length; contador++)
                {
                    Console.WriteLine("{0,5}{1,8}", contador, arreglo[contador]);
                }//fin del main
            }//fin de la clase InicArreglo

        }
}
