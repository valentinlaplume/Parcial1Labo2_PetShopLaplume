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
             Usuario.UsuarioLogeado = usuarioLogeado;
        }

        private void FrmPrincipalMenu_Load(object sender, EventArgs e)
        {
            MinimumSize = Size;
            MaximumSize = Size;
            AccesosEmpleado();
        }

        #region Accesos segun rango
        public void AccesosEmpleado()
        {
            if (Usuario.UsuarioLogeado.TipoUsuario is EnumTipoUsuario.Empleado)
                pb_MenuTrabajadora.Enabled = false;
            else
                pb_MenuTrabajadora.Enabled = true;
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

    }
}
