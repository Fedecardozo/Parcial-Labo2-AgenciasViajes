﻿
namespace Cruzeiro
{
    partial class FrmCargaPasajero
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
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBoxKg = new System.Windows.Forms.TextBox();
            this.groupBoxDatosPersonales = new System.Windows.Forms.GroupBox();
            this.comboBoxNacionalidad = new System.Windows.Forms.ComboBox();
            this.comboBoxSexo = new System.Windows.Forms.ComboBox();
            this.textBoxNroPasaporte = new System.Windows.Forms.TextBox();
            this.labelFechaNacimiento = new System.Windows.Forms.Label();
            this.dateTimePickerNacimiento = new System.Windows.Forms.DateTimePicker();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.panelContenedor.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxDatosPersonales.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelContenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContenedor.Controls.Add(this.groupBox4);
            this.panelContenedor.Controls.Add(this.button3);
            this.panelContenedor.Controls.Add(this.btnLimpiar);
            this.panelContenedor.Controls.Add(this.button1);
            this.panelContenedor.Controls.Add(this.groupBox1);
            this.panelContenedor.Controls.Add(this.groupBoxDatosPersonales);
            this.panelContenedor.Location = new System.Drawing.Point(-2, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(632, 516);
            this.panelContenedor.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton7);
            this.groupBox4.Controls.Add(this.radioButton6);
            this.groupBox4.Location = new System.Drawing.Point(382, 256);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(215, 103);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tipo de clase";
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Checked = true;
            this.radioButton7.Location = new System.Drawing.Point(133, 44);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(76, 28);
            this.radioButton7.TabIndex = 1;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Turista";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 44);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(90, 28);
            this.radioButton6.TabIndex = 0;
            this.radioButton6.Text = "Premium";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(124, 447);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 41);
            this.button3.TabIndex = 4;
            this.button3.Text = "Atras";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(444, 389);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(147, 41);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cargar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.textBoxKg);
            this.groupBox1.Location = new System.Drawing.Point(12, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 174);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Equipaje";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton5);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Location = new System.Drawing.Point(13, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(166, 64);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cantidad de valijas";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(111, 29);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(39, 28);
            this.radioButton5.TabIndex = 2;
            this.radioButton5.Text = "2";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(68, 29);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(37, 28);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.Text = "1";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(22, 29);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(40, 28);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "0";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(198, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 64);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bolso de mano";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(85, 29);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 28);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "No";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(22, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(43, 28);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Si";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBoxKg
            // 
            this.textBoxKg.Location = new System.Drawing.Point(13, 114);
            this.textBoxKg.Name = "textBoxKg";
            this.textBoxKg.PlaceholderText = "Kilogramos";
            this.textBoxKg.Size = new System.Drawing.Size(335, 29);
            this.textBoxKg.TabIndex = 1;
            this.textBoxKg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKg_KeyPress);
            // 
            // groupBoxDatosPersonales
            // 
            this.groupBoxDatosPersonales.Controls.Add(this.comboBoxNacionalidad);
            this.groupBoxDatosPersonales.Controls.Add(this.comboBoxSexo);
            this.groupBoxDatosPersonales.Controls.Add(this.textBoxNroPasaporte);
            this.groupBoxDatosPersonales.Controls.Add(this.labelFechaNacimiento);
            this.groupBoxDatosPersonales.Controls.Add(this.dateTimePickerNacimiento);
            this.groupBoxDatosPersonales.Controls.Add(this.textBoxApellido);
            this.groupBoxDatosPersonales.Controls.Add(this.textBoxNombre);
            this.groupBoxDatosPersonales.Location = new System.Drawing.Point(12, 20);
            this.groupBoxDatosPersonales.Name = "groupBoxDatosPersonales";
            this.groupBoxDatosPersonales.Size = new System.Drawing.Size(585, 220);
            this.groupBoxDatosPersonales.TabIndex = 0;
            this.groupBoxDatosPersonales.TabStop = false;
            this.groupBoxDatosPersonales.Text = "Datos personales";
            // 
            // comboBoxNacionalidad
            // 
            this.comboBoxNacionalidad.FormattingEnabled = true;
            this.comboBoxNacionalidad.Items.AddRange(new object[] {
            "AFGANISTAN",
            "ALBANIA",
            "ALEMANIA",
            "ANDORRA",
            "ANGOLA",
            "ANGUILLA",
            "ANTIGUA Y BARBUDA",
            "ANTILLAS HOLANDESAS",
            "ARABIA SAUDI",
            "ARGELIA",
            "ARGENTINA",
            "ARMENIA",
            "ARUBA",
            "AUSTRALIA",
            "AUSTRIA",
            "AZERBAIYAN",
            "BAHAMAS",
            "BAHREIN",
            "BANGLADESH",
            "BARBADOS",
            "BELARUS",
            "BELGICA",
            "BELICE",
            "BENIN",
            "BERMUDAS",
            "BHUTÁN",
            "BOLIVIA",
            "BOSNIA Y HERZEGOVINA",
            "BOTSWANA",
            "BRASIL",
            "BRUNEI",
            "BULGARIA",
            "BURKINA FASO",
            "BURUNDI",
            "CABO VERDE",
            "CAMBOYA",
            "CAMERUN",
            "CANADA",
            "CHAD",
            "CHILE",
            "CHINA",
            "CHIPRE",
            "COLOMBIA",
            "COMORES",
            "CONGO",
            "COREA",
            "COREA DEL NORTE ",
            "COSTA DE MARFIL",
            "COSTA RICA",
            "CROACIA",
            "CUBA",
            "DINAMARCA",
            "DJIBOUTI",
            "DOMINICA",
            "ECUADOR",
            "EGIPTO",
            "EL SALVADOR",
            "EMIRATOS ARABES UNIDOS",
            "ERITREA",
            "ESLOVENIA",
            "ESPAÑA",
            "ESTADOS UNIDOS DE AMERICA",
            "ESTONIA",
            "ETIOPIA",
            "FIJI",
            "FILIPINAS",
            "FINLANDIA",
            "FRANCIA",
            "GABON",
            "GAMBIA",
            "GEORGIA",
            "GHANA",
            "GIBRALTAR",
            "GRANADA",
            "GRECIA",
            "GROENLANDIA",
            "GUADALUPE",
            "GUAM",
            "GUATEMALA",
            "GUAYANA FRANCESA",
            "GUERNESEY",
            "GUINEA",
            "GUINEA ECUATORIAL",
            "GUINEA-BISSAU",
            "GUYANA",
            "HAITI",
            "HONDURAS",
            "HONG KONG",
            "HUNGRIA",
            "INDIA",
            "INDONESIA",
            "IRAN",
            "IRAQ",
            "IRLANDA",
            "ISLA DE MAN",
            "ISLA NORFOLK",
            "ISLANDIA",
            "ISLAS ALAND",
            "ISLAS CAIMÁN",
            "ISLAS COOK",
            "ISLAS DEL CANAL",
            "ISLAS FEROE",
            "ISLAS MALVINAS",
            "ISLAS MARIANAS DEL NORTE",
            "ISLAS MARSHALL",
            "ISLAS PITCAIRN",
            "ISLAS SALOMON",
            "ISLAS TURCAS Y CAICOS",
            "ISLAS VIRGENES BRITANICAS",
            "ISLAS VÍRGENES DE LOS ESTADOS UNIDOS",
            "ISRAEL",
            "ITALIA",
            "JAMAICA",
            "JAPON",
            "JERSEY",
            "JORDANIA",
            "KAZAJSTAN",
            "KENIA",
            "KIRGUISTAN",
            "KIRIBATI",
            "KUWAIT",
            "LAOS",
            "LESOTHO",
            "LETONIA",
            "LIBANO",
            "LIBERIA",
            "LIBIA",
            "LIECHTENSTEIN",
            "LITUANIA",
            "LUXEMBURGO",
            "MACAO",
            "MACEDONIA ",
            "MADAGASCAR",
            "MALASIA",
            "MALAWI",
            "MALDIVAS",
            "MALI",
            "MALTA",
            "MARRUECOS",
            "MARTINICA",
            "MAURICIO",
            "MAURITANIA",
            "MAYOTTE",
            "MEXICO",
            "MICRONESIA",
            "MOLDAVIA",
            "MONACO",
            "MONGOLIA",
            "MONTENEGRO",
            "MONTSERRAT",
            "MOZAMBIQUE",
            "MYANMAR",
            "NAMIBIA",
            "NAURU",
            "NEPAL",
            "NICARAGUA",
            "NIGER",
            "NIGERIA",
            "NIUE",
            "NORUEGA",
            "NUEVA CALEDONIA",
            "NUEVA ZELANDA",
            "OMAN",
            "PAISES BAJOS",
            "PAKISTAN",
            "PALAOS",
            "PALESTINA",
            "PANAMA",
            "PAPUA NUEVA GUINEA",
            "PARAGUAY",
            "PERU",
            "POLINESIA FRANCESA",
            "POLONIA",
            "PORTUGAL",
            "PUERTO RICO",
            "QATAR",
            "REINO UNIDO",
            "REP.DEMOCRATICA DEL CONGO",
            "REPUBLICA CENTROAFRICANA",
            "REPUBLICA CHECA",
            "REPUBLICA DOMINICANA",
            "REPUBLICA ESLOVACA",
            "REUNION",
            "RUANDA",
            "RUMANIA",
            "RUSIA",
            "SAHARA OCCIDENTAL",
            "SAMOA",
            "SAMOA AMERICANA",
            "SAN BARTOLOME",
            "SAN CRISTOBAL Y NIEVES",
            "SAN MARINO",
            "SAN MARTIN (PARTE FRANCESA)",
            "SAN PEDRO Y MIQUELON ",
            "SAN VICENTE Y LAS GRANADINAS",
            "SANTA HELENA",
            "SANTA LUCIA",
            "SANTA SEDE",
            "SANTO TOME Y PRINCIPE",
            "SENEGAL",
            "SERBIA",
            "SEYCHELLES",
            "SIERRA LEONA",
            "SINGAPUR",
            "SIRIA",
            "SOMALIA",
            "SRI LANKA",
            "SUDAFRICA",
            "SUDAN",
            "SUECIA",
            "SUIZA",
            "SURINAM",
            "SVALBARD Y JAN MAYEN",
            "SWAZILANDIA",
            "TADYIKISTAN",
            "TAILANDIA",
            "TANZANIA",
            "TIMOR ORIENTAL",
            "TOGO",
            "TOKELAU",
            "TONGA",
            "TRINIDAD Y TOBAGO",
            "TUNEZ",
            "TURKMENISTAN",
            "TURQUIA",
            "TUVALU",
            "UCRANIA",
            "UGANDA",
            "URUGUAY",
            "UZBEKISTAN",
            "VANUATU",
            "VENEZUELA",
            "VIETNAM",
            "WALLIS Y FORTUNA",
            "YEMEN",
            "ZAMBIA",
            "ZIMBABWE"});
            this.comboBoxNacionalidad.Location = new System.Drawing.Point(322, 93);
            this.comboBoxNacionalidad.Name = "comboBoxNacionalidad";
            this.comboBoxNacionalidad.Size = new System.Drawing.Size(238, 32);
            this.comboBoxNacionalidad.Sorted = true;
            this.comboBoxNacionalidad.TabIndex = 6;
            this.comboBoxNacionalidad.Text = "Nacionalidad";
            // 
            // comboBoxSexo
            // 
            this.comboBoxSexo.FormattingEnabled = true;
            this.comboBoxSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "No binario"});
            this.comboBoxSexo.Location = new System.Drawing.Point(322, 149);
            this.comboBoxSexo.Name = "comboBoxSexo";
            this.comboBoxSexo.Size = new System.Drawing.Size(238, 32);
            this.comboBoxSexo.TabIndex = 5;
            this.comboBoxSexo.Text = "Sexo";
            // 
            // textBoxNroPasaporte
            // 
            this.textBoxNroPasaporte.Location = new System.Drawing.Point(322, 43);
            this.textBoxNroPasaporte.Name = "textBoxNroPasaporte";
            this.textBoxNroPasaporte.PlaceholderText = "Numero de pasaporte";
            this.textBoxNroPasaporte.Size = new System.Drawing.Size(238, 29);
            this.textBoxNroPasaporte.TabIndex = 4;
            this.textBoxNroPasaporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNroPasaporte_KeyPress);
            // 
            // labelFechaNacimiento
            // 
            this.labelFechaNacimiento.AutoSize = true;
            this.labelFechaNacimiento.Font = new System.Drawing.Font("Sitka Banner", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFechaNacimiento.Location = new System.Drawing.Point(21, 150);
            this.labelFechaNacimiento.Name = "labelFechaNacimiento";
            this.labelFechaNacimiento.Size = new System.Drawing.Size(142, 26);
            this.labelFechaNacimiento.TabIndex = 3;
            this.labelFechaNacimiento.Text = "Fecha naciemiento:";
            // 
            // dateTimePickerNacimiento
            // 
            this.dateTimePickerNacimiento.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNacimiento.Location = new System.Drawing.Point(169, 150);
            this.dateTimePickerNacimiento.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerNacimiento.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerNacimiento.Name = "dateTimePickerNacimiento";
            this.dateTimePickerNacimiento.Size = new System.Drawing.Size(128, 27);
            this.dateTimePickerNacimiento.TabIndex = 2;
            this.dateTimePickerNacimiento.Value = new System.DateTime(1997, 12, 24, 0, 0, 0, 0);
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(21, 93);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.PlaceholderText = "Apellido";
            this.textBoxApellido.Size = new System.Drawing.Size(238, 29);
            this.textBoxApellido.TabIndex = 1;
            this.textBoxApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxApellido_KeyPress);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(21, 43);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.PlaceholderText = "Nombre";
            this.textBoxNombre.Size = new System.Drawing.Size(238, 29);
            this.textBoxNombre.TabIndex = 0;
            this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombre_KeyPress);
            // 
            // FrmCargaPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 510);
            this.Controls.Add(this.panelContenedor);
            this.MinimumSize = new System.Drawing.Size(642, 500);
            this.Name = "FrmCargaPasajero";
            this.Text = "Carga de pasajero";
            this.Load += new System.EventHandler(this.FrmCargaPasajero_Load);
            this.panelContenedor.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxDatosPersonales.ResumeLayout(false);
            this.groupBoxDatosPersonales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxKg;
        private System.Windows.Forms.GroupBox groupBoxDatosPersonales;
        private System.Windows.Forms.DateTimePicker dateTimePickerNacimiento;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label labelFechaNacimiento;
        private System.Windows.Forms.TextBox textBoxNroPasaporte;
        private System.Windows.Forms.ComboBox comboBoxSexo;
        private System.Windows.Forms.ComboBox comboBoxNacionalidad;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
    }
}