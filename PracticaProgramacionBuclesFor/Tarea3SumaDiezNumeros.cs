namespace PracticaProgramacionBuclesFor
{
    /// <summary>
    /// 3) Desarrollar un programa que permita ingresar 10 números y luego 
    /// muestre la suma de los últimos 5 números ingresados.
    /// </summary>
    internal class Tarea3SumaDiezNumeros
    {
        public void Calcular()
        {

            int numero = 0;
            int sumaUltimos5Numeros = 0;

            Console.WriteLine("Digite 10 numeros");

            try
            {
                for (int i = 1; i < 11; i++)
                {

                    Console.WriteLine($"Digite numero {i}:");

                    numero = Convert.ToInt32(Console.ReadLine());

                    if (i >= 5)
                    {
                        sumaUltimos5Numeros += numero;
                    }

                }

                Console.WriteLine($"La suma de los ultimos 5 numeros introducidos es: {sumaUltimos5Numeros}");

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ocurrio el siguiente error{ex.Message}");
            }

        }
    }
}
