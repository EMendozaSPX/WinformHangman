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
        private PictureBox splashBox;
        private Bitmap imageOne, imageTwo;
        private Timer showImage;

        public SplashScreen()
        {
            imageOne = global::HangmanProj.Properties.Resources.SchoolLogo;
            imageTwo = global::HangmanProj.Properties.Resources.EuanLogo;
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.splashBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splashBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splashBox
            // 
            this.splashBox.BackColor = System.Drawing.Color.Black;
            this.splashBox.Location = new System.Drawing.Point(0, 0);
            this.splashBox.Name = "splashBox";
            this.splashBox.Size = new System.Drawing.Size(960, 720);
            this.splashBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.splashBox.TabIndex = 0;
            this.splashBox.TabStop = false;
            // 
            // SplashScreen
            // 
            this.ClientSize = new System.Drawing.Size(960, 720);
            this.Controls.Add(this.splashBox);
            this.Name = "SplashScreen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.Shown += new System.EventHandler(this.SplashScreen_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.splashBox)).EndInit();
            this.ResumeLayout(false);

        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            this.splashBox.Image = imageOne;
        }

        private void SplashScreen_Shown(object sender, EventArgs e)
        {
            showImage = new Timer();
            showImage.Interval = 2000;
            showImage.Start();
            showImage.Tick += showImage_Tick;
        }

        private void showImage_Tick(object sender, EventArgs e)
        {
            if (this.splashBox.Image == imageTwo)
            {
                showImage.Stop();
                MenuScreen menu = new MenuScreen();
                menu.Show();
                this.Hide();
            }
            else
            {
                this.splashBox.Image = imageTwo;
            }
        }
    }
}
