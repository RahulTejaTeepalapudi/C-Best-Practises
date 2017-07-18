using System;
using System.Collections.Generic;
using System.Linq;
namespace WeighingTheStones
{
    class Program
    {
        static void Main(string[] args)
        {
            long TestCases = long.Parse(Console.ReadLine().Trim());
            while (TestCases > 0)
            {
                long Stones = long.Parse(Console.ReadLine().Trim());
                int[] A = new int[Stones];
                A = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));
                int[] B = new int[Stones];
                B = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));
                IDictionary<int, int> Dict_A = new SortedDictionary<int, int>();
                IDictionary<int, int> Dict_B = new SortedDictionary<int, int>();
                for (int i = 0; i < Stones; i++)
                {
                    if (Dict_A.ContainsKey(A[i]))
                    {
                        Dict_A[A[i]]++;
                    }
                    else
                    {
                        Dict_A.Add(A[i], 1);
                    }
                }
                for (int i = 0; i < Stones; i++)
                {
                    if (Dict_B.ContainsKey(B[i]))
                    {
                        Dict_B[B[i]]++;
                    }
                    else
                    {
                        Dict_B.Add(B[i], 1);
                    }
                }
                // Get the Weights for A and B
                var weight_A = Dict_A.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
                var weight_B = Dict_B.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
                Console.WriteLine(weight_A == weight_B ? "Tie" : (weight_A > weight_B ? "Rupam" : "Ankit"));
                TestCases--;
            }
        }
    }
}
