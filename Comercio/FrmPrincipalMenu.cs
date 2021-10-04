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

        /// <summary>
        /// Constructor que inciializa usuario de logeo
        /// </summary>
        /// <param name="usuarioLogeado"></param>
        public FrmPrincipalMenu(Usuario usuarioLogeado) : this()
        {
            if(usuarioLogeado != null)
                CoreDelSistema.UsuarioLogeado = usuarioLogeado;
        }

        /// <summary>
        /// Evento que setea color dependiendo su rango
        /// Carga imagen de usuario logeado
        /// Pacta dimensiones de forms
        /// Da accesos segun rango de usuario logeado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Desabilita accesos de admin al empleado o viceversa
        /// </summary>
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

        /// <summary>
        /// Boton con el menu del usuario trabajador del PetShop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pb_MenuTrabajadora_Click(object sender, EventArgs e)
        {
            Console.Beep();
            FrmABMTrabajador formBaseUsuario = new FrmABMTrabajador();
            formBaseUsuario.ShowDialog();
        }
        /// <summary>
        /// Boton con el menu del cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pb_MenuCliente_Click(object sender, EventArgs e)
        {
            Console.Beep();
            FrmCliente formCliente = new FrmCliente();
            formCliente.ShowDialog();
        }
        /// <summary>
        /// Boton con el menu de ventas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pb_MenuVentas_Click(object sender, EventArgs e)
        {
            Console.Beep();
            FrmVender formVender = new FrmVender();
            formVender.ShowDialog();
        }

        /// <summary>
        /// Boton con el menu de productos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pb_MenuProductos_Click(object sender, EventArgs e)
        {
            Console.Beep();
            FrmABMProducto formABMProducto = new FrmABMProducto();
            formABMProducto.ShowDialog();
        }
        /// <summary>
        /// Cierra la aplicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pb_CerrarSesion_Click(object sender, EventArgs e)
        {
            Console.Beep(500, 100);
            FrmLogin formLogin = new FrmLogin();
            this.Close();
            formLogin.Show();
        }
        /// <summary>
        /// Boton que muestra el listado de ganancias del PetShop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pb_ListadoGanancias_Click(object sender, EventArgs e)
        {
            Console.Beep();
            FrmComprasTotalesCliente frmComprasTotalesCliente = new FrmComprasTotalesCliente(true);
            frmComprasTotalesCliente.Show();
        }
    }
}
