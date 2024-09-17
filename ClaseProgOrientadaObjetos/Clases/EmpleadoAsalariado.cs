using Microsoft.VisualBasic;

namespace ClaseProgOrientadaObjetos.Clases
{
    public class EmpleadoAsalariado : Empleado
    {
        public decimal SalarioSemanal { get; set; }
        public override decimal Calcular()
        {
            return this.SalarioSemanal;
        }
    }
}
