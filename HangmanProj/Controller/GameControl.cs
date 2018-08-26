using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HangmanProj.Model;

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

        private List<char> word { get; set; }
        private List<char> dispList { get; set; }
        public string dispWord;
        
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
                    setWord = new SetWordModel(subControlNewWord.word);
                    word = setWord.SetWordList();
                    dispWord = setWord.SetDispWord();
                    subControlNewWord.view.Hide();
                    break;
            }
        }
    }
}
