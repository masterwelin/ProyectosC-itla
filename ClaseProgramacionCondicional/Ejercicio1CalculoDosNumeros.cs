

namespace ClaseProgramacionCondicional
{
    /// <summary>
    /// 
    /// </summary>
    internal class Ejercicio1CalculoDosNumeros
    {
        /// <summary>
        ///  1) Diseñar un programa que solicite al usuario dos números y, si el primer número es más grande, 
        ///  calcule y muestre su suma y resta. 
        ///  De lo contrario, calculará y mostrará su producto y cociente.
        /// </summary>
        
        public void Calcular()
        {
            //declarar las variables
            decimal num1 = 0;
            decimal num2 = 0;
            decimal resta = 0;
            decimal suma = 0;
            decimal producto = 0;
            decimal cociente = 0;

            string linea = string.Empty;


            try
            {
                //Pedir los numeros//
                Console.WriteLine("Ingrese Num1:");
                linea = Console.ReadLine();

                if (!decimal.TryParse(linea, out num1))
                {
                    Console.WriteLine("El número ingresado es invalido.");
                    return;
                }

                Console.WriteLine("Ingrese Num2:");
                linea = Console.ReadLine();

                if (!decimal.TryParse(linea, out num2))
                {
                    Console.WriteLine("El número ingresado es invalido.");
                    return;
                }

                if (num1 > num2)
                {
                    suma = num1 + num2;
                    resta = num1 - num2;
                    Console.WriteLine($"La sumatoria de los numeros ingresados es {suma} y la resta es {resta}");
                    Console.ReadLine();
                }
                else {
                    producto = num1 * num2;
                    cociente = num1 / num2;
                    Console.WriteLine($"El producto de los numeros ingresados es {producto} y el cociente es {cociente}");
                    Console.ReadLine();

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"ocurrio el siguiente error {ex.Message}");
            }

        }
    }
}
