using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProactiveBot.Services.Interfaces;

namespace ProactiveBot.Services
{
    public class WordGenerator : IWordGenerator
    {
        private List<string> _words;
        Random rand = new Random();

        public WordGenerator()
        {
            var Words = new List<string>();
            Words.Add("Iot");
            Words.Add("Bildør");
            Words.Add("Machine Learning");
            Words.Add("AR");
            Words.Add("Vacuum Cleaner");
            Words.Add("Small Boat");
        }

        public string NewWord()
        {
            return _words[rand.Next(_words.Count - 1)];
        }

        public List<string> NewWords(int numberOfWords)
        {
            var generateWords = new List<string>();
            for (int i = 0; i < numberOfWords; i++)
            {
                generateWords.Add(NewWord());
            }

            return generateWords;
        }
    }
}