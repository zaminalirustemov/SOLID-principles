using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    internal class Email : IMessage
    {
        public string ToAdress;
        public string Subject;
        public string Content;
        public void SendMessage()
        {
            Console.WriteLine("Yeni mail geldi");
            Console.WriteLine($"ToAdress: {ToAdress} Subject:{Subject} Content:{Content}");
        }
    }
}
