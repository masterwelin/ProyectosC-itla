

namespace CalcularSueldo.Producto
{
    /// <summary>
    /// Calcular el producto y la suma de dos numeros
    /// </summary>
    public class CalcularProducto
    {
        /// <summary>
        /// Mostar la suma y el producto a partir de dos numeros
        /// </summary>

        public void Calcular() 
        {
            //declarar las variables
            int num1 = 0;
            int num2 = 0;
            int producto = 0;
            int suma = 0;

            string linea = string.Empty;

            
            try
            {
                //Pedir los numeros por tablado//
                Console.WriteLine("Ingrese el valor de num 1:");
                linea = Console.ReadLine();

                if (!int.TryParse(linea, out num1))
                {
                    Console.WriteLine("El num 1 es invalido.");
                    return;
                }

                Console.WriteLine("Ingrese el valor del num 2:");
                linea = Console.ReadLine();

                if (!int.TryParse(linea, out num2))
                {
                    Console.WriteLine("El num 1 es invalido.");
                    return;
                }

                suma = (num1 + num2);
                producto = (num1 * num2);

                Console.WriteLine($"La suma es: {suma} y el producto es: {producto}");

            }
            catch (Exception ex) 
            {
                Console.WriteLine($"ocurrio el siguiente error{ex.Message}");
            }

        }

    }
}
