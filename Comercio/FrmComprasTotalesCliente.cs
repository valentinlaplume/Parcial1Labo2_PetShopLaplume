using EntidadesComercio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ventas;

namespace Comercio
{
    public partial class FrmComprasTotalesCliente : Form
    {
        bool quieroTodasLasCompras;
        Cliente clienteSeleccionado;
        #region Contructores

        public FrmComprasTotalesCliente()
        {
            quieroTodasLasCompras = false;
            InitializeComponent();
        }

        /// <summary>
        /// Constructor que recibe un cliente, este cliente es al cual se le van a mostrar 
        /// las compras
        /// </summary>
        /// <param name="clienteSeleccionado"></param>
        public FrmComprasTotalesCliente(Cliente clienteSeleccionado) : this ()
        {
            if(clienteSeleccionado != null)
            {
                this.clienteSeleccionado = clienteSeleccionado;
                lbl_MontoTotalCliente.Text = "Total gastado Cliente:";
            }
        }
        /// <summary>
        /// Constructor que recibe un booleano, si es true entonces muestra todas las compras
        /// </summary>
        /// <param name="quieroTodasLasCompras"></param>
        public FrmComprasTotalesCliente(bool quieroTodasLasCompras) : this()
        {
            if(quieroTodasLasCompras)
            {
                this.quieroTodasLasCompras = quieroTodasLasCompras;
                lbl_MontoTotalCliente.Text = "Total Ganancias:";
            }
        }


        #endregion
        /// <summary>
        /// Evento de inicio que dependiendo si la variable quieroTodasLasCompras es true 
        /// muestra todas las compras o muestra solo las del cliente pasado por parametro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmComprasTotalesCliente_Load(object sender, EventArgs e)
        {
            MinimumSize = Size;
            MaximumSize = Size;
            if (this.clienteSeleccionado != null && !quieroTodasLasCompras)
            {
                float totalCompras = 0;
                lst_ListaFacturasCliente.Items.Clear();
                lst_ListaFacturasCliente.HorizontalScrollbar = true;

                lst_ListaFacturasCliente.Items.Add(clienteSeleccionado.MostrarDatosCompletos());
                foreach (Factura factura in clienteSeleccionado.Facturas)
                {
                    lst_ListaFacturasCliente.Items.Add($"Factura | N° {factura.Numero} | Fecha: {factura.Fecha.ToString("dd/MM/yyyy")}");
                    foreach (DetalleFactura item in factura.Detalles)
                    {
                        lst_ListaFacturasCliente.Items.Add(item.DatosDetalle());
                    }
                    lst_ListaFacturasCliente.Items.Add($" > TOTAL: $ {factura.CalcularTotal()}");
                    lst_ListaFacturasCliente.Items.Add("");
                    totalCompras += factura.CalcularTotal();
                }
                lbl_MontoTotalCliente.Text = $"{lbl_MontoTotalCliente.Text} $ {totalCompras.ToString()}";
            }
            else if (quieroTodasLasCompras)
            {
                CargarTodasLasComprasPetShop();
            }

        }

        /// <summary>
        /// Carga todas las compras de todos los clientes registrados 
        /// muestra monto total de ganancias
        /// </summary>
        private void CargarTodasLasComprasPetShop()
        {
            float totalComprasPetShop = 0;
            lst_ListaFacturasCliente.HorizontalScrollbar = true;
            lst_ListaFacturasCliente.Items.Clear();
            foreach (KeyValuePair<string, Cliente> item in CoreDelSistema.ListaClientes)
            {
                foreach (Factura factura in item.Value.Facturas)
                {
                    lst_ListaFacturasCliente.Items.Add(item.Value.MostrarDatosCompletos());
                    lst_ListaFacturasCliente.Items.Add($"Factura | N° {factura.Numero} | Fecha: {factura.Fecha.ToString("dd/MM/yyyy")}");
                    foreach (DetalleFactura detalle in factura.Detalles)
                    {
                        lst_ListaFacturasCliente.Items.Add(detalle.DatosDetalle());
                    }
                    lst_ListaFacturasCliente.Items.Add($" > TOTAL: $ {factura.CalcularTotal()}");
                    lst_ListaFacturasCliente.Items.Add("");
                    totalComprasPetShop += factura.CalcularTotal();
                }
            }
            lbl_MontoTotalCliente.Text = $"{lbl_MontoTotalCliente.Text} $ {totalComprasPetShop.ToString()}";
        }
    }
}
