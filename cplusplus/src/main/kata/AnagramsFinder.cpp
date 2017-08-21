#include <fstream>
#include <iterator>

#include "kata/AnagramsFinder.h"

using kata::AnagramsFinder;

AnagramsFinder::AnagramsFinder()
{
   std::ifstream ifs("wordlist.txt");

   if (ifs)
   {
      std::copy(std::istream_iterator<std::string>(ifs), std::istream_iterator<std::string>(), std::back_inserter(wordList));
   }
   else
   {
      throw std::runtime_error("Could not open file");
   }
}

std::vector<std::string> AnagramsFinder::findAnagrams(std::string const &word) const
{
   std::vector<std::string> result;
   throw std::runtime_error("Not Implemented");
   return result;
}
