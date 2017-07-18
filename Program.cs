using System;
using System.Collections.Generic;
using System.Linq;
namespace WeighingTheStones
{
    class Program
    {
        private static IDictionary<string, int> GetMaxTimeRepeatedElement(string[] strArr)
        {
            var dict = new Dictionary<string, int>();
            int count = 0;
            for (int i = 0; i < strArr.Length; i++)
            {
                count = 0;
                for (int j = (i + 1); j < strArr.Length; j++)
                {
                    if (strArr[i] == strArr[j])
                    {
                        count++;
                    }
                }
                if (count > 0 && !dict.ContainsKey(strArr[i]))
                {
                    dict.Add(strArr[i], count + 1);
                }
            }
            return dict;
        }
        private static int CheckAndGetCountFromArray(string[] strArr, string elem)
        {
            int count = 0;
            for (int i = 0; i < strArr.Length; i++)
            {
                if (strArr[i].Equals(elem))
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            long TestCases = long.Parse(Console.ReadLine().Trim());
            while (TestCases > 0)
            {
                long Stones = long.Parse(Console.ReadLine().Trim());
                int[] A = new int[Stones];
                int[] B = new int[Stones];
                A = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));
                B = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));
                IDictionary<int,int> Dict_A = new Dictionary<int, int>();
                var Dict_B = new Dictionary<int, int>();
                while (Stones > 0)
                {
                    int i = 0;
                    if (Dict_A.ContainsKey(A[i]))
                    {
                        Dict_A[A[i]]++;
                    }
                    else {
                        Dict_A.Add(A[i], 1);
                    }
                    //--------------------------//
                    if (Dict_B.ContainsKey(B[i]))
                    {
                        Dict_B[B[i]]++;
                    }
                    else
                    {
                        Dict_B.Add(B[i], 1);
                    }
                    i++;
                    Stones--;
                }
                // Get the Weights for A and B
                var weight_A = Dict_A.FirstOrDefault(x => x.Value == Dict_A.Values.Max()).Key;
                var weight_B = Dict_B.FirstOrDefault(x => x.Value == Dict_B.Values.Max()).Key;
                if (weight_A > weight_B)
                {
                    Console.WriteLine("Ankit");
                }
                else if (weight_A < weight_B)
                {
                    Console.WriteLine("Rupam");
                }
                else
                {
                    Console.WriteLine("Tie");
                }
                TestCases--;
            }
        }
    }
}
