using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
                        /*
                Create a dictionary with key value pairs to
                represent words (key) and its definition (value)
            */
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // Add several more words and their definitions
            wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
            wordsAndDefinitions.Add("Bangazon", "This is not Amazon and it's run by students at NSS, so you will most likely not receive your orders.");
            wordsAndDefinitions.Add("Tree", "Invited by programmers, so it's upside down and doesn't actually contain any organic matter.");

            /*
                Use square brackets to get the definition of two of the
                words and then output them to the console
            */

            Console.WriteLine(wordsAndDefinitions["Bangazon"]);
            Console.WriteLine(wordsAndDefinitions["Tree"]);

            /*
                Below, loop over the wordsAndDefinitions dictionary to get the following output:
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
            */
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                Console.WriteLine($"The definition of '{word.Key}' is '{word.Value}'");
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine();
            Console.WriteLine("This is the next practice");
            Console.WriteLine();

            // Make a new list
            List<Dictionary<string, string>> dictionaryOfWordsTwo = new List<Dictionary<string, string>>();

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

            // Create dictionary to represent a few words
            Dictionary<string, string> excitedWord = new Dictionary<string, string>();

            // Add each of the 4 bits of data about the word to the Dictionary
            excitedWord.Add("word", "excited");
            excitedWord.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
            excitedWord.Add("part of speech", "adjective");
            excitedWord.Add("example of sentence", "I'm excited to learn C#!");

            // Add Dictionary to your `dictionaryOfWords` list

            dictionaryOfWordsTwo.Add(excitedWord);


            // create another Dictionary and add that to the list

             // Create dictionary to represent a few words
            Dictionary<string, string> treeWord = new Dictionary<string, string>();

            // Add each of the 4 bits of data about the word to the Dictionary
            treeWord.Add("word", "tree");
            treeWord.Add("definition", "In web development, a tree would denote the way the node structure of a website would look");
            treeWord.Add("part of speech", "noun");
            treeWord.Add("example of sentence", "This website's node tree looks just like an upside down tree");

            // Add Dictionary to your `dictionaryOfWords` list

            dictionaryOfWordsTwo.Add(treeWord);


            /*
                Iterate your list of dictionaries and output the data, You can use the two foreach() loops below to help you start your iteration.

                Example output for one word in the list of dictionaries:
                    word: excited
                    definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
                    part of speech: adjective
                    example sentence: I am excited to learn C#!
            */

            // Iterate the List of Dictionaries
            foreach (Dictionary<string, string> def in dictionaryOfWordsTwo)
            {
                // Iterate the KeyValuePairs of the Dictionary
                foreach (KeyValuePair<string, string> kvp in def)
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                }
                Console.WriteLine();
            }

            
        }
    }
}
