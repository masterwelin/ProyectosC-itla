namespace EjerciciosResumenCap4
{
    // Fig. 4.1: LibroCalificaciones.cs
    // Declaración de una clase con un método.
    using System;

    public class LibroCalificaciones
    {
        private string nombreCurso; // nombre del curso para este LibroCalificaciones

        // propiedad para obtener (get) y establecer (set) el nombre del curso
        public string NombreCurso
        {
            get
            {
                return nombreCurso;
            } // fin de get
            set
            {
                nombreCurso = value;
            } // fin de set
        } // fin de la propiedad NombreCurso

        // muestra un mensaje de bienvenida para el usuario de LibroCalificaciones
        public void MostrarMensaje()
        {
            Console.WriteLine("¡Bienvenido al libro de calificaciones para\n{0}!",
                                 NombreCurso);
        } // fin del método MostrarMensaje
    } // fin de la clase LibroCalificaciones
}
