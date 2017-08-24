#include <stdio.h>
#include <anagrams_finder.h>

int main(int argc, char** argv)
{
    char word[256];
    int anagrams_len = 0;
    sds *anagrams = NULL;

    anagrams_finder_t *anagrams_finder = anagrams_finder_new("wordlist.txt");

    printf("Enter word to find anagrams for:\n");
    fgets(word, sizeof(word), stdin);

    if ((anagrams = anagrams_finder->find(anagrams_finder, word, &anagrams_len)))
    {
    	printf("%s\n", sdsjoinsds(anagrams, anagrams_len, ", ", 2));
    }

    /* Useless but for consistency */
    anagrams_finder_destroy(anagrams_finder);

    return 0;
}
