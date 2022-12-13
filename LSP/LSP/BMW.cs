using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    internal class BMW : Car, IAirconditioning
    {
        public string Airconditioning()
        {
            return "BMW ucun kondisoner isleyir";
        }
    }
}
