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

        /// <summary>
        /// Consutrctor que recibe un booleano, si quiere dar de alta un producto
        /// recibe true
        /// </summary>
        /// <param name="quieroAgregarProducto"></param>
        public FrmAltaModificarProducto(bool quieroAgregarProducto) : this()
        {
            if(quieroAgregarProducto)
                this.quieroAgregarProducto = true;
        }

        /// <summary>
        /// Constructor que recibe un producto
        /// si es distinto a null entonces el inicio es de modificar
        /// </summary>
        /// <param name="productoAModificar"></param>
        public FrmAltaModificarProducto(Producto productoAModificar) : this()
        {
            if (productoAModificar != null)
            {
                this.productoAModificar = productoAModificar;
                quieroAgregarProducto = false;
            }

        }
        #endregion

        #region CARGAR CAMPOS
        /// <summary>
        /// Carga los campos con el producto pasado por parametro
        /// </summary>
        /// <param name="producto"></param>
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
        /// <summary>
        /// Carga las listas con info del producto pasado por parametro
        /// </summary>
        /// <param name="producto"></param>
        /// Cargar
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

        /// <summary>
        /// Limpia campos asignados 
        /// </summary>
        private void LimpiarCamposAsignadosProducto()
        {
            txt_CodigoProductoIngresado.Text = "";
            txt_NombreProductoIngresado.Text = "";
            txt_CaracteristicasProductoIngresado.Text = "";
            txt_CantidadStockProductoIngresado.Text = "";
            txt_PrecioUnidadProductoIngresado.Text = "";
        }
        /// <summary>
        /// Boton que genera un codigo irrepetible para el codigo,
        /// Utilizado para el ALTA 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_GenerarCodigo_Click(object sender, EventArgs e)
        {
            Console.Beep();
            txt_CodigoProductoIngresado.Text = GeneradorCodigo.GeneradorCodigoProducto();
        }

        #region VALIDACIONES
        /// <summary>
        /// Verifica campos asignados que no sean vacios
        /// cantidad de producto positiva y numerica al igual que el 
        /// precio unitario
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Evento load pre visualizacion, carga el combo box de alta o modificacion
        /// con los tipo de productos
        /// Realiza la pantalla dependiendo la opcion, MODIFICAR o ALTA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        #region PERMISOS DEPENDIENDO OPCION

        /// <summary>
        /// Habilita o no los ppermisos del alta
        /// generador de codigo
        /// edicion de codigo
        /// </summary>
        /// <param name="esAlta"></param>
        private void HabilitarPermisosAlta(bool esAlta)
        {
            btn_GenerarCodigo.Visible = esAlta;
            txt_CodigoProductoIngresado.Enabled = esAlta;
            cmb_TiposProductos.Visible = esAlta;
            lbl_TipoProducto.Visible = esAlta;
        }
        #endregion

        /// <summary>
        /// Muestra la imagen ingresada del campo ulr imagen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_UrlImagenProducto_TextChanged(object sender, EventArgs e)
        {
            pb_ImagenProducto.ImageLocation = txt_UrlImagenProducto.Text;
        }

        /// <summary>
        /// Confirma accion, valida antes
        /// si es valido confirma ALTA o MODIFICACION
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Carga los campos asignados al clickear en un producto, sirve para ahorro de tipeo
        /// Tambien muestra su imagen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lst_Codigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_CodigoProductoIngresado.Text = lst_Codigo.SelectedItem.ToString();
            Producto productoSeleccionado = CoreDelSistema.ListaProductos.Where(p => p.Codigo == lst_Codigo.SelectedItem.ToString()).FirstOrDefault();
            if (productoSeleccionado != null)
            {
                Console.Beep();
                CargarCamposConInfoProducto(productoSeleccionado);
                pb_ImagenProducto.ImageLocation = productoSeleccionado.UrlImagen;
            }
        }

        /// <summary>
        /// Boton salir de la pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Console.Beep(500,100);
            this.Close();
        }
    }
}
