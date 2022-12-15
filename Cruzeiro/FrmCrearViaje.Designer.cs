
namespace Cruzeiro
{
    partial class FrmCrearViaje
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
            this.dataGridViewCruceros = new System.Windows.Forms.DataGridView();
            this.nombreCrucero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piscina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gym = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantCasino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantCamarotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantSalones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacidadBodega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelActulizarFechaDisponible = new System.Windows.Forms.Label();
            this.labelFechaDisponible = new System.Windows.Forms.Label();
            this.btnCrearViaje = new System.Windows.Forms.Button();
            this.groupBoxDestino = new System.Windows.Forms.GroupBox();
            this.rBtnExtraRegional = new System.Windows.Forms.RadioButton();
            this.rBtnRegional = new System.Windows.Forms.RadioButton();
            this.comboBoxDestino = new System.Windows.Forms.ComboBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.labelFecha = new System.Windows.Forms.Label();
            this.dateTimePickerFechaPartida = new System.Windows.Forms.DateTimePicker();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCruceros)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBoxDestino.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelContenedor.Controls.Add(this.dataGridViewCruceros);
            this.panelContenedor.Controls.Add(this.panel1);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1386, 363);
            this.panelContenedor.TabIndex = 0;
            // 
            // dataGridViewCruceros
            // 
            this.dataGridViewCruceros.AllowUserToAddRows = false;
            this.dataGridViewCruceros.AllowUserToDeleteRows = false;
            this.dataGridViewCruceros.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewCruceros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCruceros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCruceros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCruceros.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewCruceros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCruceros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCruceros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCruceros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCruceros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreCrucero,
            this.matricula,
            this.piscina,
            this.gym,
            this.cantCasino,
            this.cantCamarotes,
            this.cantSalones,
            this.capacidadBodega});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCruceros.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCruceros.EnableHeadersVisualStyles = false;
            this.dataGridViewCruceros.Location = new System.Drawing.Point(271, 0);
            this.dataGridViewCruceros.MultiSelect = false;
            this.dataGridViewCruceros.Name = "dataGridViewCruceros";
            this.dataGridViewCruceros.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCruceros.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewCruceros.RowHeadersVisible = false;
            this.dataGridViewCruceros.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            this.dataGridViewCruceros.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewCruceros.RowTemplate.Height = 29;
            this.dataGridViewCruceros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCruceros.Size = new System.Drawing.Size(1115, 366);
            this.dataGridViewCruceros.TabIndex = 1;
            this.dataGridViewCruceros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCruceros_CellContentClick);
            // 
            // nombreCrucero
            // 
            this.nombreCrucero.HeaderText = "Nombre del crucero";
            this.nombreCrucero.MinimumWidth = 6;
            this.nombreCrucero.Name = "nombreCrucero";
            this.nombreCrucero.ReadOnly = true;
            // 
            // matricula
            // 
            this.matricula.HeaderText = "Matricula";
            this.matricula.MinimumWidth = 6;
            this.matricula.Name = "matricula";
            this.matricula.ReadOnly = true;
            // 
            // piscina
            // 
            this.piscina.HeaderText = "Piscina";
            this.piscina.MinimumWidth = 6;
            this.piscina.Name = "piscina";
            this.piscina.ReadOnly = true;
            // 
            // gym
            // 
            this.gym.HeaderText = "Gimnasio";
            this.gym.MinimumWidth = 6;
            this.gym.Name = "gym";
            this.gym.ReadOnly = true;
            // 
            // cantCasino
            // 
            this.cantCasino.HeaderText = "Cantidad de casinos";
            this.cantCasino.MinimumWidth = 6;
            this.cantCasino.Name = "cantCasino";
            this.cantCasino.ReadOnly = true;
            // 
            // cantCamarotes
            // 
            this.cantCamarotes.HeaderText = "Cantidad de camarotes";
            this.cantCamarotes.MinimumWidth = 6;
            this.cantCamarotes.Name = "cantCamarotes";
            this.cantCamarotes.ReadOnly = true;
            // 
            // cantSalones
            // 
            this.cantSalones.HeaderText = "Cantidad de salones";
            this.cantSalones.MinimumWidth = 6;
            this.cantSalones.Name = "cantSalones";
            this.cantSalones.ReadOnly = true;
            // 
            // capacidadBodega
            // 
            this.capacidadBodega.HeaderText = "Capacidad bodega (Kg)";
            this.capacidadBodega.MinimumWidth = 6;
            this.capacidadBodega.Name = "capacidadBodega";
            this.capacidadBodega.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.labelActulizarFechaDisponible);
            this.panel1.Controls.Add(this.labelFechaDisponible);
            this.panel1.Controls.Add(this.btnCrearViaje);
            this.panel1.Controls.Add(this.groupBoxDestino);
            this.panel1.Controls.Add(this.btnAtras);
            this.panel1.Controls.Add(this.labelFecha);
            this.panel1.Controls.Add(this.dateTimePickerFechaPartida);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 363);
            this.panel1.TabIndex = 0;
            // 
            // labelActulizarFechaDisponible
            // 
            this.labelActulizarFechaDisponible.AutoSize = true;
            this.labelActulizarFechaDisponible.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelActulizarFechaDisponible.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelActulizarFechaDisponible.Location = new System.Drawing.Point(171, 23);
            this.labelActulizarFechaDisponible.Name = "labelActulizarFechaDisponible";
            this.labelActulizarFechaDisponible.Size = new System.Drawing.Size(101, 22);
            this.labelActulizarFechaDisponible.TabIndex = 6;
            this.labelActulizarFechaDisponible.Text = "11/12/2022";
            // 
            // labelFechaDisponible
            // 
            this.labelFechaDisponible.AutoSize = true;
            this.labelFechaDisponible.Font = new System.Drawing.Font("Sitka Banner", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFechaDisponible.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFechaDisponible.Location = new System.Drawing.Point(3, 19);
            this.labelFechaDisponible.Name = "labelFechaDisponible";
            this.labelFechaDisponible.Size = new System.Drawing.Size(173, 26);
            this.labelFechaDisponible.TabIndex = 5;
            this.labelFechaDisponible.Text = "Fecha disponible desde:";
            // 
            // btnCrearViaje
            // 
            this.btnCrearViaje.Location = new System.Drawing.Point(29, 239);
            this.btnCrearViaje.Name = "btnCrearViaje";
            this.btnCrearViaje.Size = new System.Drawing.Size(204, 45);
            this.btnCrearViaje.TabIndex = 3;
            this.btnCrearViaje.Text = "Crear viaje";
            this.btnCrearViaje.UseVisualStyleBackColor = true;
            this.btnCrearViaje.Click += new System.EventHandler(this.btnCrearViaje_Click);
            // 
            // groupBoxDestino
            // 
            this.groupBoxDestino.Controls.Add(this.rBtnExtraRegional);
            this.groupBoxDestino.Controls.Add(this.rBtnRegional);
            this.groupBoxDestino.Controls.Add(this.comboBoxDestino);
            this.groupBoxDestino.Location = new System.Drawing.Point(12, 96);
            this.groupBoxDestino.Name = "groupBoxDestino";
            this.groupBoxDestino.Size = new System.Drawing.Size(250, 125);
            this.groupBoxDestino.TabIndex = 4;
            this.groupBoxDestino.TabStop = false;
            this.groupBoxDestino.Text = "Destino";
            // 
            // rBtnExtraRegional
            // 
            this.rBtnExtraRegional.AutoSize = true;
            this.rBtnExtraRegional.Checked = true;
            this.rBtnExtraRegional.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rBtnExtraRegional.Location = new System.Drawing.Point(111, 28);
            this.rBtnExtraRegional.Name = "rBtnExtraRegional";
            this.rBtnExtraRegional.Size = new System.Drawing.Size(123, 28);
            this.rBtnExtraRegional.TabIndex = 5;
            this.rBtnExtraRegional.TabStop = true;
            this.rBtnExtraRegional.Text = "Extra regional";
            this.rBtnExtraRegional.UseVisualStyleBackColor = true;
            this.rBtnExtraRegional.CheckedChanged += new System.EventHandler(this.rBtnExtraRegional_CheckedChanged);
            // 
            // rBtnRegional
            // 
            this.rBtnRegional.AutoSize = true;
            this.rBtnRegional.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rBtnRegional.Location = new System.Drawing.Point(17, 28);
            this.rBtnRegional.Name = "rBtnRegional";
            this.rBtnRegional.Size = new System.Drawing.Size(88, 28);
            this.rBtnRegional.TabIndex = 4;
            this.rBtnRegional.Text = "Regional";
            this.rBtnRegional.UseVisualStyleBackColor = true;
            this.rBtnRegional.CheckedChanged += new System.EventHandler(this.rBtnRegional_CheckedChanged);
            // 
            // comboBoxDestino
            // 
            this.comboBoxDestino.FormattingEnabled = true;
            this.comboBoxDestino.Location = new System.Drawing.Point(6, 77);
            this.comboBoxDestino.Name = "comboBoxDestino";
            this.comboBoxDestino.Size = new System.Drawing.Size(238, 32);
            this.comboBoxDestino.TabIndex = 3;
            this.comboBoxDestino.Text = "Destino";
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(29, 301);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(204, 45);
            this.btnAtras.TabIndex = 2;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Sitka Banner", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFecha.Location = new System.Drawing.Point(0, 56);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(130, 26);
            this.labelFecha.TabIndex = 1;
            this.labelFecha.Text = "Fecha de partida:";
            // 
            // dateTimePickerFechaPartida
            // 
            this.dateTimePickerFechaPartida.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerFechaPartida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaPartida.Location = new System.Drawing.Point(137, 56);
            this.dateTimePickerFechaPartida.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerFechaPartida.MinDate = new System.DateTime(2022, 10, 21, 0, 0, 0, 0);
            this.dateTimePickerFechaPartida.Name = "dateTimePickerFechaPartida";
            this.dateTimePickerFechaPartida.Size = new System.Drawing.Size(128, 27);
            this.dateTimePickerFechaPartida.TabIndex = 0;
            // 
            // FrmCrearViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 363);
            this.Controls.Add(this.panelContenedor);
            this.MinimumSize = new System.Drawing.Size(1252, 410);
            this.Name = "FrmCrearViaje";
            this.Text = "Crear nuevo viaje";
            this.Load += new System.EventHandler(this.FrmCrearViaje_Load);
            this.panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCruceros)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxDestino.ResumeLayout(false);
            this.groupBoxDestino.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCrearViaje;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.GroupBox groupBoxDestino;
        private System.Windows.Forms.RadioButton rBtnExtraRegional;
        private System.Windows.Forms.RadioButton rBtnRegional;
        private System.Windows.Forms.ComboBox comboBoxDestino;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaPartida;
        private System.Windows.Forms.DataGridView dataGridViewCruceros;
        private System.Windows.Forms.Label labelActulizarFechaDisponible;
        private System.Windows.Forms.Label labelFechaDisponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCrucero;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn piscina;
        private System.Windows.Forms.DataGridViewTextBoxColumn gym;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantCasino;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantCamarotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantSalones;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacidadBodega;
    }
}