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
        Cliente clienteSeleccionado;

        #region Contructores

        public FrmComprasTotalesCliente()
        {
            InitializeComponent();
        }

        public FrmComprasTotalesCliente(Cliente clienteSeleccionado) : this ()
        {
            if(clienteSeleccionado != null)
                this.clienteSeleccionado = clienteSeleccionado;
        }

        #endregion

        private void FrmComprasTotalesCliente_Load(object sender, EventArgs e)
        {
            MinimumSize = Size;
            MaximumSize = Size;
            if (this.clienteSeleccionado != null)
            {
                float totalCompras = 0;
                lst_ListaFacturasCliente.HorizontalScrollbar = true;
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
        }
    }
}
