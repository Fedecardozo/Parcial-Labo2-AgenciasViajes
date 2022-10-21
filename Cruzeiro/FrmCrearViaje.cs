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
        public FrmCrearViaje()
        {
            InitializeComponent();
        }

        private void FrmCrearViaje_Load(object sender, EventArgs e)
        {
            this.CargarCruceros();
            this.CargaExtraRegionalComboBox();
            this.comboBoxDestino.SelectedIndex = 2;
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
            this.comboBoxDestino.SelectedIndex = 1;
            this.CargaExtraRegionalComboBox();
        }

        private void rBtnRegional_CheckedChanged(object sender, EventArgs e)
        {
            this.comboBoxDestino.SelectedIndex = 1;
            this.CargaRegionalComboBox();
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

        #endregion
    }
}
