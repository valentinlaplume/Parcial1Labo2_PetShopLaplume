
namespace Comercio
{
    partial class FrmVender
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVender));
            this.txt_CantidadProductoIngresado = new System.Windows.Forms.TextBox();
            this.txt_DniClienteIngresado = new System.Windows.Forms.TextBox();
            this.btn_Vender = new System.Windows.Forms.Button();
            this.btn_AgregarAlCarrito = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lst_Carrito = new System.Windows.Forms.ListBox();
            this.lbl_AgregarAlCarrito = new System.Windows.Forms.Label();
            this.lbl_VentaPorEfectivo = new System.Windows.Forms.Label();
            this.lbl_SignoPesosTotalCompra = new System.Windows.Forms.Label();
            this.lbl_TotalCompra = new System.Windows.Forms.Label();
            this.pb_Carrito = new System.Windows.Forms.PictureBox();
            this.btn_DarAltaCliente = new System.Windows.Forms.Button();
            this.btn_ReiniciarCarrito = new System.Windows.Forms.Button();
            this.pnl_MarcoImagenProducto = new System.Windows.Forms.Panel();
            this.pb_FotoProducto = new System.Windows.Forms.PictureBox();
            this.btn_VerQr = new System.Windows.Forms.Button();
            this.btn_VenderPorQr = new System.Windows.Forms.Button();
            this.lbl_VentaPorQr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CerrarAplicacion)).BeginInit();
            this.pnl_BarraForms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Carrito)).BeginInit();
            this.pnl_MarcoImagenProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FotoProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(11, 47);
            this.panel2.Size = new System.Drawing.Size(828, 203);
            // 
            // pb_CerrarAplicacion
            // 
            this.pb_CerrarAplicacion.Location = new System.Drawing.Point(827, 0);
            this.pb_CerrarAplicacion.Size = new System.Drawing.Size(22, 18);
            this.pb_CerrarAplicacion.Click += new System.EventHandler(this.pb_CerrarAplicacion_Click);
            // 
            // lbl_TituloForms
            // 
            this.lbl_TituloForms.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lbl_TituloForms.Location = new System.Drawing.Point(346, 21);
            this.lbl_TituloForms.Size = new System.Drawing.Size(190, 23);
            this.lbl_TituloForms.Text = "VENTA DE PRODUCTOS";
            // 
            // lst_Codigo
            // 
            this.lst_Codigo.SelectedIndexChanged += new System.EventHandler(this.lst_Codigo_SelectedIndexChanged);
            // 
            // lbl_TipoProducto
            // 
            this.lbl_TipoProducto.Location = new System.Drawing.Point(12, 29);
            this.lbl_TipoProducto.Size = new System.Drawing.Size(66, 15);
            this.lbl_TipoProducto.Text = "Filtrar por:";
            // 
            // cmb_TiposProductos
            // 
            this.cmb_TiposProductos.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.cmb_TiposProductos.Location = new System.Drawing.Point(86, 21);
            // 
            // pnl_BarraForms
            // 
            this.pnl_BarraForms.Size = new System.Drawing.Size(850, 19);
            // 
            // lbl_CodigoDelProducto
            // 
            this.lbl_CodigoDelProducto.Location = new System.Drawing.Point(227, 306);
            this.lbl_CodigoDelProducto.Size = new System.Drawing.Size(121, 15);
            this.lbl_CodigoDelProducto.Text = "Codigo del Producto:";
            // 
            // txt_CodigoProductoIngresado
            // 
            this.txt_CodigoProductoIngresado.Location = new System.Drawing.Point(227, 324);
            this.txt_CodigoProductoIngresado.PlaceholderText = "CODIGO SELECCIONADO O INGRESADO";
            this.txt_CodigoProductoIngresado.Size = new System.Drawing.Size(220, 23);
            // 
            // txt_CantidadProductoIngresado
            // 
            this.txt_CantidadProductoIngresado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_CantidadProductoIngresado.Location = new System.Drawing.Point(227, 367);
            this.txt_CantidadProductoIngresado.Name = "txt_CantidadProductoIngresado";
            this.txt_CantidadProductoIngresado.PlaceholderText = "MAYOR A 0";
            this.txt_CantidadProductoIngresado.Size = new System.Drawing.Size(103, 23);
            this.txt_CantidadProductoIngresado.TabIndex = 4;
            // 
            // txt_DniClienteIngresado
            // 
            this.txt_DniClienteIngresado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_DniClienteIngresado.Location = new System.Drawing.Point(227, 280);
            this.txt_DniClienteIngresado.Name = "txt_DniClienteIngresado";
            this.txt_DniClienteIngresado.PlaceholderText = "INGRESE DNI DEL CLIENTE";
            this.txt_DniClienteIngresado.Size = new System.Drawing.Size(220, 23);
            this.txt_DniClienteIngresado.TabIndex = 1;
            // 
            // btn_Vender
            // 
            this.btn_Vender.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Vender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Vender.Enabled = false;
            this.btn_Vender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Vender.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Vender.Location = new System.Drawing.Point(227, 414);
            this.btn_Vender.Name = "btn_Vender";
            this.btn_Vender.Size = new System.Drawing.Size(103, 39);
            this.btn_Vender.TabIndex = 6;
            this.btn_Vender.Text = "VENDER";
            this.btn_Vender.UseVisualStyleBackColor = false;
            this.btn_Vender.Click += new System.EventHandler(this.btn_Vender_Click);
            // 
            // btn_AgregarAlCarrito
            // 
            this.btn_AgregarAlCarrito.BackColor = System.Drawing.Color.Gold;
            this.btn_AgregarAlCarrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AgregarAlCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarAlCarrito.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_AgregarAlCarrito.Location = new System.Drawing.Point(346, 367);
            this.btn_AgregarAlCarrito.Name = "btn_AgregarAlCarrito";
            this.btn_AgregarAlCarrito.Size = new System.Drawing.Size(101, 23);
            this.btn_AgregarAlCarrito.TabIndex = 5;
            this.btn_AgregarAlCarrito.Text = "AGREGAR";
            this.btn_AgregarAlCarrito.UseVisualStyleBackColor = false;
            this.btn_AgregarAlCarrito.Click += new System.EventHandler(this.btn_AgregarAlCarrito_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(227, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(227, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "DNI del Cliente:";
            // 
            // lst_Carrito
            // 
            this.lst_Carrito.BackColor = System.Drawing.SystemColors.Info;
            this.lst_Carrito.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lst_Carrito.FormattingEnabled = true;
            this.lst_Carrito.ItemHeight = 15;
            this.lst_Carrito.Location = new System.Drawing.Point(525, 256);
            this.lst_Carrito.Name = "lst_Carrito";
            this.lst_Carrito.Size = new System.Drawing.Size(313, 139);
            this.lst_Carrito.TabIndex = 9;
            this.lst_Carrito.TabStop = false;
            // 
            // lbl_AgregarAlCarrito
            // 
            this.lbl_AgregarAlCarrito.AutoSize = true;
            this.lbl_AgregarAlCarrito.BackColor = System.Drawing.Color.Transparent;
            this.lbl_AgregarAlCarrito.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_AgregarAlCarrito.Location = new System.Drawing.Point(346, 350);
            this.lbl_AgregarAlCarrito.Name = "lbl_AgregarAlCarrito";
            this.lbl_AgregarAlCarrito.Size = new System.Drawing.Size(101, 15);
            this.lbl_AgregarAlCarrito.TabIndex = 10;
            this.lbl_AgregarAlCarrito.Text = "Agregar al carrito";
            // 
            // lbl_VentaPorEfectivo
            // 
            this.lbl_VentaPorEfectivo.AutoSize = true;
            this.lbl_VentaPorEfectivo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_VentaPorEfectivo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_VentaPorEfectivo.Location = new System.Drawing.Point(227, 398);
            this.lbl_VentaPorEfectivo.Name = "lbl_VentaPorEfectivo";
            this.lbl_VentaPorEfectivo.Size = new System.Drawing.Size(50, 15);
            this.lbl_VentaPorEfectivo.TabIndex = 11;
            this.lbl_VentaPorEfectivo.Text = "Efectivo";
            // 
            // lbl_SignoPesosTotalCompra
            // 
            this.lbl_SignoPesosTotalCompra.AutoSize = true;
            this.lbl_SignoPesosTotalCompra.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_SignoPesosTotalCompra.Location = new System.Drawing.Point(525, 430);
            this.lbl_SignoPesosTotalCompra.Name = "lbl_SignoPesosTotalCompra";
            this.lbl_SignoPesosTotalCompra.Size = new System.Drawing.Size(69, 23);
            this.lbl_SignoPesosTotalCompra.TabIndex = 24;
            this.lbl_SignoPesosTotalCompra.Text = "Total:  $";
            // 
            // lbl_TotalCompra
            // 
            this.lbl_TotalCompra.AutoSize = true;
            this.lbl_TotalCompra.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_TotalCompra.Location = new System.Drawing.Point(591, 430);
            this.lbl_TotalCompra.Name = "lbl_TotalCompra";
            this.lbl_TotalCompra.Size = new System.Drawing.Size(20, 23);
            this.lbl_TotalCompra.TabIndex = 25;
            this.lbl_TotalCompra.Text = "0";
            // 
            // pb_Carrito
            // 
            this.pb_Carrito.BackColor = System.Drawing.Color.Transparent;
            this.pb_Carrito.ErrorImage = global::Comercio.Properties.Resources.carritopngsera;
            this.pb_Carrito.Image = global::Comercio.Properties.Resources.carritoLindo;
            this.pb_Carrito.Location = new System.Drawing.Point(457, 256);
            this.pb_Carrito.Name = "pb_Carrito";
            this.pb_Carrito.Size = new System.Drawing.Size(62, 60);
            this.pb_Carrito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Carrito.TabIndex = 46;
            this.pb_Carrito.TabStop = false;
            // 
            // btn_DarAltaCliente
            // 
            this.btn_DarAltaCliente.BackColor = System.Drawing.Color.Silver;
            this.btn_DarAltaCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DarAltaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DarAltaCliente.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_DarAltaCliente.Location = new System.Drawing.Point(322, 255);
            this.btn_DarAltaCliente.Name = "btn_DarAltaCliente";
            this.btn_DarAltaCliente.Size = new System.Drawing.Size(125, 22);
            this.btn_DarAltaCliente.TabIndex = 2;
            this.btn_DarAltaCliente.Text = "Dar de alta Cliente";
            this.btn_DarAltaCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_DarAltaCliente.UseVisualStyleBackColor = false;
            this.btn_DarAltaCliente.Click += new System.EventHandler(this.btn_DarAltaCliente_Click);
            // 
            // btn_ReiniciarCarrito
            // 
            this.btn_ReiniciarCarrito.BackColor = System.Drawing.Color.Silver;
            this.btn_ReiniciarCarrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ReiniciarCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ReiniciarCarrito.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ReiniciarCarrito.Location = new System.Drawing.Point(713, 398);
            this.btn_ReiniciarCarrito.Name = "btn_ReiniciarCarrito";
            this.btn_ReiniciarCarrito.Size = new System.Drawing.Size(125, 22);
            this.btn_ReiniciarCarrito.TabIndex = 7;
            this.btn_ReiniciarCarrito.Text = "REINICIAR CARRITO";
            this.btn_ReiniciarCarrito.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ReiniciarCarrito.UseVisualStyleBackColor = false;
            this.btn_ReiniciarCarrito.Click += new System.EventHandler(this.btn_ReiniciarCarrito_Click);
            // 
            // pnl_MarcoImagenProducto
            // 
            this.pnl_MarcoImagenProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.pnl_MarcoImagenProducto.Controls.Add(this.pb_FotoProducto);
            this.pnl_MarcoImagenProducto.Location = new System.Drawing.Point(12, 262);
            this.pnl_MarcoImagenProducto.Name = "pnl_MarcoImagenProducto";
            this.pnl_MarcoImagenProducto.Size = new System.Drawing.Size(204, 191);
            this.pnl_MarcoImagenProducto.TabIndex = 55;
            // 
            // pb_FotoProducto
            // 
            this.pb_FotoProducto.Image = global::Comercio.Properties.Resources.en_blanco;
            this.pb_FotoProducto.Location = new System.Drawing.Point(5, 3);
            this.pb_FotoProducto.Name = "pb_FotoProducto";
            this.pb_FotoProducto.Size = new System.Drawing.Size(190, 185);
            this.pb_FotoProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_FotoProducto.TabIndex = 0;
            this.pb_FotoProducto.TabStop = false;
            // 
            // btn_VerQr
            // 
            this.btn_VerQr.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_VerQr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_VerQr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_VerQr.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_VerQr.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_VerQr.Location = new System.Drawing.Point(457, 430);
            this.btn_VerQr.Name = "btn_VerQr";
            this.btn_VerQr.Size = new System.Drawing.Size(39, 23);
            this.btn_VerQr.TabIndex = 56;
            this.btn_VerQr.Text = "Qr";
            this.btn_VerQr.UseVisualStyleBackColor = false;
            this.btn_VerQr.Click += new System.EventHandler(this.btn_VerQr_Click);
            // 
            // btn_VenderPorQr
            // 
            this.btn_VenderPorQr.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_VenderPorQr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_VenderPorQr.Enabled = false;
            this.btn_VenderPorQr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VenderPorQr.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_VenderPorQr.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_VenderPorQr.Location = new System.Drawing.Point(344, 414);
            this.btn_VenderPorQr.Name = "btn_VenderPorQr";
            this.btn_VenderPorQr.Size = new System.Drawing.Size(103, 39);
            this.btn_VenderPorQr.TabIndex = 57;
            this.btn_VenderPorQr.Text = "VENDER";
            this.btn_VenderPorQr.UseVisualStyleBackColor = false;
            this.btn_VenderPorQr.Click += new System.EventHandler(this.btn_VenderPorQr_Click);
            // 
            // lbl_VentaPorQr
            // 
            this.lbl_VentaPorQr.AutoSize = true;
            this.lbl_VentaPorQr.BackColor = System.Drawing.Color.Transparent;
            this.lbl_VentaPorQr.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_VentaPorQr.Location = new System.Drawing.Point(344, 398);
            this.lbl_VentaPorQr.Name = "lbl_VentaPorQr";
            this.lbl_VentaPorQr.Size = new System.Drawing.Size(81, 15);
            this.lbl_VentaPorQr.TabIndex = 58;
            this.lbl_VentaPorQr.Text = "MercadoPago";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(457, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 59;
            this.label1.Text = "Ver:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = global::Comercio.Properties.Resources.carritopngsera;
            this.pictureBox1.Image = global::Comercio.Properties.Resources.pngLogoMercadoPago;
            this.pictureBox1.Location = new System.Drawing.Point(525, 398);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // FrmVender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(187)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(850, 470);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_VentaPorQr);
            this.Controls.Add(this.btn_VenderPorQr);
            this.Controls.Add(this.btn_VerQr);
            this.Controls.Add(this.pnl_MarcoImagenProducto);
            this.Controls.Add(this.btn_ReiniciarCarrito);
            this.Controls.Add(this.txt_DniClienteIngresado);
            this.Controls.Add(this.btn_DarAltaCliente);
            this.Controls.Add(this.btn_AgregarAlCarrito);
            this.Controls.Add(this.pb_Carrito);
            this.Controls.Add(this.lbl_TotalCompra);
            this.Controls.Add(this.lbl_SignoPesosTotalCompra);
            this.Controls.Add(this.btn_Vender);
            this.Controls.Add(this.lbl_AgregarAlCarrito);
            this.Controls.Add(this.lst_Carrito);
            this.Controls.Add(this.lbl_VentaPorEfectivo);
            this.Controls.Add(this.txt_CantidadProductoIngresado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FrmVender";
            this.Text = "Pet Shop Laplume - Vender";
            this.Controls.SetChildIndex(this.lbl_CodigoDelProducto, 0);
            this.Controls.SetChildIndex(this.txt_CodigoProductoIngresado, 0);
            this.Controls.SetChildIndex(this.pnl_BarraForms, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txt_CantidadProductoIngresado, 0);
            this.Controls.SetChildIndex(this.lbl_VentaPorEfectivo, 0);
            this.Controls.SetChildIndex(this.lst_Carrito, 0);
            this.Controls.SetChildIndex(this.lbl_AgregarAlCarrito, 0);
            this.Controls.SetChildIndex(this.btn_Vender, 0);
            this.Controls.SetChildIndex(this.lbl_SignoPesosTotalCompra, 0);
            this.Controls.SetChildIndex(this.lbl_TotalCompra, 0);
            this.Controls.SetChildIndex(this.pb_Carrito, 0);
            this.Controls.SetChildIndex(this.btn_AgregarAlCarrito, 0);
            this.Controls.SetChildIndex(this.btn_DarAltaCliente, 0);
            this.Controls.SetChildIndex(this.cmb_TiposProductos, 0);
            this.Controls.SetChildIndex(this.lbl_TipoProducto, 0);
            this.Controls.SetChildIndex(this.lbl_TituloForms, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.txt_DniClienteIngresado, 0);
            this.Controls.SetChildIndex(this.btn_ReiniciarCarrito, 0);
            this.Controls.SetChildIndex(this.pnl_MarcoImagenProducto, 0);
            this.Controls.SetChildIndex(this.btn_VerQr, 0);
            this.Controls.SetChildIndex(this.btn_VenderPorQr, 0);
            this.Controls.SetChildIndex(this.lbl_VentaPorQr, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CerrarAplicacion)).EndInit();
            this.pnl_BarraForms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Carrito)).EndInit();
            this.pnl_MarcoImagenProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_FotoProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_CantidadProductoIngresado;
        private System.Windows.Forms.TextBox txt_DniClienteIngresado;
        private System.Windows.Forms.Button btn_Vender;
        private System.Windows.Forms.Button btn_AgregarAlCarrito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lst_Carrito;
        private System.Windows.Forms.Label lbl_AgregarAlCarrito;
        private System.Windows.Forms.Label lbl_VentaPorEfectivo;
        private System.Windows.Forms.Label lbl_SignoPesosTotalCompra;
        private System.Windows.Forms.Label lbl_TotalCompra;
        private System.Windows.Forms.PictureBox pb_Carrito;
        private System.Windows.Forms.Button btn_DarAltaCliente;
        public System.Windows.Forms.PictureBox pb_ImagenProducto;
        public System.Windows.Forms.Panel pnl_ImagenProducto;
        private System.Windows.Forms.Button btn_ReiniciarCarrito;
        private System.Windows.Forms.Panel pnl_MarcoImagenProducto;
        private System.Windows.Forms.PictureBox pb_FotoProducto;
        private System.Windows.Forms.Button btn_VerQr;
        private System.Windows.Forms.Button btn_VenderPorQr;
        private System.Windows.Forms.Label lbl_VentaPorQr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}