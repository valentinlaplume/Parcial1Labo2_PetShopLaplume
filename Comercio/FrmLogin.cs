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

        /// <summary>
        /// Evento load, carga usuarios y pacta tamaño de forms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            MinimumSize = Size;
            MaximumSize = Size;
            LimpiarControles();
            CargarUsuariosAlComboBox();
        }

        
        #region Metodos

        /// <summary>
        /// Carga usuarios al combo box
        /// </summary>
        private void CargarUsuariosAlComboBox()
        {
            foreach (KeyValuePair<string, Usuario> item in CoreDelSistema.ListaUsuarios)
            {
                cmb_Usuario.Items.Add(item.Value.UsuarioPropiedad);
            }
        }

        /// <summary>
        /// Limpia los controles asignados
        /// </summary>
        private void LimpiarControles()
        {
            llb_Autocompletar.Visible = false;
            cmb_Usuario.Text = string.Empty;
            txt_Contraseña.Text = string.Empty;
        }

        /// <summary>
        /// Barra de cargando menu principal
        /// </summary>
        /// <returns></returns>
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


        /// <summary>
        /// Boton que inicia sesion de trabajador y verifica datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_IniciarSesion_Click(object sender, EventArgs e)
        {
            if (Usuario.EsUsuario(cmb_Usuario.Text, txt_Contraseña.Text))
            {
                Console.Beep();
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
        /// <summary>
        /// Selecciona usuarios registrados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Autocompleta logeo del usuario con su constraseña       
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void llb_Autocompletar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Usuario usuarioAux = Usuario.BuscarUsuario(cmb_Usuario.Text);
            if (usuarioAux != null)
                txt_Contraseña.Text = usuarioAux.Contraseña;
            else
                MessageBox.Show("No fue posible encontrar Usuario", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// Cierra la aplicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pb_CerrarAplicacion_Click(object sender, EventArgs e)
        {
            Console.Beep(500,200);
            this.Close();
        }
    }
    #endregion
}

