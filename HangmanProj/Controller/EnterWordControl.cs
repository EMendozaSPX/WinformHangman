using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HangmanProj.View;

namespace HangmanProj.Controller
{
    public class EnterWordControl
    {
        public string word { get; set; }

        EnterWordScreen view;

        public EnterWordControl()
        {
            view = new EnterWordScreen();
            view.SetControllerInstance(this);
        }

        public void displayView()
        {
            view.Show();
        }
    }
}
