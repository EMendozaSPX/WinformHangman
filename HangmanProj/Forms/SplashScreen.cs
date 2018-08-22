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
    public class SplashScreen : Form
    {
        Bitmap ImageOne, ImageTwo;
        PictureBox splashBox;
        Timer showImage;

        public SplashScreen()
        {
            
        }

        private void InitializeComponent()
        {
            this.splashBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splashBox)).BeginInit();
            this.SuspendLayout();
            // SplashImages
            ImageOne = Properties.Resources.SchoolLogo;
            ImageTwo = Properties.Resources.EuanLogo;
            this.splashBox.BackColor = Color.Black;
            this.splashBox.Location = new Point(1, 1);
            this.splashBox.Name = "splashBox";
            this.splashBox.Size = new Size(1600, 900);
            this.splashBox.SizeMode = PictureBoxSizeMode.CenterImage;
            this.splashBox.Image = ImageOne;


            // 
            // SplashScreen
            // 
            this.ClientSize = new Size(1600, 900);
            this.Name = "SplashScreen";
            this.Load += new EventHandler(this.SplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splashBox)).EndInit();
            this.ResumeLayout(false);
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            
        }

        private void SplashScreen_Shown(object sender, EventArgs e)
        {
            showImage = new Timer();
            showImage.Interval = 4000;
            showImage.Start();
            showImage.Tick += showImage_Tick;
        }

        private void showImage_Tick(object sender, EventArgs e)
        {
            if (splashBox.Image == ImageTwo)
            {
                showImage.Stop();
                MenuScreen menu = new MenuScreen();
                menu.Show();
                this.Hide();
            }
            else
            {
                splashBox.Image = ImageTwo;
            }
        }
    }
}
