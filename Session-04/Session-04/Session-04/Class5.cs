using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Class5
    {
        public Class5()
        {

        }

        public int[] SortLowToHigh(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        min = array[j];
                        array[j] = array[i];
                        array[i] = min;

                    }
                }
               
            }
            return array;
        }
    }
}
