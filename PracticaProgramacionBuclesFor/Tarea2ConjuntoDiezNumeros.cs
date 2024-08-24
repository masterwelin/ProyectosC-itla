using System;

namespace PracticaProgramacionBuclesFor
{
    /// <summary>
    /// 2) Crear un programa que cuente cuántos números, de un conjunto de 10, son 
    /// divisibles por 3 o por 5.
    /// </summary>
    internal class Tarea2ConjuntoDiezNumeros
    {
        public void Calcular()
        {

            int numero = 0;
            int numerosDivisiblesPor3 = 0;
            int numerosDivisiblesPor5 = 0;

            Console.WriteLine("Digite 10 numeros para validar cuales son divisilbes por 3 y por 5");

            try
            {
                for (int i = 1; i < 11; i++)
                {

                    Console.WriteLine($"Digite numero {i}:");

                    numero = Convert.ToInt32(Console.ReadLine());

                    if ((numero % 3) == 0)
                    {
                        ++numerosDivisiblesPor3;
                    }

                    if ((numero % 5) == 0)
                    {
                        ++numerosDivisiblesPor5;
                    }

                }

                Console.WriteLine($"La cantidad de numeros divisibles por 3 es: {numerosDivisiblesPor3} y la cantidad de numeros divisibles por 5 es: {numerosDivisiblesPor5}");

                Console.ReadLine();
            }

            catch (Exception ex)
            {
                Console.WriteLine($"ocurrio el siguiente error{ex.Message}");
            }

        }
    }
}
