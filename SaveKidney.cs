//============================//
// Author : Rahul Teja T      //
// Created Date : 9/8/2017    //              
//============================//


using System;
using System.Collections.Generic;
using System.Linq;


namespace SaveTheKidney
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] str; int len;
            len = int.Parse(Console.ReadLine());
            if (len == 1)
            {
                Console.WriteLine("-1");
            }
            else
            {
                str = new char[51];
                string input_str = Console.ReadLine().Trim();
                string[] checks = new string[9] { "01", "10", "00", "11", "1x", "x0", "xx", "0x", "x1"};
                if (checks.Contains(input_str))
                {
                    Console.WriteLine("2");
                }
                else
                {
                    str = input_str.ToCharArray();
                    for (int i = 1; i < len; i++)
                    {
                        if (str[i] == 'x')
                        {
                            if (i > 0 && i + 1 < len)
                            {
                                if (str[i - 1] == '0' && str[i + 1] == '0')
                                {
                                    str[i] = '1';
                                }
                                else if (str[i - 1] == '1' && str[i + 1] == '1')
                                {
                                    str[i] = '0';
                                }
                                else
                                {
                                    str[i] = '1';
                                }
                            }
                        }
                    }
                    int count = 0; int count_temp = 0;
                    for (int i = 0; i < len - 1; i++)
                    {
                        if (str[i + 1] != str[i])
                        {
                            count++;
                        }
                        else
                        {
                            count_temp = count;
                            count = 0;
                        }
                    }
                    Console.WriteLine(count_temp > 0 ? count_temp : (count > 0 ? count : -1));
                }

            }
            
        }
    }
}
