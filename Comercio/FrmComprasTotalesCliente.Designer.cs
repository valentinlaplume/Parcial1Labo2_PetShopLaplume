
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
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lst_ListaFacturasCliente
            // 
            this.lst_ListaFacturasCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lst_ListaFacturasCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(187)))), ((int)(((byte)(240)))));
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(634, 365);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.lbl_MontoTotalCliente);
            this.Controls.Add(this.lst_ListaFacturasCliente);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmComprasTotalesCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras Totales Cliente";
            this.Load += new System.EventHandler(this.FrmComprasTotalesCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_ListaFacturasCliente;
        private System.Windows.Forms.Label lbl_MontoTotalCliente;
        private System.Windows.Forms.Label lbl_Titulo;
    }
}