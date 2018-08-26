using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanProj.Model
{
    public class GameModel
    {
        public string dispWord;
        private List<char> wordList, usedChar;
        private int attempts;

        public GameModel(string _dispWord, List<char> _wordList)
        {
            dispWord = _dispWord;
            wordList = _wordList;
            attempts = 12;
        }

        public void MainLogic()
        {

        }

        public void ProcessGuess(char guess)
        {
            if (attempts != 0)
            {
                foreach (int x in wordList)
                {

                    if (wordList[x] == guess)
                    {
                        int i = (x * 2);
                        dispWord[x] = guess;
                    }
                }
            }

            else
            {
                
            }
        }
    }
}
