namespace Ventas
{
    public class DetalleFactura
    {
        private int cantidad;
        private string descripcion;
        private float precioUnitario;

        public DetalleFactura(int cantidad,
                              string descripcion,
                              float precioUnitario)
        {
            Cantidad = cantidad;
            Descripcion = descripcion;
            PrecioUnitario = precioUnitario;
        }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public float PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }


        public float TotalDetalle
        {
            get
            {
                return this.Cantidad * this.PrecioUnitario;
            }
        }

        public string DatosDetalle()
        {
            return $"{this.Cantidad} de {this.Descripcion} $ {this.PrecioUnitario}  =  $ {TotalDetalle}";
        }
    }
}
