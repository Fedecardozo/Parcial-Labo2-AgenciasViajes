
namespace Cruzeiro
{
    partial class FrmInformacionEstadistica
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
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.textBoxInformacion = new System.Windows.Forms.TextBox();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelContenedor.Controls.Add(this.btnSalir);
            this.panelContenedor.Controls.Add(this.textBoxInformacion);
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(714, 450);
            this.panelContenedor.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(285, 382);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(132, 47);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // textBoxInformacion
            // 
            this.textBoxInformacion.Location = new System.Drawing.Point(12, 12);
            this.textBoxInformacion.Multiline = true;
            this.textBoxInformacion.Name = "textBoxInformacion";
            this.textBoxInformacion.ReadOnly = true;
            this.textBoxInformacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInformacion.Size = new System.Drawing.Size(690, 347);
            this.textBoxInformacion.TabIndex = 0;
            // 
            // FrmInformacionEstadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 450);
            this.Controls.Add(this.panelContenedor);
            this.MinimumSize = new System.Drawing.Size(732, 497);
            this.Name = "FrmInformacionEstadistica";
            this.Text = "FrmInformacionEstadistica";
            this.Load += new System.EventHandler(this.FrmInformacionEstadistica_Load);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox textBoxInformacion;
    }
}