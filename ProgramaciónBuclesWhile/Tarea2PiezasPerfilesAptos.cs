namespace PracticaProgramaciónBuclesWhile
{
    /// <summary>
    /// 2) Crear un programa que cuente cuántas piezas de hierro 
    /// de un lote, dentro de un rango específico de longitud, 
    /// son aptas para fabricar perfiles.
    /// </summary>
    internal class Tarea2PiezasPerfilesAptos
    {
        public void CalcularPerfiles()
        {

            double longitud = 0;
            int piezasAptas = 0;
            int cantidad = 0;
            double minimo = 1.20;
            double maximo = 1.30;
            int index = 1;
            string valoresAptos = "";




            Console.WriteLine("Digite la cantidad que piezas que desea procesar: ");

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
    }
}
