using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HangmanProj.Controller;

namespace HangmanProj.Model
{
    public class GameModel
    {
        public string dispWord;
        private List<char> wordList, usedChar;
        private GameControl instance;

        public GameModel(GameControl _instance, string _dispWord, List<char> _wordList)
        {
            instance = _instance;
            dispWord = _dispWord;
            wordList = _wordList;
        }

        public void MainLogic()
        {

        }

        public void ProcessGuess(char guess)
        {
            if (instance.ManState != HangState.Hanged)
            {
                foreach (int x in wordList)
                {

                    if (wordList[x] == guess)
                    {
                        instance.dispWord = instance.setWord.SetDispWord(x);

                    }
                }
            }

            else if (usedChar.Contains(guess))
            {

            }

            else
            {
                
            }
            usedChar.Add(guess);
        }
    }
}
