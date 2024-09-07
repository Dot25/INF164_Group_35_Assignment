using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;
using System.IO;
using System.Windows.Forms;


namespace Group_Project.Class
{
    [Serializable]
    internal class GameClass
    {
        private List<string> _words;
        private Random _random;
        private string _filepath;
        private string _correctWord;

        public GameClass()
        {
            _words = new List<string>();
            
            _random = new Random();
            _filepath = @"";
        }
        public void LoadWordsFromFile(string filename)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filename))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        _words.Add(line.Trim());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading words from file: " + ex.Message);
            }
        }
        private string HideLetters(string _correctWord)
        {
            string _alteredWord = "";
            char[] chars = _correctWord.ToCharArray();
            if (_correctWord.Length > 4 && _correctWord.Length <= 6)
            {
                for (int i = 0; i < 2; i++)
                {
                    chars[_random.Next(1, chars.Length)] = '_';
                }
            }
            else
            {
                chars[_random.Next(1, chars.Length)] = '_';
            }
            _alteredWord = chars.ToString();
            return _alteredWord;
        }

        public string GetRandomWord()
        {
            if (_words.Count == 0)
            {
                throw new InvalidOperationException("No words have been added to the game.");
            }
            _correctWord = _words[_random.Next(_words.Count)];

            return HideLetters(_correctWord);
        }

        
        public int getRandomBlock()
        {
            Random random = new Random();
            int picture = 0;
            int randomWord = random.Next(0, 100);
            if (randomWord >= 1 && randomWord <= 4)
            {
                picture = 0;
            }
            else if(randomWord >= 5 && randomWord <= 14)
            {
                picture = 1;
            }
            else if (randomWord >= 15 && randomWord <= 30)
            {

                picture = 2;
            }
            else if (randomWord >= 31 && randomWord <= 46)
            {
                picture = 3;
            }
            else if (randomWord >= 47 && randomWord <= 57)
            {
                picture = 4;
            }
            else if (randomWord >= 58 && randomWord <= 68)
            {
                picture = 5;
            }
            else if (randomWord >= 69 && randomWord <= 79)
            {;
                picture = 6;
            }
            else if (randomWord >= 80 && randomWord <= 87)
            {
                picture = 7;
            }
            else if (randomWord >= 88 && randomWord <= 94)
            {
                picture = 8;
            }
            else if (randomWord >= 95 && randomWord <= 100)
            {
                picture = 9;
            }
                return picture;
        }
        /*public void AddWord(string word)
{
_words.Add(word);
}
public void AddWordsFromFile(string filePath)
{
string[] words = File.ReadAllLines(filePath);
foreach (string word in words)
{
AddWord(word.Trim());
}
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
}*/
    }
}