using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PracticasModulo3.Ejercicio2
{
    /// <summary>
    /// Ejercicio 2
    ///Crea una clase Libro con las propiedades Titulo, Autor y Paginas.
    ///Implementa un método MostrarInformacion que imprima la información del libro.
    ///Implementa un método EsLargo que devuelva true si el libro tiene más de 500 páginas, 
    ///o false en caso contrario.
    /// </summary>
    public class Libro
    {

        public string titulo;
        public string autor;
        public int paginas;
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public int Paginas
        {
            get { return paginas; }
            set { paginas = value; }
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"\nEl libro tiene las siguientes informaciones:\nTitulo del libro: {Titulo}\nAutor:{Autor}\nCantidad de paginas:{Paginas}\n");
        }

        public bool EsLargo()
        {

            if (Paginas >= 500)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

    }
}
