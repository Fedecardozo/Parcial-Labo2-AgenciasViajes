using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciudad
    {
        private static Eregional destinoRegional;
        private static EextraRegional destinoExtraRegional;

        public static Eregional DestinoRegional 
        { 
            get { return Ciudad.destinoRegional; }
            set { Ciudad.destinoRegional = value; }
        }

        public static EextraRegional DestinoExtraRegional
        {
            get { return Ciudad.destinoExtraRegional; }
            set { Ciudad.destinoExtraRegional = value; }
        }

    }
}
