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
        private int elapsedTurns;
        private GameControl controller;

        public GameModel(GameControl instance)
        {
            controller = instance;
        }

        public void Update(char guess)
        {
            elapsedTurns = (int)controller.ManState;
            if (elapsedTurns != 12)
            {
                controller.RemainingTurns = 12 - elapsedTurns;
                if (controller.word.Contains(guess))
                {
                    controller.SetWord.SetDispWord(controller.word.IndexOf(guess));
                    controller.view.RedrawDisplayWord();
                }
                else
                {
                    controller.GuessedLetters.Add(guess);
                } 
            }
        }
    }
}
