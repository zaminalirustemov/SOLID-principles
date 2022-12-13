using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    internal interface IPerson
    {
        string Name { get; set; }
        string Surname { get; set; }
        byte Age { get; set; }
    }
}
