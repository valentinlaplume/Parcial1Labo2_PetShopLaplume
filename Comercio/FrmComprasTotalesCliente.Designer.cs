
namespace Comercio
{
    partial class FrmComprasTotalesCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmComprasTotalesCliente));
            this.lst_ListaFacturasCliente = new System.Windows.Forms.ListBox();
            this.lbl_MontoTotalCliente = new System.Windows.Forms.Label();
            this.pb_CerrarAplicacion = new System.Windows.Forms.PictureBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CerrarAplicacion)).BeginInit();
            this.SuspendLayout();
            // 
            // lst_ListaFacturasCliente
            // 
            this.lst_ListaFacturasCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lst_ListaFacturasCliente.BackColor = System.Drawing.SystemColors.Info;
            this.lst_ListaFacturasCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst_ListaFacturasCliente.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lst_ListaFacturasCliente.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lst_ListaFacturasCliente.FormatString = "D";
            this.lst_ListaFacturasCliente.FormattingEnabled = true;
            this.lst_ListaFacturasCliente.ItemHeight = 15;
            this.lst_ListaFacturasCliente.Location = new System.Drawing.Point(12, 51);
            this.lst_ListaFacturasCliente.Name = "lst_ListaFacturasCliente";
            this.lst_ListaFacturasCliente.Size = new System.Drawing.Size(610, 270);
            this.lst_ListaFacturasCliente.TabIndex = 10;
            this.lst_ListaFacturasCliente.TabStop = false;
            // 
            // lbl_MontoTotalCliente
            // 
            this.lbl_MontoTotalCliente.AutoSize = true;
            this.lbl_MontoTotalCliente.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_MontoTotalCliente.Location = new System.Drawing.Point(12, 326);
            this.lbl_MontoTotalCliente.Name = "lbl_MontoTotalCliente";
            this.lbl_MontoTotalCliente.Size = new System.Drawing.Size(356, 26);
            this.lbl_MontoTotalCliente.TabIndex = 11;
            this.lbl_MontoTotalCliente.Text = "Monto total por las compras del Cliente:";
            // 
            // pb_CerrarAplicacion
            // 
            this.pb_CerrarAplicacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_CerrarAplicacion.Image = global::Comercio.Properties.Resources.button_x;
            this.pb_CerrarAplicacion.Location = new System.Drawing.Point(595, 12);
            this.pb_CerrarAplicacion.Name = "pb_CerrarAplicacion";
            this.pb_CerrarAplicacion.Size = new System.Drawing.Size(27, 21);
            this.pb_CerrarAplicacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_CerrarAplicacion.TabIndex = 12;
            this.pb_CerrarAplicacion.TabStop = false;
            this.pb_CerrarAplicacion.Click += new System.EventHandler(this.pb_CerrarAplicacion_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Titulo.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_Titulo.Location = new System.Drawing.Point(12, 12);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(346, 33);
            this.lbl_Titulo.TabIndex = 74;
            this.lbl_Titulo.Text = "HISTORIAL COMPRAS CLIENTE";
            // 
            // FrmComprasTotalesCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(634, 365);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.pb_CerrarAplicacion);
            this.Controls.Add(this.lbl_MontoTotalCliente);
            this.Controls.Add(this.lst_ListaFacturasCliente);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmComprasTotalesCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras Totales Cliente";
            this.Load += new System.EventHandler(this.FrmComprasTotalesCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_CerrarAplicacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_ListaFacturasCliente;
        private System.Windows.Forms.Label lbl_MontoTotalCliente;
        public System.Windows.Forms.PictureBox pb_CerrarAplicacion;
        private System.Windows.Forms.Label lbl_Titulo;
    }
}