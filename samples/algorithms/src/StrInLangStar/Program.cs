using System;

namespace Algorithms
{
    public class Program
    {
        public static void Expect(bool expected, bool found)
        {
            Console.WriteLine("expects {0}, found {1}", expected, found);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Recursive");
            Expect(true, "aaa".IsInLanguageStarRecursive("a"));
            Expect(false, "aaa".IsInLanguageStarRecursive("b"));
            Console.WriteLine();

            Console.WriteLine("Iterative");
            Expect(true, "aaa".IsInLanguageStarIterative("a"));
            Expect(false, "aaa".IsInLanguageStarIterative("b"));
        }
    }
}
