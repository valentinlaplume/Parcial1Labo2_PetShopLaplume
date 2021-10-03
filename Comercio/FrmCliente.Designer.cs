
namespace Comercio
{
    partial class FrmCliente
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
            System.Windows.Forms.Panel pbl_MenuCliente;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.btn_VerTodosClientes = new System.Windows.Forms.Button();
            this.lbl_DniNoEncontrado = new System.Windows.Forms.Label();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.lbl_DatoCapturado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_ListadoClientes = new System.Windows.Forms.DataGridView();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Billetera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Compras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_VerCompras = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.lbl_IngreseDni = new System.Windows.Forms.Label();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_BuscarDni = new System.Windows.Forms.Button();
            this.txt_DniABuscar = new System.Windows.Forms.TextBox();
            this.pb_CerrarAplicacion = new System.Windows.Forms.PictureBox();
            this.txt_NombreIngresado = new System.Windows.Forms.TextBox();
            this.txt_ApellidoIngresado = new System.Windows.Forms.TextBox();
            this.txt_DniIngresado = new System.Windows.Forms.TextBox();
            this.lbl_Billetera = new System.Windows.Forms.Label();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Dni = new System.Windows.Forms.Label();
            this.txt_BilleteraIngresada = new System.Windows.Forms.TextBox();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.btn_ConfirmarModificacion = new System.Windows.Forms.Button();
            this.lbl_AccionARealizar = new System.Windows.Forms.Label();
            this.btn_ConfirmarAlta = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            pbl_MenuCliente = new System.Windows.Forms.Panel();
            pbl_MenuCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListadoClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CerrarAplicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbl_MenuCliente
            // 
            pbl_MenuCliente.BackColor = System.Drawing.Color.Black;
            pbl_MenuCliente.Controls.Add(this.btn_VerTodosClientes);
            pbl_MenuCliente.Controls.Add(this.lbl_DniNoEncontrado);
            pbl_MenuCliente.Controls.Add(this.btn_Agregar);
            pbl_MenuCliente.Controls.Add(this.lbl_DatoCapturado);
            pbl_MenuCliente.Controls.Add(this.label1);
            pbl_MenuCliente.Controls.Add(this.dgv_ListadoClientes);
            pbl_MenuCliente.Controls.Add(this.btn_VerCompras);
            pbl_MenuCliente.Controls.Add(this.btn_Eliminar);
            pbl_MenuCliente.Controls.Add(this.lbl_IngreseDni);
            pbl_MenuCliente.Controls.Add(this.btn_Modificar);
            pbl_MenuCliente.Dock = System.Windows.Forms.DockStyle.Top;
            pbl_MenuCliente.Location = new System.Drawing.Point(0, 0);
            pbl_MenuCliente.Name = "pbl_MenuCliente";
            pbl_MenuCliente.Size = new System.Drawing.Size(751, 274);
            pbl_MenuCliente.TabIndex = 58;
            // 
            // btn_VerTodosClientes
            // 
            this.btn_VerTodosClientes.BackColor = System.Drawing.Color.DimGray;
            this.btn_VerTodosClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_VerTodosClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VerTodosClientes.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_VerTodosClientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_VerTodosClientes.Location = new System.Drawing.Point(649, 243);
            this.btn_VerTodosClientes.Name = "btn_VerTodosClientes";
            this.btn_VerTodosClientes.Size = new System.Drawing.Size(93, 23);
            this.btn_VerTodosClientes.TabIndex = 0;
            this.btn_VerTodosClientes.Text = "VER TODOS";
            this.btn_VerTodosClientes.UseVisualStyleBackColor = false;
            this.btn_VerTodosClientes.Click += new System.EventHandler(this.btn_VerTodosClientes_Click);
            // 
            // lbl_DniNoEncontrado
            // 
            this.lbl_DniNoEncontrado.AutoSize = true;
            this.lbl_DniNoEncontrado.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DniNoEncontrado.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_DniNoEncontrado.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_DniNoEncontrado.Location = new System.Drawing.Point(423, 52);
            this.lbl_DniNoEncontrado.Name = "lbl_DniNoEncontrado";
            this.lbl_DniNoEncontrado.Size = new System.Drawing.Size(273, 18);
            this.lbl_DniNoEncontrado.TabIndex = 57;
            this.lbl_DniNoEncontrado.Text = "DNI no existente entre clientes registrados";
            this.lbl_DniNoEncontrado.Visible = false;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Agregar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Agregar.Location = new System.Drawing.Point(9, 76);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(175, 36);
            this.btn_Agregar.TabIndex = 3;
            this.btn_Agregar.Text = "AGREGAR";
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // lbl_DatoCapturado
            // 
            this.lbl_DatoCapturado.AutoSize = true;
            this.lbl_DatoCapturado.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DatoCapturado.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_DatoCapturado.ForeColor = System.Drawing.Color.White;
            this.lbl_DatoCapturado.Location = new System.Drawing.Point(202, 243);
            this.lbl_DatoCapturado.Name = "lbl_DatoCapturado";
            this.lbl_DatoCapturado.Size = new System.Drawing.Size(183, 23);
            this.lbl_DatoCapturado.TabIndex = 56;
            this.lbl_DatoCapturado.Text = "Cliente seleccionado: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 33);
            this.label1.TabIndex = 55;
            this.label1.Text = "MENU CLIENTE";
            // 
            // dgv_ListadoClientes
            // 
            this.dgv_ListadoClientes.AllowUserToAddRows = false;
            this.dgv_ListadoClientes.AllowUserToDeleteRows = false;
            this.dgv_ListadoClientes.AllowUserToOrderColumns = true;
            this.dgv_ListadoClientes.AllowUserToResizeColumns = false;
            this.dgv_ListadoClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_ListadoClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ListadoClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.dgv_ListadoClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ListadoClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ListadoClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListadoClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dni,
            this.Nombre,
            this.Apellido,
            this.Billetera,
            this.Compras});
            this.dgv_ListadoClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_ListadoClientes.GridColor = System.Drawing.Color.DarkSalmon;
            this.dgv_ListadoClientes.Location = new System.Drawing.Point(202, 76);
            this.dgv_ListadoClientes.MultiSelect = false;
            this.dgv_ListadoClientes.Name = "dgv_ListadoClientes";
            this.dgv_ListadoClientes.ReadOnly = true;
            this.dgv_ListadoClientes.RowTemplate.Height = 25;
            this.dgv_ListadoClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ListadoClientes.Size = new System.Drawing.Size(540, 161);
            this.dgv_ListadoClientes.TabIndex = 11;
            this.dgv_ListadoClientes.TabStop = false;
            this.dgv_ListadoClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ListadoClientes_CellContentClick);
            // 
            // Dni
            // 
            this.Dni.HeaderText = "Dni";
            this.Dni.Name = "Dni";
            this.Dni.ReadOnly = true;
            this.Dni.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Billetera
            // 
            this.Billetera.HeaderText = "Billetera";
            this.Billetera.Name = "Billetera";
            this.Billetera.ReadOnly = true;
            // 
            // Compras
            // 
            this.Compras.HeaderText = "Compras";
            this.Compras.Name = "Compras";
            this.Compras.ReadOnly = true;
            // 
            // btn_VerCompras
            // 
            this.btn_VerCompras.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_VerCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_VerCompras.Enabled = false;
            this.btn_VerCompras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_VerCompras.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_VerCompras.Location = new System.Drawing.Point(9, 202);
            this.btn_VerCompras.Name = "btn_VerCompras";
            this.btn_VerCompras.Size = new System.Drawing.Size(175, 36);
            this.btn_VerCompras.TabIndex = 6;
            this.btn_VerCompras.Text = "HISTORIAL COMPRAS";
            this.btn_VerCompras.UseVisualStyleBackColor = false;
            this.btn_VerCompras.Click += new System.EventHandler(this.btn_VerCompras_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.Salmon;
            this.btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Eliminar.Enabled = false;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Eliminar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Eliminar.Location = new System.Drawing.Point(9, 160);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(175, 36);
            this.btn_Eliminar.TabIndex = 5;
            this.btn_Eliminar.Text = "ELIMINAR";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // lbl_IngreseDni
            // 
            this.lbl_IngreseDni.AutoSize = true;
            this.lbl_IngreseDni.BackColor = System.Drawing.Color.Transparent;
            this.lbl_IngreseDni.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_IngreseDni.ForeColor = System.Drawing.Color.White;
            this.lbl_IngreseDni.Location = new System.Drawing.Point(198, 27);
            this.lbl_IngreseDni.Name = "lbl_IngreseDni";
            this.lbl_IngreseDni.Size = new System.Drawing.Size(82, 18);
            this.lbl_IngreseDni.TabIndex = 59;
            this.lbl_IngreseDni.Text = "Ingrese Dni:";
            this.lbl_IngreseDni.Visible = false;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.Color.Gold;
            this.btn_Modificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Modificar.Enabled = false;
            this.btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Modificar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Modificar.Location = new System.Drawing.Point(9, 118);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(175, 36);
            this.btn_Modificar.TabIndex = 4;
            this.btn_Modificar.Text = "MODIFICAR";
            this.btn_Modificar.UseVisualStyleBackColor = false;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_BuscarDni
            // 
            this.btn_BuscarDni.BackColor = System.Drawing.Color.Gray;
            this.btn_BuscarDni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BuscarDni.Enabled = false;
            this.btn_BuscarDni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_BuscarDni.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_BuscarDni.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_BuscarDni.Location = new System.Drawing.Point(341, 48);
            this.btn_BuscarDni.Name = "btn_BuscarDni";
            this.btn_BuscarDni.Size = new System.Drawing.Size(75, 23);
            this.btn_BuscarDni.TabIndex = 2;
            this.btn_BuscarDni.Text = "BUSCAR";
            this.btn_BuscarDni.UseVisualStyleBackColor = false;
            this.btn_BuscarDni.Click += new System.EventHandler(this.btn_BuscarDni_Click);
            // 
            // txt_DniABuscar
            // 
            this.txt_DniABuscar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_DniABuscar.Location = new System.Drawing.Point(201, 48);
            this.txt_DniABuscar.Name = "txt_DniABuscar";
            this.txt_DniABuscar.PlaceholderText = "DNI";
            this.txt_DniABuscar.Size = new System.Drawing.Size(134, 23);
            this.txt_DniABuscar.TabIndex = 1;
            this.txt_DniABuscar.TextChanged += new System.EventHandler(this.txt_DniABuscar_TextChanged);
            // 
            // pb_CerrarAplicacion
            // 
            this.pb_CerrarAplicacion.BackColor = System.Drawing.Color.Black;
            this.pb_CerrarAplicacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_CerrarAplicacion.Image = global::Comercio.Properties.Resources.button_x;
            this.pb_CerrarAplicacion.Location = new System.Drawing.Point(714, 12);
            this.pb_CerrarAplicacion.Name = "pb_CerrarAplicacion";
            this.pb_CerrarAplicacion.Size = new System.Drawing.Size(27, 21);
            this.pb_CerrarAplicacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_CerrarAplicacion.TabIndex = 53;
            this.pb_CerrarAplicacion.TabStop = false;
            this.pb_CerrarAplicacion.Click += new System.EventHandler(this.pb_CerrarAplicacion_Click);
            // 
            // txt_NombreIngresado
            // 
            this.txt_NombreIngresado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_NombreIngresado.Location = new System.Drawing.Point(202, 332);
            this.txt_NombreIngresado.Name = "txt_NombreIngresado";
            this.txt_NombreIngresado.PlaceholderText = "INGRESE NOMBRE";
            this.txt_NombreIngresado.Size = new System.Drawing.Size(154, 23);
            this.txt_NombreIngresado.TabIndex = 7;
            this.txt_NombreIngresado.Tag = "";
            // 
            // txt_ApellidoIngresado
            // 
            this.txt_ApellidoIngresado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ApellidoIngresado.Location = new System.Drawing.Point(393, 332);
            this.txt_ApellidoIngresado.Name = "txt_ApellidoIngresado";
            this.txt_ApellidoIngresado.PlaceholderText = "INGRESE APELLIDO";
            this.txt_ApellidoIngresado.Size = new System.Drawing.Size(154, 23);
            this.txt_ApellidoIngresado.TabIndex = 8;
            // 
            // txt_DniIngresado
            // 
            this.txt_DniIngresado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_DniIngresado.Location = new System.Drawing.Point(202, 384);
            this.txt_DniIngresado.Name = "txt_DniIngresado";
            this.txt_DniIngresado.PlaceholderText = "INGRESE DNI";
            this.txt_DniIngresado.Size = new System.Drawing.Size(154, 23);
            this.txt_DniIngresado.TabIndex = 9;
            // 
            // lbl_Billetera
            // 
            this.lbl_Billetera.AutoSize = true;
            this.lbl_Billetera.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Billetera.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Billetera.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Billetera.Location = new System.Drawing.Point(393, 366);
            this.lbl_Billetera.Name = "lbl_Billetera";
            this.lbl_Billetera.Size = new System.Drawing.Size(60, 15);
            this.lbl_Billetera.TabIndex = 67;
            this.lbl_Billetera.Text = "Billetera: ";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Apellido.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Apellido.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Apellido.Location = new System.Drawing.Point(393, 314);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(56, 15);
            this.lbl_Apellido.TabIndex = 66;
            this.lbl_Apellido.Text = "Apellido:";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Nombre.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Nombre.Location = new System.Drawing.Point(201, 314);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(53, 15);
            this.lbl_Nombre.TabIndex = 65;
            this.lbl_Nombre.Text = "Nombre:";
            // 
            // lbl_Dni
            // 
            this.lbl_Dni.AutoSize = true;
            this.lbl_Dni.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Dni.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Dni.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Dni.Location = new System.Drawing.Point(201, 366);
            this.lbl_Dni.Name = "lbl_Dni";
            this.lbl_Dni.Size = new System.Drawing.Size(29, 15);
            this.lbl_Dni.TabIndex = 64;
            this.lbl_Dni.Text = "Dni:";
            // 
            // txt_BilleteraIngresada
            // 
            this.txt_BilleteraIngresada.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_BilleteraIngresada.Location = new System.Drawing.Point(393, 384);
            this.txt_BilleteraIngresada.Name = "txt_BilleteraIngresada";
            this.txt_BilleteraIngresada.PlaceholderText = "MONTO BILLETERA";
            this.txt_BilleteraIngresada.Size = new System.Drawing.Size(154, 23);
            this.txt_BilleteraIngresada.TabIndex = 10;
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Error.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error.Location = new System.Drawing.Point(585, 286);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(129, 33);
            this.lbl_Error.TabIndex = 68;
            this.lbl_Error.Text = "* ERROR *";
            this.lbl_Error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Error.Visible = false;
            // 
            // btn_ConfirmarModificacion
            // 
            this.btn_ConfirmarModificacion.BackColor = System.Drawing.Color.Gold;
            this.btn_ConfirmarModificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ConfirmarModificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConfirmarModificacion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ConfirmarModificacion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ConfirmarModificacion.Location = new System.Drawing.Point(565, 373);
            this.btn_ConfirmarModificacion.Name = "btn_ConfirmarModificacion";
            this.btn_ConfirmarModificacion.Size = new System.Drawing.Size(177, 34);
            this.btn_ConfirmarModificacion.TabIndex = 12;
            this.btn_ConfirmarModificacion.Text = "CONFIRMAR MODIFICACION";
            this.btn_ConfirmarModificacion.UseVisualStyleBackColor = false;
            this.btn_ConfirmarModificacion.Click += new System.EventHandler(this.btn_ConfirmarModificacion_Click);
            // 
            // lbl_AccionARealizar
            // 
            this.lbl_AccionARealizar.AutoSize = true;
            this.lbl_AccionARealizar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_AccionARealizar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbl_AccionARealizar.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_AccionARealizar.Location = new System.Drawing.Point(201, 284);
            this.lbl_AccionARealizar.Name = "lbl_AccionARealizar";
            this.lbl_AccionARealizar.Size = new System.Drawing.Size(156, 26);
            this.lbl_AccionARealizar.TabIndex = 61;
            this.lbl_AccionARealizar.Text = "ACCION ELEGIDA";
            // 
            // btn_ConfirmarAlta
            // 
            this.btn_ConfirmarAlta.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_ConfirmarAlta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ConfirmarAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConfirmarAlta.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ConfirmarAlta.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_ConfirmarAlta.Location = new System.Drawing.Point(565, 332);
            this.btn_ConfirmarAlta.Name = "btn_ConfirmarAlta";
            this.btn_ConfirmarAlta.Size = new System.Drawing.Size(177, 35);
            this.btn_ConfirmarAlta.TabIndex = 11;
            this.btn_ConfirmarAlta.Text = "CONFIRMAR ALTA";
            this.btn_ConfirmarAlta.UseVisualStyleBackColor = false;
            this.btn_ConfirmarAlta.Click += new System.EventHandler(this.btn_ConfirmarAlta_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Comercio.Properties.Resources.en_blanco;
            this.pictureBox1.Location = new System.Drawing.Point(-9, 271);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(751, 418);
            this.Controls.Add(this.txt_DniIngresado);
            this.Controls.Add(this.txt_NombreIngresado);
            this.Controls.Add(this.lbl_Dni);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.pb_CerrarAplicacion);
            this.Controls.Add(this.btn_BuscarDni);
            this.Controls.Add(this.txt_DniABuscar);
            this.Controls.Add(pbl_MenuCliente);
            this.Controls.Add(this.btn_ConfirmarAlta);
            this.Controls.Add(this.lbl_AccionARealizar);
            this.Controls.Add(this.txt_ApellidoIngresado);
            this.Controls.Add(this.lbl_Billetera);
            this.Controls.Add(this.lbl_Apellido);
            this.Controls.Add(this.txt_BilleteraIngresada);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.btn_ConfirmarModificacion);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            pbl_MenuCliente.ResumeLayout(false);
            pbl_MenuCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListadoClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CerrarAplicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_BuscarDni;
        private System.Windows.Forms.TextBox txt_DniABuscar;
        public System.Windows.Forms.PictureBox pb_CerrarAplicacion;
        private System.Windows.Forms.TextBox txt_NombreIngresado;
        private System.Windows.Forms.TextBox txt_ApellidoIngresado;
        private System.Windows.Forms.TextBox txt_DniIngresado;
        private System.Windows.Forms.Label lbl_Billetera;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Dni;
        private System.Windows.Forms.TextBox txt_BilleteraIngresada;
        private System.Windows.Forms.Label lbl_Error;
        private System.Windows.Forms.Button btn_ConfirmarModificacion;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Label lbl_IngreseDni;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_VerCompras;
        private System.Windows.Forms.DataGridView dgv_ListadoClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Billetera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Compras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_DatoCapturado;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label lbl_DniNoEncontrado;
        private System.Windows.Forms.Button btn_VerTodosClientes;
        private System.Windows.Forms.Label lbl_AccionARealizar;
        private System.Windows.Forms.Button btn_ConfirmarAlta;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}