
namespace ProgramacionSecuencialTarea1.Tarea1
{
    /// <summary>
    /// 
    /// </summary>
    internal class T1SumaPromedioCuatroValores
    {
        /// <summary>
        /// Realizar un programa que lea cuatro valores numéricos e informar su suma y promedio.
        /// </summary>

        public void Calcular()
        {
            //declarar las variables
            decimal num1 = 0;
            decimal num2 = 0;
            decimal num3 = 0;
            decimal num4 = 0;
            decimal suma = 0;
            decimal promedio = 0;

            string linea = string.Empty;


            try
            {
                //Pedir los número por telado//
                Console.WriteLine("Ingrese el valor de número 1:");
                linea = Console.ReadLine();

                if (!decimal.TryParse(linea, out num1))
                {
                    Console.WriteLine("El num 1 es invalido.");
                    return;
                }

                Console.WriteLine("Ingrese el valor del número 2:");
                linea = Console.ReadLine();

                if (!decimal.TryParse(linea, out num2))
                {
                    Console.WriteLine("El num 2 es invalido.");
                    return;
                }

                Console.WriteLine("Ingrese el valor del número 3:");
                linea = Console.ReadLine();

                if (!decimal.TryParse(linea, out num3))
                {
                    Console.WriteLine("El num 3 es invalido.");
                    return;
                }

                Console.WriteLine("Ingrese el valor del número 4:");
                linea = Console.ReadLine();

                if (!decimal.TryParse(linea, out num4))
                {
                    Console.WriteLine("El num 4 es invalido.");
                    return;
                }

                suma = (num1 + num2 + num3 + num4);
                promedio = (suma/4);

                Console.WriteLine($"La suma es: {suma} y el promedio es: {promedio}");

                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"ocurrio el siguiente error{ex.Message}");
            }

        }
    }
}
