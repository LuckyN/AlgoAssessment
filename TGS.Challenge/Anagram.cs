using System;
using System.Collections.Immutable;

namespace TGS.Challenge
{
  /*
        Devise a function that checks if 1 word is an anagram of another, if the words are anagrams of
        one another return true, else return false

        "Anagram": An anagram is a type of word play, the result of rearranging the letters of a word or
        phrase to produce a new word or phrase, using all the original letters exactly once; for example
        orchestra can be rearranged into carthorse.

        areAnagrams("horse", "shore") should return true
        areAnagrams("horse", "short") should return false

        NOTE: Punctuation, including spaces should be ignored, e.g.

        horse!! shore = true
        horse  !! shore = true
          horse? heroes = true

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class Anagram
    {
      public bool AreAnagrams(string word1, string word2)
      {
            //sort word1 and word2 into sorted arrays 
            //Since the comparison of CAPS and lower case did not work converted everything to lower case
            char[] wd1 = word1.ToLower().ToCharArray();
            char[] wd2 = word2.ToLower().ToCharArray();
            //the sorted characters should be sorted in descendig/ascending order
            Array.Sort(wd1);
            Array.Sort(wd2);
            //Create a string  with the from the sorted strings
            string Sortedword1 = wd1.ToString();
            string Sortedword2 = wd2.ToString();

            //Compare the characters to see if there eaxactly the same, if there are the same its anagram otherwise no
            if (Sortedword1 == Sortedword2)
            {
                return true;
            }
            else
            {
                return false;
            }

      }
    }
}
