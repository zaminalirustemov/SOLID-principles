using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    internal class Notifilaction
    {
        private ICollection<IMessage> _message;
        public Notifilaction(ICollection<IMessage> messages)
        {
            this._message = messages;
        }

        public void Send()
        {
            foreach (var item in _message)
            {
                item.SendMessage();

            }
        }
    }
}
