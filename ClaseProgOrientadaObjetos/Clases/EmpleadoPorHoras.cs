namespace ClaseProgOrientadaObjetos.Clases
{
    internal class EmpleadoPorHoras : Empleado
    {
        public decimal Sueldo { get; set; }
        public int Horas { get; set; }
        public override decimal Calcular()
        {
            decimal ValorPagar = 0;
            decimal porcentaje = 1.5m;
            int hoasPorDefault = 40;

            if (this.Horas <= hoasPorDefault)
                return this.Sueldo * this.Horas;
            else if (this.Horas > hoasPorDefault)
            {
                ValorPagar = hoasPorDefault * this.Sueldo + (this.Horas - hoasPorDefault) * this.Sueldo * porcentaje;
            }
            return ValorPagar;
        }
    }
}
