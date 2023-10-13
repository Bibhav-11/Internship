using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.SortingAlgorithms
{
    public static class InsertionSortAlgorithm
    {
        public static int[] InsertionSort(int[] inputArray)
        {
            for (int i = 1; i < inputArray.Length; i++)
            {
                var key = inputArray[i];
                var flag = 0;
                for (int j = i - 1; j >= 0 && flag != 1;)
                {
                    if (key < inputArray[j])
                    {
                        inputArray[j + 1] = inputArray[j];
                        j--;
                        inputArray[j + 1] = key;
                    }
                    else flag = 1;
                }
            }
            return inputArray;
        }
    }
}
