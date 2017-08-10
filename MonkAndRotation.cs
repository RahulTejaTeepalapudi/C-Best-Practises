/* ============================== *\
 * Created By : RAHUL TEJA T      *
 * Created Date : July 23th,2017  *
\* ============================== */
 
using System;
using System.Collections.Generic;
using System.Linq;
 
 
namespace MonkAndRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine().Trim());
            for (int i = 0; i < t; i++)
            {
                int[] A = Array.ConvertAll(Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), e=>int.Parse(e));
                int size = A[0]; int count = A[1];
                int count_new = (count % size);
                var N = new string[size];
                var LST = new LinkedList<string>();
                N = Console.ReadLine().Split(' ');
                for (int l = 0; l < size; l++)
                {
                    LST.AddLast(N[l]);
                }
                LinkedListNode<string> lastElement;
                LinkedListNode<string> prev;
                for (int j = 0; j < count_new; j++)
                {
                    lastElement = LST.Last;
                    prev = lastElement.Previous;
                    LST.RemoveLast();
                    LST.AddFirst(lastElement);
                    lastElement = prev;
                }
                Console.WriteLine(string.Join(" ", LST));
            }
        }
 
       
    }
}
