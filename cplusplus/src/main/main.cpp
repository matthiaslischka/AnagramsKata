#include <iostream>
#include <numeric>

#include "kata/AnagramsFinder.h"

using kata::AnagramsFinder;

int main()
{
   std::cout << "Enter word to find anagrams for: ";
   std::string word;
   std::cin >> word;

   AnagramsFinder finder;
   auto anagrams = finder.findAnagrams(word);
   if (!anagrams.empty())
   {
      std::cout << std::accumulate(anagrams.begin() + 1, anagrams.end(), anagrams[0],
                                   [](std::string const & acc, std::string const & element)
      {
         return acc + ", " + element;
      });
   }
   std::cout << std::endl;

   return 0;
}
