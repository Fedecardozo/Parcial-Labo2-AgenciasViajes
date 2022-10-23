
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
            // btnListaPasajeros
            // 
            this.btnListaPasajeros.Location = new System.Drawing.Point(368, 279);
            this.btnListaPasajeros.Size = new System.Drawing.Size(246, 44);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(67, 279);
            this.btnAtras.Size = new System.Drawing.Size(246, 44);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.panelContenedor.Controls.Add(this.btnCrearViaje);
            this.panelContenedor.Controls.Add(this.btnCargaPasajero);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Size = new System.Drawing.Size(1303, 353);
            this.panelContenedor.Controls.SetChildIndex(this.btnCargaPasajero, 0);
            this.panelContenedor.Controls.SetChildIndex(this.btnCrearViaje, 0);
            this.panelContenedor.Controls.SetChildIndex(this.btnAtras, 0);
            this.panelContenedor.Controls.SetChildIndex(this.btnListaPasajeros, 0);
            // 
            // btnCargaPasajero
            // 
            this.btnCargaPasajero.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCargaPasajero.Location = new System.Drawing.Point(677, 279);
            this.btnCargaPasajero.Name = "btnCargaPasajero";
            this.btnCargaPasajero.Size = new System.Drawing.Size(246, 44);
            this.btnCargaPasajero.TabIndex = 2;
            this.btnCargaPasajero.Text = "CARGAR PASAJERO";
            this.btnCargaPasajero.UseVisualStyleBackColor = true;
            this.btnCargaPasajero.Click += new System.EventHandler(this.btnCargaPasajero_Click);
            // 
            // btnCrearViaje
            // 
            this.btnCrearViaje.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCrearViaje.Location = new System.Drawing.Point(981, 279);
            this.btnCrearViaje.Name = "btnCrearViaje";
            this.btnCrearViaje.Size = new System.Drawing.Size(246, 44);
            this.btnCrearViaje.TabIndex = 3;
            this.btnCrearViaje.Text = "CREAR NUEVO VIAJE";
            this.btnCrearViaje.UseVisualStyleBackColor = true;
            this.btnCrearViaje.Click += new System.EventHandler(this.btnCrearViaje_Click);
            // 
            // FrmViajesDisponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 353);
            this.Name = "FrmViajesDisponibles";
            this.Text = "Viajes Disponibles";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmViajesDisponibles_Load);
            this.panelContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearViaje;
        private System.Windows.Forms.Button btnCargaPasajero;
    }
}