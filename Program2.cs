
﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1_Summer2021
{
    public class Question2
    {
        public static bool CheckIfPangram(string str)
        {
        bool[] isUsed = new bool[26];
        int ai = (int)'a';
        int total = 0;

            for (CharEnumerator en = str.ToLower().GetEnumerator(); en.MoveNext();)
            {
                int d = (int)en.Current - ai;
                if (d >= 0 && d < 26)
                    if (!isUsed[d])
                    {
                        isUsed[d] = true;
                        total++;
                    }
            }
            return (total == 26);
        }
    }
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Q2: Enter the string to check for pangram:");
            string str= Console.ReadLine();
            bool flag = Question2.CheckIfPangram(str);
            if(flag)
            {
                Console.WriteLine("Yes, the given string is a pangram");
            }
            else
            {
                Console.WriteLine("No, the given string is not a pangram");
            }
            Console.WriteLine();


            
        }
    }
}
         











