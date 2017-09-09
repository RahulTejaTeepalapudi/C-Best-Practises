//============================//
// Author : Rahul Teja T      //
// Created Date : 9/8/2017    //              
//============================//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGreatKian
{
    class Program
    {
        static void Main(string[] args)
        {
            long size = long.Parse(Console.ReadLine());
            long[] A = new long[size];
            A = Array.ConvertAll(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), i=> long.Parse(i));
            long sum = 0; long j = 0;
            for (int i = 0; i < 3; i++)
            {
                j = i;
                while (j < size)
                {
                    sum = sum + A[j];
                    j += 3;
                }
                sum = 0;
                Console.Write(sum + " ");
            }
            
            Console.ReadLine();
        }
    }
}
