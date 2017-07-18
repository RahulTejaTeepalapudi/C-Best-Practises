/* ============================== *\
 * Created By : RAHUL TEJA T      *
 * Created Date : July 6th,2017   *
\* ============================== */
 
using System;
using System.Collections.Generic;
 
namespace BinaryQueries
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] A = Console.ReadLine().Split(' ');
            int size = int.Parse(A[0]); 
            int queriesCount = int.Parse(A[1]);
            string[] Digits = new string[size];
            Digits = Console.ReadLine().Split(' ');
            for (int i = 0; i < queriesCount; i++)
            {
                //Read the Query from Console
                string[] Query = Console.ReadLine().Split(' ');
                if (Query[0].Equals("0")) // 0LX Query
                {
                    //Print ODD or EVEN
                    int R = int.Parse(Query[2]) - 1;
                    if (Digits[R].Equals("0"))
                    {
                        Console.WriteLine("EVEN");
                    }
                    else
                    {
                        Console.WriteLine("ODD");
                    }
                }
                else
                {
                    //1X Query //Flip the Xth Bit
                    int X = int.Parse(Query[1]) - 1;
                    Digits[X] = Digits[X].Equals("0") ?  "1" : "0";
                }
            }
        }
    }
}
