
namespace ProgramacionSecuencialTarea1.Tarea1
{
    /// <summary>
    /// 
    /// </summary>
    internal class T1ProductoCantidad
    {
        /// <summary>
        /// Se debe desarrollar un programa que pida el ingreso del precio de un artículo y la cantidad que 
        /// lleva el cliente. Mostrar lo que debe abonar el comprador..
        /// </summary>

        public void Calcular()
        {
            //declarar las variables
            int precioArticulo= 0;
            int cantidadArticulo = 0;
            int abonoCliente = 0;

            string linea = string.Empty;


            try
            {
                //Pedir los numeros por teclado//
                Console.WriteLine("Ingrese el precio del articulo:");
                linea = Console.ReadLine();

                if (!int.TryParse(linea, out precioArticulo))
                {
                    Console.WriteLine("El precio del articulo es invalido.");
                    return;
                }

                Console.WriteLine("Ingrese la cantidad de articulos:");
                linea = Console.ReadLine();

                if (!int.TryParse(linea, out cantidadArticulo))
                {
                    Console.WriteLine("La cantidad de articulos es invalida.");
                    return;
                }


                abonoCliente = (precioArticulo * cantidadArticulo);

                Console.WriteLine($"El cliente debe abonar: {abonoCliente}");

                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"ocurrio el siguiente error{ex.Message}");
            }

        }
    }
}
