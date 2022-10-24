using System;

namespace Entidades
{
    public class Usuario
    {
        #region Atributos

        private string usuario;
        //private string password;
        private string nombre;
        private string apellido;

        #endregion

        #region Constructores

        public Usuario(string usuario)//, string password)
        {
            this.usuario = usuario;
            //this.password = password;
        }

        public Usuario(string usuario, string nombre,string apellido) :this(usuario)//,password)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        #endregion

        #region Propiedades

        public string User { get { return this.usuario; } }
        public string Nombre { get { return this.nombre; } }
        public string Apellido { get { return this.apellido; } }

        #endregion

        #region Sobrecarga operadores
        public static bool operator ==(Usuario user, string usuario)
        {
            return user.usuario == usuario;
        }
        public static bool operator !=(Usuario user, string usuario)
        {
            return !(user.usuario == usuario);
        }

        public static bool operator ==(Usuario user1, Usuario user2)
        {
            return user1 == user2.usuario;
            //bool retorno = false;

           /* if (user1.usuario.CompareTo(user2.usuario) == 0 )//&& user1.password.CompareTo(user2.password) == 0)
            {
                retorno = true;
            }*/

            //return retorno;
            //return user1.usuario.Contains(user2.usuario) && user1.password.Contains(user2.password);
        }

        public static bool operator !=(Usuario user1, Usuario user2)
        {
            return !(user1 == user2);
        }

        #endregion

        #region Sobreescritura
       
        public override string ToString()
        {
            return $"Usuario: {this.usuario}";
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if (obj is Usuario)
            {
                retorno = ((Usuario)obj) == this;
            }

            return retorno;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        
        #endregion
    }
}

