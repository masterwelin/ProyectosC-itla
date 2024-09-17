
//probar clase Carta.

using CasoDeEstudioBarajaCartas;

try
{
    PruebaPaqueteDeCartas pruebaPaqueteDeCartas = new PruebaPaqueteDeCartas();
    pruebaPaqueteDeCartas.EjecutarPrograma();

}
catch (Exception ex)
{
	Console.WriteLine($"GHa ocurrido el siguiente error { ex }");
}
