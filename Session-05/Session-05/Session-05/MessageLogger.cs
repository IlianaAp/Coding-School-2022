using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class MessageLogger : BaseMessageLogger
    {
        public Message[] Messages { get; set; }
        private int _messagePointer;

        public MessageLogger()
        {
            Messages = new Message[200];
            _messagePointer = 0;
        }

        public override void ReadAll()
        {
            base.ReadAll();
        }
        public override void Clear()
        {
            Array.Clear(Messages, 0, Messages.Length);
            _messagePointer = 0;
        }

        public override void Write(Message message)
        {   
            Messages[_messagePointer] = message;
            _messagePointer++;
        }
    }
}
