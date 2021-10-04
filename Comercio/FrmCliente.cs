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

namespace Comercio
{
    public partial class FrmCliente : Form
    {
        private Cliente clienteSeleccionado;

        #region CONSTRUCTOR

        public FrmCliente()
        {
            InitializeComponent();
        }
        #endregion

        /// <summary>
        /// Limpias los campoos asignados
        /// </summary>
        private void LimpiarCampos()
        {
            txt_DniIngresado.Text = "";
            txt_NombreIngresado.Text = "";
            txt_ApellidoIngresado.Text = "";
            txt_BilleteraIngresada.Text = "";
        }

        #region EVENTOS
        /// <summary>
        /// Evento load, inicializa el forms en tamaño, sin dejar ver la parte de alta-modificacion
        /// establece minimo y maximo de tamaño pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCliente_Load(object sender, EventArgs e)
        {
            Size = new Size(767, 308);
            MinimumSize = Size;
            MaximumSize = new Size(767, 457);
        }
        #endregion

        #region BUSCAR DNI - OBTENER DNI
        /// <summary>
        /// boton que Busca el dni ingresado y lo carga a al lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_BuscarDni_Click(object sender, EventArgs e)
        {
            if (CoreDelSistema.ListaClientes.ContainsKey(txt_DniABuscar.Text))
            {
                Console.Beep();
                lbl_DniNoEncontrado.Visible = false;
                this.clienteSeleccionado = CoreDelSistema.ListaClientes[txt_DniABuscar.Text];
                dgv_ListadoClientes.Rows.Clear();
                CargarCliente(this.clienteSeleccionado);
            }
            else
            {
                lbl_DniNoEncontrado.Visible = true;
            }
        }

        /// <summary>
        /// Obtiene el dni del cliente seleccionado por el data grid
        /// </summary>
        /// <returns></returns>
        private string GetDniClientePorDataGrid()
        {
            if (CoreDelSistema.ListaClientes.ContainsKey(this.dgv_ListadoClientes.CurrentRow.Cells[0].Value.ToString()))
            {
                return this.dgv_ListadoClientes.CurrentRow.Cells[0].Value.ToString();
            }
            else
            {
                HabilitarABMCliente(false);
                lbl_DatoCapturado.BackColor = Color.Red;
                lbl_DatoCapturado.Text = "Error al querer obtener datos del Usuario seleccionado";
            }
            return string.Empty;
        }
        #endregion

        #region SELECCIONAR CLIENTE

