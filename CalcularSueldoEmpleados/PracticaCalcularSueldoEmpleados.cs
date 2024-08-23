namespace CalcularSueldoEmpleados
{
    /// <summary>
    /// En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y $500, 
    /// realizar un programa que lea los sueldos que cobra cada empleado e 
    /// informe cuántos empleados cobran entre $100 y $300 y cuántos cobran más de $300. 
    /// Además el programa deberá informar el importe que gasta la empresa en sueldos al personal.
    /// </summary>
    internal class PracticaCalcularSueldoEmpleados
    {
        public void Calcular() 
        
        {
            //Declaracion de variables
            
            int cantidadEmpleados = 0;
            int sumaSueldos = 0; //guardara el importe total que gasta la empresa en personal
            int cantEmplCat1 = 0; //cantidad de empleados que cobran entre $100 y $300
            int cantEmplCat2 = 0; //cantidad de empleados que cobran mas de $300
            int sueldoEmpleado = 0;
            int index = 1;

            Console.WriteLine("Digite la cantidad de empleados que laboran en su empresa: ");

            cantidadEmpleados = Convert.ToInt32(Console.ReadLine());

            while (index <= cantidadEmpleados)
            {
                Console.WriteLine($"Digite el sueldo que gana el empleado {index}:");

                sueldoEmpleado = Convert.ToInt32(Console.ReadLine());

                if (sueldoEmpleado >= 100 && sueldoEmpleado <= 300)
                {
                    ++cantEmplCat1;
                }

                if (sueldoEmpleado > 300)
                {
                    ++cantEmplCat2;
                }

                sumaSueldos += sueldoEmpleado;

                ++index;

            }

            Console.WriteLine($"Los empleados de su empresa que tienen un sueldo entre $100 y $300 son: {cantEmplCat1}, \n los empleados que tienen un sueldo mayor a $300 son: {cantEmplCat2} y \n el importe que gasta su empresa en sueldo de personal es ${sumaSueldos} ");

            Console.ReadLine();
        }
    }
}
