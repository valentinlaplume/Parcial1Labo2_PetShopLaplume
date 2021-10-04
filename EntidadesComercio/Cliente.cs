using System;
using System.Collections.Generic;
using System.Text;
using Ventas;

namespace EntidadesComercio
{
    public class Cliente : Persona
    {
        private float billetera;
        private List<Factura> facturas;
        private int cantidadCompras;

        #region Constructores
        /// <summary>
        /// Constructor publico por default de tipo cliente, hereda de persona
        /// </summary>
        public Cliente() : base(string.Empty, string.Empty, string.Empty)
        {
            facturas = new List<Factura>();
            CantidadCompras = 0;
            Billetera = 0;
        }

        /// <summary>
        /// Constructor publico de tipo cliente, hereda de persona
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="billetera"></param>
        public Cliente(string nombre,
                       string apellido,
                       string dni,
                       float billetera)
            : base(nombre, apellido, dni)
        {
            facturas = new List<Factura>();
            CantidadCompras = 0;
            Billetera = billetera;
        }

        #endregion

        #region Propiedades
      
        /// <summary>
        /// Propiedad lista de facturas, valida y asigna, caso contrario construye lista vacia
        /// </summary>
        public List<Factura> Facturas
        {
            get => facturas;
            set
            {
                if (value != null)
                    facturas = value;
                else
                    facturas = new List<Factura>();
            }
        }
        /// <summary>
        /// Propiedad billetera, valida que el monto sea mayor a 0
        /// </summary>
        public float Billetera
        {
            get => billetera;
            set
            {
                if (value > 0)
                    billetera = value;
                else
                    billetera = 0;
            }
        }
        /// <summary>
        /// Propiedad cantidad compras, valida que la cantidad sea mayor a 0
        /// </summary>
        public int CantidadCompras
        {
            get => cantidadCompras;
            set
            {
                if (value > 0)
                    cantidadCompras = value;
                else
                    cantidadCompras = 0;
            }
        }

        #endregion

        #region Mostrar datos
        /// <summary>
        /// Metodo heredado, muestra los datos de un cliente
        /// </summary>
        /// <returns>datos </returns>
        public override string MostrarDatosCompletos()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendLine($"{Nombre} {Apellido} | DNI: {Dni} | BILLETERA: ${Billetera}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// Muestra los datos completos de un cliente, junto con las facturas de compra
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>datos con facturas de compra</returns>
        public string MostrarDatosCompletosConFactura(Cliente cliente)
        {
            if (cliente != null && cliente.CantidadCompras > 0)
            {
                StringBuilder strBuilder = new StringBuilder();
                strBuilder.Append($"{MostrarDatosCompletos()}");

                foreach (Factura item in Facturas)
                {
                    strBuilder.AppendLine(item.RetornarFactura());
                }
                return strBuilder.ToString();
            }
            return $"{MostrarDatosCompletos()}\n > No posee compras por el momento.";
        }
        #endregion

        /// <summary>
        /// Buscar un cliente por su dni, si lo encuentre lo retorna
        /// </summary>
        /// <param name="dni"></param>
        /// <returns></returns>
        static public Cliente BuscarCliente(string dni)
        {
            if (!string.IsNullOrEmpty(dni) && Usuario.EsValidoDni(dni) &&
                CoreDelSistema.ListaClientes.ContainsKey(dni.Trim()))
            {
                return CoreDelSistema.ListaClientes[dni.Trim()];
            }
            return null;
        }
    }
}
