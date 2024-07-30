
using System.Linq.Expressions;

namespace CalcularSueldo.Calcular
{
    /// <summary>
    /// Este objeto es para calcular los sueldos de los operadores
    /// </summary>
    public class CalcularSueldoOperador
    {
        /*/// <summary>
        /// Calcular el sueldo del operario
        /// </summary>
        /// <param name="horasTrabajadas">Las horas trabajadas del empleado</param>
        /// <param name="costoHora">Costo de horas trabajadas definido por el personal de rrhh</param>


        public void Calcula(int horasTrabajadas, int costoHora) 
        { 
        //Declaracion de variables//

        }*/

        public void CalcularSueldo() 
        {
            //Declaracion de variables//
            int horasTrabajadas = 0;
            int costoHora = 0;
            int sueldo = 0;

            

            try
            {
                Console.WriteLine("Ingrese las horas trabajadas: ");
                horasTrabajadas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el costo por hora: ");
                costoHora = Convert.ToInt32(Console.ReadLine());

                sueldo = (horasTrabajadas * costoHora);

                Console.WriteLine($"El sueldo es: {sueldo}");

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ha ocurrido el siguiente error: {ex.Message} haciendo la operacion");
            }

        }
    }
}
