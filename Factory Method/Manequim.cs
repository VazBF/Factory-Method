using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    abstract class Manequim
    {
        public abstract IRoupa criarRoupa(string parteCorpo);

    }
}
