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
    public partial class FrmModificarProducto : FrmBaseProductos
    {
        private Producto productoAModificar;

        #region Consturctores

        public FrmModificarProducto()
        {
            InitializeComponent();
        }

        public FrmModificarProducto(Producto productoAModificar) : this()
        {
            if (productoAModificar != null)
                this.productoAModificar = productoAModificar;
            else
                this.productoAModificar = null;
        }
        #endregion

        #region Cargar campos
        private void CargarCamposConInfoProducto()
        {
            txt_CodigoProductoIngresado.Text = productoAModificar.Codigo;
            txt_NombreProductoIngresado.Text = productoAModificar.Nombre;
            txt_CaracteristicasProductoIngresado.Text = productoAModificar.Caracteristicas;
            txt_CantidadStockProductoIngresado.Text = productoAModificar.Cantidad.ToString();
            txt_PrecioUnidadProductoIngresado.Text = productoAModificar.PrecioUnitario.ToString();
            cmb_TipoProductoElegido.Items.Add(productoAModificar.TipoProducto);
            txt_UrlImagenProducto.Text = productoAModificar.UrlImagen;
            pb_ImagenProducto.ImageLocation = productoAModificar.UrlImagen; // cargo imagen del url al picture box
        }

        private void CargarListasConInfoProducto()
        {
            LimpiarListasProductos();
            lst_Codigo.Items.Add(productoAModificar.Codigo);
            lst_Nombre.Items.Add(productoAModificar.Nombre);
            lst_Caracteristicas.Items.Add(productoAModificar.Caracteristicas);
            lst_TipoProducto.Items.Add(productoAModificar.TipoProducto);
            lst_CantidadStock.Items.Add(productoAModificar.Cantidad);
            lst_PrecioUnitario.Items.Add(productoAModificar.PrecioUnitario);
        }
        #endregion

        private void FrmModicarProducto2_Load(object sender, EventArgs e)
        {
            CargarCamposConInfoProducto();
            CargarListasConInfoProducto();
            
            //pb_ImagenProducto.ImageLocation = urlImagen;
            //cmb_TiposProductos.Visible = false;
            //lbl_TipoProducto.Visible = false;
        }


        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool VerificarCamposModificacion()
        {
            if (!string.IsNullOrEmpty(txt_NombreProductoIngresado.Text) &&
                !string.IsNullOrEmpty(txt_CaracteristicasProductoIngresado.Text) &&
                !string.IsNullOrEmpty(txt_CantidadStockProductoIngresado.Text) &&
                !string.IsNullOrEmpty(txt_PrecioUnidadProductoIngresado.Text) &&
                !string.IsNullOrEmpty(txt_UrlImagenProducto.Text) &&
                cmb_TipoProductoElegido.SelectedItem != null)
            {
                return true;
            }
            return false;
        }
        private void btn_ModificarProducto_Click(object sender, EventArgs e)
        {
            if (VerificarCamposModificacion())
            {
               if(MessageBox.Show("Desea confirmar?", "Modificacion del producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes &&
                  Producto.EsValidoCantidadProducto(txt_CantidadStockProductoIngresado.Text.Trim()) &&
                  Producto.EsValidoPrecioUnitarioProducto(txt_PrecioUnidadProductoIngresado.Text.Trim()))
               {
                    productoAModificar.Nombre = txt_NombreProductoIngresado.Text;
                    productoAModificar.Caracteristicas = txt_CaracteristicasProductoIngresado.Text;
                    productoAModificar.TipoProducto = (EnumTipoProducto)cmb_TipoProductoElegido.SelectedItem;
                    productoAModificar.Cantidad = int.Parse(txt_CantidadStockProductoIngresado.Text);
                    productoAModificar.PrecioUnitario = float.Parse(txt_PrecioUnidadProductoIngresado.Text);
                    productoAModificar.UrlImagen = txt_UrlImagenProducto.Text;
                    CargarListasConInfoProducto();
                    CargarCamposConInfoProducto();
               }
            }
            else
                MessageBox.Show("Verifique que los campos asignados no se encuentren vacios", "Error al querer validar los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_GenerarCodigo_Click(object sender, EventArgs e)
        {
            txt_CodigoProductoIngresado.Text = GeneradorCodigo.GeneradorCodigoProducto();
        }
    }
}
