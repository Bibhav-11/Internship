using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Helper
{
    public static class PrintArray
    {
        public static void Print(int[] array)
        {
            foreach (var element in array)
            {
                Console.Write(element + ", ");
            }
        }
    }
}
