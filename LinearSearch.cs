using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV7
{
    class LinearSearch : SearchStrategy
    {
        public int Search(double[] array, double number)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] == number)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
