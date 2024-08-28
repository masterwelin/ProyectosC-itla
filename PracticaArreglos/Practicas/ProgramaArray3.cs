using System.Drawing;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PracticaArreglos.Practicas
{
    /// <summary>
    /// Crear un programa que solicite al usuario "N" números, almacenarlos en una estructura de datos lineal y determinar lo siguiente:
    ///El menor valor.
    ///Indicar si algún valor se repite al menos una vez.
    ///Nota: se debe subir un informe con la ejecución del programa.
    /// </summary>
    internal class ProgramaArray3
    {
        public void Calcular() 
        {

            try
            {
                int cantidadNumeros = 0;
                string linea = string.Empty;
                int numeroIntroducido = 0;
                int numeroMenor = 0;
                int numero = 0;
                int numerosRepetidos = 0;

                Console.WriteLine("Ingrese la cantidad de elementos que desea comparar:");

                linea = Console.ReadLine();

                if (!int.TryParse(linea, out cantidadNumeros))
                {
                    Console.WriteLine("El numero introducido es invalido.");
                    return;
                }

                int[] arrayNumeros = new int[cantidadNumeros];

                for (int i = 0; i < arrayNumeros.Length; i++)
                {
                    Console.WriteLine($"Introduzca el numero {i + 1}");
                    linea = Console.ReadLine();

                    if (!int.TryParse(linea, out numeroIntroducido))
                    {
                        Console.WriteLine("El numero introducido es invalido.");
                        return;
                    }

                    arrayNumeros[i] = numeroIntroducido;
                }

                //verificar numero con menor valor
                for (int i = 0; i < arrayNumeros.Length; i++)
                {

                    if (i == 0)
                    {
                        numeroMenor = arrayNumeros[i];
                    }
                    else 
                    {

                        if (arrayNumeros[i] < numeroMenor)
                        {
                            numeroMenor = arrayNumeros[i];
                        }

                    }
                    
                }

                //verificar si un numero esta repetido

                for (int i = 0; i < arrayNumeros.Length; i++)
                {

                    numero = arrayNumeros[i];

                    for (int ii = 0; ii < arrayNumeros.Length; ii++)
                    {
                        if (numero == arrayNumeros[ii] && ii != i)
                        {
                            ++numerosRepetidos; //al encontrar que el numero se repite incremento el contador y salgo de la iteraccion para no comparar mas el mismo numero
                            break;
                        }
                    }

                }

                Console.WriteLine($"La estructura de datos creada tiene { arrayNumeros.Length } elementos donde el valor mínimo es: {numeroMenor } y existen {numerosRepetidos} números repetidos");
                Console.ReadLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Ha ocurrido el siguiente error: {ex.Message}.");
            }

        }
    }
}
