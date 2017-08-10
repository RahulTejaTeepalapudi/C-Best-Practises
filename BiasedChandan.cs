/* ============================== *\
 * Created By : RAHUL TEJA T      *
 * Created Date : July 21th,2017  *
\* ============================== */
 
using System;
using System.Collections.Generic;
using System.Linq;
 
namespace BiasedChandhan
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine().Trim());
            var Stck = new Stack<int>();
            for (int i = 0; i < N; i++)
            {
                int s = int.Parse(Console.ReadLine().Trim());
                if (s == 0)
                {
                    //Check If the Stack is Empty. If Not Empty, Remove the Top Element
                    if (Stck.Count != 0)
                    {
                        Stck.Pop();
                    }
                }
                else
                {
                    Stck.Push(s);
                }
            }
            Console.WriteLine(Stck.Sum());
        }
    }
}
