﻿
namespace Parcial_Labo2_AgenciasViajes
{
    partial class FrmSecundario
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.btnNewViaje = new System.Windows.Forms.Button();
            this.btnViajes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(214, 332);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(373, 55);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Location = new System.Drawing.Point(214, 237);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(373, 55);
            this.btnEstadisticas.TabIndex = 6;
            this.btnEstadisticas.Text = "Estadisticas";
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            // 
            // btnNewViaje
            // 
            this.btnNewViaje.Location = new System.Drawing.Point(214, 148);
            this.btnNewViaje.Name = "btnNewViaje";
            this.btnNewViaje.Size = new System.Drawing.Size(373, 55);
            this.btnNewViaje.TabIndex = 5;
            this.btnNewViaje.Text = "Crear nuevo viaje";
            this.btnNewViaje.UseVisualStyleBackColor = true;
            // 
            // btnViajes
            // 
            this.btnViajes.Location = new System.Drawing.Point(214, 64);
            this.btnViajes.Name = "btnViajes";
            this.btnViajes.Size = new System.Drawing.Size(373, 55);
            this.btnViajes.TabIndex = 4;
            this.btnViajes.Text = "Viajes disponibles";
            this.btnViajes.UseVisualStyleBackColor = true;
            // 
            // FrmSecundario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEstadisticas);
            this.Controls.Add(this.btnNewViaje);
            this.Controls.Add(this.btnViajes);
            this.Name = "FrmSecundario";
            this.Text = "FrmSecundario";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.Button btnNewViaje;
        private System.Windows.Forms.Button btnViajes;
    }
}