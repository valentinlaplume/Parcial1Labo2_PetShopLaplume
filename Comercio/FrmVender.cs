using EntidadesComercio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ventas;

namespace Comercio
{
    public partial class FrmVender : FrmBaseProductos
    {
        private List<DetalleFactura> detalleFacturaAux;
        private Factura facturaAux;
        private Cliente clienteOriginal;
        private bool flagClienteOriginal;

        #region Constructores
        public FrmVender()
        {
            detalleFacturaAux = new List<DetalleFactura>();
            flagClienteOriginal = false;
            InitializeComponent();
        }
        #endregion

        #region Limpiar
        /// <summary>
        /// Limpia por completa la pantalla, campos, listas
        /// </summary>
        private void LimpiarTodosLosCampos()
        {
            LimpiarCampos();
            lst_Carrito.Items.Clear();
            lbl_TotalCompra.Text = "0";
        }
        /// <summary>
        /// Limpia campos asignados
        /// </summary>
        private void LimpiarCampos()
        {
            txt_CantidadProductoIngresado.Text = "";
            txt_CodigoProductoIngresado.Clear();
            txt_DniClienteIngresado.Clear();
            LimpiarListasProductos();
        }
        #endregion


        private Cliente buscarCliente(string dni)
        {
            if (!string.IsNullOrEmpty(dni) && Usuario.EsValidoDni(dni))
            {
                foreach (KeyValuePair<string, Cliente> item in CoreDelSistema.ListaClientes)
                {
                    if (item.Value.Dni == dni)
                        return item.Value;
                }
            }
            return new Cliente();
        }

        #region VALIDACIONES
        /// <summary>
        /// Valida los campos de venta, que no sean vacios y ingreso valido
        /// </summary>
        /// <returns></returns>
        private bool ValidarCamposVenta()
        {
            if (!string.IsNullOrEmpty(txt_CodigoProductoIngresado.Text) &&
                 !string.IsNullOrEmpty(txt_CantidadProductoIngresado.Text) &&
                 Producto.EsValidoCantidadProducto(txt_CantidadProductoIngresado.Text) &&
                 !string.IsNullOrEmpty(txt_DniClienteIngresado.Text) &&
                 Usuario.EsValidoDni(txt_DniClienteIngresado.Text))
            {
                btn_VenderPorQr.Enabled = true;
                btn_Vender.Enabled = true;
                return true;
            }

            btn_VenderPorQr.Enabled = false;
            btn_Vender.Enabled = false;
            return false;
        }
        #endregion

        /// <summary>
        /// Carga por primera vez al cliente original
        /// </summary>
        private void CargarPorPrimeraVezClienteOriginal()
        {
            if (flagClienteOriginal == false)
            {
                clienteOriginal = buscarCliente(txt_DniClienteIngresado.Text.Trim());
                if (clienteOriginal != null)
                    flagClienteOriginal = true;
            }
        }

