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
    public partial class FrmCargaPasajero : FrmPadre
    {
        public FrmCargaPasajero()
        {
            InitializeComponent();
        }

        private void FrmCargaPasajero_Load(object sender, EventArgs e)
        {
            FrmPadre.Centrar(this.panelContenedor, this);
            //Se Inicia por defecto nacionalidad (argentina) y sexo (Masculino)
            this.comboBoxNacionalidad.SelectedIndex = 10;
            this.comboBoxSexo.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mensaje;

            if(this.ObtenerDatosPasajero(out mensaje))
            {
                MessageBox.Show($"Le falto completar los siguientes datos: \n{mensaje}","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("¿Desea seguir cargando pasajeros?", "Carga exitosa!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //Tengo que validar que se puedan seguir subiendo pasajeros 
            }
        }

        /// <summary>
        /// Boton de limpiar. Limpia los text box nomas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control controlesGroupBox in this.panelContenedor.Controls)
            {
                if (controlesGroupBox is GroupBox)
                {
                    foreach (Control controles in controlesGroupBox.Controls)
                    {
                        if (controles is TextBox txtBox)
                        {
                            txtBox.Clear();
                            continue;
                        }
                    }
                }
            }
        }

        private bool ObtenerDatosPasajero(out string mensaje)
       {
            string nombre = this.textBoxNombre.Text;
            string apellido = this.textBoxApellido.Text;
            int numeroPasaporte;
            float pesoValijas;
            bool retorno = false;
            mensaje = "";

            StringBuilder sb = new StringBuilder();

            if(string.IsNullOrWhiteSpace(nombre))
            {
                sb.AppendLine("Nombre");
                retorno = true;
            }
            if(string.IsNullOrWhiteSpace(apellido))
            {
                sb.AppendLine("Apellido");
                retorno = true;
            }
            if(!(int.TryParse(this.textBoxNroPasaporte.Text, out numeroPasaporte)))
            {
                sb.AppendLine("Numero Pasaporte (Solo numeros)");
                retorno = true;
            }
            if(!(float.TryParse(this.textBoxKg.Text,out pesoValijas)))
            {
                sb.AppendLine("Peso de valijas");
                retorno = true;
            }

            mensaje = sb.ToString();

            return retorno;
            //return pasajero;
       }

       

        #region Validacion de textbox Eventos
        
        private void ValidadorSoloLetras(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ValidadorSoloLetras(e);
        }

        private void textBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ValidadorSoloLetras(e);
        }

        private void textBoxNroPasaporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if(!(char.IsNumber(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void textBoxKg_KeyPress(object sender, KeyPressEventArgs e)
        {

           /* bool flag = false;

            if(e.KeyChar == (char)Keys.Delete && !flag)
            {
                e.Handled = false;
                flag = true;
            }*/

            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        #endregion

    }
}
