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

        private void btn_Reiniciar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void pb_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void FrmAltaTrabajador_Load(object sender, EventArgs e)
        {
            cmb_TipoUsuarios.Items.Add(EnumTipoUsuario.Administrador);
            cmb_TipoUsuarios.Items.Add(EnumTipoUsuario.Empleado);
        }

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
                    Usuario.ListaUsuarios.Add(txt_DniIngresado.Text, administradorAgregado);
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
                    Usuario.ListaUsuarios.Add(txt_DniIngresado.Text, empleadoAgregado);
                    MessageBox.Show($"{empleadoAgregado.MostrarDatosCompletos()}\n - Alta confirmada");
                }
            }
        }
        #endregion



    }
}
