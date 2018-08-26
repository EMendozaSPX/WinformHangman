using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using HangmanProj.Controller;

namespace HangmanProj.View
{
    public class GameScreen : Form
    {
        public GameScreen()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // GameScreen
            // 
            this.ClientSize = new System.Drawing.Size(960, 720);
            this.Name = "GameScreen";
            this.ResumeLayout(false);

        }
    }
}
