package com.anagramsfinder;
import java.io.IOException;
import java.util.List;
import java.nio.file.Files;
import java.nio.file.Paths;

public class AnagramsFinder {
	
    private List<String> _wordList;

    public AnagramsFinder() {
    	try {
			_wordList = Files.readAllLines(Paths.get("src/com/anagramsfinder/wordlist.txt"));
		} catch (IOException e) {
			e.printStackTrace();
		}
    }

    public List<String> FindAnagrams(String word) {
    	return _wordList;
    }
}
