
namespace Cruzeiro
{
    partial class FrmViajes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnListaPasajeros = new System.Windows.Forms.Button();
            this.dataGridViewViajes = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadPartida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracionViaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCrucero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gimnasio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piscina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.espacioBodega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.casinos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.camaroteDisponiblePremium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.camaroteDisponibleTurista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoViaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAtras = new System.Windows.Forms.Button();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViajes)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelContenedor.Controls.Add(this.btnListaPasajeros);
            this.panelContenedor.Controls.Add(this.dataGridViewViajes);
            this.panelContenedor.Controls.Add(this.btnAtras);
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1304, 359);
            this.panelContenedor.TabIndex = 0;
            // 
            // btnListaPasajeros
            // 
            this.btnListaPasajeros.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnListaPasajeros.Location = new System.Drawing.Point(658, 303);
            this.btnListaPasajeros.Name = "btnListaPasajeros";
            this.btnListaPasajeros.Size = new System.Drawing.Size(260, 44);
            this.btnListaPasajeros.TabIndex = 6;
            this.btnListaPasajeros.Text = "LISTA DE PASAJEROS";
            this.btnListaPasajeros.UseVisualStyleBackColor = true;
            this.btnListaPasajeros.Click += new System.EventHandler(this.btnListaPasajeros_Click);
            // 
            // dataGridViewViajes
            // 
            this.dataGridViewViajes.AllowUserToAddRows = false;
            this.dataGridViewViajes.AllowUserToDeleteRows = false;
            this.dataGridViewViajes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewViajes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewViajes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewViajes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewViajes.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewViajes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewViajes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewViajes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewViajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ciudadPartida,
            this.ciudadDestino,
            this.fechaInicio,
            this.fechaLlegada,
            this.duracionViaje,
            this.nombreCrucero,
            this.gimnasio,
            this.piscina,
            this.espacioBodega,
            this.casinos,
            this.camaroteDisponiblePremium,
            this.camaroteDisponibleTurista,
            this.estadoViaje});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewViajes.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewViajes.EnableHeadersVisualStyles = false;
            this.dataGridViewViajes.Location = new System.Drawing.Point(3, 0);
            this.dataGridViewViajes.MultiSelect = false;
            this.dataGridViewViajes.Name = "dataGridViewViajes";
            this.dataGridViewViajes.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewViajes.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewViajes.RowHeadersVisible = false;
            this.dataGridViewViajes.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dataGridViewViajes.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewViajes.RowTemplate.Height = 29;
            this.dataGridViewViajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewViajes.Size = new System.Drawing.Size(1298, 282);
            this.dataGridViewViajes.TabIndex = 0;
            this.dataGridViewViajes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewViajes_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // ciudadPartida
            // 
            this.ciudadPartida.HeaderText = "Ciudad de partida";
            this.ciudadPartida.MinimumWidth = 6;
            this.ciudadPartida.Name = "ciudadPartida";
            this.ciudadPartida.ReadOnly = true;
            // 
            // ciudadDestino
            // 
            this.ciudadDestino.HeaderText = "Ciudad de destino";
            this.ciudadDestino.MinimumWidth = 6;
            this.ciudadDestino.Name = "ciudadDestino";
            this.ciudadDestino.ReadOnly = true;
            // 
            // fechaInicio
            // 
            this.fechaInicio.HeaderText = "Fecha de inicio";
            this.fechaInicio.MinimumWidth = 6;
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.ReadOnly = true;
            // 
            // fechaLlegada
            // 
            this.fechaLlegada.HeaderText = "Fecha de llegada";
            this.fechaLlegada.MinimumWidth = 6;
            this.fechaLlegada.Name = "fechaLlegada";
            this.fechaLlegada.ReadOnly = true;
            // 
            // duracionViaje
            // 
            this.duracionViaje.HeaderText = "Duracion del viaje";
            this.duracionViaje.MinimumWidth = 6;
            this.duracionViaje.Name = "duracionViaje";
            this.duracionViaje.ReadOnly = true;
            // 
            // nombreCrucero
            // 
            this.nombreCrucero.HeaderText = "Nombre de crucero";
            this.nombreCrucero.MinimumWidth = 6;
            this.nombreCrucero.Name = "nombreCrucero";
            this.nombreCrucero.ReadOnly = true;
            // 
            // gimnasio
            // 
            this.gimnasio.HeaderText = "Gimnasio";
            this.gimnasio.MinimumWidth = 6;
            this.gimnasio.Name = "gimnasio";
            this.gimnasio.ReadOnly = true;
            // 
            // piscina
            // 
            this.piscina.HeaderText = "Piscina";
            this.piscina.MinimumWidth = 6;
            this.piscina.Name = "piscina";
            this.piscina.ReadOnly = true;
            // 
            // espacioBodega
            // 
            this.espacioBodega.HeaderText = "Espacio disponible bodega";
            this.espacioBodega.MinimumWidth = 6;
            this.espacioBodega.Name = "espacioBodega";
            this.espacioBodega.ReadOnly = true;
            // 
            // casinos
            // 
            this.casinos.HeaderText = "Casinos";
            this.casinos.MinimumWidth = 6;
            this.casinos.Name = "casinos";
            this.casinos.ReadOnly = true;
            // 
            // camaroteDisponiblePremium
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.camaroteDisponiblePremium.DefaultCellStyle = dataGridViewCellStyle3;
            this.camaroteDisponiblePremium.HeaderText = "Camarotes disponible premium";
            this.camaroteDisponiblePremium.MinimumWidth = 6;
            this.camaroteDisponiblePremium.Name = "camaroteDisponiblePremium";
            this.camaroteDisponiblePremium.ReadOnly = true;
            // 
            // camaroteDisponibleTurista
            // 
            this.camaroteDisponibleTurista.HeaderText = "Camarotes disponible turista";
            this.camaroteDisponibleTurista.MinimumWidth = 6;
            this.camaroteDisponibleTurista.Name = "camaroteDisponibleTurista";
            this.camaroteDisponibleTurista.ReadOnly = true;
            // 
            // estadoViaje
            // 
            this.estadoViaje.HeaderText = "Estado viaje";
            this.estadoViaje.MinimumWidth = 6;
            this.estadoViaje.Name = "estadoViaje";
            this.estadoViaje.ReadOnly = true;
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAtras.Location = new System.Drawing.Point(347, 303);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(260, 44);
            this.btnAtras.TabIndex = 5;
            this.btnAtras.Text = "ATRAS";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // FrmViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 359);
            this.Controls.Add(this.panelContenedor);
            this.Name = "FrmViajes";
            this.Text = "FrmViajes";
            this.panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViajes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Button btnListaPasajeros;
        protected System.Windows.Forms.Button btnAtras;
        protected System.Windows.Forms.DataGridView dataGridViewViajes;
        protected System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadPartida;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaLlegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracionViaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCrucero;
        private System.Windows.Forms.DataGridViewTextBoxColumn gimnasio;
        private System.Windows.Forms.DataGridViewTextBoxColumn piscina;
        private System.Windows.Forms.DataGridViewTextBoxColumn espacioBodega;
        private System.Windows.Forms.DataGridViewTextBoxColumn casinos;
        private System.Windows.Forms.DataGridViewTextBoxColumn camaroteDisponiblePremium;
        private System.Windows.Forms.DataGridViewTextBoxColumn camaroteDisponibleTurista;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoViaje;
    }
}