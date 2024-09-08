using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;
using System.IO;
using System.Windows.Forms;
using Group_Project.Properties;
using System.IO.Pipes;
using Microsoft.VisualBasic;
using System.ComponentModel;


namespace Group_Project.Class
{
    [Serializable]
    internal class GameClass
    {
        private List<string> _words;
        private Random _random;
        private string _filepath;
        private string _correctWord;
        private int picture = 0;
        private int[] exp = new int[10] {3,6,9,12,15,18,21,24,27,30};
        private int totalExp = 0;
        private int durability = 5;
        private int numBlocksBroken = 0;
        public string _name;

        public GameClass()
        {
            _words = new List<string>();
            _random = new Random();
        }
        public void LoadWordsFromFile()
        {
            try
            {
                StreamReader reader = new StreamReader("Cat.txt");
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        _words.Add(line.Trim());
                        
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading words from file: " + ex.Message);
            }

        }
        private string HideLetters(string _correctWord)
        {
            string _alteredWord = "";
            int len = _correctWord.Length;
            Random random = new Random();
            int switchPos = random.Next(1, len);
            for(int i = 0; i < len; ++i)
            {
                if(i == switchPos)
                {
                    _alteredWord += '_';
                }
                else
                {
                    _alteredWord += _correctWord[i];
                }
                
            }
            return _alteredWord;
        }

        public bool equal(string input)
        {
            if(input.ToUpper().Equals(_correctWord.ToUpper()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void addExp()
        {
            totalExp += exp[picture];
            ++numBlocksBroken;
        }

        public int getBlocksBroken()
        {
            return numBlocksBroken;
        }

        public int getExp()
        {
            return totalExp;
        }
        public void setExperience(int experience)
        {
            totalExp = experience; 
        }

        public int getDurability()
        {
            return durability;
        }

        public void setName(string name)
        {
            _name = name;
        }
        public string getName()
        {
            return _name;
        }
        public void removeDurability()
        {
            if(durability > 0) 
            {
               --durability;
            }
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

        /*public void endGame()
        {
            try
            {
                
               StreamWriter writeTo = new StreamWriter("Records.txt");
               {
                   writeTo.WriteLine(_name + "#" + totalExp.ToString() + "#" + numBlocksBroken.ToString());
               }
                writeTo.Close();
             }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading words from file: " + ex.Message);
            }
        }*/

        public void WriteToFile(string listName, BindingList<Record> list)
        {
            try
            {
                if(!File.Exists(listName + ".ser"))
                {
                    FileStream outFile = new FileStream(listName + ".ser", FileMode.Create, FileAccess.Write);
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(outFile, list);
                    outFile.Close();
                }
                else
                {
                    ReadFromFile(listName, list);

                    FileStream outFile = new FileStream(listName + ".ser", FileMode.Create, FileAccess.Write);
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(outFile, list);
                    outFile.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving to file: " + ex.Message);
            }
        }

        
        public void ReadFromFile(string listName, BindingList<Record> list)
        {
            try
            {
                if (File.Exists(listName + ".ser"))
                {
                FileStream inFile = new FileStream(listName + ".ser", FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                var tempList = (BindingList<Record>)formatter.Deserialize(inFile);
                foreach(Record myObject in tempList)
                {
                    list.Add(myObject);
                }
                inFile.Close();
                //return (BindingList<Record>)formatter.Deserialize(inFile);
                    
                }
                else
                {
                   MessageBox.Show("File not found.");
                   // return new BindingList<Record>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading from file: " + ex.Message);
            }
        }

        public int getRandomBlock()
        {
            Random random = new Random();
            
            int randomWord = random.Next(1, 101);
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