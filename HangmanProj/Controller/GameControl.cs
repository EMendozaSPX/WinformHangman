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

    public enum HangState
    {
        None,
        Base,
        CentreBeam,
        RSupport,
        LSupport,
        TopBeam,
        TopSupport,
        Noose,
        Head,
        Body,
        Arm,
        RLeg,
        Hanged
    }

    public class GameControl
    {
        public HangState ManState;
        ScreenState state;
        EnterWordControl subControlNewWord;
        GameModel model;
        GameScreen view;
        public SetWordModel setWord;
        public int remainingTurns;
        private List<char> word { get; set; }
        private List<char> dispList { get; set; }
        public string dispWord;
        private string tempWord;
        
        public GameControl()
        {
            ManState = HangState.None;
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
            model = new GameModel(this, dispWord, word);
        }
    }
}
