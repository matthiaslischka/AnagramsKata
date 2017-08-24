# Anagrams Kata

This is the very basic setup for the "Anagrams" coding kata. **C**, **C++14**, **C#**, **Go**, **Java** and **JS**

> A code kata is an exercise in programming which helps a programmer hone their skills through practice and repetition.

(wikipedia)

The instructions are kept short on purpose. The participants should come up with some questions regarding the requirements on their own and the facilitator should act as product owner who can answer them. Key with this kata when doing tdd is to find all the baby steps so you never reach a point where you have to write a huge block of code without having tests to back it up. In addition, readability of the code and performance can be tricky.

## Instructions
Write a program that finds all possible anagrams for a submitted input word. A 3 mb wordlist is included as datasource.
Use test driven development (tdd) and pair programming when possible.

## Easy examples

| input | anagram |
| --- | --- |
| below | elbow |
| angered | enraged |
| creative | reactive |
| observe | verbose |

## Things to consider
* input word null/empty/whitespace (empty result)
* input word only one character (empty result)
* case sensitive? (no)
* validate input word = is it contained in wordlist? (not necessary)
* include input word in result? (no - just the anagrams)
* validation of datasource: distinct, whitespaces, etc.
* sorting of result
* multiple words as input
  * "moon starer" -> "astronomer"
  * should "moon starer" also return "moonstarer"? 
* performance
* readability
* tip for the algorithm: Find a key that all anagrams of a word have in common 

## Tricky bonus round
Is it possible to find multiple words anagrams?
	
| input | anagram |
| --- | --- |
| schoolmaster | the classroom |
| astronomer | moon starer |