        /// <summary>
        /// Verifica si se cambio de cliente y pregunta si quiere cambiarlo del original
        /// si dice si entonces se limpia la pantalla y resetea compra
        /// </summary>
        /// <param name="dni"></param>
        /// <returns>true si cambio de cliente, false si no cambio</returns>
        private bool SeCambioDeClienteVenta(string dni)
        {
            if(!string.IsNullOrEmpty(dni))
            {
                // Verifica que no se haya cambiado de Cliente
                Cliente clienteNuevo = buscarCliente(txt_DniClienteIngresado.Text.Trim());
                if (clienteNuevo != null && clienteNuevo.Dni != clienteOriginal.Dni)
                {
                    if (MessageBox.Show("A cambiado de Cliente, desea cancelar la anterior venta?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        txt_DniClienteIngresado.Text = clienteNuevo.Dni;
                        clienteOriginal = clienteNuevo; // Se cambia el nuevo
                        detalleFacturaAux = new List<DetalleFactura>();
                        facturaAux = new Factura();
                        LimpiarTodosLosCampos();
                        Console.Beep(5500, 100);
                        return true;
                    }
                    else
                    {
                        // Si no desea cambiar, se vuelve al dni con el que inició la compra
                        txt_DniClienteIngresado.Text = clienteOriginal.Dni;
                        return false;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Agrega al carrito de compra un producto
        /// verifica billetera, valida campos, que el producto ingresado sea valido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AgregarAlCarrito_Click(object sender, EventArgs e)
        {
            if (ValidarCamposVenta())
            {
                CargarPorPrimeraVezClienteOriginal(); // La primera vez va a cargar el Cliente original
                if (clienteOriginal != null && !SeCambioDeClienteVenta(txt_DniClienteIngresado.Text.Trim()))
                {
                    Producto productoAgregado = Producto.BuscarProducto(txt_CodigoProductoIngresado.Text);
                    if (productoAgregado != null)
                    {
                        pb_FotoProducto.ImageLocation = productoAgregado.UrlImagen;
                        if (Producto.EsValidoCantidadProducto(txt_CantidadProductoIngresado.Text.Trim()))
                        {
                            pb_FotoProducto.ImageLocation = productoAgregado.UrlImagen; // muestro imagen producto
                            int cantidadActualEnStock = productoAgregado.Cantidad - int.Parse(txt_CantidadProductoIngresado.Text);
                            if (cantidadActualEnStock > -1) // valido que quede stock
                            {
                                // Al producto agregado le asigno la cantidad actual en stock
                                productoAgregado.Cantidad = cantidadActualEnStock;

                                // Se actualizan listas por el descuento de stock
                                CargarListasPorTipoProducto(productoAgregado.TipoProducto);

                                DetalleFactura detalleAux = new DetalleFactura(int.Parse(txt_CantidadProductoIngresado.Text), productoAgregado.Nombre, productoAgregado.PrecioUnitario);
                                detalleFacturaAux.Add(detalleAux);

                                float total = (float.Parse(lbl_TotalCompra.Text) + detalleAux.TotalDetalle);
                                lbl_TotalCompra.Text = total.ToString();

                                StringBuilder carrito = new StringBuilder();
                                carrito.Append(detalleAux.DatosDetalle());
                                lst_Carrito.Items.Add(carrito.ToString()); // Agrego a la lista del carrito el producto
                                Console.Beep(500,100);
                            }
                            else { MessageBox.Show("No hay suficiente stock", "Falta de stock", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                        }
                    } else { MessageBox.Show("Producto no encontrado, asegurese de que el codigo sea válido", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }else { MessageBox.Show("Es necesario completar todos los campos", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        #region VENDER POR EFECTIVO - POR QR
        /// <summary>
        /// Vende por efectivo y descuenta de la billetera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Vender_Click(object sender, EventArgs e)
        {
            if (clienteOriginal != null)
            {
                float billeteraActual = clienteOriginal.Billetera - float.Parse(lbl_TotalCompra.Text);
                if (billeteraActual > -1)
                {
                    ConfirmarVenta(false, billeteraActual);
                }
                else { MessageBox.Show($"No tiene suficiente dinero.\n{clienteOriginal.MostrarDatosCompletos()}Saldo negativo: ${billeteraActual}", "¡Cliente sin dinero!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
        }

        /// <summary>
        /// Vende por Codigo Qr mercado pago 
        /// no descuenta la billetera ya que la verificacion está desde lo personal y
        /// puede ser por debito, credito o mismo plata de mercadopago
        /// pd :(Es valido y real el codigo)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_VenderPorQr_Click(object sender, EventArgs e)
        {
            if (clienteOriginal != null)
            {
                ConfirmarVenta(true, 0);
            }
        }

        /// <summary>
        /// Confirma la venta dependiento si se vende por efectivo o Qr
        /// realiza el descuento de billetera o no
        /// </summary>
        /// <param name="porQr"></param>
        /// <param name="billeteraActual"></param>
        private void ConfirmarVenta(bool porQr, float billeteraActual)
        {
            if(clienteOriginal != null)
            {
                if (MessageBox.Show($"Desea confirmar venta a:\n{clienteOriginal.MostrarDatosCompletos()}", "Confirmacion de venta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    facturaAux = new Factura(DateTime.Now, detalleFacturaAux); // cargo carrito de compra a la factura

                    if (porQr == false) // si no es por qr entonces le descuento de la billetera
                        clienteOriginal.Billetera = billeteraActual;

                    clienteOriginal.Facturas.Add(facturaAux);

                    if (CoreDelSistema.UsuarioLogeado.TipoUsuario is EnumTipoUsuario.Empleado)
                    {
                        Empleado emp = (Empleado)CoreDelSistema.UsuarioLogeado;
                        emp.CantidadVentas++;
                    }

                    LimpiarTodosLosCampos();
                    ConsultarDescargaTicket(facturaAux); // consulto si desea descargar ticket
                    detalleFacturaAux = new List<DetalleFactura>();
                }
            }
        }

        #endregion
        /// <summary>
        /// Consulta si desea descargar ticker, de ser asi se descarga en un archivo .txt 
        /// como nombre es TicketPetShopLaplume - (el numero de factura)
        /// </summary>
        /// <param name="facturaADescargar"></param>
        private void ConsultarDescargaTicket(Factura facturaADescargar)
        {
            if (MessageBox.Show($" > TICKET DE COMPRA <\n{facturaAux.RetornarFactura()}\n > Desea descargar ticket?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TextWriter ticket = new StreamWriter($"TicketPetShopLaplume-{facturaAux.Numero}.txt");
                //ticket.WriteLine(cliente.MostrarDatosCompletosConFactura(cliente));
                ticket.Close();
            }
        }

        /// <summary>
        /// Boton que muestra abm de cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DarAltaCliente_Click(object sender, EventArgs e)
        {
            FrmCliente formCliente = new FrmCliente();
            formCliente.ShowDialog();
        }

        /// <summary>
        /// Cierra pantalla ventas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pb_CerrarAplicacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Reincia la compra, construyo nuevo detalle de compra
        /// limpia campos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ReiniciarCarrito_Click(object sender, EventArgs e)
        {
            lst_Carrito.Items.Clear();
            this.detalleFacturaAux = new List<DetalleFactura>();
            lbl_TotalCompra.Text = "0";
        }

        /// <summary>
        /// Al seleccionar un codigo se asigna en el campo de codigoIngresado
        /// se muestra la foto del producto seleccionado
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
                pb_FotoProducto.ImageLocation = productoSeleccionado.UrlImagen;
            }
        }

        /// <summary>
        /// Abre el forms con la foto del codigo qr 
        /// pd :(Es valido y real el codigo)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_VerQr_Click(object sender, EventArgs e)
        {
            FrmCodigoQr formQr = new FrmCodigoQr();
            Console.Beep();
            formQr.Show();
        }
    }
}
