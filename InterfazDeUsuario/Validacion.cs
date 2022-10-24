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
        }

        public static bool ValidarUsuario(string user, string pass, out Usuario userAux)
        {
            bool retorno = false;
            userAux = null;

            foreach (Usuario item in Harcodeo.ListaUsuarios())
            {
                retorno = item == new Usuario(user, pass);

                if (retorno)
                {
                    userAux = item;
                    break;
                }
            }

            return retorno;

        }

    }
}
