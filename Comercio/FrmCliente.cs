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

        private void LimpiarCampos()
        {
            txt_DniIngresado.Text = "";
            txt_NombreIngresado.Text = "";
            txt_ApellidoIngresado.Text = "";
            txt_BilleteraIngresada.Text = "";
        }

        #region EVENTOS
        private void FrmCliente_Load(object sender, EventArgs e)
        {
            Size = new Size(767, 308);
            MinimumSize = Size;
            MaximumSize = new Size(767, 457);
        }
        #endregion

        #region BUSCAR DNI - OBTENER DNI
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
        private void btn_VerTodosClientes_Click(object sender, EventArgs e)
        {
            this.CargarClientes();
        }
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
        private void HabilitarABMCliente(bool estado)
        {
            btn_Modificar.Enabled = estado;
            btn_Eliminar.Enabled = estado;
            btn_VerCompras.Enabled = estado;
        }
        private void txt_DniABuscar_TextChanged(object sender, EventArgs e)
        {
            if (txt_DniABuscar.Text != string.Empty) { btn_BuscarDni.Enabled = true; } else { btn_BuscarDni.Enabled = false; }
        }

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

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            lbl_AccionARealizar.Text = "ALTA DE UN CLIENTE";
            btn_ConfirmarModificacion.Enabled = false;
            txt_DniIngresado.Enabled = true;
            Size = new Size(767, 457);
        }

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
