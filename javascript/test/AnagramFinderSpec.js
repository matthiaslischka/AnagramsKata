const expect = require('chai').expect;

const AnagramFinder = require('../lib/AnagramFinder');
const NotImplementedError = require('../lib/NotImplementedError');

describe('AnagramFinder', () => {
  let anagramFinder;

  beforeEach(() => {
    anagramFinder = new AnagramFinder();
  });

  describe('.findAnagrams()', () => {
    it('should throw NotImplementedError', () => {
      expect(() => anagramFinder.findAnagrams()).to.throw(NotImplementedError);
    });
  });
});
