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
            // listaFacturas
            // factuara.RetornarFactura() // la vista, agregarlo a una lista
            if(this.clienteSeleccionado != null)
            {
                float totalCompras = 0;
                lst_ListaFacturasCliente.HorizontalScrollbar = true;
                //lst_ListaFacturasCliente.IntegralHeight = true;
                foreach (Factura factura in clienteSeleccionado.Facturas)
                {
                    lst_ListaFacturasCliente.Items.Add($"Factura | N° {factura.Numero} | Fecha: {factura.Fecha.ToString("dd/MM/yyyy")}");
                    foreach (DetalleFactura item in factura.Detalles)
                    {
                        lst_ListaFacturasCliente.Items.Add(item.DatosDetalle());
                    }
                    lst_ListaFacturasCliente.Items.Add($" > TOTAL: $ {factura.CalcularTotal()}");
                    lst_ListaFacturasCliente.Items.Add("");
                    //lst_ListaFacturasCliente.Items.Add(factura.RetornarFactura());
                    //lst_ListaFacturasCliente.Items.Add("\n");
                    totalCompras += factura.CalcularTotal();
                }

                //------------------------------------------------------------------
                //StringBuilder stringBuilder = new StringBuilder(); // Datos Factura
                //stringBuilder.AppendLine($"Factura | N° {factura.Numero} | Fecha: {factura.Fecha.ToString("dd/MM/yyyy")}");

                //foreach (DetalleFactura item in detalles)
                //{
                //    stringBuilder.AppendLine(item.DatosDetalle());
                //}

                //stringBuilder.Append($"> TOTAL: $ {this.CalcularTotal()}");
                ////------------------------------------------------------------------

                lbl_MontoTotalCliente.Text = $"{lbl_MontoTotalCliente.Text} $ {totalCompras.ToString()}";
            }
        }


        private void pb_CerrarAplicacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
