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
    public partial class FrmAltaTrabajador : Form
    {

        public FrmAltaTrabajador()
        {
            InitializeComponent();
        }

        #region EVENTOS

        /// <summary>
        /// Limpia los campos, desabilita visibilidad del error en caso de que este
        /// y avisa con sonido la funcion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Reiniciar_Click(object sender, EventArgs e)
        {
            lbl_Error.Visible = false;
            Console.Beep();
            LimpiarCampos();
        }
        /// <summary>
        /// Evento carga tipo de usuario trabajador
        /// establece tamaño forms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAltaTrabajador_Load(object sender, EventArgs e)
        {
            cmb_TipoUsuarios.Items.Add(EnumTipoUsuario.Administrador);
            cmb_TipoUsuarios.Items.Add(EnumTipoUsuario.Empleado);
            MinimumSize = Size;
            MaximumSize = Size;
        }

        /// <summary>
        /// Limpia campos asignados
        /// </summary>
        private void LimpiarCampos()
        {
            txt_NombreIngresado.Text = "";
            txt_ApellidoIngresado.Text = "";
            txt_DniIngresado.Text = "";
            txt_UsuarioIngresado.Text = "";
            txt_ContraseñaIngresada.Text = "";
            txt_UrlFotoPerfilIngresada.Text = "";
            txt_SueldoIngresado.Text = "";
        }
        #endregion

        #region VALIDACIONES
        /// <summary>
        /// Valida los campos del alta que no seas vacion ni null
        /// que el sueldo sea valido y dni valido de 8 caracteres
        /// </summary>
        /// <returns></returns>
        private bool SonValidosCamposAlta()
        {
            float sueldoValido;
            if (cmb_TipoUsuarios.SelectedItem != null  &&
                !String.IsNullOrEmpty(txt_DniIngresado.Text) &&
                !String.IsNullOrEmpty(txt_NombreIngresado.Text) &&
                !String.IsNullOrEmpty(txt_ApellidoIngresado.Text) &&
                !String.IsNullOrEmpty(txt_UsuarioIngresado.Text) &&
                !String.IsNullOrEmpty(txt_ContraseñaIngresada.Text) &&
                float.TryParse(txt_SueldoIngresado.Text, out sueldoValido) && sueldoValido > 0 &&
                Usuario.EsValidoDni(txt_DniIngresado.Text) &&
                Usuario.EsValidoNombreUsuario(txt_UsuarioIngresado.Text))
            {
                lbl_Error.Visible = false;
                return true;
            }
            else
                lbl_Error.Visible = true;
            return false;
        }


        #endregion

        #region DAR DE ALTA
        /// <summary>
        /// Boton que confirma el alta, antes verifica 
        /// de ser valido muestra mensaje de confirmacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ConfirmarAltaTrabajador_Click(object sender, EventArgs e)
        {
            if(this.SonValidosCamposAlta())
            {

                if ((EnumTipoUsuario)cmb_TipoUsuarios.SelectedItem is EnumTipoUsuario.Administrador)
                {
                    Administrador administradorAgregado = new Administrador(txt_NombreIngresado.Text,
                                                                            txt_ApellidoIngresado.Text,
                                                                            txt_DniIngresado.Text,
                                                                            txt_UsuarioIngresado.Text,
                                                                            txt_ContraseñaIngresada.Text,
                                                                            float.Parse(txt_SueldoIngresado.Text),
                                                                            EnumTipoUsuario.Administrador,
                                                                            txt_UrlFotoPerfilIngresada.Text);
                    CoreDelSistema.ListaUsuarios.Add(txt_DniIngresado.Text, administradorAgregado);
                    Console.Beep();
                    MessageBox.Show($"{administradorAgregado.MostrarDatosCompletos()}\n - Alta confirmada");
                }
                else if ((EnumTipoUsuario)cmb_TipoUsuarios.SelectedItem is EnumTipoUsuario.Empleado)
                {
                    Empleado empleadoAgregado = new Empleado(txt_NombreIngresado.Text,
                                                                            txt_ApellidoIngresado.Text,
                                                                            txt_DniIngresado.Text,
                                                                            txt_UsuarioIngresado.Text,
                                                                            txt_ContraseñaIngresada.Text,
                                                                            float.Parse(txt_SueldoIngresado.Text),
                                                                            EnumTipoUsuario.Empleado, 
                                                                            0,
                                                                            txt_UrlFotoPerfilIngresada.Text);
                    CoreDelSistema.ListaUsuarios.Add(txt_DniIngresado.Text, empleadoAgregado);
                    Console.Beep();
                    MessageBox.Show($"{empleadoAgregado.MostrarDatosCompletos()}\n - Alta confirmada");
                }
            }
        }
        #endregion
    }
}
