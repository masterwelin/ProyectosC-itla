namespace PracticaArreglos.Practicas
{
    /// <summary>
    /// Escribe un programa que cree una matriz de 20 elementos de tipo entero e inicialice cada uno de los elementos 
    /// con un valor igual al índice del elemento multiplicado por 5. Imprime los elementos en la consola.
    /// </summary>
    internal class ProgramaArray1
    {
        /// <summary>
        /// funcion que ejecuta el ejercicio
        /// </summary>
        public void Calcular() 
        {
            try
            {
                int[] arreglo = new int[20];

                Console.WriteLine("Crear arreglo de 20 elementos, inicializarlos con valor igual a su indice y mostrar sus datos \n");

                for (int i = 0; i < arreglo.Length; i++)
                {
                    arreglo[i] = i * 5;
                }

                for (int i = 0; i < arreglo.Length; i++)
                {
                    Console.WriteLine($"El valor del indice {i} del arreglo tiene el valor {arreglo[i]}");
                }

                Console.ReadLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine($"el programa se ha detenido por el siguiente error: {ex.Message}");

            }
        
           

        }
    }
}
