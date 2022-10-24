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
    public partial class FrmListaPasajeros : FrmPadre
    {
        private List<Pasajero> pasajeros;

        private FrmListaPasajeros()
        {
            InitializeComponent();
        }

        public FrmListaPasajeros(List<Pasajero> pasajeros) : this()
        {
            this.pasajeros = pasajeros;
        }

        private void FrmListaPasajeros_Load(object sender, EventArgs e)
        {
            Pasaporte pasaporte;
            Equipaje equipaje;

            foreach (Pasajero item in this.pasajeros)
            {
                pasaporte = item.Pasaporte;
                equipaje = item.Equipaje;

                this.dataGridViewPasajeros.Rows.Add(pasaporte.Nombre,pasaporte.Apellido,pasaporte.Dni,pasaporte.FechaNacimiento,pasaporte.Edad,pasaporte.Sexo,
                    pasaporte.NumeroPasaporte,item.TipoClase.ToString(),equipaje.Valijas,equipaje.BolsoMano,equipaje.Kilosgramos.ToString("N2"));
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
