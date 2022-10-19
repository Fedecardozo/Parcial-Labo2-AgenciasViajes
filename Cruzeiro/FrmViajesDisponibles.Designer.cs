
namespace Cruzeiro
{
    partial class FrmViajesDisponibles
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
            this.btnCargaPasajero = new System.Windows.Forms.Button();
            this.btnCrearViaje = new System.Windows.Forms.Button();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.btnCrearViaje);
            this.panelContenedor.Controls.Add(this.btnCargaPasajero);
            this.panelContenedor.Size = new System.Drawing.Size(1404, 377);
            this.panelContenedor.Controls.SetChildIndex(this.btnAtras, 0);
            this.panelContenedor.Controls.SetChildIndex(this.btnCargaPasajero, 0);
            this.panelContenedor.Controls.SetChildIndex(this.btnCrearViaje, 0);
            this.panelContenedor.Controls.SetChildIndex(this.btnListaPasajeros, 0);
            // 
            // btnListaPasajeros
            // 
            this.btnListaPasajeros.Location = new System.Drawing.Point(397, 297);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(92, 297);
            // 
            // btnCargaPasajero
            // 
            this.btnCargaPasajero.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCargaPasajero.Location = new System.Drawing.Point(700, 297);
            this.btnCargaPasajero.Name = "btnCargaPasajero";
            this.btnCargaPasajero.Size = new System.Drawing.Size(260, 44);
            this.btnCargaPasajero.TabIndex = 2;
            this.btnCargaPasajero.Text = "CARGAR PASAJERO";
            this.btnCargaPasajero.UseVisualStyleBackColor = true;
            // 
            // btnCrearViaje
            // 
            this.btnCrearViaje.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCrearViaje.Location = new System.Drawing.Point(1015, 297);
            this.btnCrearViaje.Name = "btnCrearViaje";
            this.btnCrearViaje.Size = new System.Drawing.Size(260, 44);
            this.btnCrearViaje.TabIndex = 3;
            this.btnCrearViaje.Text = "CREAR NUEVO VIAJE";
            this.btnCrearViaje.UseVisualStyleBackColor = true;
            // 
            // FrmViajesDisponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 377);
            this.MinimumSize = new System.Drawing.Size(1422, 300);
            this.Name = "FrmViajesDisponibles";
            this.Text = "Viajes Disponibles";
            this.Load += new System.EventHandler(this.FrmViajesDisponibles_Load);
            this.panelContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearViaje;
        private System.Windows.Forms.Button btnCargaPasajero;
    }
}