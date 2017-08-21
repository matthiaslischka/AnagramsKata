#include <stdio.h>
#include <stdlib.h>
#include <anagrams_finder.h>

// anagrams_finder_find finds anagrams matching the input word
static void anagrams_finder_find(struct anagrams_finder_s *_this, char *word)
{
    printf("%s not implemented!\n", __func__);
}

// anagrams_finder_new returns an instance of an anagrams_finder_t based on
// a wordlist file.
anagrams_finder_t *anagrams_finder_new(char *wordlist)
{
    anagrams_finder_t *anagrams_finder_ref = malloc(sizeof(anagrams_finder_t));

    anagrams_finder_ref->wordlist = wordlist;
    anagrams_finder_ref->find = anagrams_finder_find;

    return anagrams_finder_ref;
}

// destructor
void anagrams_finder_destroy(anagrams_finder_t* anagrams_finder_ref)
{
    free(anagrams_finder_ref);
}
