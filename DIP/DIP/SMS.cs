using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DIP
{
    internal class SMS : IMessage
    {
        public string PhoneNumber;
        public string Message;
        public void SendMessage()
        {
            Console.WriteLine("Yeni SMS geldi");
            Console.WriteLine($"PhoneNumber: {PhoneNumber} Message:{Message} ");
        }
    }
}
