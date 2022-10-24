
namespace Cruzeiro
{
    partial class FrmEstadisticaHistoricas
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
            this.btnDestinos = new System.Windows.Forms.Button();
            this.btnPasajeroFrecuentes = new System.Windows.Forms.Button();
            this.btnHorasCrucero = new System.Windows.Forms.Button();
            this.btnDestinoMasPedido = new System.Windows.Forms.Button();
            this.btnGananciasTotales = new System.Windows.Forms.Button();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListaPasajeros
            // 
            this.btnListaPasajeros.Location = new System.Drawing.Point(162, 325);
            this.btnListaPasajeros.Size = new System.Drawing.Size(161, 44);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(12, 326);
            this.btnAtras.Size = new System.Drawing.Size(144, 44);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.btnGananciasTotales);
            this.panelContenedor.Controls.Add(this.btnDestinoMasPedido);
            this.panelContenedor.Controls.Add(this.btnHorasCrucero);
            this.panelContenedor.Controls.Add(this.btnPasajeroFrecuentes);
            this.panelContenedor.Controls.Add(this.btnDestinos);
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Size = new System.Drawing.Size(1304, 389);
            this.panelContenedor.Controls.SetChildIndex(this.btnAtras, 0);
            this.panelContenedor.Controls.SetChildIndex(this.btnListaPasajeros, 0);
            this.panelContenedor.Controls.SetChildIndex(this.btnDestinos, 0);
            this.panelContenedor.Controls.SetChildIndex(this.btnPasajeroFrecuentes, 0);
            this.panelContenedor.Controls.SetChildIndex(this.btnHorasCrucero, 0);
            this.panelContenedor.Controls.SetChildIndex(this.btnDestinoMasPedido, 0);
            this.panelContenedor.Controls.SetChildIndex(this.btnGananciasTotales, 0);
            // 
            // btnDestinos
            // 
            this.btnDestinos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDestinos.Location = new System.Drawing.Point(525, 326);
            this.btnDestinos.Name = "btnDestinos";
            this.btnDestinos.Size = new System.Drawing.Size(190, 44);
            this.btnDestinos.TabIndex = 7;
            this.btnDestinos.Text = "DESTINOS ORDENADOS";
            this.btnDestinos.UseVisualStyleBackColor = true;
            this.btnDestinos.Click += new System.EventHandler(this.btnDestinos_Click);
            // 
            // btnPasajeroFrecuentes
            // 
            this.btnPasajeroFrecuentes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPasajeroFrecuentes.Location = new System.Drawing.Point(1086, 326);
            this.btnPasajeroFrecuentes.Name = "btnPasajeroFrecuentes";
            this.btnPasajeroFrecuentes.Size = new System.Drawing.Size(190, 44);
            this.btnPasajeroFrecuentes.TabIndex = 8;
            this.btnPasajeroFrecuentes.Text = "PASAJEROS FRECUENTES";
            this.btnPasajeroFrecuentes.UseVisualStyleBackColor = true;
            this.btnPasajeroFrecuentes.Click += new System.EventHandler(this.btnPasajeroFrecuentes_Click);
            // 
            // btnHorasCrucero
            // 
            this.btnHorasCrucero.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnHorasCrucero.Location = new System.Drawing.Point(917, 326);
            this.btnHorasCrucero.Name = "btnHorasCrucero";
            this.btnHorasCrucero.Size = new System.Drawing.Size(163, 44);
            this.btnHorasCrucero.TabIndex = 9;
            this.btnHorasCrucero.Text = "HORAS CRUCEROS";
            this.btnHorasCrucero.UseVisualStyleBackColor = true;
            this.btnHorasCrucero.Click += new System.EventHandler(this.btnHorasCrucero_Click);
            // 
            // btnDestinoMasPedido
            // 
            this.btnDestinoMasPedido.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDestinoMasPedido.Location = new System.Drawing.Point(329, 326);
            this.btnDestinoMasPedido.Name = "btnDestinoMasPedido";
            this.btnDestinoMasPedido.Size = new System.Drawing.Size(190, 44);
            this.btnDestinoMasPedido.TabIndex = 10;
            this.btnDestinoMasPedido.Text = "DESTINO MÁS PEDIDO";
            this.btnDestinoMasPedido.UseVisualStyleBackColor = true;
            this.btnDestinoMasPedido.Click += new System.EventHandler(this.btnDestinoMasPedido_Click);
            // 
            // btnGananciasTotales
            // 
            this.btnGananciasTotales.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGananciasTotales.Location = new System.Drawing.Point(721, 326);
            this.btnGananciasTotales.Name = "btnGananciasTotales";
            this.btnGananciasTotales.Size = new System.Drawing.Size(190, 44);
            this.btnGananciasTotales.TabIndex = 11;
            this.btnGananciasTotales.Text = "GANANCIAS TOTALES";
            this.btnGananciasTotales.UseVisualStyleBackColor = true;
            this.btnGananciasTotales.Click += new System.EventHandler(this.btnGananciasTotales_Click);
            // 
            // FrmEstadisticaHistoricas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 421);
            this.Name = "FrmEstadisticaHistoricas";
            this.Text = "Estadisticas Historicas";
            this.panelContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button btnGananciasTotales;
        protected System.Windows.Forms.Button btnDestinoMasPedido;
        protected System.Windows.Forms.Button btnHorasCrucero;
        protected System.Windows.Forms.Button btnPasajeroFrecuentes;
        protected System.Windows.Forms.Button btnDestinos;
    }
}