using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.SortingAlgorithms
{
    public static class BubbleSortAlgorithm
    {
        public static int[] BubbleSort(int[] inputArray)
        {
            var n = inputArray.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (inputArray[j] > inputArray[j + 1])
                    {
                        var tempVar = inputArray[j];
                        inputArray[j] = inputArray[j + 1];
                        inputArray[j + 1] = tempVar;
                    }
            return inputArray;
        }
    }
}
