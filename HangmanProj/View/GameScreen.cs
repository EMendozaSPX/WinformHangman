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
        private Label dispWordLabel;
        private string dispWord;

        public GameScreen(string _dispWord)
        {
            dispWord = _dispWord;
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.dispWordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dispWordLabel
            // 
            this.dispWordLabel.AutoSize = true;
            this.dispWordLabel.Location = new System.Drawing.Point(362, 318);
            this.dispWordLabel.Name = "dispWordLabel";
            this.dispWordLabel.Size = new System.Drawing.Size(35, 13);
            this.dispWordLabel.TabIndex = 0;
            this.dispWordLabel.Text = dispWord;
            // 
            // GameScreen
            // 
            this.ClientSize = new System.Drawing.Size(960, 720);
            this.Controls.Add(this.dispWordLabel);
            this.Name = "GameScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
