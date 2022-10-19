
namespace Cruzeiro
{
    partial class FrmHistorialViajes
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
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListaPasajeros
            // 
            this.btnListaPasajeros.Location = new System.Drawing.Point(709, 282);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(397, 282);
            // 
            // FrmHistorialViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 338);
            this.MinimumSize = new System.Drawing.Size(1422, 385);
            this.Name = "FrmHistorialViajes";
            this.Text = "Historial de viajes";
            this.Load += new System.EventHandler(this.FrmHistorialViajes_Load);
            this.panelContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}