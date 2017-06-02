using System;
using System.Collections.Generic;
using System.Linq;

namespace AnagramsKata
{
    public class AnagramsFinder
    {
        private readonly Dictionary<string, List<string>> _wordsByAnagramKey;

        public AnagramsFinder(List<string> wordList)
        {
            _wordsByAnagramKey = new Dictionary<string, List<string>>();
            foreach (var word in wordList.Distinct())
            {
                var anagramKey = CreateWordAnagramKey(word);
                List<string> foundAnagrams;
                if (_wordsByAnagramKey.TryGetValue(anagramKey, out foundAnagrams))
                    foundAnagrams.Add(word);
                else
                    _wordsByAnagramKey.Add(anagramKey, new List<string> {word});
            }
        }

        public List<string> FindAnagrams(string word)
        {
            if (string.IsNullOrWhiteSpace(word) || (word.Length == 1))
                return new List<string>();

            var anagramKey = CreateWordAnagramKey(word);
            List<string> foundAnagrams;
            
            if (!_wordsByAnagramKey.TryGetValue(anagramKey, out foundAnagrams))
                return new List<string>();

            var anagramsWithoutInputWord =
                foundAnagrams.Where(w => !string.Equals(w, word, StringComparison.CurrentCultureIgnoreCase));
            return anagramsWithoutInputWord.OrderBy(a => a).ToList();
        }

        private string CreateWordAnagramKey(string word)
        {
            var orderedCharactersWithoutWhitepsace = word
                .ToLower()
                .Where(c => !char.IsWhiteSpace(c))
                .OrderBy(character => character);

            var wordKey = new string(orderedCharactersWithoutWhitepsace.ToArray());
            return wordKey;
        }
    }
}