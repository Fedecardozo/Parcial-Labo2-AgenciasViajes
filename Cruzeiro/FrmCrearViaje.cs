using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Cruzeiro
{
    public partial class FrmCrearViaje : FrmPadre
    {
        private Crucero crucero;

        public FrmCrearViaje()
        {
            InitializeComponent();
        }

        private void FrmCrearViaje_Load(object sender, EventArgs e)
        {
            this.CargarCruceros();
            this.CargaExtraRegionalComboBox();
            this.comboBoxDestino.SelectedIndex = 2;
            IniciarCrucero(this.dataGridViewCruceros.Rows[0].Cells[1].Value.ToString());
        }

        private void CargarCruceros()
        {
            foreach (Crucero item in Harcodeo.ListaCruceros())
            {
                this.dataGridViewCruceros.Rows.Add(item.Nombre,item.Matricula,item.Piscina,item.Gimnsaio,1,1,20);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rBtnExtraRegional_CheckedChanged(object sender, EventArgs e)
        {
            this.CargaExtraRegionalComboBox();
            this.comboBoxDestino.SelectedIndex = 1;
        }

        private void rBtnRegional_CheckedChanged(object sender, EventArgs e)
        {
            this.CargaRegionalComboBox();
            this.comboBoxDestino.SelectedIndex = 1;
        }
        private void dataGridViewCruceros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int obtenerIndex = this.dataGridViewCruceros.CurrentRow.Index;

            string matricula = this.dataGridViewCruceros.Rows[obtenerIndex].Cells[1].Value.ToString();

            this.IniciarCrucero(matricula);
        }
        private void btnCrearViaje_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;

            this.CrearViaje();
            respuesta = MessageBox.Show("¿Desea seguir creando viajes?" , "Continuar" , MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if(respuesta == DialogResult.No)
            {
                this.Close();
            }

        }

        #region Metodos 
        private void CargaExtraRegionalComboBox()
        {
            this.comboBoxDestino.Items.Clear();
            this.comboBoxDestino.Items.Add(EextraRegional.Acapulco);
            this.comboBoxDestino.Items.Add(EextraRegional.Atenas);
            this.comboBoxDestino.Items.Add(EextraRegional.Bangkok);
            this.comboBoxDestino.Items.Add(EextraRegional.La_Habana);
            this.comboBoxDestino.Items.Add(EextraRegional.Miami);
            this.comboBoxDestino.Items.Add(EextraRegional.Nueva_York);
            this.comboBoxDestino.Items.Add(EextraRegional.Taipei);
            this.comboBoxDestino.Items.Add(EextraRegional.Venecia);
        }

        private void CargaRegionalComboBox()
        {
            this.comboBoxDestino.Items.Clear();
            this.comboBoxDestino.Items.Add(Eregional.Cartagena);
            this.comboBoxDestino.Items.Add(Eregional.Isla_de_Pascua);
            this.comboBoxDestino.Items.Add(Eregional.Isla_Galapagos);
            this.comboBoxDestino.Items.Add(Eregional.Lima);
            this.comboBoxDestino.Items.Add(Eregional.Motevideo);
            this.comboBoxDestino.Items.Add(Eregional.Puerto_Madryn);
            this.comboBoxDestino.Items.Add(Eregional.Recife);
            this.comboBoxDestino.Items.Add(Eregional.Rio_de_Janeiro);
            this.comboBoxDestino.Items.Add(Eregional.Santiago);
            this.comboBoxDestino.Items.Add(Eregional.Ushuaia);
        }

        private void CargarFechaInicio()
        {
            this.labelActulizarFechaDisponible.Text = this.crucero.FechaDisponible.ToString("d");
            //this.dateTimePickerFechaPartida.Value = this.crucero.FechaDisponible;
            this.dateTimePickerFechaPartida.MinDate = this.crucero.FechaDisponible;
        }
        
        private void IniciarCrucero(string matricula)
        {
            this.crucero = Crucero.ObtenerCrucero(matricula);

            this.CargarFechaInicio();
        }

        private void CrearViaje()
        {
            if (this.rBtnExtraRegional.Checked)
            {
                HistorialViajes.AgregarViaje(new ViajeExtraRegional(this.dateTimePickerFechaPartida.Value,
                    this.crucero, (EextraRegional)this.comboBoxDestino.SelectedItem));
            }
            else if (this.rBtnRegional.Checked)
            {
                HistorialViajes.AgregarViaje(new ViajeRegional(this.dateTimePickerFechaPartida.Value,
                   this.crucero, (Eregional)this.comboBoxDestino.SelectedItem));
            }
        }


        #endregion

    }
}
