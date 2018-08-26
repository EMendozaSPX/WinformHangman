using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using HangmanProj.Controller;

namespace HangmanProj
{
    public class MenuScreen : Form
    {
        private GameControl Game;

        private Button New;
        private Button Reuse;
        private Label Title;

        public MenuScreen()
        {
            this.InitializeComponent();
            Game = new GameControl();
        }
        
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.New = new System.Windows.Forms.Button();
            this.Reuse = new System.Windows.Forms.Button();
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
            // New
            // 
            this.New.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(59)))));
            this.New.Font = new System.Drawing.Font("Lucida Sans", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.New.Location = new System.Drawing.Point(50, 305);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(215, 135);
            this.New.TabIndex = 1;
            this.New.Text = "New Word";
            this.New.UseVisualStyleBackColor = false;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Reuse
            // 
            this.Reuse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(59)))));
            this.Reuse.Font = new System.Drawing.Font("Lucida Sans", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reuse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.Reuse.Location = new System.Drawing.Point(680, 305);
            this.Reuse.Name = "Reuse";
            this.Reuse.Size = new System.Drawing.Size(215, 135);
            this.Reuse.TabIndex = 2;
            this.Reuse.Text = "Reuse Old Word";
            this.Reuse.UseVisualStyleBackColor = false;
            this.Reuse.Click += new System.EventHandler(this.Reuse_Click);
            // 
            // MenuScreen
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(20)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(960, 720);
            this.Controls.Add(this.Reuse);
            this.Controls.Add(this.New);
            this.Controls.Add(this.Title);
            this.Name = "MenuScreen";
            this.Load += new System.EventHandler(this.MenuScreen_Load);
            this.ResumeLayout(false);

        }

        private void MenuScreen_Load(object sender, EventArgs e)
        {

        }

        private void New_Click(object sender, EventArgs e)
        {
            Game.NewWord();
            this.Hide();
        }

        private void Reuse_Click(object sender, EventArgs e)
        {

        }
    }
}
