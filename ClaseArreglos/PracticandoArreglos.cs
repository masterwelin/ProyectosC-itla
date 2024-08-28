namespace ClaseArreglos
{
    internal class PracticandoArreglos
    {
        private static float[] alturas;
        private static float promedio = 0;

        static public void Calcular()
        {
            //int cantidadElemento = 5;

            int[] sueldos = new int[5]; //declaracion e inicializacion del arreglo.

            for (int i = 0; i < sueldos.Length; i++)
            {
                Console.WriteLine($"Ingresar el sueldo: {i}");
                string linea = Console.ReadLine();
                sueldos[i] = Convert.ToInt32(linea);
            }

            for (int i = 0; i < sueldos.Length; i++)
            {
                int sueldo = sueldos[i];
                Console.WriteLine("{0,4}{1,8}", i, sueldos[i]);
            }

        }

        #region "esto es una region segundo ejercicio"


        public void CapturarAlturas()
        {
            alturas = new float[5];
            //float promedio = 0;
            float suma = 0;
            //string linea = "";

            try
            {
                for (int i = 0; i < alturas.Length; i++)
                {
                    Console.WriteLine($"Digite la altura de la persona: {i}");
                    alturas[i] = float.Parse(Console.ReadLine());
                    string linea = Console.ReadLine();

                    if (float.TryParse(linea, out float altura))
                    {
                        alturas[i] = altura;
                        suma += alturas[i];
                    }
                    else
                    {
                        Console.WriteLine("altura introducida es invalida.");
                        return;
                    }

                }

                promedio = (suma / alturas.Length);

                Console.WriteLine($"el promedio de las alturas introducidas es: {promedio}.");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"ha ocurrido el siguietne error {ex.Message}");
            }


        }

        public void CalcularMayorMenor()
        {
            int mayor = 0;
            int menor = 0;

            try
            {
                for (int i = 0; i < alturas.Length; i++)
                {
                    float altura = alturas[i];
                    if (altura > promedio)
                    {
                        ++mayor;
                    }
                    else
                    {
                        ++menor;
                    }
                }
                Console.WriteLine($"Cantidad de persoinas mayor: { mayor } y la cantidad de personas menores al promedio son: { menor }");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"ha ocurrido el siguietne error {ex.Message}");
            }



        }

        #endregion "termina mi region"
    }

}
