

using PracticasModulo3.Ejercicio2;
using System.Timers;

Libro libro = new Libro();

// Seteando las propiedades
Console.WriteLine("Inserte el autor del libro que sera pasado a la propiedad Autor de la clase libro...");

try
{
    libro.autor = Console.ReadLine();
}
catch (Exception ex)
{
	Console.WriteLine($"ha ocurrido el siguiente error {ex}");
}
Console.WriteLine("Inserte el titulo del libro que sera pasado a la propiedad Titulo de la clase libro...");

try
{
    libro.titulo = Console.ReadLine();
}
catch (Exception ex)
{
    Console.WriteLine($"ha ocurrido el siguiente error {ex}");
}

Console.WriteLine("Inserte la cantidad de paginas que sera pasada a la propiedad Paginas de la clase libro...");

try
{
    libro.paginas = Convert.ToInt32(Console.ReadLine());
}
catch (Exception ex)
{
    Console.WriteLine($"ha ocurrido el siguiente error {ex}");
}

libro.MostrarInformacion();

if (libro.EsLargo() == true)
{
    Console.WriteLine("El metodo EsLargo devolvio true por lo que el libro es laargo");
}
else 
{
    Console.WriteLine("El libro no es largo");
}

Console.ReadLine();
