

namespace ClaseProgramacionCondicional
{
    /// <summary>
    /// 2) Leer tres calificaciones y calcular el promedio. Si el promedio es igual o superior a siete, 
    /// imprimir un mensaje indicando que el alumno ha aprobado.
    /// </summary>
    internal class Ejercicio2LeerTresCalificaciones
    {
        /// <summary>
        /// 
        /// </summary>
        public void Calcular()
        {
            //declarar las variables
            decimal cal1 = 0;
            decimal cal2 = 0;
            decimal cal3 = 0;
            decimal promedio = 0;

            string linea = string.Empty;


            try
            {
                //Pedir las calificaciones//
                Console.WriteLine("Ingrese la calificación 1:");
                linea = Console.ReadLine();

                if (!decimal.TryParse(linea, out cal1))
                {
                    Console.WriteLine("La calificación 1 es invalida.");
                    return;
                }

                Console.WriteLine("Ingrese la calificación 2:");
                linea = Console.ReadLine();

                if (!decimal.TryParse(linea, out cal2))
                {
                    Console.WriteLine("La calificación 2 es invalida.");
                    return;
                }

                Console.WriteLine("Ingrese la calificación 3:");
                linea = Console.ReadLine();

                if (!decimal.TryParse(linea, out cal3))
                {
                    Console.WriteLine("La calificación 3 es invalida.");
                    return;
                }

                promedio = Math.Round((cal1 + cal2 + cal3)/3,2);

                if (promedio >= 7)
                {
                    Console.WriteLine($"El estudiante aprobó con una calificacion promedio de: {promedio} :)");
                }
                else {
                    Console.WriteLine($"El estudiante reprobó con una calificacion promedio de: {promedio} :(");
                }

                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"ocurrio el siguiente error {ex.Message}");
            }

        }

    }
}
