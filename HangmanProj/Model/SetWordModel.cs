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
        
        public SetWordModel(string word)
        {
            _word = word;
        }

        public string SetDispWord()
        {
            var builder = new StringBuilder();
            foreach (char c in _word)
            {
                if (c == ' ')
                {
                    builder.Append(' ');
                    builder.Append(' ');
                }

                else
                {
                    builder.Append('_');
                    builder.Append(' ');
                }
            }
            dispWord = builder.ToString();
            return dispWord;
        }

        public string SetDispWord(int index)
        {
            var builder = new StringBuilder();
            char t = _word[index];
            foreach (char c in _word)
            {
                if (c == ' ')
                {
                    builder.Append(' ');
                    builder.Append(' ');
                }

                else if (c == t)
                {
                    builder.Append(c);
                }

                else
                {
                    builder.Append('_');
                    builder.Append(' ');
                }
            }
            dispWord = builder.ToString();
            return dispWord;
        }

        public List<char> SetWordList()
        {
            List<char> wordList = new List<char>();
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
