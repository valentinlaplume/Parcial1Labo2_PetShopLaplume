
namespace Comercio
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.btn_IniciarSesion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.llb_Autocompletar = new System.Windows.Forms.LinkLabel();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.prg_BarraInicioSesion = new System.Windows.Forms.ProgressBar();
            this.pb_CerrarAplicacion = new System.Windows.Forms.PictureBox();
            this.pb_ImagenPerfilUsuario = new System.Windows.Forms.PictureBox();
            this.pnl_FondoImagenUsuario = new System.Windows.Forms.Panel();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.cmb_Usuario = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CerrarAplicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ImagenPerfilUsuario)).BeginInit();
            this.pnl_FondoImagenUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_IniciarSesion
            // 
            this.btn_IniciarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btn_IniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_IniciarSesion.FlatAppearance.BorderSize = 0;
            this.btn_IniciarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(225)))));
            this.btn_IniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_IniciarSesion.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_IniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btn_IniciarSesion.Location = new System.Drawing.Point(369, 279);
            this.btn_IniciarSesion.Name = "btn_IniciarSesion";
            this.btn_IniciarSesion.Size = new System.Drawing.Size(308, 37);
            this.btn_IniciarSesion.TabIndex = 3;
            this.btn_IniciarSesion.Text = "Iniciar sesión";
            this.btn_IniciarSesion.UseVisualStyleBackColor = false;
            this.btn_IniciarSesion.Click += new System.EventHandler(this.btn_IniciarSesion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(-109, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Contraseña";
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Usuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Usuario.Location = new System.Drawing.Point(-85, 176);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(59, 19);
            this.lbl_Usuario.TabIndex = 17;
            this.lbl_Usuario.Text = "Usuario";
            // 
            // llb_Autocompletar
            // 
            this.llb_Autocompletar.ActiveLinkColor = System.Drawing.Color.Lime;
            this.llb_Autocompletar.AutoSize = true;
            this.llb_Autocompletar.BackColor = System.Drawing.Color.Transparent;
            this.llb_Autocompletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llb_Autocompletar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.llb_Autocompletar.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.llb_Autocompletar.Location = new System.Drawing.Point(679, 254);
            this.llb_Autocompletar.Name = "llb_Autocompletar";
            this.llb_Autocompletar.Size = new System.Drawing.Size(80, 14);
            this.llb_Autocompletar.TabIndex = 1;
            this.llb_Autocompletar.TabStop = true;
            this.llb_Autocompletar.Text = "Autocompletar";
            this.llb_Autocompletar.Visible = false;
            this.llb_Autocompletar.VisitedLinkColor = System.Drawing.Color.Lime;
            this.llb_Autocompletar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_Autocompletar_LinkClicked);
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Contraseña.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Contraseña.Location = new System.Drawing.Point(369, 231);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.PasswordChar = '*';
            this.txt_Contraseña.PlaceholderText = "Ejemplo: contraseña123";
            this.txt_Contraseña.Size = new System.Drawing.Size(308, 37);
            this.txt_Contraseña.TabIndex = 2;
            // 
            // prg_BarraInicioSesion
            // 
            this.prg_BarraInicioSesion.Location = new System.Drawing.Point(-3, 327);
            this.prg_BarraInicioSesion.Name = "prg_BarraInicioSesion";
            this.prg_BarraInicioSesion.Size = new System.Drawing.Size(766, 10);
            this.prg_BarraInicioSesion.TabIndex = 19;
            this.prg_BarraInicioSesion.Visible = false;
            // 
            // pb_CerrarAplicacion
            // 
            this.pb_CerrarAplicacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_CerrarAplicacion.Image = ((System.Drawing.Image)(resources.GetObject("pb_CerrarAplicacion.Image")));
            this.pb_CerrarAplicacion.Location = new System.Drawing.Point(720, 12);
            this.pb_CerrarAplicacion.Name = "pb_CerrarAplicacion";
            this.pb_CerrarAplicacion.Size = new System.Drawing.Size(32, 25);
            this.pb_CerrarAplicacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_CerrarAplicacion.TabIndex = 24;
            this.pb_CerrarAplicacion.TabStop = false;
            this.pb_CerrarAplicacion.Click += new System.EventHandler(this.pb_CerrarAplicacion_Click);
            // 
            // pb_ImagenPerfilUsuario
            // 
            this.pb_ImagenPerfilUsuario.BackColor = System.Drawing.Color.Transparent;
            this.pb_ImagenPerfilUsuario.Image = global::Comercio.Properties.Resources.usuarioSinFoto;
            this.pb_ImagenPerfilUsuario.ImageLocation = "";
            this.pb_ImagenPerfilUsuario.Location = new System.Drawing.Point(3, 4);
            this.pb_ImagenPerfilUsuario.Name = "pb_ImagenPerfilUsuario";
            this.pb_ImagenPerfilUsuario.Size = new System.Drawing.Size(178, 164);
            this.pb_ImagenPerfilUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_ImagenPerfilUsuario.TabIndex = 25;
            this.pb_ImagenPerfilUsuario.TabStop = false;
            // 
            // pnl_FondoImagenUsuario
            // 
            this.pnl_FondoImagenUsuario.BackColor = System.Drawing.Color.Khaki;
            this.pnl_FondoImagenUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_FondoImagenUsuario.BackgroundImage")));
            this.pnl_FondoImagenUsuario.Controls.Add(this.pb_ImagenPerfilUsuario);
            this.pnl_FondoImagenUsuario.Location = new System.Drawing.Point(429, 12);
            this.pnl_FondoImagenUsuario.Name = "pnl_FondoImagenUsuario";
            this.pnl_FondoImagenUsuario.Size = new System.Drawing.Size(186, 173);
            this.pnl_FondoImagenUsuario.TabIndex = 26;
            // 
            // pb_Logo
            // 
            this.pb_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(187)))), ((int)(((byte)(240)))));
            this.pb_Logo.Enabled = false;
            this.pb_Logo.Image = global::Comercio.Properties.Resources.logoPetShopNegro;
            this.pb_Logo.Location = new System.Drawing.Point(-3, -2);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(353, 339);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Logo.TabIndex = 27;
            this.pb_Logo.TabStop = false;
            // 
            // cmb_Usuario
            // 
            this.cmb_Usuario.BackColor = System.Drawing.Color.White;
            this.cmb_Usuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_Usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Usuario.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_Usuario.FormattingEnabled = true;
            this.cmb_Usuario.Location = new System.Drawing.Point(369, 191);
            this.cmb_Usuario.Name = "cmb_Usuario";
            this.cmb_Usuario.Size = new System.Drawing.Size(308, 34);
            this.cmb_Usuario.TabIndex = 0;
            this.cmb_Usuario.SelectedIndexChanged += new System.EventHandler(this.cmb_Usuario_SelectedIndexChanged);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(764, 336);
            this.Controls.Add(this.txt_Contraseña);
            this.Controls.Add(this.cmb_Usuario);
            this.Controls.Add(this.btn_IniciarSesion);
            this.Controls.Add(this.prg_BarraInicioSesion);
            this.Controls.Add(this.pb_Logo);
            this.Controls.Add(this.pnl_FondoImagenUsuario);
            this.Controls.Add(this.pb_CerrarAplicacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.llb_Autocompletar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pet Shop - Inicio de Sesión";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_CerrarAplicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ImagenPerfilUsuario)).EndInit();
            this.pnl_FondoImagenUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_IniciarSesion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.LinkLabel llb_Autocompletar;
        private System.Windows.Forms.TextBox txt_Contraseña;
        private System.Windows.Forms.ProgressBar prg_BarraInicioSesion;
        private System.Windows.Forms.PictureBox pb_CerrarAplicacion;
        private System.Windows.Forms.PictureBox pb_ImagenPerfilUsuario;
        private System.Windows.Forms.Panel pnl_FondoImagenUsuario;
        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.ComboBox cmb_Usuario;
    }
}

