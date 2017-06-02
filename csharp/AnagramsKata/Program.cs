using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AnagramsKata
{
    internal class Program
    {
        private static void Main()
        {
            var anagramsFinder = CreateAnagramsFinder();

            Console.WriteLine("Enter word to find anagrams for: ");
            var word = Console.ReadLine();
            var anagrams = anagramsFinder.FindAnagrams(word);
            Console.Write(FormatResult(anagrams));
            Console.ReadKey();
        }

        private static string FormatResult(List<string> anagrams)
        {
            return anagrams.Any() ? "Found anagrams: " + string.Join(", ", anagrams) : "No anagrams found...";
        }

        private static AnagramsFinder CreateAnagramsFinder()
        {
            var wordList = File.ReadAllLines("wordlist.txt").ToList();
            var anagramsFinder = new AnagramsFinder(wordList);
            return anagramsFinder;
        }
    }
}