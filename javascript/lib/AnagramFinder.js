const fs = require('fs');
const path = require('path');

const NotImplementedError = require('./NotImplementedError');

class AnagramFinder {
  constructor() {
    const fileLineBreaks = '\n';
    const wordListPath = path.join(__dirname, 'wordlist.txt');
    const fileEncoding = 'utf8';

    const words = fs
      .readFileSync(wordListPath, fileEncoding)
      .split(fileLineBreaks);

    this.allTheWords = new Set(words);
  }

  findAnagrams(word) {
    throw new NotImplementedError();
  }
}

module.exports = AnagramFinder;
