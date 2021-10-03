using EntidadesComercio;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Comercio
{
    public partial class FrmStockProductos : FrmBaseProductos
    {
        private Producto productoBuscado;
        public FrmStockProductos()
        {
            InitializeComponent();
        }
        
        private void FrmStockProductos_Load(object sender, EventArgs e)
        {
            CargarTiposProductosAlComboBox();
        }


        private void btn_DescargarStock_Click(object sender, EventArgs e)
        {
            StringBuilder stock = new StringBuilder();
            foreach (Producto producto in Producto.ListaProductos)
            {
                stock.AppendLine($"{producto.Codigo},{producto.Nombre},{producto.Caracteristicas},{producto.TipoProducto},{producto.Cantidad},{producto.PrecioUnitario}");
            }
            TextWriter ticket = new StreamWriter($"PetShopLaplumeStock{new Random().Next(0, 9999)}.csv");
            ticket.WriteLine(stock.ToString());
            ticket.Close();
            MessageBox.Show("Stock completo a sido descargado con éxito");
        }

        private void btn_BuscarProducto_Click(object sender, EventArgs e)
        {
            //productoBuscado = Producto.BuscarProducto(txt_CodigoProductoIngresado.Text);
            if (productoBuscado != null)
            {
                lbl_ProductoEncontrado.Visible = true;
                btn_ModificarProducto.Enabled = true;
                btn_EliminarProducto.Enabled = true;
            }
            else
                MessageBox.Show("Producto no encontrado, intente con otro codigo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btn_ModificarProducto_Click(object sender, EventArgs e)
        {
            FrmModificarProducto frmModicarProducto = new FrmModificarProducto(productoBuscado);
            frmModicarProducto.ShowDialog();
        }

        private void txt_CodigoProductoIngresado_TextChanged(object sender, EventArgs e)
        {
            lbl_ProductoEncontrado.Visible = false;
            btn_ModificarProducto.Enabled = false;
            btn_EliminarProducto.Enabled = false;
        }

        private void btn_EliminarProducto_Click(object sender, EventArgs e)
        {

        }
    }
}
