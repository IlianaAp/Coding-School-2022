using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal abstract class BaseMessageLogger
    {
        public virtual void ReadAll()
        {
            
        }
        public abstract void Write(Message message);
        public abstract void Clear();

    }
}
