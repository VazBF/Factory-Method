using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public class Camisa : IRoupa
    {
        public string pecaRoupa()
        {
            return "{Camisa}";
        }
    }
}
