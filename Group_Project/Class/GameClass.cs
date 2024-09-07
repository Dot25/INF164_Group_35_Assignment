using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;

namespace Group_Project.Class
{
    [Serializable]
    internal class GameClass
    {
        private List<string> _words;
        private Random _random;

        public GameClass()
        {
            _words = new List<string>();
            _random = new Random();
        }
        public void AddWord(string word)
        {
            _words.Add(word);
        }
        public string GetRandomWord()
        {
            if (_words.Count == 0)
            {
                throw new InvalidOperationException("No words have been added to the game.");
            }
            return _words[_random.Next(_words.Count)];
        }

        public bool CheckInput(string word, string userInput)
        {
            return word.Equals(userInput, StringComparison.OrdinalIgnoreCase);
        }
        public string RevealWord(string word, string userInput)
        {
            char[] revealedWord = word.ToCharArray();
            for (int i = 0; i < revealedWord.Length; i++)
            {
                if (userInput.Length > i && char.ToUpper(userInput[i]) == char.ToUpper(word[i]))
                {
                    revealedWord[i] = word[i]; // reveal the correct character(s)
                }
            }
            return new string(revealedWord);
        }
    }
}