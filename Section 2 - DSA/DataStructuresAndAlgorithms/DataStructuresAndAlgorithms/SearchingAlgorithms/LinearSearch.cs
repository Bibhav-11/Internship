using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.SearchingAlgorithms
{
    public static class LinearSearchAlgorithm
    {
        public static int LinearSearch(int[] inputArray, int key)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == key)
                {
                    return ++i;
                }
            }
            return -1;
        }
    }
}
