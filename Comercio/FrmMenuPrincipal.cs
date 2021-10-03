using EntidadesComercio;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Comercio
{
    public partial class FrmMenuPrincipal : Form
    {
        #region Constructores

        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        public FrmMenuPrincipal(Usuario usuarioLogeado)
        {
            if (usuarioLogeado != null)
            {
                InitializeComponent();
                Usuario.UsuarioLogeado = usuarioLogeado;
            }
        }
        #endregion

        #region Accesos segun rango
        public void AccesosEmpleado()
        {
            if (Usuario.UsuarioLogeado.TipoUsuario is EnumTipoUsuario.Empleado)
            {
                tsr_AltaAdministrador.Enabled = false;
                tsr_AltaEmpleado.Enabled = false;
                tsr_BajaAdministrador.Enabled = false;
                tsr_BajaEmpleado.Enabled = false;
                tsr_ModificarAdministrador.Enabled = false;
                tsr_ModificarEmpleado.Enabled = false;
            }
        }
        #endregion

        #region Activar color forms MDI

        private void CambiarColorFormsMDI(Usuario usuarioLogueado)
        {
            if (usuarioLogueado != null)
            {
                if(Usuario.UsuarioLogeado.TipoUsuario == EnumTipoUsuario.Administrador)
                    ActivarColorFormsMDI(Color.Black);
                else if(Usuario.UsuarioLogeado.TipoUsuario == EnumTipoUsuario.Empleado)
                    ActivarColorFormsMDI(Color.White);
            }
        }

        private void ActivarColorFormsMDI(Color colorElegido)
        {
            MdiClient oMDI;
            //recorremos todos los controles hijos del formulario
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    // Intentamos castear el objeto MdiClient
                    oMDI = (MdiClient)ctl;

                    // Cuando sea casteado con éxito, podremos cambiar el color así
                    oMDI.BackColor = colorElegido;
                }
                catch (InvalidCastException exc)
                {
                    // No hacemos nada cuando el control no sea tupo MdiClient
                }
            }
        }
        #endregion

        #region Eventos

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            AccesosEmpleado();
            MinimumSize = Size;
            MaximumSize = Size;
            CambiarColorFormsMDI(Usuario.UsuarioLogeado);
            //txt_InfoUsuario.Text = Usuario.usuarioLogeado.SaludarUsuario();
        }


        #endregion


        private void tsr_RealizarVenta_Click(object sender, EventArgs e)
        {
            FrmVender formVender = new FrmVender();
            //formVender.MdiParent = this;
            formVender.ShowDialog();
        }

        private void tsr_cerrarSesión_Click(object sender, EventArgs e)
        {
            FrmLogin formLogin = new FrmLogin();
            this.Close();
            //this.Hide();
            formLogin.ShowDialog();
        }

        private void tsr_VerStock_Click(object sender, EventArgs e)
        {
            FrmABMProducto formABMProducto = new FrmABMProducto();
            //formStock.MdiParent = this;
            formABMProducto.ShowDialog();
        }

        private void tsr_modificarProducto_Click(object sender, EventArgs e)
        {
            
            

        }

        private void FrmMenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void CerrarForms()
        {
            foreach (Form frm in System.Windows.Forms.Application.OpenForms)
            {
                if (frm != this)    //Cerramos todos los formularios menos el formulario principal que contiene el menú
                    frm.Close();
            }
        }

        private void tsr_ListarUsuarios_Click(object sender, EventArgs e)
        {
            FrmABMTrabajador formBaseUsuario = new FrmABMTrabajador();
            formBaseUsuario.ShowDialog();
        }

        private void verInformacionDelUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente formCliente = new FrmCliente();
            formCliente.ShowDialog();
        }

    }
}
