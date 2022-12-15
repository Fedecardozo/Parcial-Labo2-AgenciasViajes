using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace InterfazDeUsuario
{
    public static class Validacion
    {
        /*
        public static bool ValidarUsuario(Usuario user)
        {
            bool retorno = false;

            foreach (Usuario item in Harcodeo.ListaUsuarios())
            {
                retorno = item == user;

                if (retorno)
                    break;
            }

            return retorno;
        }*/

        /// <summary>
        /// Valido que el usuario se encuentre en el sistema
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pass"></param>
        /// <param name="userAux"></param>
        /// <returns></returns>
        public static bool ValidarUsuario(string user, string pass, out Usuario userAux)
        {
            bool retorno = false;

            if(Harcodeo.ListaUsuarios().TryGetValue(pass, out userAux) && userAux == pass)
            {
                retorno = true;
            }

            return retorno;

        }

    }
}
