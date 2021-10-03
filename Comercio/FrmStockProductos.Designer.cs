
namespace Comercio
{
    partial class FrmStockProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStockProductos));
            this.btn_DescargarStock = new System.Windows.Forms.Button();
            this.btn_BuscarProducto = new System.Windows.Forms.Button();
            this.btn_ModificarProducto = new System.Windows.Forms.Button();
            this.btn_EliminarProducto = new System.Windows.Forms.Button();
            this.lbl_ProductoEncontrado = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CerrarAplicacion)).BeginInit();
            this.pnl_BarraForms.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(11, 104);
            this.panel2.Size = new System.Drawing.Size(847, 262);
            // 
            // lbl_NombreProducto
            // 
            this.lbl_NombreProducto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_NombreProducto.Location = new System.Drawing.Point(83, 2);
            this.lbl_NombreProducto.Size = new System.Drawing.Size(60, 19);
            // 
            // lbl_CaracteristicasProducto
            // 
            this.lbl_CaracteristicasProducto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_CaracteristicasProducto.Location = new System.Drawing.Point(219, 2);
            this.lbl_CaracteristicasProducto.Size = new System.Drawing.Size(106, 19);
            // 
            // lbl_PrecioUnitarioProducto
            // 
            this.lbl_PrecioUnitarioProducto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_PrecioUnitarioProducto.Location = new System.Drawing.Point(752, 2);
            this.lbl_PrecioUnitarioProducto.Size = new System.Drawing.Size(78, 19);
            this.lbl_PrecioUnitarioProducto.Text = "Precio C/U";
            // 
            // lbl_CodigoProducto
            // 
            this.lbl_CodigoProducto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_CodigoProducto.Location = new System.Drawing.Point(9, 2);
            this.lbl_CodigoProducto.Size = new System.Drawing.Size(54, 19);
            // 
            // lbl_TipoProductoEncabezado
            // 
            this.lbl_TipoProductoEncabezado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_TipoProductoEncabezado.Location = new System.Drawing.Point(508, 2);
            this.lbl_TipoProductoEncabezado.Size = new System.Drawing.Size(37, 19);
            // 
            // lbl_CantidadStockProducto
            // 
            this.lbl_CantidadStockProducto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_CantidadStockProducto.Location = new System.Drawing.Point(640, 2);
            this.lbl_CantidadStockProducto.Size = new System.Drawing.Size(63, 19);
            this.lbl_CantidadStockProducto.Text = "En stock";
            // 
            // lbl_TituloForms
            // 
            this.lbl_TituloForms.Location = new System.Drawing.Point(306, 35);
            this.lbl_TituloForms.Size = new System.Drawing.Size(235, 29);
            this.lbl_TituloForms.Text = "STOCK DE PRODUCTOS";
            // 
            // lst_Codigo
            // 
            this.lst_Codigo.Location = new System.Drawing.Point(9, 24);
            this.lst_Codigo.Size = new System.Drawing.Size(68, 213);
            // 
            // lst_Caracteristicas
            // 
            this.lst_Caracteristicas.Location = new System.Drawing.Point(219, 24);
            this.lst_Caracteristicas.Size = new System.Drawing.Size(283, 213);
            // 
            // lst_Nombre
            // 
            this.lst_Nombre.Location = new System.Drawing.Point(83, 24);
            this.lst_Nombre.Size = new System.Drawing.Size(130, 213);
            // 
            // lst_TipoProducto
            // 
            this.lst_TipoProducto.Location = new System.Drawing.Point(508, 24);
            this.lst_TipoProducto.Size = new System.Drawing.Size(126, 213);
            // 
            // lst_CantidadStock
            // 
            this.lst_CantidadStock.Location = new System.Drawing.Point(640, 24);
            this.lst_CantidadStock.Size = new System.Drawing.Size(106, 213);
            // 
            // lbl_TipoProducto
            // 
            this.lbl_TipoProducto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_TipoProducto.Location = new System.Drawing.Point(11, 79);
            this.lbl_TipoProducto.Size = new System.Drawing.Size(105, 19);
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
            this.cmb_TiposProductos.Location = new System.Drawing.Point(120, 76);
            // 
            // lst_PrecioUnitario
            // 
            this.lst_PrecioUnitario.Location = new System.Drawing.Point(752, 24);
            this.lst_PrecioUnitario.Size = new System.Drawing.Size(84, 213);
            // 
            // pnl_BarraForms
            // 
            this.pnl_BarraForms.Size = new System.Drawing.Size(870, 23);
            // 
            // lbl_CodigoDelProducto
            // 
            this.lbl_CodigoDelProducto.Location = new System.Drawing.Point(165, 376);
            // 
            // btn_DescargarStock
            // 
            this.btn_DescargarStock.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_DescargarStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DescargarStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DescargarStock.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_DescargarStock.Location = new System.Drawing.Point(724, 412);
            this.btn_DescargarStock.Name = "btn_DescargarStock";
            this.btn_DescargarStock.Size = new System.Drawing.Size(117, 34);
            this.btn_DescargarStock.TabIndex = 66;
            this.btn_DescargarStock.Text = "DESCARGAR STOCK";
            this.btn_DescargarStock.UseVisualStyleBackColor = false;
            this.btn_DescargarStock.Click += new System.EventHandler(this.btn_DescargarStock_Click);
            // 
            // btn_BuscarProducto
            // 
            this.btn_BuscarProducto.BackColor = System.Drawing.Color.Gold;
            this.btn_BuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BuscarProducto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_BuscarProducto.Location = new System.Drawing.Point(353, 412);
            this.btn_BuscarProducto.Name = "btn_BuscarProducto";
            this.btn_BuscarProducto.Size = new System.Drawing.Size(116, 23);
            this.btn_BuscarProducto.TabIndex = 2;
            this.btn_BuscarProducto.Text = "BUSCAR";
            this.btn_BuscarProducto.UseVisualStyleBackColor = false;
            this.btn_BuscarProducto.Click += new System.EventHandler(this.btn_BuscarProducto_Click);
            // 
            // btn_ModificarProducto
            // 
            this.btn_ModificarProducto.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_ModificarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ModificarProducto.Enabled = false;
            this.btn_ModificarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ModificarProducto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ModificarProducto.Location = new System.Drawing.Point(519, 372);
            this.btn_ModificarProducto.Name = "btn_ModificarProducto";
            this.btn_ModificarProducto.Size = new System.Drawing.Size(116, 23);
            this.btn_ModificarProducto.TabIndex = 3;
            this.btn_ModificarProducto.Text = "MODIFICAR";
            this.btn_ModificarProducto.UseVisualStyleBackColor = false;
            this.btn_ModificarProducto.Click += new System.EventHandler(this.btn_ModificarProducto_Click);
            // 
            // btn_EliminarProducto
            // 
            this.btn_EliminarProducto.BackColor = System.Drawing.Color.LightCoral;
            this.btn_EliminarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EliminarProducto.Enabled = false;
            this.btn_EliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EliminarProducto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_EliminarProducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_EliminarProducto.Location = new System.Drawing.Point(641, 372);
            this.btn_EliminarProducto.Name = "btn_EliminarProducto";
            this.btn_EliminarProducto.Size = new System.Drawing.Size(102, 23);
            this.btn_EliminarProducto.TabIndex = 4;
            this.btn_EliminarProducto.Text = "ELIMINAR";
            this.btn_EliminarProducto.UseVisualStyleBackColor = false;
            this.btn_EliminarProducto.Click += new System.EventHandler(this.btn_EliminarProducto_Click);
            // 
            // lbl_ProductoEncontrado
            // 
            this.lbl_ProductoEncontrado.AutoSize = true;
            this.lbl_ProductoEncontrado.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ProductoEncontrado.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lbl_ProductoEncontrado.ForeColor = System.Drawing.Color.Aqua;
            this.lbl_ProductoEncontrado.Location = new System.Drawing.Point(355, 394);
            this.lbl_ProductoEncontrado.Name = "lbl_ProductoEncontrado";
            this.lbl_ProductoEncontrado.Size = new System.Drawing.Size(122, 15);
            this.lbl_ProductoEncontrado.TabIndex = 37;
            this.lbl_ProductoEncontrado.Text = "Producto Encontrado";
            this.lbl_ProductoEncontrado.Visible = false;
            // 
            // FrmStockProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(870, 470);
            this.Controls.Add(this.lbl_ProductoEncontrado);
            this.Controls.Add(this.btn_EliminarProducto);
            this.Controls.Add(this.btn_ModificarProducto);
            this.Controls.Add(this.btn_BuscarProducto);
            this.Controls.Add(this.btn_DescargarStock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmStockProductos";
            this.Text = "Pet Shop Laplume - Stock de productos";
            this.Load += new System.EventHandler(this.FrmStockProductos_Load);
            this.Controls.SetChildIndex(this.txt_CodigoProductoIngresado, 0);
            this.Controls.SetChildIndex(this.lbl_CodigoDelProducto, 0);
            this.Controls.SetChildIndex(this.pnl_BarraForms, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.lbl_TituloForms, 0);
            this.Controls.SetChildIndex(this.cmb_TiposProductos, 0);
            this.Controls.SetChildIndex(this.lbl_TipoProducto, 0);
            this.Controls.SetChildIndex(this.btn_DescargarStock, 0);
            this.Controls.SetChildIndex(this.btn_BuscarProducto, 0);
            this.Controls.SetChildIndex(this.btn_ModificarProducto, 0);
            this.Controls.SetChildIndex(this.btn_EliminarProducto, 0);
            this.Controls.SetChildIndex(this.lbl_ProductoEncontrado, 0);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CerrarAplicacion)).EndInit();
            this.pnl_BarraForms.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_DescargarStock;
        private System.Windows.Forms.Button btn_BuscarProducto;
        private System.Windows.Forms.TextBox txt_CodigoProductoIngresado;
        private System.Windows.Forms.Button btn_ModificarProducto;
        private System.Windows.Forms.Button btn_EliminarProducto;
        private System.Windows.Forms.Label lbl_ProductoEncontrado;
    }
}