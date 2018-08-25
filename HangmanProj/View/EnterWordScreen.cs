using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using HangmanProj.Controller;


namespace HangmanProj.View
{
    public class EnterWordScreen : Form
    {
        private TextBox enterTextBox;
        private Button enterButton;
        private Label enterLabel;
        EnterWordControl controller;

        public EnterWordScreen()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.enterLabel = new System.Windows.Forms.Label();
            this.enterTextBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterLabel
            // 
            this.enterLabel.AutoSize = true;
            this.enterLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterLabel.ForeColor = System.Drawing.Color.White;
            this.enterLabel.Location = new System.Drawing.Point(345, 221);
            this.enterLabel.Name = "enterLabel";
            this.enterLabel.Size = new System.Drawing.Size(234, 30);
            this.enterLabel.TabIndex = 0;
            this.enterLabel.Text = "Enter Hangman Word";
            // 
            // enterTextBox
            // 
            this.enterTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(59)))));
            this.enterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterTextBox.ForeColor = System.Drawing.Color.Black;
            this.enterTextBox.Location = new System.Drawing.Point(300, 291);
            this.enterTextBox.MaxLength = 30;
            this.enterTextBox.Name = "enterTextBox";
            this.enterTextBox.PasswordChar = '*';
            this.enterTextBox.Size = new System.Drawing.Size(229, 26);
            this.enterTextBox.TabIndex = 1;
            this.enterTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterTextBox_KeyDown);
            this.enterTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enterTextBox_KeyPress);
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(59)))));
            this.enterButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterButton.Location = new System.Drawing.Point(584, 288);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 31);
            this.enterButton.TabIndex = 2;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // EnterWordScreen
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(20)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(960, 720);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.enterTextBox);
            this.Controls.Add(this.enterLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EnterWordScreen";
            this.Load += new System.EventHandler(this.EnterWordScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void SetControllerInstance(EnterWordControl enterWord)
        {
            controller = enterWord;
        }

        private void EnterWordScreen_Load(object sender, EventArgs e)
        {

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (this.enterTextBox != null)
            {
                this.controller.word = this.enterTextBox.ToString();
            }          
        }

        private void enterTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Regex.IsMatch(e.KeyChar.ToString(), @"[^a-zA-Z\s]"))
            {
                e.Handled = true;
            }

            else if (e.KeyChar == (char)Keys.Enter && this.enterTextBox != null)
            {
                this.controller.word = this.enterTextBox.ToString();
            }
        }

        private void enterTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
