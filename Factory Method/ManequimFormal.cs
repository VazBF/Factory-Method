using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    class ManequimFormal : Manequim
    {
        public override IRoupa criarRoupa(string parteCorpo)
        {
            if (parteCorpo.Equals("tronco"))
            {
                return new Camisa();
            } else if(parteCorpo.Equals("pernas")){
                return new Calca();
            } else if (parteCorpo.Equals("pes"))
            {
                return new Sapatos();
            }
            return null;
        }
    }
}
