/* ============================== *\
 * Created By : RAHUL TEJA T      *
 * Created Date : July 23th,2017  *
\* ============================== */
 
using System;
using System.Collections.Generic;
 
namespace MonkAndLuckyMinimum
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine().Trim());
            while (testCases > 0)
            {
                int size = int.Parse(Console.ReadLine().Trim());
                var A = new int[size];
                A = Array.ConvertAll(Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), i => int.Parse(i));
                int min = A[0];
                for (int i = 1; i < A.Length; i++)
                {
                    if (A[i] < min)
                    {
                        min = A[i];
                    }
                }
                int count = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] == min)
                    {
                        count++;
                    }
                }
                Console.WriteLine((count > 1) ? ((count % 2) == 0 ? "Unlucky" : "Lucky") : "Lucky");
                testCases--;
            }
        }
    }
}
