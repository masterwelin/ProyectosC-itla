namespace PracticaModulo3Ejercicio3.Ejercicio3
{
    /// <summary>
    /// Crea una clase Alumno con las propiedades Nombre, Matricula, Carrera y Calificaciones (una lista de enteros).
    ///Implementa un método CalcularPromedio que devuelva el promedio de las calificaciones.
    ///Implementa un método MostrarInformacion que imprima el nombre, la matrícula, la carrera y el promedio del alumno
    ///Crea instancias de la clase Alumno, asigna valores a las propiedades y muestra la información.
    /// </summary>
    public class Alumno
    {
        // declaracion de las Propiedades del alumno
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public string Carrera { get; set; }
        public List<int> Calificaciones { get; set; }

        public int index = 0;
        public decimal sumaCalificaciones = 0;

        // Constructor para inicializar la lista de calificaciones
        public Alumno()
        {
            Calificaciones = new List<int>();
        }

        // Método para calcular el promedio de las calificaciones
        public decimal CalcularPromedio()
        {
            if (Calificaciones.Count == 0)
            {
                return 0;  // si no hay calificaciones retorna 0 para evitar errores.
            }

            while (index < Calificaciones.Count)
            {
                sumaCalificaciones += Calificaciones[index];
                //Console.WriteLine(Calificaciones[index]);
                index++;
            }

            return ((sumaCalificaciones / Calificaciones.Count)); // calculamos el promedio usando un bucle while ya que no sabemos la cantidad de calificaciones que podran poner
        }

        // Método para mostrar la información del alumno
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Matrícula: {Matricula}");
            Console.WriteLine($"Carrera: {Carrera}");
            Console.WriteLine($"Promedio: {CalcularPromedio():F2}");
            Console.WriteLine("\n");
        }
    }
}
