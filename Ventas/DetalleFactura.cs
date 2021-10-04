namespace Ventas
{
    public class DetalleFactura
    {
        private int cantidad;
        private string descripcion;
        private float precioUnitario;

        /// <summary>
        /// Constructor publico de detalles de una factura
        /// </summary>
        /// <param name="cantidad"></param>
        /// <param name="descripcion"></param>
        /// <param name="precioUnitario"></param>
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

        /// <summary>
        /// Propiedad que muestra total del detalle de factura
        /// </summary>
        public float TotalDetalle
        {
            get
            {
                return this.Cantidad * this.PrecioUnitario;
            }
        }

        /// <summary>
        /// Metodo publico que retorna detalles de al factura
        /// </summary>
        /// <returns></returns>
        public string DatosDetalle()
        {
            return $"{this.Cantidad} de {this.Descripcion} $ {this.PrecioUnitario}  =  $ {TotalDetalle}";
        }
    }
}
