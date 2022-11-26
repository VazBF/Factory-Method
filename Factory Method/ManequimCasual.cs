using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    class ManequimCasual : Manequim
    {
        public override IRoupa criarRoupa(string parteCorpo)
        {
            if (parteCorpo.Equals("tronco"))
            {
                return new Camiseta();
            }
            else if (parteCorpo.Equals("pernas"))
            {
                return new Bermuda();
            }
            else if (parteCorpo.Equals("pes"))
            {
                return new Tenis();
            }
            return null;
        }
    }
}
