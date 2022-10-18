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
    public partial class FrmMenuUsuario : FrmPadre
    {
        private Usuario usuario;

        public FrmMenuUsuario()
        {
            InitializeComponent();
        }

        public FrmMenuUsuario(Usuario usuario) : this()
        {
            this.usuario = usuario;
        }

        private void FrmMenuUsuario_Load(object sender, EventArgs e)
        {
            this.CargarUsuario();
            FrmPadre.Centrar(this.panelContenedor,this);
        }

        #region Metodos
        
        private void CargarUsuario()
        {
            this.UsuarioCargaImagen();
            this.UsuarioLabel();
        }

        private void UsuarioCargaImagen()
        {
            string nombreUsuario = this.usuario.User;

            if(nombreUsuario == "admin")
            {
                this.pictureBox1.Image = Cruzeiro.Properties.Resources.gamer;
            }
            else if(nombreUsuario == "admin2")
            {
                this.pictureBox1.Image = Cruzeiro.Properties.Resources.hacker;
            }
            else if (nombreUsuario == "admin3")
            {
                this.pictureBox1.Image = Cruzeiro.Properties.Resources.man;
            }
            else
            {
                this.pictureBox1.Image = Cruzeiro.Properties.Resources.man__1_;
            }
        }
        
        private void UsuarioLabel()
        {
            this.labelnNombreVendedor.Text = this.usuario.Nombre;
            this.labelApellidoVendedor.Text = this.usuario.Apellido;
            this.labelUsuarioVendedor.Text = this.usuario.User;
            this.labelFecha.Text = DateTime.Now.ToString("d");
        }

        #endregion
    }
}
