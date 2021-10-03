
namespace Comercio
{
    partial class FrmABMTrabajador
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmABMTrabajador));
            this.lbl_DatoCapturado = new System.Windows.Forms.Label();
            this.btn_EliminarUsuario = new System.Windows.Forms.Button();
            this.btn_ModificarUsuario = new System.Windows.Forms.Button();
            this.dgv_ListadoUsuarios = new System.Windows.Forms.DataGridView();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ventas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pb_ImagenUsuario = new System.Windows.Forms.PictureBox();
            this.cmb_TipoUsuarios = new System.Windows.Forms.ComboBox();
            this.lbl_FiltrarPor = new System.Windows.Forms.Label();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.txt_ContraseñaIngresada = new System.Windows.Forms.TextBox();
            this.txt_UrlFotoPerfilIngresada = new System.Windows.Forms.TextBox();
            this.txt_UsuarioIngresado = new System.Windows.Forms.TextBox();
            this.lbl_Legajo = new System.Windows.Forms.Label();
            this.txt_LegajoIngresado = new System.Windows.Forms.TextBox();
            this.txt_NombreIngresado = new System.Windows.Forms.TextBox();
            this.txt_ApellidoIngresado = new System.Windows.Forms.TextBox();
            this.txt_DniIngresado = new System.Windows.Forms.TextBox();
            this.lbl_Dni = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.lbl_UsuarioNombre = new System.Windows.Forms.Label();
            this.lbl_Contraseña = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_SueldoIngresado = new System.Windows.Forms.TextBox();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.txt_LegajoABuscar = new System.Windows.Forms.TextBox();
            this.lbl_BuscarLegajo = new System.Windows.Forms.Label();
            this.btn_BuscarLegajo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_CerrarAplicacion = new System.Windows.Forms.PictureBox();
            this.pnl_ModificadorUsuario = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_AgregarUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListadoUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ImagenUsuario)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CerrarAplicacion)).BeginInit();
            this.pnl_ModificadorUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_DatoCapturado
            // 
            this.lbl_DatoCapturado.AutoSize = true;
            this.lbl_DatoCapturado.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_DatoCapturado.ForeColor = System.Drawing.Color.Black;
            this.lbl_DatoCapturado.Location = new System.Drawing.Point(13, 251);
            this.lbl_DatoCapturado.Name = "lbl_DatoCapturado";
            this.lbl_DatoCapturado.Size = new System.Drawing.Size(144, 18);
            this.lbl_DatoCapturado.TabIndex = 9;
            this.lbl_DatoCapturado.Text = "Usuario seleccioando:";
            // 
            // btn_EliminarUsuario
            // 
            this.btn_EliminarUsuario.BackColor = System.Drawing.Color.Salmon;
            this.btn_EliminarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EliminarUsuario.Enabled = false;
            this.btn_EliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_EliminarUsuario.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_EliminarUsuario.Location = new System.Drawing.Point(557, 241);
            this.btn_EliminarUsuario.Name = "btn_EliminarUsuario";
            this.btn_EliminarUsuario.Size = new System.Drawing.Size(98, 27);
            this.btn_EliminarUsuario.TabIndex = 4;
            this.btn_EliminarUsuario.Text = "ELIMINAR";
            this.btn_EliminarUsuario.UseVisualStyleBackColor = false;
            this.btn_EliminarUsuario.Click += new System.EventHandler(this.btn_EliminarUsuario_Click);
            // 
            // btn_ModificarUsuario
            // 
            this.btn_ModificarUsuario.BackColor = System.Drawing.Color.Gold;
            this.btn_ModificarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ModificarUsuario.Enabled = false;
            this.btn_ModificarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ModificarUsuario.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ModificarUsuario.Location = new System.Drawing.Point(453, 242);
            this.btn_ModificarUsuario.Name = "btn_ModificarUsuario";
            this.btn_ModificarUsuario.Size = new System.Drawing.Size(98, 27);
            this.btn_ModificarUsuario.TabIndex = 3;
            this.btn_ModificarUsuario.Text = "MODIFICAR";
            this.btn_ModificarUsuario.UseVisualStyleBackColor = false;
            this.btn_ModificarUsuario.Click += new System.EventHandler(this.btn_ModificarUsuario_Click);
            // 
            // dgv_ListadoUsuarios
            // 
            this.dgv_ListadoUsuarios.AllowUserToAddRows = false;
            this.dgv_ListadoUsuarios.AllowUserToDeleteRows = false;
            this.dgv_ListadoUsuarios.AllowUserToOrderColumns = true;
            this.dgv_ListadoUsuarios.AllowUserToResizeColumns = false;
            this.dgv_ListadoUsuarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_ListadoUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ListadoUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.dgv_ListadoUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ListadoUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ListadoUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListadoUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Legajo,
            this.Dni,
            this.Nombre,
            this.Apellido,
            this.User,
            this.Sueldo,
            this.Ventas});
            this.dgv_ListadoUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_ListadoUsuarios.GridColor = System.Drawing.Color.DarkSalmon;
            this.dgv_ListadoUsuarios.Location = new System.Drawing.Point(12, 48);
            this.dgv_ListadoUsuarios.MultiSelect = false;
            this.dgv_ListadoUsuarios.Name = "dgv_ListadoUsuarios";
            this.dgv_ListadoUsuarios.ReadOnly = true;
            this.dgv_ListadoUsuarios.RowTemplate.Height = 25;
            this.dgv_ListadoUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ListadoUsuarios.Size = new System.Drawing.Size(643, 186);
            this.dgv_ListadoUsuarios.TabIndex = 10;
            this.dgv_ListadoUsuarios.TabStop = false;
            this.dgv_ListadoUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ListadoUsuarios_CellContentClick_1);
            // 
            // Legajo
            // 
            this.Legajo.HeaderText = "Legajo";
            this.Legajo.Name = "Legajo";
            this.Legajo.ReadOnly = true;
            this.Legajo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            // User
            // 
            this.User.HeaderText = "User";
            this.User.Name = "User";
            this.User.ReadOnly = true;
            this.User.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Sueldo
            // 
            this.Sueldo.HeaderText = "Sueldo";
            this.Sueldo.Name = "Sueldo";
            this.Sueldo.ReadOnly = true;
            // 
            // Ventas
            // 
            this.Ventas.HeaderText = "Ventas";
            this.Ventas.Name = "Ventas";
            this.Ventas.ReadOnly = true;
            // 
            // pb_ImagenUsuario
            // 
            this.pb_ImagenUsuario.Image = global::Comercio.Properties.Resources.usuarioSinFoto;
            this.pb_ImagenUsuario.ImageLocation = "";
            this.pb_ImagenUsuario.Location = new System.Drawing.Point(4, 1);
            this.pb_ImagenUsuario.Name = "pb_ImagenUsuario";
            this.pb_ImagenUsuario.Size = new System.Drawing.Size(172, 186);
            this.pb_ImagenUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_ImagenUsuario.TabIndex = 11;
            this.pb_ImagenUsuario.TabStop = false;
            this.pb_ImagenUsuario.UseWaitCursor = true;
            // 
            // cmb_TipoUsuarios
            // 
            this.cmb_TipoUsuarios.FormattingEnabled = true;
            this.cmb_TipoUsuarios.Location = new System.Drawing.Point(108, 10);
            this.cmb_TipoUsuarios.Name = "cmb_TipoUsuarios";
            this.cmb_TipoUsuarios.Size = new System.Drawing.Size(121, 23);
            this.cmb_TipoUsuarios.TabIndex = 0;
            this.cmb_TipoUsuarios.SelectedIndexChanged += new System.EventHandler(this.cmb_TipoUsuarios_SelectedIndexChanged);
            // 
            // lbl_FiltrarPor
            // 
            this.lbl_FiltrarPor.AutoSize = true;
            this.lbl_FiltrarPor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_FiltrarPor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_FiltrarPor.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_FiltrarPor.Location = new System.Drawing.Point(12, 16);
            this.lbl_FiltrarPor.Name = "lbl_FiltrarPor";
            this.lbl_FiltrarPor.Size = new System.Drawing.Size(76, 19);
            this.lbl_FiltrarPor.TabIndex = 13;
            this.lbl_FiltrarPor.Text = "Filtrar por:";
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.BackColor = System.Drawing.Color.Gold;
            this.btn_Confirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Confirmar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Confirmar.Location = new System.Drawing.Point(672, 89);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(140, 51);
            this.btn_Confirmar.TabIndex = 11;
            this.btn_Confirmar.Text = "CONFIRMAR MODIFICACION";
            this.btn_Confirmar.UseVisualStyleBackColor = false;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // txt_ContraseñaIngresada
            // 
            this.txt_ContraseñaIngresada.Location = new System.Drawing.Point(361, 335);
            this.txt_ContraseñaIngresada.Name = "txt_ContraseñaIngresada";
            this.txt_ContraseñaIngresada.Size = new System.Drawing.Size(306, 23);
            this.txt_ContraseñaIngresada.TabIndex = 8;
            // 
            // txt_UrlFotoPerfilIngresada
            // 
            this.txt_UrlFotoPerfilIngresada.Location = new System.Drawing.Point(361, 364);
            this.txt_UrlFotoPerfilIngresada.Name = "txt_UrlFotoPerfilIngresada";
            this.txt_UrlFotoPerfilIngresada.PlaceholderText = "OPCIONAL , SI NO DEJAR VACIO";
            this.txt_UrlFotoPerfilIngresada.Size = new System.Drawing.Size(306, 23);
            this.txt_UrlFotoPerfilIngresada.TabIndex = 9;
            // 
            // txt_UsuarioIngresado
            // 
            this.txt_UsuarioIngresado.Location = new System.Drawing.Point(349, 31);
            this.txt_UsuarioIngresado.Name = "txt_UsuarioIngresado";
            this.txt_UsuarioIngresado.Size = new System.Drawing.Size(306, 23);
            this.txt_UsuarioIngresado.TabIndex = 7;
            // 
            // lbl_Legajo
            // 
            this.lbl_Legajo.AutoSize = true;
            this.lbl_Legajo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Legajo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Legajo.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Legajo.Location = new System.Drawing.Point(9, 39);
            this.lbl_Legajo.Name = "lbl_Legajo";
            this.lbl_Legajo.Size = new System.Drawing.Size(45, 15);
            this.lbl_Legajo.TabIndex = 20;
            this.lbl_Legajo.Text = "Legajo:";
            // 
            // txt_LegajoIngresado
            // 
            this.txt_LegajoIngresado.Location = new System.Drawing.Point(83, 31);
            this.txt_LegajoIngresado.Name = "txt_LegajoIngresado";
            this.txt_LegajoIngresado.Size = new System.Drawing.Size(154, 23);
            this.txt_LegajoIngresado.TabIndex = 5;
            this.txt_LegajoIngresado.TabStop = false;
            // 
            // txt_NombreIngresado
            // 
            this.txt_NombreIngresado.Location = new System.Drawing.Point(95, 364);
            this.txt_NombreIngresado.Name = "txt_NombreIngresado";
            this.txt_NombreIngresado.Size = new System.Drawing.Size(154, 23);
            this.txt_NombreIngresado.TabIndex = 5;
            // 
            // txt_ApellidoIngresado
            // 
            this.txt_ApellidoIngresado.Location = new System.Drawing.Point(95, 393);
            this.txt_ApellidoIngresado.Name = "txt_ApellidoIngresado";
            this.txt_ApellidoIngresado.Size = new System.Drawing.Size(154, 23);
            this.txt_ApellidoIngresado.TabIndex = 6;
            // 
            // txt_DniIngresado
            // 
            this.txt_DniIngresado.Location = new System.Drawing.Point(95, 335);
            this.txt_DniIngresado.Name = "txt_DniIngresado";
            this.txt_DniIngresado.Size = new System.Drawing.Size(154, 23);
            this.txt_DniIngresado.TabIndex = 6;
            this.txt_DniIngresado.TabStop = false;
            // 
            // lbl_Dni
            // 
            this.lbl_Dni.AutoSize = true;
            this.lbl_Dni.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Dni.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Dni.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Dni.Location = new System.Drawing.Point(9, 68);
            this.lbl_Dni.Name = "lbl_Dni";
            this.lbl_Dni.Size = new System.Drawing.Size(29, 15);
            this.lbl_Dni.TabIndex = 26;
            this.lbl_Dni.Text = "Dni:";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Nombre.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Nombre.Location = new System.Drawing.Point(9, 100);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(53, 15);
            this.lbl_Nombre.TabIndex = 27;
            this.lbl_Nombre.Text = "Nombre:";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Apellido.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Apellido.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Apellido.Location = new System.Drawing.Point(9, 125);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(56, 15);
            this.lbl_Apellido.TabIndex = 28;
            this.lbl_Apellido.Text = "Apellido:";
            // 
            // lbl_UsuarioNombre
            // 
            this.lbl_UsuarioNombre.AutoSize = true;
            this.lbl_UsuarioNombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_UsuarioNombre.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_UsuarioNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_UsuarioNombre.Location = new System.Drawing.Point(248, 39);
            this.lbl_UsuarioNombre.Name = "lbl_UsuarioNombre";
            this.lbl_UsuarioNombre.Size = new System.Drawing.Size(54, 15);
            this.lbl_UsuarioNombre.TabIndex = 29;
            this.lbl_UsuarioNombre.Text = "Usuario:";
            // 
            // lbl_Contraseña
            // 
            this.lbl_Contraseña.AutoSize = true;
            this.lbl_Contraseña.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Contraseña.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Contraseña.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Contraseña.Location = new System.Drawing.Point(248, 69);
            this.lbl_Contraseña.Name = "lbl_Contraseña";
            this.lbl_Contraseña.Size = new System.Drawing.Size(73, 15);
            this.lbl_Contraseña.TabIndex = 30;
            this.lbl_Contraseña.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(248, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 31;
            this.label1.Text = "URL  foto perfil:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(248, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "Sueldo:               $";
            // 
            // txt_SueldoIngresado
            // 
            this.txt_SueldoIngresado.Location = new System.Drawing.Point(361, 392);
            this.txt_SueldoIngresado.Name = "txt_SueldoIngresado";
            this.txt_SueldoIngresado.Size = new System.Drawing.Size(130, 23);
            this.txt_SueldoIngresado.TabIndex = 10;
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Error.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error.Location = new System.Drawing.Point(698, 52);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(83, 29);
            this.lbl_Error.TabIndex = 34;
            this.lbl_Error.Text = "ERROR";
            this.lbl_Error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Error.Visible = false;
            // 
            // txt_LegajoABuscar
            // 
            this.txt_LegajoABuscar.Location = new System.Drawing.Point(394, 10);
            this.txt_LegajoABuscar.Name = "txt_LegajoABuscar";
            this.txt_LegajoABuscar.PlaceholderText = "INGRESE LEGAJO";
            this.txt_LegajoABuscar.Size = new System.Drawing.Size(134, 23);
            this.txt_LegajoABuscar.TabIndex = 1;
            this.txt_LegajoABuscar.TextChanged += new System.EventHandler(this.txt_LegajoABuscar_TextChanged);
            // 
            // lbl_BuscarLegajo
            // 
            this.lbl_BuscarLegajo.AutoSize = true;
            this.lbl_BuscarLegajo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_BuscarLegajo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_BuscarLegajo.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_BuscarLegajo.Location = new System.Drawing.Point(287, 14);
            this.lbl_BuscarLegajo.Name = "lbl_BuscarLegajo";
            this.lbl_BuscarLegajo.Size = new System.Drawing.Size(101, 19);
            this.lbl_BuscarLegajo.TabIndex = 36;
            this.lbl_BuscarLegajo.Text = "Buscar legajo:";
            // 
            // btn_BuscarLegajo
            // 
            this.btn_BuscarLegajo.BackColor = System.Drawing.Color.Gray;
            this.btn_BuscarLegajo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BuscarLegajo.Enabled = false;
            this.btn_BuscarLegajo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_BuscarLegajo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_BuscarLegajo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_BuscarLegajo.Location = new System.Drawing.Point(534, 10);
            this.btn_BuscarLegajo.Name = "btn_BuscarLegajo";
            this.btn_BuscarLegajo.Size = new System.Drawing.Size(79, 23);
            this.btn_BuscarLegajo.TabIndex = 2;
            this.btn_BuscarLegajo.Text = "BUSCAR";
            this.btn_BuscarLegajo.UseVisualStyleBackColor = false;
            this.btn_BuscarLegajo.Click += new System.EventHandler(this.btn_BuscarLegajo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.panel1.Controls.Add(this.pb_ImagenUsuario);
            this.panel1.Location = new System.Drawing.Point(661, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 186);
            this.panel1.TabIndex = 51;
            // 
            // pb_CerrarAplicacion
            // 
            this.pb_CerrarAplicacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_CerrarAplicacion.Image = global::Comercio.Properties.Resources.button_x;
            this.pb_CerrarAplicacion.Location = new System.Drawing.Point(815, 12);
            this.pb_CerrarAplicacion.Name = "pb_CerrarAplicacion";
            this.pb_CerrarAplicacion.Size = new System.Drawing.Size(27, 21);
            this.pb_CerrarAplicacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_CerrarAplicacion.TabIndex = 52;
            this.pb_CerrarAplicacion.TabStop = false;
            this.pb_CerrarAplicacion.Click += new System.EventHandler(this.pb_CerrarAplicacion_Click);
            // 
            // pnl_ModificadorUsuario
            // 
            this.pnl_ModificadorUsuario.BackColor = System.Drawing.Color.Black;
            this.pnl_ModificadorUsuario.Controls.Add(this.label3);
            this.pnl_ModificadorUsuario.Controls.Add(this.txt_LegajoIngresado);
            this.pnl_ModificadorUsuario.Controls.Add(this.lbl_Error);
            this.pnl_ModificadorUsuario.Controls.Add(this.btn_Confirmar);
            this.pnl_ModificadorUsuario.Controls.Add(this.label2);
            this.pnl_ModificadorUsuario.Controls.Add(this.label1);
            this.pnl_ModificadorUsuario.Controls.Add(this.lbl_UsuarioNombre);
            this.pnl_ModificadorUsuario.Controls.Add(this.lbl_Contraseña);
            this.pnl_ModificadorUsuario.Controls.Add(this.txt_UsuarioIngresado);
            this.pnl_ModificadorUsuario.Controls.Add(this.lbl_Apellido);
            this.pnl_ModificadorUsuario.Controls.Add(this.lbl_Nombre);
            this.pnl_ModificadorUsuario.Controls.Add(this.lbl_Dni);
            this.pnl_ModificadorUsuario.Controls.Add(this.lbl_Legajo);
            this.pnl_ModificadorUsuario.Location = new System.Drawing.Point(12, 275);
            this.pnl_ModificadorUsuario.Name = "pnl_ModificadorUsuario";
            this.pnl_ModificadorUsuario.Size = new System.Drawing.Size(830, 153);
            this.pnl_ModificadorUsuario.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label3.Location = new System.Drawing.Point(9, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 18);
            this.label3.TabIndex = 54;
            this.label3.Text = "MODIFICAR USUARIO";
            // 
            // btn_AgregarUsuario
            // 
            this.btn_AgregarUsuario.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_AgregarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AgregarUsuario.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AgregarUsuario.Location = new System.Drawing.Point(349, 241);
            this.btn_AgregarUsuario.Name = "btn_AgregarUsuario";
            this.btn_AgregarUsuario.Size = new System.Drawing.Size(98, 27);
            this.btn_AgregarUsuario.TabIndex = 54;
            this.btn_AgregarUsuario.Text = "AGREGAR";
            this.btn_AgregarUsuario.UseVisualStyleBackColor = false;
            this.btn_AgregarUsuario.Click += new System.EventHandler(this.btn_AgregarUsuario_Click);
            // 
            // FrmBaseUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(850, 435);
            this.Controls.Add(this.txt_ApellidoIngresado);
            this.Controls.Add(this.txt_NombreIngresado);
            this.Controls.Add(this.txt_DniIngresado);
            this.Controls.Add(this.txt_SueldoIngresado);
            this.Controls.Add(this.txt_UrlFotoPerfilIngresada);
            this.Controls.Add(this.txt_ContraseñaIngresada);
            this.Controls.Add(this.btn_AgregarUsuario);
            this.Controls.Add(this.lbl_DatoCapturado);
            this.Controls.Add(this.btn_EliminarUsuario);
            this.Controls.Add(this.btn_ModificarUsuario);
            this.Controls.Add(this.pnl_ModificadorUsuario);
            this.Controls.Add(this.pb_CerrarAplicacion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_BuscarLegajo);
            this.Controls.Add(this.lbl_BuscarLegajo);
            this.Controls.Add(this.txt_LegajoABuscar);
            this.Controls.Add(this.lbl_FiltrarPor);
            this.Controls.Add(this.cmb_TipoUsuarios);
            this.Controls.Add(this.dgv_ListadoUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmBaseUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmBaseUsuarios";
            this.Load += new System.EventHandler(this.FrmBaseUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListadoUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ImagenUsuario)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_CerrarAplicacion)).EndInit();
            this.pnl_ModificadorUsuario.ResumeLayout(false);
            this.pnl_ModificadorUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_DatoCapturado;
        private System.Windows.Forms.Button btn_EliminarUsuario;
        private System.Windows.Forms.Button btn_ModificarUsuario;
        private System.Windows.Forms.DataGridView dgv_ListadoUsuarios;
        private System.Windows.Forms.PictureBox pb_ImagenUsuario;
        private System.Windows.Forms.ComboBox cmb_TipoUsuarios;
        private System.Windows.Forms.Label lbl_FiltrarPor;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.TextBox txt_ContraseñaIngresada;
        private System.Windows.Forms.TextBox txt_UrlFotoPerfilIngresada;
        private System.Windows.Forms.TextBox txt_UsuarioIngresado;
        private System.Windows.Forms.Label lbl_Legajo;
        private System.Windows.Forms.TextBox txt_LegajoIngresado;
        private System.Windows.Forms.TextBox txt_NombreIngresado;
        private System.Windows.Forms.TextBox txt_ApellidoIngresado;
        private System.Windows.Forms.TextBox txt_DniIngresado;
        private System.Windows.Forms.Label lbl_Dni;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.Label lbl_UsuarioNombre;
        private System.Windows.Forms.Label lbl_Contraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_SueldoIngresado;
        private System.Windows.Forms.Label lbl_Error;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sueldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ventas;
        private System.Windows.Forms.TextBox txt_LegajoABuscar;
        private System.Windows.Forms.Label lbl_BuscarLegajo;
        private System.Windows.Forms.Button btn_BuscarLegajo;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox pb_CerrarAplicacion;
        private System.Windows.Forms.Panel pnl_ModificadorUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_AgregarUsuario;
    }
}