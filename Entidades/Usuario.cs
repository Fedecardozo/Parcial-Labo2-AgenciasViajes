﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        private string usuario;
        private string password;

        /*public Usuario()
        {
            this.usuario = "";
            this.password = "";
        }*/

        public Usuario(string usuario, string password) //:this()
        {

            if(usuario != null && password != null)
            {
                this.usuario = usuario;
                this.password = password;
            }
        }

        public static bool operator ==(Usuario user1, Usuario user2)
        {
            bool retorno = false;

            if(user1.usuario.CompareTo(user2.usuario) == 0 && user1.password.CompareTo(user2.password) == 0)
            {
                retorno = true;
            }

            return retorno;
            //return user1.usuario.Contains(user2.usuario) && user1.password.Contains(user2.password);
        }

        public static bool operator !=(Usuario user1, Usuario user2)
        {
            return !(user1 == user2);
        }

        public override string ToString()
        {
            return $"Usuario: {this.usuario}";
        }

    }
}
