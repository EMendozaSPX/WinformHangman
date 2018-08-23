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
        public MenuScreen()
        {
            this.InitializeComponent();
        }
        
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SplashScreen
            // 
            this.ClientSize = new System.Drawing.Size(960, 720);
            this.Name = "MenuScreen";

            this.ResumeLayout(false);
        }
    }
}
