namespace ClaseProgramacionCondicional
{
    /// <summary>
    /// 3) Desarrollar un programa que calcule el nivel de un postulante a partir de los resultados de un test. 
    /// El programa recibirá como entrada el número total de preguntas y las respuestas correctas, 
    /// y devolverá un nivel según el porcentaje de aciertos.
    /// Nivel máximo: Porcentaje>=90%.
    /// Nivel medio: Porcentaje>=75% y<90%.
    /// Nivel regular: Porcentaje>=50% y<75%.
    /// Fuera de nivel: Porcentaje<50%.
    /// </summary>

    internal class Ejercicio3NivelPostulante
    {
        /// <summary>
        /// 
        /// </summary>
        
        public void Calcular()
        {
            //declarar las variables
            decimal vPreguntas = 0;
            decimal vRespuestasCorrectas = 0;
            decimal vPorcentajeAciertos = 0;
            string vNivelPostulante = "";

            string linea = string.Empty;


            try
            {
                //Pedir los datos//
                Console.WriteLine("Ingrese cantidad de preguntas:");
                linea = Console.ReadLine();

                if (!decimal.TryParse(linea, out vPreguntas))
                {
                    Console.WriteLine("La cantidad de preguntas es invalida.");
                    return;
                }

                Console.WriteLine("Ingrese la cantidad de respuestas correctas:");
                linea = Console.ReadLine();

                if (!decimal.TryParse(linea, out vRespuestasCorrectas))
                {
                    Console.WriteLine("La cantidad de respuestas correctas es invalida.");
                    return;
                }

                //fin pedir los datos

                //Determinar porcentaje de aciertos

                vPorcentajeAciertos = Math.Round(((vRespuestasCorrectas / vPreguntas) * 100),2);

                if (vPorcentajeAciertos >= 90) {
                    vNivelPostulante = "Nivel Máximo";
                } else if (vPorcentajeAciertos >= 75 && vPorcentajeAciertos < 90) {
                    vNivelPostulante = "Nivel Medio";
                } else if (vPorcentajeAciertos >= 50 && vPorcentajeAciertos < 75) {
                    vNivelPostulante = "Nivel Regular";
                } else if (vPorcentajeAciertos < 50) {
                    vNivelPostulante = "Fuera de Nivel";
                }

                Console.WriteLine($"Según la cantidad de preguntas {vPreguntas} y la cantidad de aciertos {vRespuestasCorrectas}, el nivel del estudiante es: ({vPorcentajeAciertos}) {vNivelPostulante}.");

                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"ocurrio el siguiente error {ex.Message}");
            }

        }
    }
}
