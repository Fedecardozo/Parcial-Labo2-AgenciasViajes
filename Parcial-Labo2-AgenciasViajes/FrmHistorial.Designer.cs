
namespace Parcial_Labo2_AgenciasViajes
{
    partial class FrmHistorial
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnVisualizarPasajero = new System.Windows.Forms.Button();
            this.dataGridViajes = new System.Windows.Forms.DataGridView();
            this.idViaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadPartida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicioViaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaLLegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cruceroName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pasajesLibres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadTurista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadPremium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoViaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracionViaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVenta = new System.Windows.Forms.Button();
            this.panelListado = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViajes)).BeginInit();
            this.panelListado.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAtras.Location = new System.Drawing.Point(256, 358);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(279, 54);
            this.btnAtras.TabIndex = 1;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnVisualizarPasajero
            // 
            this.btnVisualizarPasajero.Location = new System.Drawing.Point(684, 358);
            this.btnVisualizarPasajero.Name = "btnVisualizarPasajero";
            this.btnVisualizarPasajero.Size = new System.Drawing.Size(279, 54);
            this.btnVisualizarPasajero.TabIndex = 3;
            this.btnVisualizarPasajero.Text = "Visualizar pasajeros";
            this.btnVisualizarPasajero.UseVisualStyleBackColor = true;
            this.btnVisualizarPasajero.Click += new System.EventHandler(this.btnVisualizarPasajero_Click);
            // 
            // dataGridViajes
            // 
            this.dataGridViajes.AllowUserToAddRows = false;
            this.dataGridViajes.AllowUserToDeleteRows = false;
            this.dataGridViajes.AllowUserToResizeColumns = false;
            this.dataGridViajes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridViajes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViajes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViajes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViajes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViajes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViajes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViajes.ColumnHeadersHeight = 29;
            this.dataGridViajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idViaje,
            this.ciudadPartida,
            this.ciudadDestino,
            this.fechaInicioViaje,
            this.fechaLLegada,
            this.cruceroName,
            this.pasajesLibres,
            this.cantidadTurista,
            this.cantidadPremium,
            this.estadoViaje,
            this.duracionViaje});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViajes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViajes.Location = new System.Drawing.Point(23, 27);
            this.dataGridViajes.Name = "dataGridViajes";
            this.dataGridViajes.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViajes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViajes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViajes.RowTemplate.Height = 29;
            this.dataGridViajes.Size = new System.Drawing.Size(1666, 294);
            this.dataGridViajes.TabIndex = 4;
            this.dataGridViajes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViajes_CellContentClick);
            this.dataGridViajes.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridViajes_ColumnAdded);
            // 
            // idViaje
            // 
            this.idViaje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idViaje.HeaderText = "ID";
            this.idViaje.MinimumWidth = 6;
            this.idViaje.Name = "idViaje";
            this.idViaje.ReadOnly = true;
            // 
            // ciudadPartida
            // 
            this.ciudadPartida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ciudadPartida.HeaderText = "Ciudad de Partida";
            this.ciudadPartida.MinimumWidth = 6;
            this.ciudadPartida.Name = "ciudadPartida";
            this.ciudadPartida.ReadOnly = true;
            // 
            // ciudadDestino
            // 
            this.ciudadDestino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ciudadDestino.HeaderText = "Ciudad de Destino";
            this.ciudadDestino.MinimumWidth = 6;
            this.ciudadDestino.Name = "ciudadDestino";
            this.ciudadDestino.ReadOnly = true;
            // 
            // fechaInicioViaje
            // 
            this.fechaInicioViaje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fechaInicioViaje.HeaderText = "Fecha inicio";
            this.fechaInicioViaje.MinimumWidth = 6;
            this.fechaInicioViaje.Name = "fechaInicioViaje";
            this.fechaInicioViaje.ReadOnly = true;
            // 
            // fechaLLegada
            // 
            this.fechaLLegada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fechaLLegada.HeaderText = "Fecha de LLegada";
            this.fechaLLegada.MinimumWidth = 6;
            this.fechaLLegada.Name = "fechaLLegada";
            this.fechaLLegada.ReadOnly = true;
            // 
            // cruceroName
            // 
            this.cruceroName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cruceroName.HeaderText = "Nombre crucero";
            this.cruceroName.MinimumWidth = 6;
            this.cruceroName.Name = "cruceroName";
            this.cruceroName.ReadOnly = true;
            // 
            // pasajesLibres
            // 
            this.pasajesLibres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pasajesLibres.HeaderText = "Pasaje libre";
            this.pasajesLibres.MinimumWidth = 6;
            this.pasajesLibres.Name = "pasajesLibres";
            this.pasajesLibres.ReadOnly = true;
            // 
            // cantidadTurista
            // 
            this.cantidadTurista.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cantidadTurista.HeaderText = "Cantidad pasajeros clase turista";
            this.cantidadTurista.MinimumWidth = 6;
            this.cantidadTurista.Name = "cantidadTurista";
            this.cantidadTurista.ReadOnly = true;
            this.cantidadTurista.Width = 247;
            // 
            // cantidadPremium
            // 
            this.cantidadPremium.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cantidadPremium.HeaderText = "Cantidad pasajeros clase premium";
            this.cantidadPremium.MinimumWidth = 6;
            this.cantidadPremium.Name = "cantidadPremium";
            this.cantidadPremium.ReadOnly = true;
            // 
            // estadoViaje
            // 
            this.estadoViaje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.estadoViaje.HeaderText = "Estado de viaje";
            this.estadoViaje.MinimumWidth = 6;
            this.estadoViaje.Name = "estadoViaje";
            this.estadoViaje.ReadOnly = true;
            // 
            // duracionViaje
            // 
            this.duracionViaje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.duracionViaje.HeaderText = "Duracion Viaje";
            this.duracionViaje.MinimumWidth = 6;
            this.duracionViaje.Name = "duracionViaje";
            this.duracionViaje.ReadOnly = true;
            // 
            // btnVenta
            // 
            this.btnVenta.Location = new System.Drawing.Point(1145, 358);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(279, 54);
            this.btnVenta.TabIndex = 5;
            this.btnVenta.TabStop = false;
            this.btnVenta.Text = "Vender pasaje";
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // panelListado
            // 
            this.panelListado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelListado.AutoScroll = true;
            this.panelListado.Controls.Add(this.dataGridViajes);
            this.panelListado.Controls.Add(this.btnVenta);
            this.panelListado.Controls.Add(this.btnAtras);
            this.panelListado.Controls.Add(this.btnVisualizarPasajero);
            this.panelListado.Location = new System.Drawing.Point(12, 25);
            this.panelListado.MinimumSize = new System.Drawing.Size(1687, 452);
            this.panelListado.Name = "panelListado";
            this.panelListado.Size = new System.Drawing.Size(1728, 452);
            this.panelListado.TabIndex = 6;
            // 
            // FrmHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1774, 503);
            this.Controls.Add(this.panelListado);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FrmHistorial";
            this.Text = "FrmHistorial";
            this.Load += new System.EventHandler(this.FrmHistorial_Load);
            this.SizeChanged += new System.EventHandler(this.FrmHistorial_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViajes)).EndInit();
            this.panelListado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnVisualizarPasajero;
        private System.Windows.Forms.DataGridView dataGridViajes;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Panel panelListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idViaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadPartida;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicioViaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaLLegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn cruceroName;
        private System.Windows.Forms.DataGridViewTextBoxColumn pasajesLibres;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadTurista;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadPremium;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoViaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracionViaje;
    }
}