using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.SortingAlgorithms
{
    public static class SelectionSortAlgorithm
    {
        public static int[] SelectionSort(int[] inputArray)
        {
            var arrayLength = inputArray.Length;
            for (int i = 0; i < arrayLength - 1; i++)
            {
                var smallestVal = i;
                for (int j = i + 1; j < arrayLength; j++)
                {
                    if (inputArray[j] < inputArray[smallestVal])
                    {
                        smallestVal = j;
                    }
                }
                var tempVar = inputArray[smallestVal];
                inputArray[smallestVal] = inputArray[i];
                inputArray[i] = tempVar;
            }
            return inputArray;
        }
    }
}
