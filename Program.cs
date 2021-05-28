using System;

namespace test
{
    class Question1
    {
        public static bool JudgeCircle(string moves)
        {
            int x = 0;
            int y = 0;

            char[] array = moves.ToCharArray();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 'R')
                    x++;
                else if (array[i] == 'L')
                    x--;
                else if (array[i] == 'U')
                    y++;
                else if (array[i] == 'D')
                    y--;
            }
            return (x == 0 && y == 0);
        }
    }

    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Q1 : Enter the Moves of Robot:");
            string moves = Console.ReadLine();
            bool pos = Question1.JudgeCircle(moves);
            if (pos)
            {
                Console.WriteLine("The Robot return’s to initial Position (0,0)");
            }
            else
            {
                Console.WriteLine("The Robot doesn’t return to the Initial Postion (0,0)");
            }
            Console.WriteLine();



        }
    }
}

        
    

