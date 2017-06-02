using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnagramsKata.Tests
{
    [TestClass]
    public class AnagramsFinderTest
    {
        private AnagramsFinder _target = new AnagramsFinder(new List<string>());

        [TestMethod]
        public void FindAnagrams_InputIsNull_NoAnagramsFound()
        {
            _target.FindAnagrams(null).Should().BeEmpty();
        }

        [TestMethod]
        public void FindAnagrams_InputIsEmpty_NoAnagramsFound()
        {
            _target.FindAnagrams(string.Empty).Should().BeEmpty();
        }

        [TestMethod]
        public void FindAnagrams_InputIsSingleCharacter_NoAnagramsFound()
        {
            _target.FindAnagrams("A").Should().BeEmpty();
        }

        [TestMethod]
        public void FindAnagrams_EmptyWordList_NoAnagramsFound()
        {
            _target.FindAnagrams("SomeWord").Should().BeEmpty();
        }

        [TestMethod]
        public void FindAnagrams_InputNotInWordList_NoAnagramsFound()
        {
            SetupWordList("SomeWord");
            _target.FindAnagrams("AnotherWord").Should().BeEmpty();
        }

        [TestMethod]
        public void FindAnagrams_OnlyInputWordInWordList_NoAnagramsFound()
        {
            SetupWordList("SpecificWord");

            _target.FindAnagrams("SpecificWord").Should().BeEmpty();
        }

        [TestMethod]
        public void FindAnagrams_OneAnagramInWordList_ReturnsTheOneAnagram()
        {
            SetupWordList("below");
            _target.FindAnagrams("elbow").Should().BeEquivalentTo("below");
        }

        [TestMethod]
        public void FindAnagrams_OneAnagramAndWordItselfInWordList_ReturnsTheOneAnagram()
        {
            SetupWordList("below", "elbow");
            _target.FindAnagrams("elbow").Should().BeEquivalentTo("below");
        }

        [TestMethod]
        public void FindAnagrams_TwoAnagramInWordList_ReturnsTheTwoAnagram()
        {
            SetupWordList("below", "bowel");
            _target.FindAnagrams("elbow").Should().BeEquivalentTo("below", "bowel");
        }

        [TestMethod]
        public void FindAnagrams_OneAnagramWithOtherCaseInWordList_ReturnsTheOneAnagram()
        {
            SetupWordList("Below");
            _target.FindAnagrams("elbow").Should().BeEquivalentTo("Below");
        }

        [TestMethod]
        public void FindAnagrams_OneAnagramWithOtherCaseInInputWord_ReturnsTheOneAnagram()
        {
            SetupWordList("below");
            _target.FindAnagrams("Elbow").Should().BeEquivalentTo("below");
        }
        
        [TestMethod]
        public void FindAnagrams_AnagramsInputWordAsc_ReturnsAnagramsAlphabeticalSorted()
        {
            SetupWordList("abc", "bac", "cab");
            _target.FindAnagrams("abc").Should().BeInAscendingOrder();
        }
        
        [TestMethod]
        public void FindAnagrams_AnagramsInputWordDesc_ReturnsAnagramsAlphabeticalSorted()
        {
            SetupWordList("cab", "bac", "abc");
            _target.FindAnagrams("abc").Should().BeInAscendingOrder();
        }

        [TestMethod]
        public void FindAnagrams_TwoWordsInputOneWordResult_ReturnsTheOneAnagram()
        {   
            SetupWordList("astronomer");
            _target.FindAnagrams("moon starer").Should().BeEquivalentTo("astronomer");
        }

        [TestMethod]
        public void FindAnagrams_InputWordSeparatedNotSeparatedInWordList_ReturnsTheNotSeparatedAnagram()
        {
            SetupWordList("elbow", "below");
            _target.FindAnagrams("el bow").Should().BeEquivalentTo("elbow", "below");
        }

        [TestMethod]
        public void FindAnagrams_AnagramTwiceInWordList_ReturnsOnlyOnce()
        {
            SetupWordList("below", "below");
            _target.FindAnagrams("elbow").Should().BeEquivalentTo("below");
        }

        [TestMethod]
        public void FindAnagrams_WhitespaceInAnagram_ReturnsTheOneAnagram()
        {
            SetupWordList("moon starer");
            _target.FindAnagrams("astronomer").Should().BeEquivalentTo("moon starer");
        }

        private void SetupWordList(params string[] words)
        {
            _target = new AnagramsFinder(new List<string>(words));
        }
    }
}
