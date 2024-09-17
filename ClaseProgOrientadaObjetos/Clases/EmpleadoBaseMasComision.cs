namespace ClaseProgOrientadaObjetos.Clases
{
    internal class EmpleadoBaseMasComision : EmpleadoPorComision
    {
        public decimal SalarioBase { get; set; }

        public decimal TarifaComision { get; set; }

        public override decimal Calcular()
        {
            return (this.TarifaComision * this.VentasBrutas) + this.SalarioBase;
        }

    }
}
