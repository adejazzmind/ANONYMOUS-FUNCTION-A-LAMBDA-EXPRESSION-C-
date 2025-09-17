using System;

namespace DelegateAndStringTasks
{
    class Program
    {
        // 1. Define the delegate
        delegate int AddDelegate(int x, int y);

        static void Main(string[] args)
        {
            // ---------- 1. Delegate ----------
            // (a) Anonymous function
            AddDelegate addAnon = delegate (int a, int b)
            {
                return a + b;
            };
            Console.WriteLine("Anonymous function result: " + addAnon(5, 3));

            // (b) Lambda expression
            AddDelegate addLambda = (a, b) => a + b;
            Console.WriteLine("Lambda expression result: " + addLambda(10, 7));

            Console.WriteLine();

            // ---------- 2. Remove vowels ----------
            string input = "Hello World";
            string noVowels = RemoveVowels(input);
            Console.WriteLine($"Original: {input}");
            Console.WriteLine($"Without vowels: {noVowels}");

            Console.WriteLine();

            // ---------- 3. Count character occurrences ----------
            string text = "Mississippi";
            char targetChar = 's';
            int count = CountCharacter(text, targetChar);
            Console.WriteLine($"Input: \"{text}\", Character: '{targetChar}'");
            Console.WriteLine($"Occurrences: {count}");
        }

        // Method to remove vowels
        public static string RemoveVowels(string input)
        {
            string vowels = "aeiouAEIOU";
            string result = "";

            foreach (char c in input)
            {
                if (!vowels.Contains(c))
                {
                    result += c;
                }
            }
            return result;
        }

        // Method to count character occurrences
        public static int CountCharacter(string input, char target)
        {
            int count = 0;
            foreach (char c in input)
            {
                if (c == target)
                    count++;
            }
            return count;
        }
    }
}
