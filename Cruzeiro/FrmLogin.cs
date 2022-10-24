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
using InterfazDeUsuario;

namespace Cruzeiro
{
    public partial class FrmLogin : FrmPadre
    {

        #region Inicio de formulario
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            FrmPadre.Centrar(this.panelContenedor,this);
        }

        #endregion

        #region Boton
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.InicioSesion();
        }
        #endregion

        #region TextBox

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.TeclaEnterAbreMenu(e);
        }
        private void textBoxUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.TeclaEnterAbreMenu(e);
        }

        #endregion

        #region Metodos
        private void TeclaEnterAbreMenu(KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.InicioSesion();
            }
        }

        private void InicioSesion()
        {
            Usuario user;

            //MessageBox.Show(Validacion.ValidarUsuario(user).ToString());
            if (Validacion.ValidarUsuario(this.textBoxUser.Text, this.textBoxPassword.Text,out user))
            {
                //Nuevo formulario con el menu de opciones 
                this.AbrirMenuUsuario(user);
            }
            else
            {
                MessageBox.Show("Usuario o password incorrectos", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AbrirMenuUsuario(Usuario user)
        {
            this.Hide();

            FrmMenuUsuario frmMenuUsuario = new FrmMenuUsuario(user);
            //frmMenuUsuario.Show();

            frmMenuUsuario.ShowDialog();

            this.textBoxPassword.Clear();
            this.textBoxUser.Clear();
            
            this.Show();

        }

        #endregion

    }
}
