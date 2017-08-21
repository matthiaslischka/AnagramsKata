package main

import (
	"fmt"
	"strings"
)

func main() {
	finder := NewAnagramsFinder()

	fmt.Print("Enter word to find anagrams for: ")
	var word string
	fmt.Scanln(&word)
	anagrams := finder.Find(word)
	fmt.Println(strings.Join(anagrams, ", "))
	fmt.Scanln()
}
