
namespace Comercio
{
    partial class FrmABMProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmABMProducto));
            this.btn_BuscarProducto = new System.Windows.Forms.Button();
            this.btn_DescargarStock = new System.Windows.Forms.Button();
            this.btn_EliminarProducto = new System.Windows.Forms.Button();
            this.btn_ModificarProducto = new System.Windows.Forms.Button();
            this.lbl_ProductoEncontrado = new System.Windows.Forms.Label();
            this.btn_AgregarProducto = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CerrarAplicacion)).BeginInit();
            this.pnl_BarraForms.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(827, 360);
            // 
            // lbl_TituloForms
            // 
            this.lbl_TituloForms.Location = new System.Drawing.Point(580, 27);
            // 
            // lst_Codigo
            // 
            this.lst_Codigo.Size = new System.Drawing.Size(99, 327);
            this.lst_Codigo.SelectedIndexChanged += new System.EventHandler(this.lst_Codigo_SelectedIndexChanged);
            // 
            // lst_Caracteristicas
            // 
            this.lst_Caracteristicas.Size = new System.Drawing.Size(325, 327);
            // 
            // lst_Nombre
            // 
            this.lst_Nombre.Size = new System.Drawing.Size(121, 327);
            // 
            // lst_TipoProducto
            // 
            this.lst_TipoProducto.Size = new System.Drawing.Size(95, 327);
            // 
            // lst_CantidadStock
            // 
            this.lst_CantidadStock.Size = new System.Drawing.Size(61, 327);
            // 
            // lbl_TipoProducto
            // 
            this.lbl_TipoProducto.Location = new System.Drawing.Point(12, 38);
            // 
            // cmb_TiposProductos
            // 
            this.cmb_TiposProductos.Items.AddRange(new object[] {
            EntidadesComercio.EnumTipoProducto.Alimento,
            EntidadesComercio.EnumTipoProducto.Juguete,
            EntidadesComercio.EnumTipoProducto.Comodidad,
            EntidadesComercio.EnumTipoProducto.Limpieza,
            EntidadesComercio.EnumTipoProducto.Farmacia,
            EntidadesComercio.EnumTipoProducto.Alimento,
            EntidadesComercio.EnumTipoProducto.Juguete,
            EntidadesComercio.EnumTipoProducto.Comodidad,
            EntidadesComercio.EnumTipoProducto.Limpieza,
            EntidadesComercio.EnumTipoProducto.Farmacia,
            EntidadesComercio.EnumTipoProducto.Alimento,
            EntidadesComercio.EnumTipoProducto.Juguete,
            EntidadesComercio.EnumTipoProducto.Comodidad,
            EntidadesComercio.EnumTipoProducto.Limpieza,
            EntidadesComercio.EnumTipoProducto.Farmacia,
            EntidadesComercio.EnumTipoProducto.Alimento,
            EntidadesComercio.EnumTipoProducto.Juguete,
            EntidadesComercio.EnumTipoProducto.Comodidad,
            EntidadesComercio.EnumTipoProducto.Limpieza,
            EntidadesComercio.EnumTipoProducto.Farmacia,
            EntidadesComercio.EnumTipoProducto.Alimento,
            EntidadesComercio.EnumTipoProducto.Juguete,
            EntidadesComercio.EnumTipoProducto.Comodidad,
            EntidadesComercio.EnumTipoProducto.Limpieza,
            EntidadesComercio.EnumTipoProducto.Farmacia,
            EntidadesComercio.EnumTipoProducto.Alimento,
            EntidadesComercio.EnumTipoProducto.Juguete,
            EntidadesComercio.EnumTipoProducto.Comodidad,
            EntidadesComercio.EnumTipoProducto.Limpieza,
            EntidadesComercio.EnumTipoProducto.Farmacia});
            this.cmb_TiposProductos.Location = new System.Drawing.Point(109, 30);
            // 
            // lst_PrecioUnitario
            // 
            this.lst_PrecioUnitario.Size = new System.Drawing.Size(82, 327);
            // 
            // lbl_CodigoDelProducto
            // 
            this.lbl_CodigoDelProducto.Location = new System.Drawing.Point(263, -28);
            this.lbl_CodigoDelProducto.Size = new System.Drawing.Size(89, 15);
            this.lbl_CodigoDelProducto.Text = "Ingrese codigo:";
            // 
            // txt_CodigoProductoIngresado
            // 
            this.txt_CodigoProductoIngresado.Location = new System.Drawing.Point(236, 30);
            this.txt_CodigoProductoIngresado.PlaceholderText = "CODIGO ";
            this.txt_CodigoProductoIngresado.Size = new System.Drawing.Size(109, 23);
            this.txt_CodigoProductoIngresado.TextChanged += new System.EventHandler(this.txt_CodigoProductoIngresado_TextChanged);
            // 
            // btn_BuscarProducto
            // 
            this.btn_BuscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_BuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_BuscarProducto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_BuscarProducto.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_BuscarProducto.Location = new System.Drawing.Point(351, 30);
            this.btn_BuscarProducto.Name = "btn_BuscarProducto";
            this.btn_BuscarProducto.Size = new System.Drawing.Size(66, 23);
            this.btn_BuscarProducto.TabIndex = 2;
            this.btn_BuscarProducto.Text = "BUSCAR";
            this.btn_BuscarProducto.UseVisualStyleBackColor = false;
            this.btn_BuscarProducto.Click += new System.EventHandler(this.btn_BuscarProducto_Click);
            // 
            // btn_DescargarStock
            // 
            this.btn_DescargarStock.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_DescargarStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DescargarStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DescargarStock.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_DescargarStock.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_DescargarStock.Location = new System.Drawing.Point(721, 424);
            this.btn_DescargarStock.Name = "btn_DescargarStock";
            this.btn_DescargarStock.Size = new System.Drawing.Size(117, 34);
            this.btn_DescargarStock.TabIndex = 6;
            this.btn_DescargarStock.Text = "DESCARGAR STOCK";
            this.btn_DescargarStock.UseVisualStyleBackColor = false;
            this.btn_DescargarStock.Click += new System.EventHandler(this.btn_DescargarStock_Click);
            // 
            // btn_EliminarProducto
            // 
            this.btn_EliminarProducto.BackColor = System.Drawing.Color.LightCoral;
            this.btn_EliminarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EliminarProducto.Enabled = false;
            this.btn_EliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EliminarProducto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_EliminarProducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_EliminarProducto.Location = new System.Drawing.Point(629, 423);
            this.btn_EliminarProducto.Name = "btn_EliminarProducto";
            this.btn_EliminarProducto.Size = new System.Drawing.Size(86, 34);
            this.btn_EliminarProducto.TabIndex = 5;
            this.btn_EliminarProducto.Text = "ELIMINAR";
            this.btn_EliminarProducto.UseVisualStyleBackColor = false;
            this.btn_EliminarProducto.Click += new System.EventHandler(this.btn_EliminarProducto_Click);
            // 
            // btn_ModificarProducto
            // 
            this.btn_ModificarProducto.BackColor = System.Drawing.Color.Gold;
            this.btn_ModificarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ModificarProducto.Enabled = false;
            this.btn_ModificarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ModificarProducto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ModificarProducto.Location = new System.Drawing.Point(537, 424);
            this.btn_ModificarProducto.Name = "btn_ModificarProducto";
            this.btn_ModificarProducto.Size = new System.Drawing.Size(86, 34);
            this.btn_ModificarProducto.TabIndex = 4;
            this.btn_ModificarProducto.Text = "MODIFICAR";
            this.btn_ModificarProducto.UseVisualStyleBackColor = false;
            this.btn_ModificarProducto.Click += new System.EventHandler(this.btn_ModificarProducto_Click);
            // 
            // lbl_ProductoEncontrado
            // 
            this.lbl_ProductoEncontrado.AutoSize = true;
            this.lbl_ProductoEncontrado.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ProductoEncontrado.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lbl_ProductoEncontrado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_ProductoEncontrado.Location = new System.Drawing.Point(423, 38);
            this.lbl_ProductoEncontrado.Name = "lbl_ProductoEncontrado";
            this.lbl_ProductoEncontrado.Size = new System.Drawing.Size(122, 15);
            this.lbl_ProductoEncontrado.TabIndex = 55;
            this.lbl_ProductoEncontrado.Text = "Producto Encontrado";
            this.lbl_ProductoEncontrado.Visible = false;
            // 
            // btn_AgregarProducto
            // 
            this.btn_AgregarProducto.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_AgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarProducto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_AgregarProducto.Location = new System.Drawing.Point(445, 424);
            this.btn_AgregarProducto.Name = "btn_AgregarProducto";
            this.btn_AgregarProducto.Size = new System.Drawing.Size(86, 34);
            this.btn_AgregarProducto.TabIndex = 56;
            this.btn_AgregarProducto.Text = "AGREGAR";
            this.btn_AgregarProducto.UseVisualStyleBackColor = false;
            this.btn_AgregarProducto.Click += new System.EventHandler(this.btn_AgregarProducto_Click);
            // 
            // FrmABMProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 470);
            this.Controls.Add(this.btn_AgregarProducto);
            this.Controls.Add(this.lbl_ProductoEncontrado);
            this.Controls.Add(this.btn_EliminarProducto);
            this.Controls.Add(this.btn_ModificarProducto);
            this.Controls.Add(this.btn_DescargarStock);
            this.Controls.Add(this.btn_BuscarProducto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmABMProducto";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.FrmABMProducto_Load);
            this.Controls.SetChildIndex(this.lbl_TituloForms, 0);
            this.Controls.SetChildIndex(this.lbl_TipoProducto, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.pnl_BarraForms, 0);
            this.Controls.SetChildIndex(this.lbl_CodigoDelProducto, 0);
            this.Controls.SetChildIndex(this.cmb_TiposProductos, 0);
            this.Controls.SetChildIndex(this.txt_CodigoProductoIngresado, 0);
            this.Controls.SetChildIndex(this.btn_BuscarProducto, 0);
            this.Controls.SetChildIndex(this.btn_DescargarStock, 0);
            this.Controls.SetChildIndex(this.btn_ModificarProducto, 0);
            this.Controls.SetChildIndex(this.btn_EliminarProducto, 0);
            this.Controls.SetChildIndex(this.lbl_ProductoEncontrado, 0);
            this.Controls.SetChildIndex(this.btn_AgregarProducto, 0);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CerrarAplicacion)).EndInit();
            this.pnl_BarraForms.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_BuscarProducto;
        private System.Windows.Forms.Button btn_DescargarStock;
        private System.Windows.Forms.Button btn_EliminarProducto;
        private System.Windows.Forms.Button btn_ModificarProducto;
        private System.Windows.Forms.Label lbl_ProductoEncontrado;
        private System.Windows.Forms.Button btn_AgregarProducto;
    }
}