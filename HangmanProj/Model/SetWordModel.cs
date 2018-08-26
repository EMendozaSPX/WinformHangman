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
                switch (c)
                {
                    case ' ':
                        builder.Append(' ');
                        builder.Append(' ');
                        break;
                    default:
                        builder.Append('_');
                        builder.Append(' ');
                        break;
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
