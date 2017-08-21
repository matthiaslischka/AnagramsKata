#ifndef ANAGRAMS_FINDER_H
#define ANAGRAMS_FINDER_H

typedef struct anagrams_finder_s
{
    char *wordlist;
    void (*find)(struct anagrams_finder_s *_this, char *word);

} anagrams_finder_t; 

anagrams_finder_t *anagrams_finder_new(char *wordlist);
void anagrams_finder_destroy(anagrams_finder_t* anagrams_finder_ref);

#endif /* ANAGRAMS_FINDER_H */