        /// <summary>
        /// Verifica que se haya seleccionado un cliente y captura sus datos
        /// inicializa cliente seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_ListadoClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {
                // aca deveria preguntar si el combo box está seleccionado algo
                if(GetDniClientePorDataGrid() != string.Empty)
                {
                    Console.Beep();
                    Size = new Size(751, 273);
                    this.clienteSeleccionado = CoreDelSistema.ListaClientes[GetDniClientePorDataGrid()];
                    lbl_DatoCapturado.BackColor = Color.Transparent;
                    lbl_DatoCapturado.Text = ($"Cliente seleccionado: {this.clienteSeleccionado.Nombre} {this.clienteSeleccionado.Apellido}");

                    HabilitarABMCliente(true);
                }
            }
            catch
            {
                lbl_DatoCapturado.BackColor = Color.Red;
                lbl_DatoCapturado.Text = "ERROR al querer capturar datos del cliente selecionado";
            }
        }

        #endregion

        #region VER Y CARGAR CLIENTES
        /// <summary>
        /// Boton que muestra todos los clientes cargados en sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_VerTodosClientes_Click(object sender, EventArgs e)
        {
            this.CargarClientes();
        }
        /// <summary>
        /// Carga un cliente a la lista
        /// </summary>
        /// <param name="cliente"></param>
        private void CargarCliente(Cliente cliente)
        {
            if (cliente != null)
            {
                dgv_ListadoClientes.Rows.Add($"{cliente.Dni}",
                                             $"{cliente.Nombre}",
                                             $"{cliente.Apellido}",
                                             $"{cliente.Billetera}",
                                             $"{cliente.CantidadCompras}");
            }
        }
        /// <summary>
        /// Carga todos los clientes a la lista
        /// </summary>
        private void CargarClientes()
        {
            dgv_ListadoClientes.Rows.Clear();
            foreach (KeyValuePair<string, Cliente> item in CoreDelSistema.ListaClientes)
            {
                this.CargarCliente(item.Value);
            }
        }
        #endregion

        #region VER COMPRAS CLIENTE SELECCIONADO
        /// <summary>
        /// Te lleva al forms de compras totales y muestra historial de compras del cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_VerCompras_Click(object sender, EventArgs e)
        {
            if (this.clienteSeleccionado != null)
            {
                FrmComprasTotalesCliente formComprasTotalesCliente = new FrmComprasTotalesCliente(this.clienteSeleccionado);
                Console.Beep();
                formComprasTotalesCliente.ShowDialog();
            }
            else
                MessageBox.Show("No se a seleccionado un Cliente", "Error al querer ver compras del Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region VALIDACIONES Y PERMISOS
        /// <summary>
        /// Habilita modificaion y eliminar y ver compras o no, dependiendo el valor de parametro
        /// </summary>
        /// <param name="estado"></param>
        private void HabilitarABMCliente(bool estado)
        {
            btn_Modificar.Enabled = estado;
            btn_Eliminar.Enabled = estado;
            btn_VerCompras.Enabled = estado;
        }
        /// <summary>
        /// Si edita y deja vacio el txt del dni a buscar se bloquea boton buscar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_DniABuscar_TextChanged(object sender, EventArgs e)
        {
            if (txt_DniABuscar.Text != string.Empty) { btn_BuscarDni.Enabled = true; } else { btn_BuscarDni.Enabled = false; }
        }

        /// <summary>
        /// Verifica campos asignados para alta o modificacion cliente
        /// </summary>
        /// <returns></returns>
        private bool VerificarCamposCliente()
        {
            float billeteraValida;
            if (txt_DniIngresado.Text != string.Empty &&
            txt_NombreIngresado.Text != string.Empty &&
            txt_ApellidoIngresado.Text != string.Empty &&
            float.TryParse(txt_BilleteraIngresada.Text, out billeteraValida) &&
            billeteraValida > 0 &&
            Usuario.EsValidoDni(txt_DniIngresado.Text))
            {
                lbl_Error.Visible = false;
                return true;
            }
            else
            {
                lbl_Error.Visible = true;
                return false;
            }
        }
        #endregion

        #region ALTA DE UN CLIENTE

        /// <summary>
        /// Redimensiona la pantalla y muestra menu de alta cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            lbl_AccionARealizar.Text = "ALTA DE UN CLIENTE";
            btn_ConfirmarModificacion.Enabled = false;
            txt_DniIngresado.Enabled = true;
            Size = new Size(767, 457);
        }
        /// <summary>
        /// Verifican y confirma el alta del cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ConfirmarAlta_Click(object sender, EventArgs e)
        {
            if (VerificarCamposCliente())
            {
                Cliente clienteAgregado = new Cliente(txt_NombreIngresado.Text,
                                                      txt_ApellidoIngresado.Text,
                                                      txt_DniIngresado.Text,
                                                      float.Parse(txt_BilleteraIngresada.Text));
                if(clienteAgregado != null)
                {
                    Console.Beep();
                    Size = new Size(767, 308);
                    CoreDelSistema.ListaClientes.Add(txt_DniIngresado.Text, clienteAgregado);
                    btn_ConfirmarAlta.Enabled = true;

                    lbl_DatoCapturado.BackColor = Color.Lime;
                    lbl_DatoCapturado.Text = "ALTA DEL CLIENTE CON ÉXITO";
                    dgv_ListadoClientes.Rows.Clear();
                    CargarCliente(clienteAgregado);
                }
            }
        }
        #endregion

        #region ELIMINAR CLIENTE

        /// <summary>
        /// Da aviso si queres confirmar baja del cliente y realiza o no dependiendo la opcion elegida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if(this.clienteSeleccionado != null &&
               MessageBox.Show($"{this.clienteSeleccionado.MostrarDatosCompletos()}\nDesea confirmar la baja?", "Confirmacion, baja Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes &&
               CoreDelSistema.ListaClientes.Remove(this.clienteSeleccionado.Dni))
            {
                Size = new Size(767, 308);
                lbl_DatoCapturado.BackColor = Color.Lime;
                lbl_DatoCapturado.Text = "CLIENTE ELIMINADO";
                Console.Beep(500,200);
                this.clienteSeleccionado = new Cliente();
                this.HabilitarABMCliente(false);
                CargarClientes();
            }
        }
        #endregion

        #region MODIFICAR CLIENTE
        /// <summary>
        /// Redimensiona pantalla y muestra menu modificar cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if(this.clienteSeleccionado != null)
            {
                lbl_AccionARealizar.Text = "MODIFICACION DEL CLIENTE";
                Size = new Size(767, 457);
                btn_ConfirmarModificacion.Enabled = true;
                btn_ConfirmarAlta.Enabled = false;

                txt_DniIngresado.Text = this.clienteSeleccionado.Dni;
                txt_DniIngresado.Enabled = false;
                txt_NombreIngresado.Text = this.clienteSeleccionado.Nombre;
                txt_ApellidoIngresado.Text = this.clienteSeleccionado.Apellido;
                txt_BilleteraIngresada.Text = this.clienteSeleccionado.Billetera.ToString();
            }
            else
            {
                lbl_DatoCapturado.BackColor = Color.Red;
                lbl_DatoCapturado.Text = "No se a seleccionado un cliente a modificar";
            }
        }

        /// <summary>
        /// Verifica y confirma la modiificacion del cliente de ser valido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ConfirmarModificacion_Click(object sender, EventArgs e)
        {
            if(this.clienteSeleccionado != null && VerificarCamposCliente())
            {
                this.clienteSeleccionado.Dni = txt_DniIngresado.Text;
                this.clienteSeleccionado.Nombre = txt_NombreIngresado.Text;
                this.clienteSeleccionado.Apellido = txt_ApellidoIngresado.Text;
                this.clienteSeleccionado.Billetera = float.Parse(txt_BilleteraIngresada.Text);

                lbl_DatoCapturado.BackColor = Color.Lime;
                lbl_DatoCapturado.Text = "SE A MODIFICADO EL CLIENTE CORRECTAMENTE";
                Console.Beep();
                dgv_ListadoClientes.Rows.Clear();
                CargarCliente(this.clienteSeleccionado);
                Size = new Size(767, 308);
            }
        }
        #endregion
    }
}
