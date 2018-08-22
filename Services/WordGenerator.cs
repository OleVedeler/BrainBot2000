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
            _words = new List<string>();
            _words.Add("Iot");
            _words.Add("Bildør");
            _words.Add("Machine Learning");
            _words.Add("AR");
            _words.Add("Vacuum Cleaner");
            _words.Add("Small Boat");
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