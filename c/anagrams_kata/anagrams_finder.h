#ifndef ANAGRAMS_FINDER_H
#define ANAGRAMS_FINDER_H

#include <sds.h>

typedef struct anagrams_finder_s
{
	int wordlist_len;
    sds *wordlist;

    sds *(*find)(struct anagrams_finder_s *_this, char *word, int *ret_sdslen);

} anagrams_finder_t; 

anagrams_finder_t *anagrams_finder_new(char *wordlist);
void anagrams_finder_destroy(anagrams_finder_t* anagrams_finder_ref);

#endif /* ANAGRAMS_FINDER_H */
