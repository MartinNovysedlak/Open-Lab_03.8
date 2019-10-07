using System;

namespace Open_Lab_03._8
{
    class Program
    {
        public static bool Isplural(string Word)
        {
            return Word.EndsWith("s");
        }
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Console.WriteLine(Isplural(word));
        }

    }
}