using System;

namespace MainSpace
{
    class StartCode
    {
        static string input(char end = '\n')
        {
            string text = Console.ReadLine();
            Console.WriteLine(end);
            return text;
        }

        static void print(string text, char end = '\n')
        {
            Console.Write(text + end);
        }

        static void Main()
        {
            
        }
    }
}
