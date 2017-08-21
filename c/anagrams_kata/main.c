#include <stdio.h>
#include <anagrams_finder.h>

int main(int argc, char** argv)
{
    char word[256];

    anagrams_finder_t *anagrams_finder = anagrams_finder_new("Path/to/Wordlist");

    printf("Enter word to find anagrams for:\n");
    fgets(word, sizeof(word), stdin);

    anagrams_finder->find(anagrams_finder, word);

    return 0;
}
