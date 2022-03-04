using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Class4
    {
        public Class4()
        {

        }

        public int[] MultiplyTwoArrays(int[] array1, int[] array2)
        {
            int[] arrayResult = new int[array1.Length * array2.Length];
            int pointer = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    arrayResult[pointer] = array1[i] * array2[j];
                    pointer++;
                }
            }
            return arrayResult;
        }
    }
}
