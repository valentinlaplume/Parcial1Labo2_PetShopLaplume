using EntidadesComercio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Comercio
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            MinimumSize = Size;
            MaximumSize = Size;
            LimpiarControles();
            CargarUsuariosAlComboBox();
        }

        
        #region Metodos


        private void CargarUsuariosAlComboBox()
        {
            foreach (KeyValuePair<string, Usuario> item in Usuario.ListaUsuarios)
            {
                cmb_Usuario.Items.Add(item.Value.UsuarioPropiedad);
            }
        }

        //private void pb_MinimizarAplicacion_Click(object sender, EventArgs e)
        //{
        //    this.WindowState = FormWindowState.Minimized;
        //}

        private void LimpiarControles()
        {
            llb_Autocompletar.Visible = false;
            cmb_Usuario.Text = string.Empty;
            txt_Contraseña.Text = string.Empty;
        }

        //private void cmb_Usuario_SelectedIndexChanged1(object sender, EventArgs e)
        //{
        //    if (cmb_Usuario.Text != string.Empty)
        //        llb_Autocompletar.Visible = true;
        //}

        public bool BarraInicioSesion()
        {
            prg_BarraInicioSesion.Minimum = 1;
            prg_BarraInicioSesion.Maximum = 10000;
            prg_BarraInicioSesion.Step = 2;
            for (int i = 0; i < 15000; i++)
            {
                prg_BarraInicioSesion.PerformStep();
                if (i == 14999)
                    return true;
            }
            return false;
        }

        //private void llb_Autocompletar_LinkClicked1(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    Usuario usuarioAux = Usuario.BuscarUsuarioPorNombreUsuario(cmb_Usuario.Text);
        //    if (usuarioAux != null)
        //        txt_Contraseña.Text = usuarioAux.Contraseña;
        //    else
        //        MessageBox.Show("No fue posible encontrar Usuario", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}

        private void btn_IniciarSesion_Click(object sender, EventArgs e)
        {
            if (Usuario.EsUsuario(cmb_Usuario.Text, txt_Contraseña.Text))
            {
                prg_BarraInicioSesion.Visible = true;
                Usuario user = Usuario.BuscarUsuario(cmb_Usuario.Text);
                FrmPrincipalMenu formPrincipalMenu = new FrmPrincipalMenu(user);
                if (BarraInicioSesion())
                {
                    formPrincipalMenu.Text = $"{formPrincipalMenu.Text} - {DateTime.Now} - {user.TipoUsuario} - {user.UsuarioPropiedad}";
                    formPrincipalMenu.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("No fue posible encontrar Usuario", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarControles();
            }
        }

        private void cmb_Usuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Usuario.Text != string.Empty)
            {
                Usuario usuarioAuxiliar = Usuario.BuscarUsuario(cmb_Usuario.Text);
                if (usuarioAuxiliar != null)
                    pb_ImagenPerfilUsuario.ImageLocation = usuarioAuxiliar.UrlImagen;

                llb_Autocompletar.Visible = true;
            }
        }

        private void llb_Autocompletar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Usuario usuarioAux = Usuario.BuscarUsuario(cmb_Usuario.Text);
            if (usuarioAux != null)
                txt_Contraseña.Text = usuarioAux.Contraseña;
            else
                MessageBox.Show("No fue posible encontrar Usuario", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void pb_CerrarAplicacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    #endregion
}

