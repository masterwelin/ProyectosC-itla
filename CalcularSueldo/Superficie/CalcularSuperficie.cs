
namespace CalcularSueldo.Superficie
{

    /// <summary>
    /// 
    /// </summary>
    public class CalcularSuperficie
    {
        /// <summary>
        /// Calcular lado
        /// </summary>
        public void Calcular() 
        {
            // Declarar Variables //
            int lado = 0;
            int superficie = 0;
            string linea = string.Empty;

            try
            {
                //Pedir por teclado//
                Console.WriteLine("Ingrese el lado: ");
                linea = Console.ReadLine();

                if (string.IsNullOrEmpty(linea))
                {
                    Console.WriteLine("El lado es requerido invalido");
                    return;
                }

                if (!int.TryParse(linea, out lado))
                {
                    Console.WriteLine("El valor del lado es invalido.");
                    return;
                }

                //Calcular superficie//
                superficie = (lado * lado);

                Console.WriteLine($"La superficie es: {superficie}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ocurrio el siguiente error: {ex.Message}");
              
            }

           
        }   

            
    }
}
