
namespace Comercio
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsr_Alta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsr_AltaAdministrador = new System.Windows.Forms.ToolStripMenuItem();
            this.tsr_AltaEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.tsr_AltaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsr_Baja = new System.Windows.Forms.ToolStripMenuItem();
            this.tsr_BajaAdministrador = new System.Windows.Forms.ToolStripMenuItem();
            this.tsr_BajaEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.tsr_BajaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsr_Modificar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsr_ModificarAdministrador = new System.Windows.Forms.ToolStripMenuItem();
            this.tsr_ModificarEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.tsr_ModificarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsr_Listar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsr_ListarUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verInformacionDelUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verMiInformaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsr_cerrarSesión = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsr_agregarAlStock = new System.Windows.Forms.ToolStripMenuItem();
            this.tsr_modificarProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsr_VerStock = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsr_RealizarVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.ventasToolStripMenuItem1,
            this.informesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(914, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsr_Alta,
            this.tsr_Baja,
            this.tsr_Modificar,
            this.toolStripSeparator1,
            this.tsr_Listar,
            this.tsr_cerrarSesión});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(64, 20);
            this.toolStripMenuItem1.Text = "Usuarios";
            // 
            // tsr_Alta
            // 
            this.tsr_Alta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsr_AltaAdministrador,
            this.tsr_AltaEmpleado,
            this.tsr_AltaCliente});
            this.tsr_Alta.Name = "tsr_Alta";
            this.tsr_Alta.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tsr_Alta.Size = new System.Drawing.Size(180, 22);
            this.tsr_Alta.Text = "Dar de alta ";
            // 
            // tsr_AltaAdministrador
            // 
            this.tsr_AltaAdministrador.Name = "tsr_AltaAdministrador";
            this.tsr_AltaAdministrador.Size = new System.Drawing.Size(150, 22);
            this.tsr_AltaAdministrador.Text = "Administrador";
            // 
            // tsr_AltaEmpleado
            // 
            this.tsr_AltaEmpleado.Name = "tsr_AltaEmpleado";
            this.tsr_AltaEmpleado.Size = new System.Drawing.Size(150, 22);
            this.tsr_AltaEmpleado.Text = "Empleado";
            // 
            // tsr_AltaCliente
            // 
            this.tsr_AltaCliente.Name = "tsr_AltaCliente";
            this.tsr_AltaCliente.Size = new System.Drawing.Size(150, 22);
            this.tsr_AltaCliente.Text = "Cliente";
            // 
            // tsr_Baja
            // 
            this.tsr_Baja.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsr_BajaAdministrador,
            this.tsr_BajaEmpleado,
            this.tsr_BajaCliente});
            this.tsr_Baja.Name = "tsr_Baja";
            this.tsr_Baja.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.tsr_Baja.Size = new System.Drawing.Size(180, 22);
            this.tsr_Baja.Text = "Dar de baja";
            // 
            // tsr_BajaAdministrador
            // 
            this.tsr_BajaAdministrador.Name = "tsr_BajaAdministrador";
            this.tsr_BajaAdministrador.Size = new System.Drawing.Size(150, 22);
            this.tsr_BajaAdministrador.Text = "Administrador";
            // 
            // tsr_BajaEmpleado
            // 
            this.tsr_BajaEmpleado.Name = "tsr_BajaEmpleado";
            this.tsr_BajaEmpleado.Size = new System.Drawing.Size(150, 22);
            this.tsr_BajaEmpleado.Text = "Empleado";
            // 
            // tsr_BajaCliente
            // 
            this.tsr_BajaCliente.Name = "tsr_BajaCliente";
            this.tsr_BajaCliente.Size = new System.Drawing.Size(150, 22);
            this.tsr_BajaCliente.Text = "Cliente";
            // 
            // tsr_Modificar
            // 
            this.tsr_Modificar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsr_ModificarAdministrador,
            this.tsr_ModificarEmpleado,
            this.tsr_ModificarCliente});
            this.tsr_Modificar.Name = "tsr_Modificar";
            this.tsr_Modificar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.tsr_Modificar.Size = new System.Drawing.Size(180, 22);
            this.tsr_Modificar.Text = "Modificar";
            // 
            // tsr_ModificarAdministrador
            // 
            this.tsr_ModificarAdministrador.Name = "tsr_ModificarAdministrador";
            this.tsr_ModificarAdministrador.Size = new System.Drawing.Size(150, 22);
            this.tsr_ModificarAdministrador.Text = "Administrador";
            // 
            // tsr_ModificarEmpleado
            // 
            this.tsr_ModificarEmpleado.Name = "tsr_ModificarEmpleado";
            this.tsr_ModificarEmpleado.Size = new System.Drawing.Size(150, 22);
            this.tsr_ModificarEmpleado.Text = "Empleado";
            // 
            // tsr_ModificarCliente
            // 
            this.tsr_ModificarCliente.Name = "tsr_ModificarCliente";
            this.tsr_ModificarCliente.Size = new System.Drawing.Size(150, 22);
            this.tsr_ModificarCliente.Text = "Cliente";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // tsr_Listar
            // 
            this.tsr_Listar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsr_ListarUsuarios,
            this.clientesToolStripMenuItem,
            this.verInformacionDelUsuarioToolStripMenuItem,
            this.verMiInformaciónToolStripMenuItem});
            this.tsr_Listar.Name = "tsr_Listar";
            this.tsr_Listar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsr_Listar.Size = new System.Drawing.Size(180, 22);
            this.tsr_Listar.Text = "Listar";
            // 
            // tsr_ListarUsuarios
            // 
            this.tsr_ListarUsuarios.Name = "tsr_ListarUsuarios";
            this.tsr_ListarUsuarios.Size = new System.Drawing.Size(175, 22);
            this.tsr_ListarUsuarios.Text = "Usuarios";
            this.tsr_ListarUsuarios.Click += new System.EventHandler(this.tsr_ListarUsuarios_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.clientesToolStripMenuItem.Text = "Empleados";
            // 
            // verInformacionDelUsuarioToolStripMenuItem
            // 
            this.verInformacionDelUsuarioToolStripMenuItem.Name = "verInformacionDelUsuarioToolStripMenuItem";
            this.verInformacionDelUsuarioToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.verInformacionDelUsuarioToolStripMenuItem.Text = "Clientes";
            this.verInformacionDelUsuarioToolStripMenuItem.Click += new System.EventHandler(this.verInformacionDelUsuarioToolStripMenuItem_Click);
            // 
            // verMiInformaciónToolStripMenuItem
            // 
            this.verMiInformaciónToolStripMenuItem.Name = "verMiInformaciónToolStripMenuItem";
            this.verMiInformaciónToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.verMiInformaciónToolStripMenuItem.Text = "Ver mi información";
            // 
            // tsr_cerrarSesión
            // 
            this.tsr_cerrarSesión.Name = "tsr_cerrarSesión";
            this.tsr_cerrarSesión.Size = new System.Drawing.Size(180, 22);
            this.tsr_cerrarSesión.Text = "Cerrar sesión";
            this.tsr_cerrarSesión.Click += new System.EventHandler(this.tsr_cerrarSesión_Click);
            // 
            // ventasToolStripMenuItem1
            // 
            this.ventasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsr_agregarAlStock,
            this.tsr_modificarProducto,
            this.tsr_VerStock});
            this.ventasToolStripMenuItem1.Name = "ventasToolStripMenuItem1";
            this.ventasToolStripMenuItem1.Size = new System.Drawing.Size(73, 20);
            this.ventasToolStripMenuItem1.Text = "Productos";
            // 
            // tsr_agregarAlStock
            // 
            this.tsr_agregarAlStock.Name = "tsr_agregarAlStock";
            this.tsr_agregarAlStock.Size = new System.Drawing.Size(211, 22);
            this.tsr_agregarAlStock.Text = "Agregar producto al stock";
            // 
            // tsr_modificarProducto
            // 
            this.tsr_modificarProducto.Name = "tsr_modificarProducto";
            this.tsr_modificarProducto.Size = new System.Drawing.Size(211, 22);
            this.tsr_modificarProducto.Text = "Modificar producto";
            this.tsr_modificarProducto.Click += new System.EventHandler(this.tsr_modificarProducto_Click);
            // 
            // tsr_VerStock
            // 
            this.tsr_VerStock.Name = "tsr_VerStock";
            this.tsr_VerStock.Size = new System.Drawing.Size(211, 22);
            this.tsr_VerStock.Text = "Ver stock";
            this.tsr_VerStock.Click += new System.EventHandler(this.tsr_VerStock_Click);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsr_RealizarVenta,
            this.consultarVentasToolStripMenuItem});
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.informesToolStripMenuItem.Text = "Ventas";
            // 
            // tsr_RealizarVenta
            // 
            this.tsr_RealizarVenta.Name = "tsr_RealizarVenta";
            this.tsr_RealizarVenta.Size = new System.Drawing.Size(162, 22);
            this.tsr_RealizarVenta.Text = "Realizar ventas";
            this.tsr_RealizarVenta.Click += new System.EventHandler(this.tsr_RealizarVenta_Click);
            // 
            // consultarVentasToolStripMenuItem
            // 
            this.consultarVentasToolStripMenuItem.Name = "consultarVentasToolStripMenuItem";
            this.consultarVentasToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.consultarVentasToolStripMenuItem.Text = "Consultar ventas";
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(914, 461);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pet Shop Laplume - Menu Principal";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMenuPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsr_Alta;
        private System.Windows.Forms.ToolStripMenuItem tsr_AltaAdministrador;
        private System.Windows.Forms.ToolStripMenuItem tsr_AltaEmpleado;
        private System.Windows.Forms.ToolStripMenuItem tsr_AltaCliente;
        private System.Windows.Forms.ToolStripMenuItem tsr_Baja;
        private System.Windows.Forms.ToolStripMenuItem tsr_BajaAdministrador;
        private System.Windows.Forms.ToolStripMenuItem tsr_BajaEmpleado;
        private System.Windows.Forms.ToolStripMenuItem tsr_BajaCliente;
        private System.Windows.Forms.ToolStripMenuItem tsr_Modificar;
        private System.Windows.Forms.ToolStripMenuItem tsr_ModificarAdministrador;
        private System.Windows.Forms.ToolStripMenuItem tsr_ModificarEmpleado;
        private System.Windows.Forms.ToolStripMenuItem tsr_ModificarCliente;
        private System.Windows.Forms.ToolStripMenuItem tsr_Listar;
        private System.Windows.Forms.ToolStripMenuItem tsr_ListarUsuarios;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verInformacionDelUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verMiInformaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsr_agregarAlStock;
        private System.Windows.Forms.ToolStripMenuItem tsr_modificarProducto;
        private System.Windows.Forms.ToolStripMenuItem tsr_VerStock;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsr_RealizarVenta;
        private System.Windows.Forms.ToolStripMenuItem consultarVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsr_cerrarSesión;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}