using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Validacion
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

    }
}
