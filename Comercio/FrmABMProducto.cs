using EntidadesComercio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comercio
{
    public partial class FrmABMProducto : FrmBaseProductos
    {
        Producto productoBuscado;
        public FrmABMProducto()
        {
            InitializeComponent();
        }

        #region DESCARGAR STOCK A CSV

        private void btn_DescargarStock_Click(object sender, EventArgs e)
        {
            StringBuilder stock = new StringBuilder();
            foreach (Producto producto in Producto.ListaProductos)
            {
                stock.AppendLine($"{producto.Codigo},{producto.Nombre},{producto.Caracteristicas},{producto.TipoProducto},{producto.Cantidad},{producto.PrecioUnitario}");
            }
            TextWriter ticket = new StreamWriter($"StockPetShopLaplume{new Random().Next(0, 9999)}.csv");
            ticket.WriteLine(stock.ToString());
            ticket.Close();
            MessageBox.Show("Stock completo a sido descargado con éxito");
        }
        #endregion

        private void lst_Codigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_CodigoProductoIngresado.Text = lst_Codigo.SelectedItem.ToString();
            HabilitarBotones(true);
        }

        private void btn_BuscarProducto_Click(object sender, EventArgs e)
        {
            if(txt_CodigoProductoIngresado.Text != string.Empty)
            {
                productoBuscado = Producto.BuscarProducto(txt_CodigoProductoIngresado.Text);
                if (productoBuscado != null)
                {
                    lbl_ProductoEncontrado.Visible = true;
                    HabilitarBotones(true);
                    LimpiarListasProductos();
                    CargarListasPorProducto(productoBuscado);
                }
                else
                    MessageBox.Show("Producto no encontrado, intente con otro codigo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_EliminarProducto_Click(object sender, EventArgs e)
        {
            if (txt_CodigoProductoIngresado.Text != string.Empty)
            {
                productoBuscado = Producto.BuscarProducto(txt_CodigoProductoIngresado.Text);
                if (productoBuscado != null &&
                    MessageBox.Show($"{productoBuscado.MostrarDatosCompletos()}\nDesea confirmar la baja?", "Confirmacion, baja producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes &&
                    Producto.ListaProductos.Remove(productoBuscado))
                {
                    LimpiarListasProductos();
                    txt_CodigoProductoIngresado.Text = "";
                    lbl_ProductoEncontrado.Visible = false;
                    productoBuscado = new Producto();
                    HabilitarBotones(false);
                }
            }
        }

        private void txt_CodigoProductoIngresado_TextChanged(object sender, EventArgs e)
        {
            lbl_ProductoEncontrado.Visible = false;
            HabilitarBotones(false);
        }

        private void HabilitarBotones(bool accion)
        {
            btn_ModificarProducto.Enabled = accion;
            btn_EliminarProducto.Enabled = accion;
        }

        private void FrmABMProducto_Load(object sender, EventArgs e)
        {
            lbl_TituloForms.Text = "STOCK PRODUCTOS";
        }
    }
}
