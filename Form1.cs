using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class Form1 : Form
    {
        private readonly Game game;
        private readonly bool isDebugMode = false; 

        public Form1()
        {
            InitializeComponent();
            game = new Game();
            UpdateUI();
            this.KeyPreview = true;
            this.KeyPress += Form1_KeyPress;
            ApplyCustomStyle();
        }

        private void ApplyCustomStyle()
        {
            // Dark theme colors
            Color darkBackground = Color.FromArgb(32, 32, 32);
            Color darkPanel = Color.FromArgb(45, 45, 45);
            Color accentColor = Color.FromArgb(86, 156, 214); 
            Color textColor = Color.FromArgb(220, 220, 220);

            this.BackColor = darkBackground;
            panelMain.BackColor = darkPanel;
            panelMain.BorderStyle = BorderStyle.None;
            
            foreach (Control control in panelMain.Controls)
            {
                if (control is Button btn)
                {
                    btn.BackColor = accentColor;
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Cursor = Cursors.Hand;
                }
                else if (control is Label lbl)
                {
                    lbl.ForeColor = textColor;
                }
            }

            txtGuess.BorderStyle = BorderStyle.None;
            txtGuess.BackColor = Color.FromArgb(60, 60, 60);
            txtGuess.ForeColor = textColor;
            panelTextBox.BackColor = Color.FromArgb(60, 60, 60);

            // Add some padding and rounded corners to the main panel
            panelMain.Padding = new Padding(30);
            AddRoundedCorners(panelMain);
            AddRoundedCorners(btnGuess);
            AddRoundedCorners(panelTextBox);
        }

        private void AddRoundedCorners(Control control)
        {
            control.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width, control.Height, 10, 10));
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, 
            int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            AddRoundedCorners(panelMain);
            AddRoundedCorners(btnGuess);
            AddRoundedCorners(panelTextBox);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnGuess.PerformClick();
                e.Handled = true;
            }
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtGuess.Text, out int guess))
            {
                ShowError("Please enter a valid number!");
                return;
            }

            if (guess < 1 || guess > 1000)
            {
                ShowError("Please enter a number between 1 and 1000!");
                return;
            }

            var (message, isCorrect) = game.CheckGuess(guess);
            UpdateUI(message);

            if (isCorrect)
            {
                HandleGameWon();
            }

            txtGuess.Clear();
            txtGuess.Focus();
        }

        private void ShowError(string message)
        {
            lblResult.Text = message;
            lblResult.ForeColor = Color.FromArgb(255, 99, 99); 
            txtGuess.SelectAll();
            txtGuess.Focus();
        }

        private void HandleGameWon()
        {
            var stats = game.GetStatistics();
            var performanceMessage = stats.CurrentGuesses < 10 ? 
                "I think you know the secret!" : 
                "You can do better!";
                
            var message = $"Congratulations! You won!\n" +
                         $"Number of guesses: {stats.CurrentGuesses}\n" +
                         $"{performanceMessage}\n" +
                         $"Best score: {stats.BestScore}\n\n" +
                         $"Would you like to play again?";

            if (MessageBox.Show(message, "Game Over", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                game.NewGame();
                UpdateUI();
            }
            else
            {
                Close();
            }
        }

        private void UpdateUI(string message = null)
        {
            lblResult.Text = message ?? "I have a number between 1 and 1000.\nPlease enter your guess:";
            lblResult.ForeColor = Color.FromArgb(220, 220, 220); // Light text for dark theme
            lblStats.Text = $"Games Played: {game.GetStatistics().GamesPlayed}";
            lblStats.ForeColor = Color.FromArgb(180, 180, 180); // Slightly dimmer text for stats
            
            if (isDebugMode)
            {
                lblSecretNumber.Text = $"Secret Number: {game.GetTargetNumber()}";
                lblSecretNumber.Visible = true;
            }
            else
            {
                lblSecretNumber.Visible = false;
            }

            txtGuess.Clear();
            txtGuess.Focus();
        }

        private void txtGuess_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
