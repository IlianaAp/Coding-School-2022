using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Class1
    {
        public Class1()
        {

        }

        public string ReverseName(string name)
        {
            string reversedName = string.Empty;
            char[] charArray = name.ToCharArray();

            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                reversedName += charArray[i]; 
            }
           
            return reversedName;

        }
    }
}
