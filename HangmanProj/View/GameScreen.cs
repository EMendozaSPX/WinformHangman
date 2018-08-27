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
        private FlowLayoutPanel guessButtons;
        private PictureBox hangmanSpot;
        private FlowLayoutPanel guessedLettersContainer;
        private Label lettersGuessedLabel;
        private Label remainingGuessLabel;
        private Label remainingGuessesDisplay;
        private string dispWord;

        public GameScreen(string _dispWord)
        {
            dispWord = _dispWord;
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.dispWordLabel = new System.Windows.Forms.Label();
            this.hangmanSpot = new System.Windows.Forms.PictureBox();
            this.guessedLettersContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lettersGuessedLabel = new System.Windows.Forms.Label();
            this.remainingGuessLabel = new System.Windows.Forms.Label();
            this.remainingGuessesDisplay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hangmanSpot)).BeginInit();
            this.SuspendLayout();
            // 
            // dispWordLabel
            // 
            this.dispWordLabel.AutoSize = true;
            this.dispWordLabel.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispWordLabel.ForeColor = System.Drawing.Color.White;
            this.dispWordLabel.Location = new System.Drawing.Point(534, 377);
            this.dispWordLabel.Name = "dispWordLabel";
            this.dispWordLabel.Size = new System.Drawing.Size(75, 40);
            this.dispWordLabel.TabIndex = 0;
            this.dispWordLabel.Text = "test";
            // 
            // hangmanSpot
            // 
            this.hangmanSpot.Location = new System.Drawing.Point(0, 0);
            this.hangmanSpot.Name = "hangmanSpot";
            this.hangmanSpot.Size = new System.Drawing.Size(291, 469);
            this.hangmanSpot.TabIndex = 0;
            this.hangmanSpot.TabStop = false;
            // 
            // lettersGuessedLabel
            // 
            this.lettersGuessedLabel.AutoSize = true;
            this.lettersGuessedLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lettersGuessedLabel.ForeColor = System.Drawing.Color.White;
            this.lettersGuessedLabel.Location = new System.Drawing.Point(333, 19);
            this.lettersGuessedLabel.Name = "lettersGuessedLabel";
            this.lettersGuessedLabel.Size = new System.Drawing.Size(154, 26);
            this.lettersGuessedLabel.TabIndex = 3;
            this.lettersGuessedLabel.Text = "Guessed Letters";
            // 
            // remainingGuessLabel
            // 
            this.remainingGuessLabel.AutoSize = true;
            this.remainingGuessLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainingGuessLabel.ForeColor = System.Drawing.Color.White;
            this.remainingGuessLabel.Location = new System.Drawing.Point(723, 19);
            this.remainingGuessLabel.Name = "remainingGuessLabel";
            this.remainingGuessLabel.Size = new System.Drawing.Size(173, 26);
            this.remainingGuessLabel.TabIndex = 4;
            this.remainingGuessLabel.Text = "Guesses Remaining";
            // 
            // remainingGuessesDisplay
            // 
            this.remainingGuessesDisplay.AutoSize = true;
            this.remainingGuessesDisplay.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainingGuessesDisplay.ForeColor = System.Drawing.Color.White;
            this.remainingGuessesDisplay.Location = new System.Drawing.Point(786, 59);
            this.remainingGuessesDisplay.Name = "remainingGuessesDisplay";
            this.remainingGuessesDisplay.Size = new System.Drawing.Size(58, 67);
            this.remainingGuessesDisplay.TabIndex = 5;
            this.remainingGuessesDisplay.Text = "1";
            // 
            // GameScreen
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(960, 720);
            this.Controls.Add(this.remainingGuessesDisplay);
            this.Controls.Add(this.remainingGuessLabel);
            this.Controls.Add(this.lettersGuessedLabel);
            this.Controls.Add(this.guessedLettersContainer);
            this.Controls.Add(this.hangmanSpot);
            this.Controls.Add(this.guessButtons);
            this.Controls.Add(this.dispWordLabel);
            this.Name = "GameScreen";
            ((System.ComponentModel.ISupportInitialize)(this.hangmanSpot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void initializeGuessButtons()
        {
            this.guessButtons.Location = new System.Drawing.Point(121, 475);
            this.guessButtons.Name = "guessButtons";
            this.guessButtons.Size = new System.Drawing.Size(723, 244);
            this.guessButtons.TabIndex = 1;
        }

        private void initializeGuessedLettersContainer()
        {
            this.guessButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.guessedLettersContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.guessedLettersContainer.Location = new System.Drawing.Point(314, 59);
            this.guessedLettersContainer.Name = "guessedLettersContainer";
            this.guessedLettersContainer.Size = new System.Drawing.Size(271, 224);
            this.guessedLettersContainer.TabIndex = 2;
        }
    }
}
