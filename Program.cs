using System;
using System.Collections.Generic;

namespace list_of_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ListZone Commence");
            // Make a new list
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

            /*
                You want to track the following about each word:
                    word, definition, part of speech, example sentence

                Example of one dictionary in the list:
                {
                    "word": "excited",
                    "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
                    "part of speech": "adjective",
                    "example sentence": "I am excited to learn C#!"
                }
            */

            // Create dictionary to represent a few word
            Dictionary<string, string> excitedWord = new Dictionary<string, string>();

            // Add each of the 4 bits of data about the word to the Dictionary
            excitedWord.Add("word", "clam");
            excitedWord.Add("definition", "a briny delight of the sea");
            excitedWord.Add("part of speech", "noun");
            excitedWord.Add("example sentence", "why did the clam cross the road? to get to the shell station!");

            // Add Dictionary to your `dictionaryOfWords` list
            dictionaryOfWords.Add(excitedWord);

            // create another Dictionary and add that to the list
            Dictionary<string, string> newWord = new Dictionary<string, string>();
            newWord.Add("word", "shrimp");
            newWord.Add("definition", "a little guy, delicate in taste and shape");
            newWord.Add("part of speech", "noun");
            newWord.Add("example sentence", "the shrimp scuttled softly into the cocktail sauce, shell and all");

            dictionaryOfWords.Add(newWord);


            /*
                Iterate your list of dictionaries and output the data

                Example output for one word in the list of dictionaries:
                    word: excited
                    definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
                    part of speech: adjective
                    example sentence: I am excited to learn C#!
            */
        
            // Iterate the List of Dictionaries
            foreach (Dictionary<string, string> allWords in dictionaryOfWords)
            {
                // Iterate the KeyValuePairs of the Dictionary
                foreach (KeyValuePair<string, string> wordData in allWords)
                {
                    Console.WriteLine($"{wordData.Key}: {wordData.Value}");
                }
            }
        }
    }
}
