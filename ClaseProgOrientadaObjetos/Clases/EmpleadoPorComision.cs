namespace ClaseProgOrientadaObjetos.Clases
{
    internal class EmpleadoPorComision : Empleado
    {
        public decimal VentasBrutas { get; set; }
        public decimal TarifaComision { get; set; }
        public override decimal Calcular()
        {
            return this.TarifaComision * this.VentasBrutas;
        }
    }
}
