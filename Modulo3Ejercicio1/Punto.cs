using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo3Ejercicio1
{
    public class Punto
    {
        // Propiedades para las coordenadas del punto
        public int X { get; set; }
        public int Y { get; set; }

        // Método para setear los valores
        public void CargarValores(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Aqui determinamos en que cuadrante se encuentra el punto.
        public void ImprimirCuadrante()
        {
            if (X > 0 && Y > 0)
            {
                Console.WriteLine("El punto se encuentra en el primer cuadrante.");
            }
            else if (X < 0 && Y > 0)
            {
                Console.WriteLine("El punto se encuentra en el segundo cuadrante.");
            }
            else if (X < 0 && Y < 0)
            {
                Console.WriteLine("El punto se encuentra en el tercer cuadrante.");
            }
            else if (X > 0 && Y < 0)
            {
                Console.WriteLine("El punto se encuentra en el cuarto cuadrante.");
            }
            else if (X == 0 && Y == 0)
            {
                Console.WriteLine("El punto se encuentra en el origen.");
            }
            else if (X == 0)
            {
                Console.WriteLine("El punto se encuentra sobre el eje Y.");
            }
            else if (Y == 0)
            {
                Console.WriteLine("El punto se encuentra sobre el eje X.");
            }
        }

    }



}
