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
        public string DispWord;
        public HangState ManState;
        public SetWordModel SetWord;
        public GameScreen view;
        public int RemainingTurns;
        public List<char> GuessedLetters;
        public List<char> word;

        ScreenState state;
        EnterWordControl subControlNewWord;
        GameModel model;
        

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
                    SetWord = new SetWordModel(subControlNewWord.word);
                    word = SetWord.SetWordList();
                    RemainingTurns = 12;
                    DispWord = SetWord.SetDispWord();
                    subControlNewWord.view.Hide();
                    break;
            }
            view = new GameScreen(this);
            view.Show();
            model = new GameModel(this);
        }

        private void setHangImage()
        {
            switch (ManState)
            {
                case (HangState) 1:

                    break;
                case (HangState)2:
                    break;
            }
        }
    }
}
