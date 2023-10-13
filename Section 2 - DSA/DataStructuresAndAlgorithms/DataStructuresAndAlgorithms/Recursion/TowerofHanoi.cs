using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Recursion
{
    public static class TowersOfHanoi
    {
        public static void Solve(int n, char source, char auxiliary, char destination)
        {
            if (n == 1)
            {
                Console.WriteLine($"Move disk 1 from {source} to {destination}");
                return;
            }

            Solve(n - 1, source, destination, auxiliary);
            Console.WriteLine($"Move disk {n} from {source} to {destination}");
            Solve(n - 1, auxiliary, source, destination);
        }
    }
}
