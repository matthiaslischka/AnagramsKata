#include <stdio.h>
#include <stdlib.h>
#include <anagrams_finder.h>

/* 
 * anagrams_finder_find finds anagrams matching the input word 
 * it returns an array of sds strings, the size of the array is 
 * written into ret_sdslen
 */
static sds *anagrams_finder_find(struct anagrams_finder_s *_this, char *word, int *ret_sdslen)
{
    fprintf(stderr, "%s not implemented!\n", __func__);
    return NULL;
}

/*
 * anagrams_finder_new returns an instance of an anagrams_finder_t based on
 * wordlist file. The file is called "wordlist.txt" and must be in the
 * working directory.
 */
anagrams_finder_t *anagrams_finder_new(char *wordlist)
{
    anagrams_finder_t *anagrams_finder_ref = malloc(sizeof(anagrams_finder_t));

    char *buffer = NULL;
    long length = 0;
    sds tmp_sds = NULL;
    FILE *f = fopen(wordlist, "rb");

    if (f)
    {
        /* Get len */
        fseek(f, 0, SEEK_END); length = ftell(f); fseek(f, 0, SEEK_SET);

        /* Allocate buffer */
        buffer = malloc(length);
        if (buffer)
        {
            fread(buffer, sizeof(*buffer), length, f);

            /* convert into sds string */
            tmp_sds = sdsnewlen(buffer, length);
            anagrams_finder_ref->wordlist = sdssplitlen(tmp_sds, sdslen(tmp_sds), "\n", 1, 
                                                        &anagrams_finder_ref->wordlist_len);

            /* Cleanup */
            sdsfree(tmp_sds);
            free(buffer);
        }
        fclose(f);
    }
    else
    {
        fprintf(stderr, "File %s not found!\n", wordlist);
    }

    /* Set method pointers here */
    anagrams_finder_ref->find = anagrams_finder_find;

    return anagrams_finder_ref;
}

/* destructor */
void anagrams_finder_destroy(anagrams_finder_t* anagrams_finder_ref)
{
    free(anagrams_finder_ref);
}
