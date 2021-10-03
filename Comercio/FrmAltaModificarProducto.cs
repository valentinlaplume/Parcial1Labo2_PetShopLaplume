using EntidadesComercio;
using Generador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comercio
{
    public partial class FrmAltaModificarProducto : FrmBaseProductos
    {
        private bool quieroAgregarProducto;
        private Producto productoAModificar;

        #region CONSTRUCTORES

        public FrmAltaModificarProducto()
        {
            InitializeComponent();
        }

        public FrmAltaModificarProducto(bool quieroAgregarProducto) : this()
        {
            this.quieroAgregarProducto = quieroAgregarProducto;
            quieroAgregarProducto = false;
        }

        public FrmAltaModificarProducto(Producto productoAModificar) : this()
        {
            if (productoAModificar != null)
                this.productoAModificar = productoAModificar;
        }
        #endregion

        #region CARGAR CAMPOS
        private void CargarCamposConInfoProducto(Producto producto)
        {
            txt_CodigoProductoIngresado.Text = producto.Codigo;
            txt_NombreProductoIngresado.Text = producto.Nombre;
            txt_CaracteristicasProductoIngresado.Text = producto.Caracteristicas;
            txt_CantidadStockProductoIngresado.Text = producto.Cantidad.ToString();
            txt_PrecioUnidadProductoIngresado.Text = producto.PrecioUnitario.ToString();
            txt_UrlImagenProducto.Text = producto.UrlImagen;
            pb_ImagenProducto.ImageLocation = producto.UrlImagen; // cargo imagen del url al picture box
        }

        private void CargarListasConInfoProducto(Producto producto)
        {
            LimpiarListasProductos();
            lst_Codigo.Items.Add(producto.Codigo);
            lst_Nombre.Items.Add(producto.Nombre);
            lst_Caracteristicas.Items.Add(producto.Caracteristicas);
            lst_TipoProducto.Items.Add(producto.TipoProducto);
            lst_CantidadStock.Items.Add(producto.Cantidad);
            lst_PrecioUnitario.Items.Add(producto.PrecioUnitario);
        }
        #endregion

        private void LimpiarCamposAsignadosProducto()
        {
            txt_CodigoProductoIngresado.Text = "";
            txt_NombreProductoIngresado.Text = "";
            txt_CaracteristicasProductoIngresado.Text = "";
            txt_CantidadStockProductoIngresado.Text = "";
            txt_PrecioUnidadProductoIngresado.Text = "";
        }

        private void btn_GenerarCodigo_Click(object sender, EventArgs e)
        {
            txt_CodigoProductoIngresado.Text = GeneradorCodigo.GeneradorCodigoProducto();
        }

        #region VALIDACIONES
        public bool VerificarCamposAsignados()
        {
            if (!string.IsNullOrEmpty(txt_CodigoProductoIngresado.Text) &&
                !string.IsNullOrEmpty(txt_NombreProductoIngresado.Text) &&
                !string.IsNullOrEmpty(txt_CaracteristicasProductoIngresado.Text) &&
                !string.IsNullOrEmpty(txt_CantidadStockProductoIngresado.Text) &&
                Producto.EsValidoCantidadProducto(txt_CantidadStockProductoIngresado.Text) &&
                !string.IsNullOrEmpty(txt_PrecioUnidadProductoIngresado.Text) &&
                Producto.EsValidoPrecioUnitarioProducto(txt_PrecioUnidadProductoIngresado.Text) &&
                cmb_TipoProductoElegido.SelectedItem != null)
            {
                return true;
            }
            return false;
        }
        #endregion

        private void FrmAltaModificarProducto_Load(object sender, EventArgs e)
        {
            CargarTiposProductosAlComboBox(cmb_TipoProductoElegido);
            if (quieroAgregarProducto)
            {
                LimpiarCamposAsignadosProducto();
                lbl_TituloForms.Text = "ALTA DE UN PRODUCTO";
                HabilitarPermisosAlta(true);
            }
            else if (productoAModificar != null)
            {
                lbl_TituloForms.Text = "MODIFICACIÓN DE PRODUCTO";
                CargarCamposConInfoProducto(productoAModificar);
                CargarListasConInfoProducto(productoAModificar);
                HabilitarPermisosAlta(false);
            }
        }

        private void HabilitarPermisosAlta(bool esAlta)
        {
            btn_GenerarCodigo.Visible = esAlta;
            txt_CodigoProductoIngresado.Enabled = esAlta;
            cmb_TiposProductos.Visible = esAlta;
            lbl_TipoProducto.Visible = esAlta;
        }

        private void txt_UrlImagenProducto_TextChanged(object sender, EventArgs e)
        {
            pb_ImagenProducto.ImageLocation = txt_UrlImagenProducto.Text;
        }

        private void btn_ConfirmarAccionProducto_Click(object sender, EventArgs e)
        {
            if (VerificarCamposAsignados())
            {
                switch (this.quieroAgregarProducto) // define que accion quiero realizar
                {
                    case true: // Si quiero dar de alta un producto
                        Producto productoAgregar = new Producto(txt_CodigoProductoIngresado.Text,
                                                                txt_NombreProductoIngresado.Text,
                                                                txt_CaracteristicasProductoIngresado.Text,
                                                                (EnumTipoProducto)cmb_TipoProductoElegido.SelectedItem,
                                                                int.Parse(txt_CantidadStockProductoIngresado.Text),
                                                                float.Parse(txt_PrecioUnidadProductoIngresado.Text),
                                                                txt_UrlImagenProducto.Text);
                        if (productoAgregar != null)
                        {
                            CoreDelSistema.ListaProductos.Add(productoAgregar);
                            MessageBox.Show("Alta del producto con éxito");
                            CargarListasConInfoProducto(productoAgregar);
                            LimpiarCamposAsignadosProducto();
                        }
                        break;
                    case false: // Si quiero modificar un producto
                        if (productoAModificar != null &&
                            MessageBox.Show("Desea confirmar?", "Modificacion del producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes &&
                            Producto.EsValidoCantidadProducto(txt_CantidadStockProductoIngresado.Text.Trim()) &&
                            Producto.EsValidoPrecioUnitarioProducto(txt_PrecioUnidadProductoIngresado.Text.Trim()))
                        {
                            productoAModificar.Nombre = txt_NombreProductoIngresado.Text;
                            productoAModificar.Caracteristicas = txt_CaracteristicasProductoIngresado.Text;
                            productoAModificar.TipoProducto = (EnumTipoProducto)cmb_TipoProductoElegido.SelectedItem;
                            productoAModificar.Cantidad = int.Parse(txt_CantidadStockProductoIngresado.Text);
                            productoAModificar.PrecioUnitario = float.Parse(txt_PrecioUnidadProductoIngresado.Text);
                            productoAModificar.UrlImagen = txt_UrlImagenProducto.Text;
                            CargarListasConInfoProducto(productoAModificar);
                            CargarCamposConInfoProducto(productoAModificar);
                        }
                        break;
                }
            } else { MessageBox.Show("Verifique que los campos asignados no se encuentren vacios", "Error al querer validar los campos", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void lst_Codigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_CodigoProductoIngresado.Text = lst_Codigo.SelectedItem.ToString();
            Producto productoSeleccionado = CoreDelSistema.ListaProductos.Where(p => p.Codigo == lst_Codigo.SelectedItem.ToString()).FirstOrDefault();
            if (productoSeleccionado != null)
            {
                CargarCamposConInfoProducto(productoSeleccionado);
                pb_ImagenProducto.ImageLocation = productoSeleccionado.UrlImagen;
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
