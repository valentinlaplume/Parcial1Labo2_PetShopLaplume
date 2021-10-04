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
    public partial class FrmPrincipalMenu : Form
    {
        public FrmPrincipalMenu()
        {
            InitializeComponent();
        }

        public FrmPrincipalMenu(Usuario usuarioLogeado) : this()
        {
            if(usuarioLogeado != null)
                CoreDelSistema.UsuarioLogeado = usuarioLogeado;
        }

        private void FrmPrincipalMenu_Load(object sender, EventArgs e)
        {
            if (CoreDelSistema.UsuarioLogeado.TipoUsuario is EnumTipoUsuario.Administrador)
            {
                BackColor = Color.FromArgb(51, 70, 116); 
            }
            else { BackColor = Color.FromArgb(159, 187, 240); }

            pb_FotoUsuarioLogeado.ImageLocation = CoreDelSistema.UsuarioLogeado.UrlImagen;
            lbl_LegajoUsuarioLogeado.Text = $"Legajo: {CoreDelSistema.UsuarioLogeado.Legajo}";
            MinimumSize = Size;
            MaximumSize = Size;
            AccesosEmpleado();
        }

        #region Accesos segun rango
        public void AccesosEmpleado()
        {
            if (CoreDelSistema.UsuarioLogeado.TipoUsuario is EnumTipoUsuario.Empleado)
            {
                pb_MenuTrabajadora.Enabled = false;
                pb_ListadoGanancias.Enabled = false;
            }
            else
            {
                pb_MenuTrabajadora.Enabled = true;
                pb_ListadoGanancias.Enabled = true;
            }
        }
        #endregion

        private void pb_MenuTrabajadora_Click(object sender, EventArgs e)
        {
            FrmABMTrabajador formBaseUsuario = new FrmABMTrabajador();
            formBaseUsuario.ShowDialog();
        }

        private void pb_MenuCliente_Click(object sender, EventArgs e)
        {
            FrmCliente formCliente = new FrmCliente();
            formCliente.ShowDialog();
        }

        private void pb_MenuVentas_Click(object sender, EventArgs e)
        {
            FrmVender formVender = new FrmVender();
            formVender.ShowDialog();
        }

        private void pb_MenuProductos_Click(object sender, EventArgs e)
        {
            FrmABMProducto formABMProducto = new FrmABMProducto();
            formABMProducto.ShowDialog();
        }

        private void pb_CerrarSesion_Click(object sender, EventArgs e)
        {
            FrmLogin formLogin = new FrmLogin();
            this.Close();
            formLogin.Show();
        }

        private void pb_ListadoGanancias_Click(object sender, EventArgs e)
        {
            FrmComprasTotalesCliente frmComprasTotalesCliente = new FrmComprasTotalesCliente(true);
            frmComprasTotalesCliente.Show();
        }
    }
}
