/* ============================== *\
 * Created By : RAHUL TEJA T      *
 * Created Date : July 6th,2017   *
\* ============================== */
 
using System;
using System.Collections.Generic;
 
namespace HackerEarth{
    class MemorizeMe {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] IntArr = new int[size];
            IntArr = GetIntArray(Console.ReadLine(), IntArr, size); //Get String Converted To Array of Integers
            //Creating Dictionary to Store the Data
            Dictionary<int, int> D = new Dictionary<int, int>(size);
            foreach (int num in IntArr)
            {
                if (D.ContainsKey(num))
                {
                    D[num]++;
                }
                else
                {
                    D[num] = 1;
                }
            }
            int total = int.Parse(Console.ReadLine());
            for (int i = 0; i < total; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (D.ContainsKey(number))
                {
                    Console.WriteLine(D[number]);
                }
                else
                {
                    Console.WriteLine("NOT PRESENT");
                }
            }
        }
        /// <summary>
		/// Converts the String Read for Console to Array of Integers
		/// </summary>
        public static int[] GetIntArray(string inputString, int[] intArr ,int size)
        {
            string[] strArr = inputString.Split(' ');
            for (int j = 0; j < size; j++)
            {
                intArr[j] = int.Parse(strArr[j]);
            }
            return intArr;
        }
        
}
}
