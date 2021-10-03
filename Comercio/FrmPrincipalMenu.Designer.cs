
namespace Comercio
{
    partial class FrmPrincipalMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipalMenu));
            this.pb_MenuTrabajadora = new System.Windows.Forms.PictureBox();
            this.pb_MenuCliente = new System.Windows.Forms.PictureBox();
            this.pb_MenuVentas = new System.Windows.Forms.PictureBox();
            this.pb_MenuProductos = new System.Windows.Forms.PictureBox();
            this.lbl_Trabajadores = new System.Windows.Forms.Label();
            this.lbl_Usuarios = new System.Windows.Forms.Label();
            this.lbl_Ventas = new System.Windows.Forms.Label();
            this.lbl_Productos = new System.Windows.Forms.Label();
            this.pb_CerrarSesion = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_FotoUsuarioLogeado = new System.Windows.Forms.PictureBox();
            this.lbl_LegajoUsuarioLogeado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_MenuTrabajadora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_MenuCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_MenuVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_MenuProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CerrarSesion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FotoUsuarioLogeado)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_MenuTrabajadora
            // 
            this.pb_MenuTrabajadora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_MenuTrabajadora.BackColor = System.Drawing.Color.Transparent;
            this.pb_MenuTrabajadora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_MenuTrabajadora.Image = global::Comercio.Properties.Resources.Usuarios;
            this.pb_MenuTrabajadora.Location = new System.Drawing.Point(21, 154);
            this.pb_MenuTrabajadora.Name = "pb_MenuTrabajadora";
            this.pb_MenuTrabajadora.Size = new System.Drawing.Size(139, 131);
            this.pb_MenuTrabajadora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_MenuTrabajadora.TabIndex = 0;
            this.pb_MenuTrabajadora.TabStop = false;
            this.pb_MenuTrabajadora.Click += new System.EventHandler(this.pb_MenuTrabajadora_Click);
            // 
            // pb_MenuCliente
            // 
            this.pb_MenuCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_MenuCliente.BackColor = System.Drawing.Color.Transparent;
            this.pb_MenuCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_MenuCliente.Image = global::Comercio.Properties.Resources.ClienteSatisfecho;
            this.pb_MenuCliente.Location = new System.Drawing.Point(209, 154);
            this.pb_MenuCliente.Name = "pb_MenuCliente";
            this.pb_MenuCliente.Size = new System.Drawing.Size(139, 131);
            this.pb_MenuCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_MenuCliente.TabIndex = 1;
            this.pb_MenuCliente.TabStop = false;
            this.pb_MenuCliente.Click += new System.EventHandler(this.pb_MenuCliente_Click);
            // 
            // pb_MenuVentas
            // 
            this.pb_MenuVentas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_MenuVentas.BackColor = System.Drawing.Color.Transparent;
            this.pb_MenuVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_MenuVentas.Image = global::Comercio.Properties.Resources.vender;
            this.pb_MenuVentas.Location = new System.Drawing.Point(396, 154);
            this.pb_MenuVentas.Name = "pb_MenuVentas";
            this.pb_MenuVentas.Size = new System.Drawing.Size(139, 131);
            this.pb_MenuVentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_MenuVentas.TabIndex = 2;
            this.pb_MenuVentas.TabStop = false;
            this.pb_MenuVentas.Click += new System.EventHandler(this.pb_MenuVentas_Click);
            // 
            // pb_MenuProductos
            // 
            this.pb_MenuProductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_MenuProductos.BackColor = System.Drawing.Color.Transparent;
            this.pb_MenuProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_MenuProductos.Image = global::Comercio.Properties.Resources.InventarioProducto;
            this.pb_MenuProductos.Location = new System.Drawing.Point(585, 154);
            this.pb_MenuProductos.Name = "pb_MenuProductos";
            this.pb_MenuProductos.Size = new System.Drawing.Size(139, 131);
            this.pb_MenuProductos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_MenuProductos.TabIndex = 3;
            this.pb_MenuProductos.TabStop = false;
            this.pb_MenuProductos.Click += new System.EventHandler(this.pb_MenuProductos_Click);
            // 
            // lbl_Trabajadores
            // 
            this.lbl_Trabajadores.AutoSize = true;
            this.lbl_Trabajadores.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Trabajadores.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Trabajadores.Location = new System.Drawing.Point(13, 130);
            this.lbl_Trabajadores.Name = "lbl_Trabajadores";
            this.lbl_Trabajadores.Size = new System.Drawing.Size(151, 26);
            this.lbl_Trabajadores.TabIndex = 4;
            this.lbl_Trabajadores.Text = "TRABAJADORES";
            // 
            // lbl_Usuarios
            // 
            this.lbl_Usuarios.AutoSize = true;
            this.lbl_Usuarios.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Usuarios.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Usuarios.Location = new System.Drawing.Point(233, 130);
            this.lbl_Usuarios.Name = "lbl_Usuarios";
            this.lbl_Usuarios.Size = new System.Drawing.Size(92, 26);
            this.lbl_Usuarios.TabIndex = 5;
            this.lbl_Usuarios.Text = "CLIENTES";
            // 
            // lbl_Ventas
            // 
            this.lbl_Ventas.AutoSize = true;
            this.lbl_Ventas.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Ventas.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Ventas.Location = new System.Drawing.Point(428, 130);
            this.lbl_Ventas.Name = "lbl_Ventas";
            this.lbl_Ventas.Size = new System.Drawing.Size(79, 26);
            this.lbl_Ventas.TabIndex = 6;
            this.lbl_Ventas.Text = "VENTAS";
            // 
            // lbl_Productos
            // 
            this.lbl_Productos.AutoSize = true;
            this.lbl_Productos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Productos.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Productos.Location = new System.Drawing.Point(595, 130);
            this.lbl_Productos.Name = "lbl_Productos";
            this.lbl_Productos.Size = new System.Drawing.Size(120, 26);
            this.lbl_Productos.TabIndex = 7;
            this.lbl_Productos.Text = "PRODUCTOS";
            // 
            // pb_CerrarSesion
            // 
            this.pb_CerrarSesion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_CerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.pb_CerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_CerrarSesion.Image = global::Comercio.Properties.Resources.CerrarSesion;
            this.pb_CerrarSesion.Location = new System.Drawing.Point(8, 12);
            this.pb_CerrarSesion.Name = "pb_CerrarSesion";
            this.pb_CerrarSesion.Size = new System.Drawing.Size(37, 30);
            this.pb_CerrarSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_CerrarSesion.TabIndex = 8;
            this.pb_CerrarSesion.TabStop = false;
            this.pb_CerrarSesion.Click += new System.EventHandler(this.pb_CerrarSesion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(48, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cerrar sesión";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::Comercio.Properties.Resources.logo_chico;
            this.pictureBox1.Location = new System.Drawing.Point(144, -73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(427, 353);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pb_FotoUsuarioLogeado
            // 
            this.pb_FotoUsuarioLogeado.Location = new System.Drawing.Point(663, 12);
            this.pb_FotoUsuarioLogeado.Name = "pb_FotoUsuarioLogeado";
            this.pb_FotoUsuarioLogeado.Size = new System.Drawing.Size(73, 74);
            this.pb_FotoUsuarioLogeado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_FotoUsuarioLogeado.TabIndex = 11;
            this.pb_FotoUsuarioLogeado.TabStop = false;
            // 
            // lbl_LegajoUsuarioLogeado
            // 
            this.lbl_LegajoUsuarioLogeado.AutoSize = true;
            this.lbl_LegajoUsuarioLogeado.Location = new System.Drawing.Point(663, 89);
            this.lbl_LegajoUsuarioLogeado.Name = "lbl_LegajoUsuarioLogeado";
            this.lbl_LegajoUsuarioLogeado.Size = new System.Drawing.Size(45, 15);
            this.lbl_LegajoUsuarioLogeado.TabIndex = 12;
            this.lbl_LegajoUsuarioLogeado.Text = "Legajo:";
            // 
            // FrmPrincipalMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(748, 297);
            this.Controls.Add(this.lbl_LegajoUsuarioLogeado);
            this.Controls.Add(this.pb_FotoUsuarioLogeado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_CerrarSesion);
            this.Controls.Add(this.pb_MenuProductos);
            this.Controls.Add(this.pb_MenuVentas);
            this.Controls.Add(this.pb_MenuCliente);
            this.Controls.Add(this.pb_MenuTrabajadora);
            this.Controls.Add(this.lbl_Productos);
            this.Controls.Add(this.lbl_Ventas);
            this.Controls.Add(this.lbl_Usuarios);
            this.Controls.Add(this.lbl_Trabajadores);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPrincipalMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal - Pet Shop Laplume";
            this.Load += new System.EventHandler(this.FrmPrincipalMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_MenuTrabajadora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_MenuCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_MenuVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_MenuProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CerrarSesion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FotoUsuarioLogeado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_MenuTrabajadora;
        private System.Windows.Forms.PictureBox pb_MenuCliente;
        private System.Windows.Forms.PictureBox pb_MenuVentas;
        private System.Windows.Forms.PictureBox pb_MenuProductos;
        private System.Windows.Forms.Label lbl_Trabajadores;
        private System.Windows.Forms.Label lbl_Usuarios;
        private System.Windows.Forms.Label lbl_Ventas;
        private System.Windows.Forms.Label lbl_Productos;
        private System.Windows.Forms.PictureBox pb_CerrarSesion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pb_FotoUsuarioLogeado;
        private System.Windows.Forms.Label lbl_LegajoUsuarioLogeado;
    }
}