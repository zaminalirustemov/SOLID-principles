using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    internal class Student : IPerson
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }
    }
}
