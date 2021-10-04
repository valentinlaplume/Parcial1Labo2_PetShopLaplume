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
        private void LimpiarTodosLosCampos()
        {
            LimpiarCampos();
            lst_Carrito.Items.Clear();
            lbl_TotalCompra.Text = "0";
        }

        private void LimpiarCampos()
        {
            txt_CantidadProductoIngresado.Text = "";
            txt_CodigoProductoIngresado.Clear();
            txt_DniClienteIngresado.Clear();
            LimpiarListasProductos();
        }
        #endregion

        #region Eventos
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

        private void CargarPorPrimeraVezClienteOriginal()
        {
            if (flagClienteOriginal == false)
            {
                clienteOriginal = buscarCliente(txt_DniClienteIngresado.Text.Trim());
                if (clienteOriginal != null)
                    flagClienteOriginal = true;
            }
        }

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

                            }else { MessageBox.Show("No hay suficiente stock", "Falta de stock", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                        }
                    } else { MessageBox.Show("Producto no encontrado, asegurese de que el codigo sea válido", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }else { MessageBox.Show("Es necesario completar todos los campos", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        #region VENDER POR EFECTIVO - POR QR
        private void btn_Vender_Click(object sender, EventArgs e)
        {
            if (clienteOriginal != null)
            {
                float billeteraActual = clienteOriginal.Billetera - float.Parse(lbl_TotalCompra.Text);
                if (billeteraActual > -1)
                    ConfirmarVenta(false, billeteraActual);
                else { MessageBox.Show($"No tiene suficiente dinero.\n{clienteOriginal.MostrarDatosCompletos()}Saldo negativo: ${billeteraActual}", "¡Cliente sin dinero!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
        }

        private void btn_VenderPorQr_Click(object sender, EventArgs e)
        {
            if (clienteOriginal != null)
            {
                ConfirmarVenta(true, 0);
            }
        }

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

        private void ConsultarDescargaTicket(Factura facturaADescargar)
        {
            if (MessageBox.Show($" > TICKET DE COMPRA <\n{facturaAux.RetornarFactura()}\n > Desea descargar ticket?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TextWriter ticket = new StreamWriter($"TicketPetShopLaplume{facturaAux.Numero}.txt");
                //ticket.WriteLine(cliente.MostrarDatosCompletosConFactura(cliente));
                ticket.Close();
            }
        }


        private void btn_DarAltaCliente_Click(object sender, EventArgs e)
        {
            FrmCliente formCliente = new FrmCliente();
            formCliente.ShowDialog();
        }

        private void pb_CerrarAplicacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ReiniciarCarrito_Click(object sender, EventArgs e)
        {
            lst_Carrito.Items.Clear();
            this.detalleFacturaAux = new List<DetalleFactura>();
            lbl_TotalCompra.Text = "0";
        }

        private void lst_Codigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_CodigoProductoIngresado.Text = lst_Codigo.SelectedItem.ToString();
            Producto productoSeleccionado = CoreDelSistema.ListaProductos.Where(p => p.Codigo == lst_Codigo.SelectedItem.ToString()).FirstOrDefault();
            if (productoSeleccionado != null)
            {
                pb_FotoProducto.ImageLocation = productoSeleccionado.UrlImagen;
            }
        }



        private void btn_VerQr_Click(object sender, EventArgs e)
        {
            FrmCodigoQr formQr = new FrmCodigoQr();
            formQr.Show();
        }
    }
}
