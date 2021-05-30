using System;

namespace Question_5
{
    class Program5
    {
        static string merge(string word1, string word2)
        {
            // To store the final string
            string result = "";

            // For every index in the strings
            for (int i = 0; i < word1.Length || i < word2.Length; i++)
            {

                // First choose the ith character of the
                // first string if it exists
                if (i < word1.Length)
                    result += word1[i];

                // Then choose the ith character of the
                // second string if it exists
                if (i < word2.Length)
                    result += word2[i];
            }
            return result;
        }
        static void Main()
        {
            Console.WriteLine("Q5:");
            Console.WriteLine("Enter the First Word:");
            String word1 = Console.ReadLine();
            Console.WriteLine("Enter the Second Word:");
            String word2 = Console.ReadLine();
            String merged = Program5.merge(word1, word2);
            Console.WriteLine("The Merged Sentence fromed by both words is {0}", merged);
        }

        }
    }
