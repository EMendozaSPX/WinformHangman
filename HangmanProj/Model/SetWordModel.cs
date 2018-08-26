using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanProj.Model
{
    public class SetWordModel
    {
        string _word, dispWord;
        List<char> wordList, wordDisp;

        public SetWordModel(string word)
        {
            _word = word;
        }

        public string SetDispWord()
        {
            foreach (char c in _word)
            {
                dispWord += c + ' ';
            }
            return dispWord;
        }

        public List<char> SetWordList()
        {
            foreach (char c in _word)
            {
                switch (c)
                {
                    case ' ':
                        break;
                    default:
                        wordList.Add(c);
                        break;
                }
            }
            return wordList;
        }
    }
}
