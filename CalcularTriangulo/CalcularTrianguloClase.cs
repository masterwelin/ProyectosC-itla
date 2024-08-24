
namespace CalcularTriangulo
{
    /// <summary>
    /// Diseñar un algoritmo que:
    ///Solicite al usuario ingresar un número entero "n" que represente la cantidad de triángulos a procesar.
    ///Para cada triángulo, capture los valores de la base y la altura.
    ///Calcule el área de cada triángulo utilizando la fórmula correspondiente.
    ///Muestre en pantalla los datos de cada triángulo (base, altura y área).
    ///Determine y reporte la cantidad de triángulos con un área superior a 12 unidades cuadradas.
    /// </summary>
    
    internal class CalcularTrianguloClase
    {
        public void Calcular() {

            //declaracion de variables
            int cantidadTriangulos = 0;
            decimal vBase = 0;
            decimal vAltura = 0;
            decimal AreaTriangulo = 0;
            int index = 1; //variable de control del bucle
            string resultado = "";
            string triangulos = "";
            int limite = 12;
            int cantidadTriangulosAptos = 0;

            try
            {

                Console.WriteLine("Digite la cantidad de triángulos que desea procesar:");
                cantidadTriangulos = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");

                while (index <= cantidadTriangulos)
                {
                    ///la formula para calcular triangulos es area = (base * altura)/2
                    ///sabiendo la base y la altura solo hay que realizar la formula

                    Console.WriteLine($"Digite la base del triángulo {index}:");
                    vBase = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine($"Digite la altura del triángulo {index}:");
                    vAltura = Convert.ToDecimal(Console.ReadLine());

                    AreaTriangulo = (vBase * vAltura) / 2;

                    if (AreaTriangulo > limite)
                    {
                        resultado += $"El area del triángulo ({index}) es: {AreaTriangulo}\n";
                        ++cantidadTriangulosAptos;
                    }

                    triangulos += $"Los valores del triángulo {index} son > Base {vBase}, Altura {vAltura} y Area {AreaTriangulo}.\n";

                    ++index;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ocurrio el siguiente error{ex.Message}");
            }

            Console.WriteLine($"\nLos triángulos digitados fueron los siguientes:\n{triangulos}");

            if (cantidadTriangulosAptos == 0)
            {
                resultado = "No hay triángulos que cumplan con la condición";
            }
            else 
            {
                resultado = $"La cantidad de triángulos cuyo resultado es mayor a {limite} unidades cuadradas es {cantidadTriangulosAptos}.";
            }

            Console.WriteLine(resultado);
            Console.ReadLine();
            
        }
    }
}
