using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AnagramsKata
{
    public class AnagramsFinder
    {
        private readonly List<string> _wordList;

        public AnagramsFinder()
        {
            _wordList = File.ReadAllLines("wordlist.txt").ToList();
        }

        public List<string> FindAnagrams(string word)
        {
            throw new NotImplementedException();
        }
    }
}