
namespace Cruzeiro
{
    partial class FrmListaPasajeros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.dataGridViewPasajeros = new System.Windows.Forms.DataGridView();
            this.nombrePasajero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoPasajero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniPasajero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNaciemiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoPasajero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numPasaporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantBolsos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolsoMano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kgBolsos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPasajeros)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.dataGridViewPasajeros);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1398, 291);
            this.panelContenedor.TabIndex = 0;
            // 
            // dataGridViewPasajeros
            // 
            this.dataGridViewPasajeros.AllowUserToAddRows = false;
            this.dataGridViewPasajeros.AllowUserToDeleteRows = false;
            this.dataGridViewPasajeros.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewPasajeros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPasajeros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPasajeros.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewPasajeros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPasajeros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPasajeros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPasajeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombrePasajero,
            this.apellidoPasajero,
            this.dniPasajero,
            this.fechaNaciemiento,
            this.sexoPasajero,
            this.numPasaporte,
            this.cantBolsos,
            this.bolsoMano,
            this.kgBolsos});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPasajeros.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPasajeros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPasajeros.EnableHeadersVisualStyles = false;
            this.dataGridViewPasajeros.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPasajeros.MultiSelect = false;
            this.dataGridViewPasajeros.Name = "dataGridViewPasajeros";
            this.dataGridViewPasajeros.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPasajeros.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewPasajeros.RowHeadersVisible = false;
            this.dataGridViewPasajeros.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dataGridViewPasajeros.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewPasajeros.RowTemplate.Height = 29;
            this.dataGridViewPasajeros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPasajeros.Size = new System.Drawing.Size(1398, 291);
            this.dataGridViewPasajeros.TabIndex = 1;
            // 
            // nombrePasajero
            // 
            this.nombrePasajero.HeaderText = "Nombre";
            this.nombrePasajero.MinimumWidth = 6;
            this.nombrePasajero.Name = "nombrePasajero";
            this.nombrePasajero.ReadOnly = true;
            // 
            // apellidoPasajero
            // 
            this.apellidoPasajero.HeaderText = "Apellido";
            this.apellidoPasajero.MinimumWidth = 6;
            this.apellidoPasajero.Name = "apellidoPasajero";
            this.apellidoPasajero.ReadOnly = true;
            // 
            // dniPasajero
            // 
            this.dniPasajero.HeaderText = "N° Documento";
            this.dniPasajero.MinimumWidth = 6;
            this.dniPasajero.Name = "dniPasajero";
            this.dniPasajero.ReadOnly = true;
            // 
            // fechaNaciemiento
            // 
            this.fechaNaciemiento.HeaderText = "Fecha Nacimento";
            this.fechaNaciemiento.MinimumWidth = 6;
            this.fechaNaciemiento.Name = "fechaNaciemiento";
            this.fechaNaciemiento.ReadOnly = true;
            // 
            // sexoPasajero
            // 
            this.sexoPasajero.HeaderText = "Sexo";
            this.sexoPasajero.MinimumWidth = 6;
            this.sexoPasajero.Name = "sexoPasajero";
            this.sexoPasajero.ReadOnly = true;
            // 
            // numPasaporte
            // 
            this.numPasaporte.HeaderText = "N° Pasaporte";
            this.numPasaporte.MinimumWidth = 6;
            this.numPasaporte.Name = "numPasaporte";
            this.numPasaporte.ReadOnly = true;
            // 
            // cantBolsos
            // 
            this.cantBolsos.HeaderText = "Cantidad de bolsos";
            this.cantBolsos.MinimumWidth = 6;
            this.cantBolsos.Name = "cantBolsos";
            this.cantBolsos.ReadOnly = true;
            // 
            // bolsoMano
            // 
            this.bolsoMano.HeaderText = "Bolso mano";
            this.bolsoMano.MinimumWidth = 6;
            this.bolsoMano.Name = "bolsoMano";
            this.bolsoMano.ReadOnly = true;
            // 
            // kgBolsos
            // 
            this.kgBolsos.HeaderText = "Kg Bolsos";
            this.kgBolsos.MinimumWidth = 6;
            this.kgBolsos.Name = "kgBolsos";
            this.kgBolsos.ReadOnly = true;
            // 
            // FrmListaPasajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 291);
            this.Controls.Add(this.panelContenedor);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MinimumSize = new System.Drawing.Size(1396, 338);
            this.Name = "FrmListaPasajeros";
            this.Text = "Lista de pasajeros";
            this.Load += new System.EventHandler(this.FrmListaPasajeros_Load);
            this.panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPasajeros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        protected System.Windows.Forms.DataGridView dataGridViewPasajeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePasajero;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoPasajero;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniPasajero;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNaciemiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoPasajero;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPasaporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantBolsos;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolsoMano;
        private System.Windows.Forms.DataGridViewTextBoxColumn kgBolsos;
    }
}