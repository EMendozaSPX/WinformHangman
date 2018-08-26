using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using HangmanProj.View;

namespace HangmanProj.Controller
{
    public class EnterWordControl
    {
        public string word { get; set; }

        public EnterWordScreen view;
        public GameControl parent;

        public EnterWordControl()
        {
            view = new EnterWordScreen(this);
        }

        public void DisplayView()
        {
            view.Show();
        }

        public void SetParentInstance(GameControl instance)
        {
            parent = instance;
        }

        public void enterButton_Click(object sender, EventArgs e)
        {
            if (view.enterTextBox != null)
            {
                word = view.enterTextBox.Text.ToUpper();
                parent.InitializeGame();
            }
        }

        public void enterTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Regex.IsMatch(e.KeyChar.ToString(), @"[^a-zA-Z\s]"))
            {
                e.Handled = true;
            }

            else if (e.KeyChar == (char)Keys.Enter && view.enterTextBox != null)
            {
                word = view.enterTextBox.Text.ToUpper();
                parent.InitializeGame();
            }
        }
    }
}
