
namespace Parcial_Labo2_AgenciasViajes
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
            this.dataGridPasajeros = new System.Windows.Forms.DataGridView();
            this.NombrePasajero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoPasajero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroPasaporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadBolsos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolsoMano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kgBolsos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPasajeros)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPasajeros
            // 
            this.dataGridPasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPasajeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombrePasajero,
            this.apellidoPasajero,
            this.dni,
            this.fechaNacimiento,
            this.sexo,
            this.nroPasaporte,
            this.cantidadBolsos,
            this.bolsoMano,
            this.kgBolsos});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridPasajeros.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridPasajeros.Location = new System.Drawing.Point(12, 12);
            this.dataGridPasajeros.Name = "dataGridPasajeros";
            this.dataGridPasajeros.RowHeadersWidth = 51;
            this.dataGridPasajeros.RowTemplate.Height = 29;
            this.dataGridPasajeros.Size = new System.Drawing.Size(1273, 319);
            this.dataGridPasajeros.TabIndex = 0;
            // 
            // NombrePasajero
            // 
            this.NombrePasajero.HeaderText = "Nombre";
            this.NombrePasajero.MinimumWidth = 6;
            this.NombrePasajero.Name = "NombrePasajero";
            this.NombrePasajero.Width = 150;
            // 
            // apellidoPasajero
            // 
            this.apellidoPasajero.HeaderText = "Apellido";
            this.apellidoPasajero.MinimumWidth = 6;
            this.apellidoPasajero.Name = "apellidoPasajero";
            this.apellidoPasajero.Width = 150;
            // 
            // dni
            // 
            this.dni.HeaderText = "DNI";
            this.dni.MinimumWidth = 6;
            this.dni.Name = "dni";
            this.dni.Width = 125;
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.HeaderText = "Fecha nacimiento";
            this.fechaNacimiento.MinimumWidth = 6;
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.Width = 170;
            // 
            // sexo
            // 
            this.sexo.HeaderText = "Sexo";
            this.sexo.MinimumWidth = 6;
            this.sexo.Name = "sexo";
            this.sexo.Width = 125;
            // 
            // nroPasaporte
            // 
            this.nroPasaporte.HeaderText = "Numero pasaporte";
            this.nroPasaporte.MinimumWidth = 6;
            this.nroPasaporte.Name = "nroPasaporte";
            this.nroPasaporte.Width = 125;
            // 
            // cantidadBolsos
            // 
            this.cantidadBolsos.HeaderText = "Cantidad bolsos";
            this.cantidadBolsos.MinimumWidth = 6;
            this.cantidadBolsos.Name = "cantidadBolsos";
            this.cantidadBolsos.Width = 125;
            // 
            // bolsoMano
            // 
            this.bolsoMano.HeaderText = "Bolso mano";
            this.bolsoMano.MinimumWidth = 6;
            this.bolsoMano.Name = "bolsoMano";
            this.bolsoMano.Width = 125;
            // 
            // kgBolsos
            // 
            this.kgBolsos.HeaderText = "Kg Bolsos";
            this.kgBolsos.MinimumWidth = 6;
            this.kgBolsos.Name = "kgBolsos";
            this.kgBolsos.Width = 125;
            // 
            // FrmListaPasajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 355);
            this.Controls.Add(this.dataGridPasajeros);
            this.Name = "FrmListaPasajeros";
            this.Text = "FrmListaPasajeros";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPasajeros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPasajeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePasajero;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoPasajero;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroPasaporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadBolsos;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolsoMano;
        private System.Windows.Forms.DataGridViewTextBoxColumn kgBolsos;
    }
}