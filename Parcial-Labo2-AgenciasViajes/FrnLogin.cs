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
    public partial class FrmLogin : FrmCentrado
    {

        private static bool flag;

        public FrmLogin()
        {
            InitializeComponent();
            FrmLogin.flag = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Centrado(this.panelLogin,this);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario(this.textBoxUser.Text,this.textBoxPassword.Text);

             //MessageBox.Show(Validacion.ValidarUsuario(user).ToString());
            if(Validacion.ValidarUsuario(user) == true)
            {
                if(!FrmLogin.flag)
                {
                    //this.WindowState = FormWindowState.Minimized;
                    //this.Opacity = 0;
                    //this.Enabled = false;
                    this.textBoxUser.Clear();
                    this.textBoxPassword.Clear();
                    FrmSecundario form2 = new FrmSecundario();
                    form2.ShowDialog();
                    FrmLogin.flag = true;
                    
                }
                
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelLogin_SizeChanged(object sender, EventArgs e)
        {
            this.Centrado(this.panelLogin,this);
        }
    }
}
