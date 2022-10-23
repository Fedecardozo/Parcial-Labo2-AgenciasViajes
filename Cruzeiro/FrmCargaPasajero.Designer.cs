
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
            this.rBtnClaseTurista = new System.Windows.Forms.RadioButton();
            this.rBtnClasePremium = new System.Windows.Forms.RadioButton();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxEquipaje = new System.Windows.Forms.GroupBox();
            this.rBtnCantidad2 = new System.Windows.Forms.RadioButton();
            this.rBtnCantidad1 = new System.Windows.Forms.RadioButton();
            this.rBtnCantidad0 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rBtnBolsoManoNo = new System.Windows.Forms.RadioButton();
            this.rBtnBolsoManoSi = new System.Windows.Forms.RadioButton();
            this.textBoxKg = new System.Windows.Forms.TextBox();
            this.groupBoxDatosPersonales = new System.Windows.Forms.GroupBox();
            this.textBoxNroDni = new System.Windows.Forms.TextBox();
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
            this.groupBoxEquipaje.SuspendLayout();
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
            this.panelContenedor.Controls.Add(this.btnAtras);
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
            this.groupBox4.Controls.Add(this.rBtnClaseTurista);
            this.groupBox4.Controls.Add(this.rBtnClasePremium);
            this.groupBox4.Location = new System.Drawing.Point(382, 256);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(215, 103);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tipo de clase";
            // 
            // rBtnClaseTurista
            // 
            this.rBtnClaseTurista.AutoSize = true;
            this.rBtnClaseTurista.Checked = true;
            this.rBtnClaseTurista.Location = new System.Drawing.Point(133, 44);
            this.rBtnClaseTurista.Name = "rBtnClaseTurista";
            this.rBtnClaseTurista.Size = new System.Drawing.Size(76, 28);
            this.rBtnClaseTurista.TabIndex = 1;
            this.rBtnClaseTurista.TabStop = true;
            this.rBtnClaseTurista.Text = "Turista";
            this.rBtnClaseTurista.UseVisualStyleBackColor = true;
            // 
            // rBtnClasePremium
            // 
            this.rBtnClasePremium.AutoSize = true;
            this.rBtnClasePremium.Location = new System.Drawing.Point(6, 44);
            this.rBtnClasePremium.Name = "rBtnClasePremium";
            this.rBtnClasePremium.Size = new System.Drawing.Size(90, 28);
            this.rBtnClasePremium.TabIndex = 0;
            this.rBtnClasePremium.Text = "Premium";
            this.rBtnClasePremium.UseVisualStyleBackColor = true;
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(124, 447);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(147, 41);
            this.btnAtras.TabIndex = 4;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(382, 383);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(209, 41);
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
            this.groupBox1.Controls.Add(this.groupBoxEquipaje);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.textBoxKg);
            this.groupBox1.Location = new System.Drawing.Point(12, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 174);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Equipaje";
            // 
            // groupBoxEquipaje
            // 
            this.groupBoxEquipaje.Controls.Add(this.rBtnCantidad2);
            this.groupBoxEquipaje.Controls.Add(this.rBtnCantidad1);
            this.groupBoxEquipaje.Controls.Add(this.rBtnCantidad0);
            this.groupBoxEquipaje.Location = new System.Drawing.Point(13, 28);
            this.groupBoxEquipaje.Name = "groupBoxEquipaje";
            this.groupBoxEquipaje.Size = new System.Drawing.Size(166, 64);
            this.groupBoxEquipaje.TabIndex = 3;
            this.groupBoxEquipaje.TabStop = false;
            this.groupBoxEquipaje.Text = "Cantidad de valijas";
            // 
            // rBtnCantidad2
            // 
            this.rBtnCantidad2.AutoSize = true;
            this.rBtnCantidad2.Location = new System.Drawing.Point(111, 29);
            this.rBtnCantidad2.Name = "rBtnCantidad2";
            this.rBtnCantidad2.Size = new System.Drawing.Size(39, 28);
            this.rBtnCantidad2.TabIndex = 2;
            this.rBtnCantidad2.Text = "2";
            this.rBtnCantidad2.UseVisualStyleBackColor = true;
            this.rBtnCantidad2.CheckedChanged += new System.EventHandler(this.rBtnCantidad2_CheckedChanged);
            // 
            // rBtnCantidad1
            // 
            this.rBtnCantidad1.AutoSize = true;
            this.rBtnCantidad1.Checked = true;
            this.rBtnCantidad1.Location = new System.Drawing.Point(68, 29);
            this.rBtnCantidad1.Name = "rBtnCantidad1";
            this.rBtnCantidad1.Size = new System.Drawing.Size(37, 28);
            this.rBtnCantidad1.TabIndex = 1;
            this.rBtnCantidad1.TabStop = true;
            this.rBtnCantidad1.Text = "1";
            this.rBtnCantidad1.UseVisualStyleBackColor = true;
            this.rBtnCantidad1.CheckedChanged += new System.EventHandler(this.rBtnCantidad1_CheckedChanged);
            // 
            // rBtnCantidad0
            // 
            this.rBtnCantidad0.AutoSize = true;
            this.rBtnCantidad0.Location = new System.Drawing.Point(22, 29);
            this.rBtnCantidad0.Name = "rBtnCantidad0";
            this.rBtnCantidad0.Size = new System.Drawing.Size(40, 28);
            this.rBtnCantidad0.TabIndex = 0;
            this.rBtnCantidad0.Text = "0";
            this.rBtnCantidad0.UseVisualStyleBackColor = true;
            this.rBtnCantidad0.CheckedChanged += new System.EventHandler(this.rBtnCantidad0_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rBtnBolsoManoNo);
            this.groupBox2.Controls.Add(this.rBtnBolsoManoSi);
            this.groupBox2.Location = new System.Drawing.Point(198, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 64);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bolso de mano";
            // 
            // rBtnBolsoManoNo
            // 
            this.rBtnBolsoManoNo.AutoSize = true;
            this.rBtnBolsoManoNo.Checked = true;
            this.rBtnBolsoManoNo.Location = new System.Drawing.Point(85, 29);
            this.rBtnBolsoManoNo.Name = "rBtnBolsoManoNo";
            this.rBtnBolsoManoNo.Size = new System.Drawing.Size(50, 28);
            this.rBtnBolsoManoNo.TabIndex = 1;
            this.rBtnBolsoManoNo.TabStop = true;
            this.rBtnBolsoManoNo.Text = "No";
            this.rBtnBolsoManoNo.UseVisualStyleBackColor = true;
            // 
            // rBtnBolsoManoSi
            // 
            this.rBtnBolsoManoSi.AutoSize = true;
            this.rBtnBolsoManoSi.Location = new System.Drawing.Point(22, 29);
            this.rBtnBolsoManoSi.Name = "rBtnBolsoManoSi";
            this.rBtnBolsoManoSi.Size = new System.Drawing.Size(43, 28);
            this.rBtnBolsoManoSi.TabIndex = 0;
            this.rBtnBolsoManoSi.Text = "Si";
            this.rBtnBolsoManoSi.UseVisualStyleBackColor = true;
            // 
            // textBoxKg
            // 
            this.textBoxKg.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxKg.Location = new System.Drawing.Point(13, 114);
            this.textBoxKg.Name = "textBoxKg";
            this.textBoxKg.PlaceholderText = "Kilogramos";
            this.textBoxKg.Size = new System.Drawing.Size(335, 27);
            this.textBoxKg.TabIndex = 1;
            this.textBoxKg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKg_KeyPress);
            // 
            // groupBoxDatosPersonales
            // 
            this.groupBoxDatosPersonales.Controls.Add(this.textBoxNroDni);
            this.groupBoxDatosPersonales.Controls.Add(this.comboBoxNacionalidad);
            this.groupBoxDatosPersonales.Controls.Add(this.comboBoxSexo);
            this.groupBoxDatosPersonales.Controls.Add(this.textBoxNroPasaporte);
            this.groupBoxDatosPersonales.Controls.Add(this.labelFechaNacimiento);
            this.groupBoxDatosPersonales.Controls.Add(this.dateTimePickerNacimiento);
            this.groupBoxDatosPersonales.Controls.Add(this.textBoxApellido);
            this.groupBoxDatosPersonales.Controls.Add(this.textBoxNombre);
            this.groupBoxDatosPersonales.Location = new System.Drawing.Point(12, 20);
            this.groupBoxDatosPersonales.Name = "groupBoxDatosPersonales";
            this.groupBoxDatosPersonales.Size = new System.Drawing.Size(585, 230);
            this.groupBoxDatosPersonales.TabIndex = 0;
            this.groupBoxDatosPersonales.TabStop = false;
            this.groupBoxDatosPersonales.Text = "Datos personales";
            // 
            // textBoxNroDni
            // 
            this.textBoxNroDni.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNroDni.Location = new System.Drawing.Point(21, 143);
            this.textBoxNroDni.MaxLength = 8;
            this.textBoxNroDni.Name = "textBoxNroDni";
            this.textBoxNroDni.PlaceholderText = "Numero de documento";
            this.textBoxNroDni.Size = new System.Drawing.Size(238, 27);
            this.textBoxNroDni.TabIndex = 7;
            this.textBoxNroDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
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
            this.comboBoxNacionalidad.Location = new System.Drawing.Point(322, 90);
            this.comboBoxNacionalidad.Name = "comboBoxNacionalidad";
            this.comboBoxNacionalidad.Size = new System.Drawing.Size(238, 32);
            this.comboBoxNacionalidad.Sorted = true;
            this.comboBoxNacionalidad.TabIndex = 6;
            this.comboBoxNacionalidad.Text = "Nacionalidad";
            // 
            // comboBoxSexo
            // 
            this.comboBoxSexo.FormattingEnabled = true;
            this.comboBoxSexo.Location = new System.Drawing.Point(322, 140);
            this.comboBoxSexo.Name = "comboBoxSexo";
            this.comboBoxSexo.Size = new System.Drawing.Size(238, 32);
            this.comboBoxSexo.TabIndex = 5;
            this.comboBoxSexo.Text = "Sexo";
            // 
            // textBoxNroPasaporte
            // 
            this.textBoxNroPasaporte.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNroPasaporte.Location = new System.Drawing.Point(322, 43);
            this.textBoxNroPasaporte.MaxLength = 9;
            this.textBoxNroPasaporte.Name = "textBoxNroPasaporte";
            this.textBoxNroPasaporte.PlaceholderText = "Numero de pasaporte";
            this.textBoxNroPasaporte.Size = new System.Drawing.Size(238, 27);
            this.textBoxNroPasaporte.TabIndex = 4;
            this.textBoxNroPasaporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNroPasaporte_KeyPress);
            // 
            // labelFechaNacimiento
            // 
            this.labelFechaNacimiento.AutoSize = true;
            this.labelFechaNacimiento.Font = new System.Drawing.Font("Sitka Banner", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFechaNacimiento.Location = new System.Drawing.Point(157, 187);
            this.labelFechaNacimiento.Name = "labelFechaNacimiento";
            this.labelFechaNacimiento.Size = new System.Drawing.Size(142, 26);
            this.labelFechaNacimiento.TabIndex = 3;
            this.labelFechaNacimiento.Text = "Fecha naciemiento:";
            // 
            // dateTimePickerNacimiento
            // 
            this.dateTimePickerNacimiento.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNacimiento.Location = new System.Drawing.Point(305, 187);
            this.dateTimePickerNacimiento.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerNacimiento.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerNacimiento.Name = "dateTimePickerNacimiento";
            this.dateTimePickerNacimiento.Size = new System.Drawing.Size(128, 27);
            this.dateTimePickerNacimiento.TabIndex = 2;
            this.dateTimePickerNacimiento.Value = new System.DateTime(1997, 12, 24, 0, 0, 0, 0);
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxApellido.Location = new System.Drawing.Point(21, 93);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.PlaceholderText = "Apellido";
            this.textBoxApellido.Size = new System.Drawing.Size(238, 27);
            this.textBoxApellido.TabIndex = 1;
            this.textBoxApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxApellido_KeyPress);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNombre.Location = new System.Drawing.Point(21, 43);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.PlaceholderText = "Nombre";
            this.textBoxNombre.Size = new System.Drawing.Size(238, 27);
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
            this.groupBoxEquipaje.ResumeLayout(false);
            this.groupBoxEquipaje.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBoxEquipaje;
        private System.Windows.Forms.RadioButton rBtnCantidad2;
        private System.Windows.Forms.RadioButton rBtnCantidad1;
        private System.Windows.Forms.RadioButton rBtnCantidad0;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rBtnBolsoManoNo;
        private System.Windows.Forms.RadioButton rBtnBolsoManoSi;
        private System.Windows.Forms.Label labelFechaNacimiento;
        private System.Windows.Forms.TextBox textBoxNroPasaporte;
        private System.Windows.Forms.ComboBox comboBoxSexo;
        private System.Windows.Forms.ComboBox comboBoxNacionalidad;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rBtnClaseTurista;
        private System.Windows.Forms.RadioButton rBtnClasePremium;
        private System.Windows.Forms.TextBox textBoxNroDni;
    }
}