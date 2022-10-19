
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
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnCargaPasajero = new System.Windows.Forms.Button();
            this.btnCrearViaje = new System.Windows.Forms.Button();
            this.btnListaPasajeros = new System.Windows.Forms.Button();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.btnListaPasajeros);
            this.panelContenedor.Controls.Add(this.btnCrearViaje);
            this.panelContenedor.Controls.Add(this.btnCargaPasajero);
            this.panelContenedor.Controls.Add(this.btnAtras);
            this.panelContenedor.Size = new System.Drawing.Size(1404, 283);
            this.panelContenedor.Controls.SetChildIndex(this.btnAtras, 0);
            this.panelContenedor.Controls.SetChildIndex(this.btnCargaPasajero, 0);
            this.panelContenedor.Controls.SetChildIndex(this.btnCrearViaje, 0);
            this.panelContenedor.Controls.SetChildIndex(this.btnListaPasajeros, 0);
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAtras.Location = new System.Drawing.Point(144, 227);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(133, 44);
            this.btnAtras.TabIndex = 1;
            this.btnAtras.Text = "ATRAS";
            this.btnAtras.UseVisualStyleBackColor = true;
            // 
            // btnCargaPasajero
            // 
            this.btnCargaPasajero.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCargaPasajero.Location = new System.Drawing.Point(660, 227);
            this.btnCargaPasajero.Name = "btnCargaPasajero";
            this.btnCargaPasajero.Size = new System.Drawing.Size(260, 44);
            this.btnCargaPasajero.TabIndex = 2;
            this.btnCargaPasajero.Text = "CARGAR PASAJERO";
            this.btnCargaPasajero.UseVisualStyleBackColor = true;
            // 
            // btnCrearViaje
            // 
            this.btnCrearViaje.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCrearViaje.Location = new System.Drawing.Point(984, 227);
            this.btnCrearViaje.Name = "btnCrearViaje";
            this.btnCrearViaje.Size = new System.Drawing.Size(260, 44);
            this.btnCrearViaje.TabIndex = 3;
            this.btnCrearViaje.Text = "CREAR NUEVO VIAJE";
            this.btnCrearViaje.UseVisualStyleBackColor = true;
            // 
            // btnListaPasajeros
            // 
            this.btnListaPasajeros.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnListaPasajeros.Location = new System.Drawing.Point(336, 227);
            this.btnListaPasajeros.Name = "btnListaPasajeros";
            this.btnListaPasajeros.Size = new System.Drawing.Size(260, 44);
            this.btnListaPasajeros.TabIndex = 4;
            this.btnListaPasajeros.Text = "LISTA DE PASAJEROS";
            this.btnListaPasajeros.UseVisualStyleBackColor = true;
            // 
            // FrmViajesDisponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 283);
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
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnListaPasajeros;
    }
}