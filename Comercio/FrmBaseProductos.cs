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
        /// <summary>
        /// Limpia las listas de campos producto
        /// </summary>
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
        /// <summary>
        /// Carga el combo box pasado por parametro con los tipo de tipo producto
        /// </summary>
        /// <param name="combobox"></param>
        public void CargarTiposProductosAlComboBox(ComboBox combobox)
        {
            combobox.Items.Clear();
            combobox.Items.Add(EnumTipoProducto.Alimento);
            combobox.Items.Add(EnumTipoProducto.Juguete);
            combobox.Items.Add(EnumTipoProducto.Comodidad);
            combobox.Items.Add(EnumTipoProducto.Limpieza);
            combobox.Items.Add(EnumTipoProducto.Farmacia);
        }
        /// <summary>
        /// Carga las listas de los campos dependiendo el producto pasado por parametro
        /// separa por tipo
        /// </summary>
        /// <param name="tipoProducto"></param>
        public void CargarListasPorTipoProducto(EnumTipoProducto tipoProducto)
        {
            LimpiarListasProductos();
            List<Producto> listaFiltrada = CoreDelSistema.ListaProductos.Where(p => p.TipoProducto == tipoProducto).ToList();

            foreach (Producto producto in listaFiltrada)
            {
                CargarListasPorProducto(producto);
            }
        }
        /// <summary>
        /// Carga listas con info de cada campo del producto pasado por parametro
        /// </summary>
        /// <param name="producto"></param>
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

        /// <summary>
        /// Evento load carga combo box con tipo de productos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmBaseProductos_Load(object sender, EventArgs e)
        {
            CargarTiposProductosAlComboBox(cmb_TiposProductos);
        }
        /// <summary>
        /// Dependiendo al seleccion del tipo de producto
        /// carga las listas con todos los productos de ese tipo seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Cierra pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pb_CerrarAplicacion_Click_1(object sender, EventArgs e)
        {
            Console.Beep(500,200);
            this.Close();
        }

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
