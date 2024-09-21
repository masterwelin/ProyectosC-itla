namespace EjerciciosResumenCap4
{
    public class LibroCalificaciones48
    {
        1 // Fig. 4.8: PruebaLibroCalificaciones.cs
2 // Creación y manipulación de un objeto LibroCalificaciones.
3 using System;
45
public class PruebaLibroCalificaciones
        {
            // El método Main comienza la ejecución del programa
            public static void Main(string[] args)
            {
                // crea un objeto LibroCalificaciones y lo asigna a miLibroCalificaciones
                LibroCalificaciones miLibroCalificaciones = new LibroCalificaciones();

                // muestra el valor inicial de NombreCurso
                Console.WriteLine("El nombre inicial del curso es: '{0}'\n",
                miLibroCalificaciones.NombreCurso);

                // pide y lee el nombre del curso
                Console.WriteLine("Por favor escriba el nombre del curso:");
                string elNombre = Console.ReadLine(); // lee una línea de texto
                miLibroCalificaciones.NombreCurso = elNombre; // establece el nombre usando una
                propiedad
             Console.WriteLine(); // imprime en pantalla una línea en blanco

                // muestra el mensaje de bienvenida después de especificar el nombre del curso
                miLibroCalificaciones.MostrarMensaje();
            } // fin de Main
        } // fin de la clase PruebaLibroCalificaciones
    }
}
