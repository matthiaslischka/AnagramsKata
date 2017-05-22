using System;

namespace AnagramsKata
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Enter word to find anagrams for: ");
            var word = Console.ReadLine();
            var anagramsFinder = new AnagramsFinder();
            var anagrams = anagramsFinder.FindAnagrams(word);
            Console.WriteLine(string.Join(", ", anagrams));
            Console.ReadKey();
        }
    }
}