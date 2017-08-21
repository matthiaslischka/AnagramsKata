package main

import (
	"io/ioutil"
	"strings"
)

// AnagramsFinder maps an input text to a list of matching texts that each
// are an anagram of the input.
type AnagramsFinder struct {
	wordList []string
}

// NewAnagramsFinder returns an instance of an AnagramsFinder based on
// a wordlist file. The file is called "wordlist.txt" and must be in the
// working directory.
func NewAnagramsFinder() *AnagramsFinder {
	finder := &AnagramsFinder{}

	data, err := ioutil.ReadFile("wordlist.txt")
	if err != nil {
		panic(err)
	}
	finder.wordList = strings.Split(string(data), "\n")

	return finder
}

// Find returns a set of strings that each are an anagram of the input word.
func (finder *AnagramsFinder) Find(word string) []string {
	panic("Not Implemented")
	return nil
}
