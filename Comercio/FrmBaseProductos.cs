using EntidadesComercio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Comercio
{
    public partial class FrmBaseProductos : Form
    {
        public FrmBaseProductos()
        {
            InitializeComponent();
        }

        #region Limpiar

        public void LimpiarListasProductos()
        {
            lst_Codigo.Items.Clear();
            lst_Nombre.Items.Clear();
            lst_Caracteristicas.Items.Clear();
            lst_TipoProducto.Items.Clear();
            lst_CantidadStock.Items.Clear();
            lst_PrecioUnitario.Items.Clear();
        }
        #endregion

        #region Cargar
        public void CargarTiposProductosAlComboBox(ComboBox combobox)
        {
            combobox.Items.Clear();
            combobox.Items.Add(EnumTipoProducto.Alimento);
            combobox.Items.Add(EnumTipoProducto.Juguete);
            combobox.Items.Add(EnumTipoProducto.Comodidad);
            combobox.Items.Add(EnumTipoProducto.Limpieza);
            combobox.Items.Add(EnumTipoProducto.Farmacia);
        }
        public void CargarListasPorTipoProducto(EnumTipoProducto tipoProducto)
        {
            LimpiarListasProductos();
            List<Producto> listaFiltrada = CoreDelSistema.ListaProductos.Where(p => p.TipoProducto == tipoProducto).ToList();

            foreach (Producto producto in listaFiltrada)
            {
                CargarListasPorProducto(producto);
            }
        }
        public void CargarListasPorProducto(Producto producto)
        {
            lst_Codigo.Items.Add(producto.Codigo);
            lst_Nombre.Items.Add(producto.Nombre);
            lst_Caracteristicas.Items.Add(producto.Caracteristicas);
            lst_TipoProducto.Items.Add(producto.TipoProducto);
            lst_CantidadStock.Items.Add(producto.Cantidad);
            lst_PrecioUnitario.Items.Add(producto.PrecioUnitario);
        }

        #endregion

        private void FrmBaseProductos_Load(object sender, EventArgs e)
        {
            CargarTiposProductosAlComboBox(cmb_TiposProductos);
        }

        private void cmb_TiposProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((EnumTipoProducto)cmb_TiposProductos.SelectedItem)
            {
                case EnumTipoProducto.Alimento:
                    CargarListasPorTipoProducto(EnumTipoProducto.Alimento);
                    break;
                case EnumTipoProducto.Juguete:
                    CargarListasPorTipoProducto(EnumTipoProducto.Juguete);
                    break;
                case EnumTipoProducto.Comodidad:
                    CargarListasPorTipoProducto(EnumTipoProducto.Comodidad);
                    break;
                case EnumTipoProducto.Limpieza:
                    CargarListasPorTipoProducto(EnumTipoProducto.Limpieza);
                    break;
                case EnumTipoProducto.Farmacia:
                    CargarListasPorTipoProducto(EnumTipoProducto.Farmacia);
                    break;
            }
        }

        private void pb_CerrarAplicacion_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void lst_Codigo_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    txt_CodigoProductoIngresado.Text = lst_Codigo.SelectedItem.ToString();
        //    Producto productoSeleccionado = Producto.ListaProductos.Where(p => p.Codigo == lst_Codigo.SelectedItem.ToString()).FirstOrDefault();
        //    if (productoSeleccionado != null)
        //    {
        //        pb_ImagenProducto.ImageLocation = productoSeleccionado.UrlImagen;
        //    }
        //}


        #region BARRA MOVIMIENTO FORMS
        private bool presion = false;
        private void pnl_BarraForms_MouseDown(object sender, MouseEventArgs e)
        {
            this.presion = true;
        }

        private void pnl_BarraForms_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.presion == true)
                this.Location = Cursor.Position;
        }

        private void pnl_BarraForms_MouseUp(object sender, MouseEventArgs e)
        {
            this.presion = false;
        }
        #endregion

    }
}
