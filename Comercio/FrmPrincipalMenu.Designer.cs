
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
            ((System.ComponentModel.ISupportInitialize)(this.pb_MenuTrabajadora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_MenuCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_MenuVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_MenuProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_MenuTrabajadora
            // 
            this.pb_MenuTrabajadora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_MenuTrabajadora.BackColor = System.Drawing.Color.Transparent;
            this.pb_MenuTrabajadora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_MenuTrabajadora.Image = global::Comercio.Properties.Resources.Usuarios;
            this.pb_MenuTrabajadora.Location = new System.Drawing.Point(12, 130);
            this.pb_MenuTrabajadora.Name = "pb_MenuTrabajadora";
            this.pb_MenuTrabajadora.Size = new System.Drawing.Size(160, 155);
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
            this.pb_MenuCliente.Location = new System.Drawing.Point(200, 130);
            this.pb_MenuCliente.Name = "pb_MenuCliente";
            this.pb_MenuCliente.Size = new System.Drawing.Size(160, 155);
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
            this.pb_MenuVentas.Location = new System.Drawing.Point(387, 130);
            this.pb_MenuVentas.Name = "pb_MenuVentas";
            this.pb_MenuVentas.Size = new System.Drawing.Size(160, 155);
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
            this.pb_MenuProductos.Location = new System.Drawing.Point(576, 130);
            this.pb_MenuProductos.Name = "pb_MenuProductos";
            this.pb_MenuProductos.Size = new System.Drawing.Size(160, 155);
            this.pb_MenuProductos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_MenuProductos.TabIndex = 3;
            this.pb_MenuProductos.TabStop = false;
            this.pb_MenuProductos.Click += new System.EventHandler(this.pb_MenuProductos_Click);
            // 
            // lbl_Trabajadores
            // 
            this.lbl_Trabajadores.AutoSize = true;
            this.lbl_Trabajadores.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Trabajadores.Location = new System.Drawing.Point(8, 102);
            this.lbl_Trabajadores.Name = "lbl_Trabajadores";
            this.lbl_Trabajadores.Size = new System.Drawing.Size(172, 29);
            this.lbl_Trabajadores.TabIndex = 4;
            this.lbl_Trabajadores.Text = "TRABAJADORES";
            // 
            // lbl_Usuarios
            // 
            this.lbl_Usuarios.AutoSize = true;
            this.lbl_Usuarios.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Usuarios.Location = new System.Drawing.Point(228, 102);
            this.lbl_Usuarios.Name = "lbl_Usuarios";
            this.lbl_Usuarios.Size = new System.Drawing.Size(105, 29);
            this.lbl_Usuarios.TabIndex = 5;
            this.lbl_Usuarios.Text = "CLIENTES";
            // 
            // lbl_Ventas
            // 
            this.lbl_Ventas.AutoSize = true;
            this.lbl_Ventas.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Ventas.Location = new System.Drawing.Point(423, 102);
            this.lbl_Ventas.Name = "lbl_Ventas";
            this.lbl_Ventas.Size = new System.Drawing.Size(91, 29);
            this.lbl_Ventas.TabIndex = 6;
            this.lbl_Ventas.Text = "VENTAS";
            // 
            // lbl_Productos
            // 
            this.lbl_Productos.AutoSize = true;
            this.lbl_Productos.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Productos.Location = new System.Drawing.Point(590, 102);
            this.lbl_Productos.Name = "lbl_Productos";
            this.lbl_Productos.Size = new System.Drawing.Size(138, 29);
            this.lbl_Productos.TabIndex = 7;
            this.lbl_Productos.Text = "PRODUCTOS";
            // 
            // FrmPrincipalMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(748, 297);
            this.Controls.Add(this.pb_MenuProductos);
            this.Controls.Add(this.pb_MenuVentas);
            this.Controls.Add(this.pb_MenuCliente);
            this.Controls.Add(this.pb_MenuTrabajadora);
            this.Controls.Add(this.lbl_Productos);
            this.Controls.Add(this.lbl_Ventas);
            this.Controls.Add(this.lbl_Usuarios);
            this.Controls.Add(this.lbl_Trabajadores);
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
    }
}