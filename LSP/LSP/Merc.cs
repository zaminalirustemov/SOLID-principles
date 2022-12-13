using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    internal class Merc : Car, IAirconditioning
    {
        public string Airconditioning()
        {
            return "Mercedes ucun kondisoner isleyir";
        }
    }
}
