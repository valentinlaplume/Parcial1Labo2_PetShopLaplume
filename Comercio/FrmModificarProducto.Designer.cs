
namespace Comercio
{
    partial class FrmModificarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificarProducto));
            this.cmb_TipoProductoElegido = new System.Windows.Forms.ComboBox();
            this.btn_ModificarProducto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_PrecioUnidadProductoIngresado = new System.Windows.Forms.TextBox();
            this.txt_CantidadStockProductoIngresado = new System.Windows.Forms.TextBox();
            this.txt_CaracteristicasProductoIngresado = new System.Windows.Forms.TextBox();
            this.txt_NombreProductoIngresado = new System.Windows.Forms.TextBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.txt_UrlImagenProducto = new System.Windows.Forms.TextBox();
            this.pb_ImagenProducto = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_UrlImagenProducto = new System.Windows.Forms.Label();
            this.btn_GenerarCodigo = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CerrarAplicacion)).BeginInit();
            this.pnl_BarraForms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ImagenProducto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(17, 55);
            this.panel2.Size = new System.Drawing.Size(846, 94);
            // 
            // pb_CerrarAplicacion
            // 
            this.pb_CerrarAplicacion.Location = new System.Drawing.Point(842, 0);
            this.pb_CerrarAplicacion.Visible = false;
            // 
            // lbl_NombreProducto
            // 
            this.lbl_NombreProducto.Location = new System.Drawing.Point(97, 0);
            // 
            // lbl_PrecioUnitarioProducto
            // 
            this.lbl_PrecioUnitarioProducto.Location = new System.Drawing.Point(759, 0);
            // 
            // lbl_TipoProductoEncabezado
            // 
            this.lbl_TipoProductoEncabezado.Location = new System.Drawing.Point(586, 0);
            // 
            // lbl_CantidadStockProducto
            // 
            this.lbl_CantidadStockProducto.Location = new System.Drawing.Point(680, 0);
            // 
            // lbl_TituloForms
            // 
            this.lbl_TituloForms.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_TituloForms.Location = new System.Drawing.Point(278, 26);
            this.lbl_TituloForms.Size = new System.Drawing.Size(314, 29);
            this.lbl_TituloForms.Text = "MODIFICACIÓN DE PRODUCTO";
            // 
            // lst_Codigo
            // 
            this.lst_Codigo.Size = new System.Drawing.Size(89, 61);
            // 
            // lst_Caracteristicas
            // 
            this.lst_Caracteristicas.Size = new System.Drawing.Size(342, 61);
            // 
            // lst_Nombre
            // 
            this.lst_Nombre.Location = new System.Drawing.Point(101, 18);
            this.lst_Nombre.Size = new System.Drawing.Size(131, 61);
            // 
            // lst_TipoProducto
            // 
            this.lst_TipoProducto.Location = new System.Drawing.Point(586, 18);
            this.lst_TipoProducto.Size = new System.Drawing.Size(92, 61);
            // 
            // lst_CantidadStock
            // 
            this.lst_CantidadStock.Location = new System.Drawing.Point(684, 18);
            this.lst_CantidadStock.Size = new System.Drawing.Size(74, 61);
            // 
            // lbl_TipoProducto
            // 
            this.lbl_TipoProducto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TipoProducto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_TipoProducto.ForeColor = System.Drawing.Color.White;
            this.lbl_TipoProducto.Location = new System.Drawing.Point(17, 36);
            this.lbl_TipoProducto.Visible = false;
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
            this.cmb_TiposProductos.Location = new System.Drawing.Point(114, 29);
            this.cmb_TiposProductos.Visible = false;
            // 
            // lst_PrecioUnitario
            // 
            this.lst_PrecioUnitario.Location = new System.Drawing.Point(764, 18);
            this.lst_PrecioUnitario.Size = new System.Drawing.Size(74, 61);
            // 
            // pnl_BarraForms
            // 
            this.pnl_BarraForms.Size = new System.Drawing.Size(870, 22);
            // 
            // lbl_CodigoDelProducto
            // 
            this.lbl_CodigoDelProducto.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_CodigoDelProducto.Location = new System.Drawing.Point(14, 178);
            this.lbl_CodigoDelProducto.Size = new System.Drawing.Size(44, 15);
            this.lbl_CodigoDelProducto.Text = "Codigo";
            // 
            // txt_CodigoProductoIngresado
            // 
            this.txt_CodigoProductoIngresado.Location = new System.Drawing.Point(126, 170);
            this.txt_CodigoProductoIngresado.PlaceholderText = "";
            this.txt_CodigoProductoIngresado.Size = new System.Drawing.Size(124, 23);
            // 
            // cmb_TipoProductoElegido
            // 
            this.cmb_TipoProductoElegido.FormattingEnabled = true;
            this.cmb_TipoProductoElegido.Location = new System.Drawing.Point(126, 259);
            this.cmb_TipoProductoElegido.Name = "cmb_TipoProductoElegido";
            this.cmb_TipoProductoElegido.Size = new System.Drawing.Size(124, 23);
            this.cmb_TipoProductoElegido.TabIndex = 5;
            // 
            // btn_ModificarProducto
            // 
            this.btn_ModificarProducto.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_ModificarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ModificarProducto.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ModificarProducto.Location = new System.Drawing.Point(739, 288);
            this.btn_ModificarProducto.Name = "btn_ModificarProducto";
            this.btn_ModificarProducto.Size = new System.Drawing.Size(124, 44);
            this.btn_ModificarProducto.TabIndex = 6;
            this.btn_ModificarProducto.Text = "CONFIRMAR";
            this.btn_ModificarProducto.UseVisualStyleBackColor = false;
            this.btn_ModificarProducto.Click += new System.EventHandler(this.btn_ModificarProducto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 44;
            this.label1.Text = "Precio por unidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 42;
            this.label3.Text = "Tipo ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 15);
            this.label4.TabIndex = 41;
            this.label4.Text = "Cantidad en stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 40;
            this.label5.Text = "Caracteristicas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 39;
            this.label6.Text = "Nombre";
            // 
            // txt_PrecioUnidadProductoIngresado
            // 
            this.txt_PrecioUnidadProductoIngresado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_PrecioUnidadProductoIngresado.Location = new System.Drawing.Point(126, 319);
            this.txt_PrecioUnidadProductoIngresado.Name = "txt_PrecioUnidadProductoIngresado";
            this.txt_PrecioUnidadProductoIngresado.Size = new System.Drawing.Size(124, 23);
            this.txt_PrecioUnidadProductoIngresado.TabIndex = 7;
            // 
            // txt_CantidadStockProductoIngresado
            // 
            this.txt_CantidadStockProductoIngresado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_CantidadStockProductoIngresado.Location = new System.Drawing.Point(126, 288);
            this.txt_CantidadStockProductoIngresado.Name = "txt_CantidadStockProductoIngresado";
            this.txt_CantidadStockProductoIngresado.Size = new System.Drawing.Size(124, 23);
            this.txt_CantidadStockProductoIngresado.TabIndex = 6;
            // 
            // txt_CaracteristicasProductoIngresado
            // 
            this.txt_CaracteristicasProductoIngresado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_CaracteristicasProductoIngresado.Location = new System.Drawing.Point(126, 228);
            this.txt_CaracteristicasProductoIngresado.Name = "txt_CaracteristicasProductoIngresado";
            this.txt_CaracteristicasProductoIngresado.Size = new System.Drawing.Size(390, 23);
            this.txt_CaracteristicasProductoIngresado.TabIndex = 4;
            // 
            // txt_NombreProductoIngresado
            // 
            this.txt_NombreProductoIngresado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_NombreProductoIngresado.Location = new System.Drawing.Point(126, 199);
            this.txt_NombreProductoIngresado.Name = "txt_NombreProductoIngresado";
            this.txt_NombreProductoIngresado.Size = new System.Drawing.Size(390, 23);
            this.txt_NombreProductoIngresado.TabIndex = 3;
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salir.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Salir.Location = new System.Drawing.Point(739, 338);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(124, 33);
            this.btn_Salir.TabIndex = 7;
            this.btn_Salir.Text = "SALIR";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // txt_UrlImagenProducto
            // 
            this.txt_UrlImagenProducto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_UrlImagenProducto.Location = new System.Drawing.Point(126, 348);
            this.txt_UrlImagenProducto.Name = "txt_UrlImagenProducto";
            this.txt_UrlImagenProducto.PlaceholderText = "OPCIONAL - PEGUE URL DE IMAGEN";
            this.txt_UrlImagenProducto.Size = new System.Drawing.Size(390, 23);
            this.txt_UrlImagenProducto.TabIndex = 8;
            // 
            // pb_ImagenProducto
            // 
            this.pb_ImagenProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.pb_ImagenProducto.ImageLocation = "https://www.mio.tv/images/carousel/noimage_poster.png?_v=1.5.70";
            this.pb_ImagenProducto.Location = new System.Drawing.Point(12, 12);
            this.pb_ImagenProducto.Name = "pb_ImagenProducto";
            this.pb_ImagenProducto.Size = new System.Drawing.Size(187, 177);
            this.pb_ImagenProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_ImagenProducto.TabIndex = 48;
            this.pb_ImagenProducto.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.panel1.Controls.Add(this.pb_ImagenProducto);
            this.panel1.Location = new System.Drawing.Point(522, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 201);
            this.panel1.TabIndex = 49;
            // 
            // lbl_UrlImagenProducto
            // 
            this.lbl_UrlImagenProducto.AutoSize = true;
            this.lbl_UrlImagenProducto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_UrlImagenProducto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_UrlImagenProducto.ForeColor = System.Drawing.Color.White;
            this.lbl_UrlImagenProducto.Location = new System.Drawing.Point(14, 356);
            this.lbl_UrlImagenProducto.Name = "lbl_UrlImagenProducto";
            this.lbl_UrlImagenProducto.Size = new System.Drawing.Size(98, 15);
            this.lbl_UrlImagenProducto.TabIndex = 50;
            this.lbl_UrlImagenProducto.Text = "URL Imagen web";
            // 
            // btn_GenerarCodigo
            // 
            this.btn_GenerarCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_GenerarCodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GenerarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_GenerarCodigo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_GenerarCodigo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_GenerarCodigo.Location = new System.Drawing.Point(255, 170);
            this.btn_GenerarCodigo.Name = "btn_GenerarCodigo";
            this.btn_GenerarCodigo.Size = new System.Drawing.Size(113, 23);
            this.btn_GenerarCodigo.TabIndex = 2;
            this.btn_GenerarCodigo.Text = "GENERAR CODIGO";
            this.btn_GenerarCodigo.UseVisualStyleBackColor = false;
            this.btn_GenerarCodigo.Visible = false;
            this.btn_GenerarCodigo.Click += new System.EventHandler(this.btn_GenerarCodigo_Click);
            // 
            // FrmModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(870, 387);
            this.Controls.Add(this.btn_GenerarCodigo);
            this.Controls.Add(this.lbl_UrlImagenProducto);
            this.Controls.Add(this.txt_UrlImagenProducto);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.txt_NombreProductoIngresado);
            this.Controls.Add(this.txt_CaracteristicasProductoIngresado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmb_TipoProductoElegido);
            this.Controls.Add(this.btn_ModificarProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_PrecioUnidadProductoIngresado);
            this.Controls.Add(this.txt_CantidadStockProductoIngresado);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmModificarProducto";
            this.Text = "Modificar Producto";
            this.Load += new System.EventHandler(this.FrmModicarProducto2_Load);
            this.Controls.SetChildIndex(this.lbl_TituloForms, 0);
            this.Controls.SetChildIndex(this.pnl_BarraForms, 0);
            this.Controls.SetChildIndex(this.lbl_CodigoDelProducto, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.txt_CodigoProductoIngresado, 0);
            this.Controls.SetChildIndex(this.txt_CantidadStockProductoIngresado, 0);
            this.Controls.SetChildIndex(this.txt_PrecioUnidadProductoIngresado, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btn_ModificarProducto, 0);
            this.Controls.SetChildIndex(this.cmb_TipoProductoElegido, 0);
            this.Controls.SetChildIndex(this.cmb_TiposProductos, 0);
            this.Controls.SetChildIndex(this.lbl_TipoProducto, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.txt_CaracteristicasProductoIngresado, 0);
            this.Controls.SetChildIndex(this.txt_NombreProductoIngresado, 0);
            this.Controls.SetChildIndex(this.btn_Salir, 0);
            this.Controls.SetChildIndex(this.txt_UrlImagenProducto, 0);
            this.Controls.SetChildIndex(this.lbl_UrlImagenProducto, 0);
            this.Controls.SetChildIndex(this.btn_GenerarCodigo, 0);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CerrarAplicacion)).EndInit();
            this.pnl_BarraForms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ImagenProducto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cmb_TipoProductoElegido;
        private System.Windows.Forms.Button btn_ModificarProducto;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Salir;
        public System.Windows.Forms.TextBox txt_CodigoProductoIngresado;
        public System.Windows.Forms.TextBox txt_PrecioUnidadProductoIngresado;
        public System.Windows.Forms.TextBox txt_CantidadStockProductoIngresado;
        public System.Windows.Forms.TextBox txt_CaracteristicasProductoIngresado;
        public System.Windows.Forms.TextBox txt_NombreProductoIngresado;
        private System.Windows.Forms.TextBox txt_UrlImagenProducto;
        private System.Windows.Forms.PictureBox pb_ImagenProducto;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lbl_UrlImagenProducto;
        private System.Windows.Forms.Button btn_GenerarCodigo;
    }
}