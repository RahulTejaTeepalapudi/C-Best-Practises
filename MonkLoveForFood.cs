/* ============================== *\
 * Created By : RAHUL TEJA T      *
 * Created Date : July 14th,2017   *
\* ============================== */
 
 
using System;
using System.Collections.Generic;
 
namespace MonksLoveForFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int TotalQueries = int.Parse(Console.ReadLine());
            Stack<int> PilesStack = new Stack<int>();
            while(TotalQueries > 0){
                string s = Console.ReadLine();
                if (s.Trim().Equals("1"))
                {
                    //Check If the Stack is Empty
                    if (PilesStack.Count == 0)
                    {
                        Console.WriteLine("No Food");
                    }
                    else
                    {
                        // Print the Top One from the Stack and Remove it from the Stack
                        Console.WriteLine(PilesStack.Pop());
                    }
                }
                else
                {
                    //Add the Pile to the Stack
                    PilesStack.Push(int.Parse(s.Split(' ')[1]));
                }
                TotalQueries -= 1;
            }
        }
    }
}
