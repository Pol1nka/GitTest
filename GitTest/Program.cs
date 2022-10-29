using System;
    namespace GitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "hello world!";
            foreach(char c in str)
            {
                Console.Write(c);
            }
            Console.WriteLine();
        }
    }
}

