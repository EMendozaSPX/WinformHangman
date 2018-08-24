using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HangmanProj
{
    public class MenuScreen : Form
    {
        private Label Title;

        public MenuScreen()
        {
            this.InitializeComponent();
        }
        
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(960, 90);
            this.Title.TabIndex = 0;
            this.Title.Text = "Ms Crabapples Hangman Game";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuScreen
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(20)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(960, 720);
            this.Controls.Add(this.Title);
            this.Name = "MenuScreen";
            this.Load += new System.EventHandler(this.MenuScreen_Load);
            this.ResumeLayout(false);

        }

        private void MenuScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
