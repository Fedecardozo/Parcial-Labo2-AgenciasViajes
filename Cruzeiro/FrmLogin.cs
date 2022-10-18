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
    public partial class FrmLogin : FrmPadre
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            FrmPadre.Centrar(this.panelContenedor,this);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.InicioSesion();
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.TeclaEnterAbreMenu(e);
        }
        private void textBoxUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.TeclaEnterAbreMenu(e);
        }

        private void TeclaEnterAbreMenu(KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.InicioSesion();
            }
        }

        private void InicioSesion()
        {
            Usuario user = new Usuario(this.textBoxUser.Text, this.textBoxPassword.Text);

            //MessageBox.Show(Validacion.ValidarUsuario(user).ToString());
            if (Validacion.ValidarUsuario(user) == true)
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
            frmMenuUsuario.ShowDialog();

            this.Show();
        }

        
    }
}
