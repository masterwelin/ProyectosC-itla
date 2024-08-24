using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PracticaProgramaciónBuclesWhile
{
    /// <summary>
    ///  1) Confeccionar un programa que, 
    ///  a partir de una secuencia de 10 números enteros, 
    ///  calcule y muestre la suma y el promedio aritmético de dichos números.
    /// </summary>
    internal class Tarea1SumaPromedioDiezNumeros
    {
        public void Calcular()
        {

            decimal suma = 0;
            decimal promedio = 0;
            int index = 1;

            Console.WriteLine("Digite 10 numeros para realizar su suma y promedio: ");

            //cantidad = Convert.ToInt32(Console.ReadLine());

            try
            {
                while (index <= 10)
                {
                    Console.WriteLine($"Digite el numero {index}: ");

                    suma += Convert.ToInt32(Console.ReadLine());

                    ++index;
                }

                promedio = Math.Round((suma / Convert.ToDecimal(index)), 2);

                Console.WriteLine($"La suma de las cantidades digitadas es: {suma} y el promedio es: {promedio}");

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ocurrio el siguiente error{ex.Message}");
            }

        }
    }
}
