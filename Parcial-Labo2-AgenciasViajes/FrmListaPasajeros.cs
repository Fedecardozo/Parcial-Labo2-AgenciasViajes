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

namespace Parcial_Labo2_AgenciasViajes
{
    public partial class FrmListaPasajeros : Form
    {
        public FrmListaPasajeros()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public static void cargaPasajero(FrmListaPasajeros frmListaPasajeros, List<Pasajero> pasajeros)
        {

            foreach (Pasajero item in pasajeros)
            {
                
                frmListaPasajeros.dataGridPasajeros.Rows.Add(item.Pasaporte.Nombre, item.Pasaporte.Apellido, item.Pasaporte.Dni, 
                    item.Pasaporte.FechaNacimiento, item.Pasaporte.Sexo, item.Pasaporte, 
                    item.Equipaje.Valijas,item.Equipaje.BolsoMano,item.Equipaje.Kilosgramos);
            }

        }

    }
}
