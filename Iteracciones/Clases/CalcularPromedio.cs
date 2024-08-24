
namespace Iteracciones.Clases
{
    public class CalcularPromedio
    {

        public void Calcular() {

            decimal suma = 0;
            decimal promedio = 0;
            decimal cantidad = 0;
            decimal valor = 0;

            Console.WriteLine("Digite la cantidad que desea calcular: ");

            try
            {
                cantidad = Convert.ToDecimal(Console.ReadLine());

                for (int i = 1; i <= cantidad; i++)
                {
                    Console.WriteLine("Digite el valor a calcular: ");
                    valor = Convert.ToDecimal(Console.ReadLine());

                    suma = suma + valor;
                }

                promedio = (suma / cantidad);

                Console.WriteLine($"La suma es: {suma} y el promedio es: {promedio}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ocurrio el siguiente error{ex.Message}");
            }

        }

        public void CalcularNotas() {

            int aprobado = 0;
            int reprobado = 0;
            int cantidad = 0;
            int calificacion = 0;

            try
            {
                for (int i = 1; i <= cantidad; i++)
                {
                    Console.WriteLine($"Ingrese la calificacion {i}");
                    calificacion = Convert.ToInt32(Console.ReadLine());
                    if (calificacion >= 7)
                    {
                        aprobado = aprobado + 1;
                    }
                    else
                    {
                        reprobado = reprobado + 1;
                    }

                }

                Console.WriteLine($"Aprobados: {aprobado} y reprobados {reprobado}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ocurrio el siguiente error{ex.Message}");
            }

        }

        public void CalcularPromedioWhile() {

            decimal suma = 0;
            decimal promedio = 0;
            decimal cantidad = 0;
            decimal valor = 0;
            int index = 1;


            Console.WriteLine("Digite la cantidad que desea calcular:");

            try
            {
                cantidad = Convert.ToInt32(Console.ReadLine());

                while (index <= cantidad)
                {
                    Console.WriteLine("");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ocurrio el siguiente error{ex.Message}");
            }

        }

        public void CalcularPerfiles() {

            double longitud = 0;
            int piezasAptas = 0;
            int cantidad = 0;
            double minimo = 1.20;
            double maximo = 1.30;
            int index = 1;
            string valoresAptos = "";
            
            Console.WriteLine("Digite la cantidad que piezas que desea procesar: ");

            try
            {
                cantidad = Convert.ToInt32(Console.ReadLine());

                while (index <= cantidad)
                {
                    Console.WriteLine($"Digite el perfil de longitud de la pieza {index}: ");
                    longitud = Convert.ToDouble(Console.ReadLine());

                    if (longitud >= minimo && longitud <= maximo)
                    {
                        ++piezasAptas;

                        if (index == 1)
                        {
                            valoresAptos += $"pieza({index}): " + Convert.ToString(longitud);
                        }
                        else
                        {
                            valoresAptos += $", pieza({index}) " + Convert.ToString(longitud);
                        }
                    }

                    ++index;

                }

                Console.WriteLine($"La cantidad de piezas evaluadas es: {cantidad} y la cantidad de piezas aptas es: {piezasAptas} y los valores aptos son: {valoresAptos}");

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ocurrio el siguiente error{ex.Message}");
            }

        }

    }
}
