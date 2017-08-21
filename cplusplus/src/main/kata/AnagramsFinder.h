#ifndef H_KATA_ANAGRAMSFINDER
#define H_KATA_ANAGRAMSFINDER

#include <string>
#include <vector>

namespace kata
{

class AnagramsFinder
{
public:
   AnagramsFinder();

   std::vector<std::string> findAnagrams(std::string const &word) const;

private:
   std::vector<std::string> wordList;
};

} // namespace kata

#endif
