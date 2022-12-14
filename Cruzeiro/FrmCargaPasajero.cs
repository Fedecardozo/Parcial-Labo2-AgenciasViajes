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
        private Viaje viaje;

        #region Inicio Form
        public FrmCargaPasajero()
        {
            InitializeComponent();
        }
        public FrmCargaPasajero(Viaje viaje) : this()
        {
            this.viaje = viaje;
        }

        private void FrmCargaPasajero_Load(object sender, EventArgs e)
        {
            FrmPadre.Centrar(this.panelContenedor, this);
            this.comboBoxSexo.Items.Add(ESexo.Masculino);
            this.comboBoxSexo.Items.Add(ESexo.Femenino);
            this.comboBoxSexo.Items.Add(ESexo.No_Binario);
            //Se Inicia por defecto nacionalidad (argentina) y sexo (Masculino)
            this.comboBoxNacionalidad.SelectedIndex = 10;
            this.comboBoxSexo.SelectedIndex = 0;
        }

        #endregion

        #region Botones 

        #region Boton de Cargar
        private void button1_Click(object sender, EventArgs e)
        {
            string mensaje;
            DialogResult respuesta;
            Pasajero pasajero;

            if(this.CrearPasajero(out mensaje, out pasajero))
            {
                MessageBox.Show($"Errores al intentar cargar el pasajero: \n{mensaje}","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                respuesta = MessageBox.Show($"{this.InformacionCostoFinal()}¿Desea cargar pasajero?","Información costo final", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                //MessageBox.Show("¿Desea seguir cargando pasajeros?", "Carga exitosa!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //Tengo que validar que se puedan seguir subiendo pasajeros 
                if(respuesta == DialogResult.Yes)
                {
                    this.viaje.AgregarPasajero(pasajero);
                    MessageBox.Show("Carga Exitosa!","Información carga",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                }

            }
        }

        #endregion

        #region Boton de limpiar
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

        #endregion

        #region Boton de atras
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #endregion

        #region Metodos

        #region Validacion de textbox Eventos

        private void ValidadorSoloLetras(KeyPressEventArgs e)
        {

            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            
        }
        
        private void ValidarSoloNumeros(KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (!(char.IsNumber(e.KeyChar)))
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
            this.ValidarSoloNumeros(e);
        }

        private void textBoxKg_KeyPress(object sender, KeyPressEventArgs e)
        {

            /* bool flag = false;

             if(e.KeyChar == (char)Keys.Delete && !flag)
             {
                 e.Handled = false;
                 flag = true;
             }*/

            this.ValidarSoloNumeros(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
          
           this.ValidarSoloNumeros(e);
           // MessageBox.Show($"{this.textBoxNroDni.TextLength}");
            
        }

        #endregion

        #region Metodos obtener datos 
        private bool CrearPasajero(out string mensaje, out Pasajero pasajero)
        {
            string nombre = this.textBoxNombre.Text;
            string apellido = this.textBoxApellido.Text;
            int numeroPasaporte;
            int numeroDni;
            float pesoValijas;
            bool bolsoMano;
            int cantValijas;

            bool retorno = this.ValidacionDatos(nombre, apellido, out numeroPasaporte, out numeroDni, out pesoValijas, out mensaje);
            this.ValidacionEquipaje(out bolsoMano,out cantValijas);

            if(!retorno)
            {

                Pasaporte pasaporte = new Pasaporte(nombre,apellido,numeroDni,this.dateTimePickerNacimiento.Value,(string)this.comboBoxNacionalidad.SelectedItem,
                    (ESexo)this.comboBoxSexo.SelectedItem,numeroPasaporte);

                Equipaje equipaje = new Equipaje(bolsoMano,pesoValijas, cantValijas);

                pasajero = new Pasajero(pasaporte, equipaje, this.TipoClase);
                //this.viaje.AgregarPasajero(new Pasajero(pasaporte,equipaje,this.TipoClase));
            }
            else
            {
                pasajero = null;
            }

            return retorno;
            //return pasajero;
        }

        private void ValidacionEquipaje(out bool bolsoMano, out int cantValijas)
        {
            bolsoMano = false;
            cantValijas = 0;

            if (this.rBtnBolsoManoSi.Checked)
            {
                bolsoMano = true;
                
            }

            if (this.rBtnCantidad1.Checked)
            {
                cantValijas = 1;

            }
            else if (this.rBtnCantidad2.Checked)
            {
                cantValijas = 2;

            }
            
        }

        public EtipoClase TipoClase 
        {
            get
            {
                EtipoClase clase = EtipoClase.Turistica;

                if(this.rBtnClasePremium.Checked)
                {
                    clase = EtipoClase.Premium;
                }

                return clase;
            }
        }

        private bool ValidacionDatos(string nombre, string apellido, out int numeroPasaporte, out int numeroDni, out float pesoValijas, out string repuesta)
        {
            bool retorno = false;
            StringBuilder sb = new StringBuilder();

            #region Verificacion si hay lugar para clase turista o clase premium

            if (this.TipoClase == EtipoClase.Premium && this.viaje.CamaroteDisponiblePremium <= 0)
            {
                sb.AppendLine("No hay lugar en la clase premium");
                retorno = true;
            }
            else if(this.TipoClase == EtipoClase.Turistica && this.viaje.CamaroteDisponibleTurista <= 0)
            {
                sb.AppendLine("No hay lugar en la clase turista");
                retorno = true;
            }

            #endregion

            #region Nombre y apellido

            if (string.IsNullOrWhiteSpace(nombre))
            {
                sb.AppendLine("Nombre (Campo sin completar)");
                retorno = true;
            }
            if (string.IsNullOrWhiteSpace(apellido))
            {
                sb.AppendLine("Apellido (Campo sin completar)");
                retorno = true;
            }
            #endregion

            #region Numero Pasaporte

            if (!(int.TryParse(this.textBoxNroPasaporte.Text, out numeroPasaporte)))
            {
                sb.AppendLine("Numero Pasaporte (Campo sin completar)");
                retorno = true;
            }
            else if (numeroPasaporte < 99999999)
            {
                sb.AppendLine("Faltan numeros al pasaporte [9 digitos total]");
                retorno = true;
            }

            #endregion

            #region Peso valija

            if (!(float.TryParse(this.textBoxKg.Text, out pesoValijas)))
            {
                sb.AppendLine("Peso de valijas (Campo sin completar)");
                retorno = true;
            }
            else if(this.rBtnCantidad1.Checked && pesoValijas > 25)
            {
                sb.AppendLine("Peso permitido para una valija hasta 25 Kg ");
                retorno = true;
            }
            else if(this.rBtnCantidad2.Checked && pesoValijas > 50)
            {
                sb.AppendLine("Peso permitido para dos valijas hasta 50 Kg ");
                retorno = true;
            }
            else if(pesoValijas > viaje.CapacidadDisponibleBodega)
            {
                sb.AppendLine("Se sobre pasa el peso permitido de la bodega ");
                sb.AppendLine($"Peso disponible en la bodega: {this.viaje.CapacidadDisponibleBodega.ToString("N3")}");
                retorno = true;
            }

            #endregion

            #region Numero documento

            if (!(int.TryParse(this.textBoxNroDni.Text, out numeroDni)))
            {
                sb.AppendLine("Numero de documento (Campo sin completar)");
            }
            else if (numeroDni < 999999)
            {
                sb.AppendLine("Faltan numeros al DNI [7-8 digitos total]");
                retorno = true;
            }

            #endregion

            repuesta = sb.ToString();

            return retorno;
        }

        #endregion

        #region Equipaje

        private void rBtnCantidad0_CheckedChanged(object sender, EventArgs e)
        {
            this.textBoxKg.Enabled = false;
            this.textBoxKg.Text = $"{0}";
        }

        private void rBtnCantidad1_CheckedChanged(object sender, EventArgs e)
        {
            this.textBoxKg.Enabled = true;
        }

        private void rBtnCantidad2_CheckedChanged(object sender, EventArgs e)
        {
            this.textBoxKg.Enabled = true;
        }

        #endregion

        #region Mostrar informacion
        private string InformacionCostoFinal()
        {
            StringBuilder sb = new StringBuilder();
            double costoFinalConIva;

            sb.AppendLine("***** FACTURACIÓN *****");
            sb.AppendLine($"Nombre: {Persona.ConvertirMayusculaMinuscula(this.textBoxNombre.Text)}");
            sb.AppendLine($"Apeliido: {Persona.ConvertirMayusculaMinuscula(this.textBoxApellido.Text)}");
            sb.AppendLine($"Nro Documento: {this.textBoxNroDni.Text}");
            sb.AppendLine($"Nro Pasaporte: {this.textBoxNroPasaporte.Text}");

            if (this.rBtnClaseTurista.Checked)
            {
                costoFinalConIva = this.viaje.CostoTurista + (this.viaje.CostoTurista * 21) / 100;
                sb.AppendLine("Clase: TURISTA");
                sb.AppendLine($"Costo del viaje sin Iva: $ {this.viaje.CostoTurista.ToString("N2")}");
                sb.AppendLine($"Costo final del viaje con iva: $ {costoFinalConIva.ToString("N2")}");
            }
            else if(this.rBtnClasePremium.Checked)
            {
                costoFinalConIva = this.viaje.CostoPremium + (this.viaje.CostoPremium * 21) / 100;
                sb.AppendLine("Clase: PREMIUM");
                sb.AppendLine($"Costo del viaje sin Iva: $ {this.viaje.CostoPremium.ToString("N2")}");
                sb.AppendLine($"Costo final del viaje con iva: $ {costoFinalConIva.ToString("N2")}");
            }

            return sb.ToString();
        }
        #endregion

        #endregion

        #region Radio buttons seleccionados eventos

        private void rBtnClaseTurista_CheckedChanged(object sender, EventArgs e)
        {
            if(this.rBtnCantidad2.Checked)
            {
                this.rBtnCantidad1.Checked = true;
            }

            this.rBtnCantidad2.Enabled = false;
        }

        private void rBtnClasePremium_CheckedChanged(object sender, EventArgs e)
        {
            this.rBtnCantidad2.Enabled = true;
        }

        #endregion
    }
}
