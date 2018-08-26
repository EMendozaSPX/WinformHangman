using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HangmanProj.Model;
using HangmanProj.View;

namespace HangmanProj.Controller
{
    public enum ScreenState
    {
        NewWord,
        OldWord
    }

    public class GameControl
    {
        ScreenState state;
        EnterWordControl subControlNewWord;
        SetWordModel setWord;
        GameScreen view;

        private List<char> word { get; set; }
        private List<char> dispList { get; set; }
        public string dispWord;
        private string tempWord;
        
        public GameControl()
        {

        }

        public void NewWord()
        {
            subControlNewWord = new EnterWordControl();
            subControlNewWord.SetParentInstance(this);
            subControlNewWord.DisplayView();
            state = 0;
        }

        public void InitializeGame()
        {
            
            switch (state)
            {
                case 0:
                    tempWord = subControlNewWord.word;
                    setWord = new SetWordModel(tempWord);
                    word = setWord.SetWordList();
                    dispWord = setWord.SetDispWord();
                    subControlNewWord.view.Hide();
                    break;
            }
            view = new GameScreen(dispWord);
            view.Show();
        }
    }
}
