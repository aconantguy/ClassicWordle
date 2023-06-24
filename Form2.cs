using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wordle
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string word;
        public int guesses;
        public Point pos1;
        public Point pos2;
        public Point pos3;
        public Point pos4;
        public Point pos5;
        public string BankString = "Incorrect Letters: \n\n\n";
        public string Bank = "";

        public void btnGuess_Click(object sender, EventArgs e)
        {
            if (txtGuess.Text.Length != 5)
            {
                txtInstructions.Text = "Oops! \nMake sure to input a 5-letter word!";
                txtInstructions.Show();
                return;
            }

            string Guess = txtGuess.Text;
            char[] wordArray = word.ToCharArray();
            char[] GuessArray = Guess.ToCharArray();


            Respond(GuessArray, wordArray);
            txtInstructions.Text = BankString;
            


            txtChar1.Text = Convert.ToString(GuessArray[0]);
            txtChar2.Text = Convert.ToString(GuessArray[1]);
            txtChar3.Text = Convert.ToString(GuessArray[2]);
            txtChar4.Text = Convert.ToString(GuessArray[3]);
            txtChar5.Text = Convert.ToString(GuessArray[4]);

            guesses--;
            txtGuesses.Text = Convert.ToString(guesses);

            if (Guess == word)
            {
                txtRemaining.Text = "Congradulations!";
                txtGuesses.Hide();
                btnGuess.Enabled = false;
                txtGuess.Enabled = false;
                btnNewGame.Show();
            }
            else if (guesses == 0)
            {
                txtGuesses.Hide();
                txtRemaining.Text = "Too Bad! Try Again!";
                btnGuess.Enabled = false;
                txtGuess.Enabled = false;
                txtInstructions.Text = "The Word Was: " + word;
                txtInstructions.Show();
                btnNewGame.Show();
            }    
        }

        public void Respond(char[] guess, char[] word)
        {

            if (guess[0] == word[0])
            {
                green1.Show();
                yellow1.Hide();
                grey1.Hide();

                if (guesses == 6)
                {
                    pos1 = this.PointToScreen(txtChar1.Location);
                    pos1 = green1.PointToClient(pos1);
                }
                txtChar1.Parent = green1;
                txtChar1.Location = pos1;
            }
            else if (word.Contains(guess[0]))
            {
                yellow1.Show();
                green1.Hide();
                grey1.Hide();
                if (guesses == 6)
                {
                    pos1 = this.PointToScreen(txtChar1.Location);
                    pos1 = green1.PointToClient(pos1);
                }
                txtChar1.Parent = yellow1;
                txtChar1.Location = pos1;
            }
            else
            {
                grey1.Show();
                green1.Hide();
                yellow1.Hide();
                if (guesses == 6)
                {
                    pos1 = this.PointToScreen(txtChar1.Location);
                    pos1 = green1.PointToClient(pos1);
                }
                txtChar1.Parent = grey1;
                txtChar1.Location = pos1;
                if (!(Bank.Contains(guess[0])))
                {
                    BankString = BankString + "  " + guess[0];
                    Bank += (guess[0]);
                }
            };


            if (guess[1] == word[1])
            {
                green2.Show();
                yellow2.Hide();
                grey2.Hide();
                if (guesses == 6)
                {
                    pos2 = this.PointToScreen(txtChar2.Location);
                    pos2 = green2.PointToClient(pos2);
                }
                txtChar2.Parent = green2;
                txtChar2.Location = pos2;
            }
            else if (word.Contains(guess[1]))
            {
                yellow2.Show();
                green2.Hide();
                grey2.Hide();
                if (guesses == 6)
                {
                    pos2 = this.PointToScreen(txtChar2.Location);
                    pos2 = green2.PointToClient(pos2);
                }
                txtChar2.Parent = yellow2;
                txtChar2.Location = pos2;
            }
            else
            {
                grey2.Show();
                green2.Hide();
                yellow2.Hide();
                if (guesses == 6)
                {
                    pos2 = this.PointToScreen(txtChar2.Location);
                    pos2 = green2.PointToClient(pos2);
                }
                txtChar2.Parent = grey2;
                txtChar2.Location = pos2;
                if (!(Bank.Contains(guess[1])))
                {
                    BankString = BankString + "  " + guess[1];
                    Bank += (guess[1]);
                }






            };



            if (guess[2] == word[2])
            {
                green3.Show();
                yellow3.Hide();
                grey3.Hide();
                if (guesses == 6)
                {
                    pos3 = this.PointToScreen(txtChar3.Location);
                    pos3 = green3.PointToClient(pos3);
                }
                txtChar3.Parent = green3;
                txtChar3.Location = pos3;
            }
            else if (word.Contains(guess[2]))
            {
                yellow3.Show();
                green3.Hide();
                grey3.Hide();
                if (guesses == 6)
                {
                    pos3 = this.PointToScreen(txtChar3.Location);
                    pos3 = green3.PointToClient(pos3);
                }
                txtChar3.Parent = yellow3;
                txtChar3.Location = pos3;
            }
            else
            {
                grey3.Show();
                green3.Hide();
                yellow3.Hide();
                if (guesses == 6)
                {
                    pos3 = this.PointToScreen(txtChar3.Location);
                    pos3 = green3.PointToClient(pos3);
                }
                txtChar3.Parent = grey3;
                txtChar3.Location = pos3;
                if (!(Bank.Contains(guess[2])))
                {
                    BankString = BankString + "  " + guess[2];
                    Bank += (guess[2]);
                }




            };



            if (guess[3] == word[3])
            {
                green4.Show();
                yellow4.Hide();
                grey4.Hide();
                if (guesses == 6)
                {
                    pos4 = this.PointToScreen(txtChar4.Location);
                    pos4 = green4.PointToClient(pos4);
                }
                txtChar4.Parent = green4;
                txtChar4.Location = pos4;
            }
            else if (word.Contains(guess[3]))
            {
                yellow4.Show();
                green4.Hide();
                grey4.Hide();
                if (guesses == 6)
                {
                    pos4 = this.PointToScreen(txtChar4.Location);
                    pos4 = green4.PointToClient(pos4);
                }
                txtChar4.Parent = yellow4;
                txtChar4.Location = pos4;
            }
            else
            {
                grey4.Show();
                green4.Hide();
                yellow4.Hide();
                if (guesses == 6)
                {
                    pos4 = this.PointToScreen(txtChar4.Location);
                    pos4 = green4.PointToClient(pos4);
                }
                txtChar4.Parent = grey4;
                txtChar4.Location = pos4;
                if (!(Bank.Contains(guess[3])))
                {
                    BankString = BankString + "  " + guess[3];
                    Bank += (guess[3]);
                }





            };



            if (guess[4] == word[4])
            {
                green5.Show();
                yellow5.Hide();
                grey5.Hide();
                if (guesses == 6)
                {
                    pos5 = this.PointToScreen(txtChar5.Location);
                    pos5 = green5.PointToClient(pos5);
                }
                txtChar5.Parent = green5;
                txtChar5.Location = pos5;
            }
            else if (word.Contains(guess[4]))
            {
                yellow5.Show();
                green5.Hide();
                grey5.Hide();
                if (guesses == 6)
                {
                    pos5 = this.PointToScreen(txtChar5.Location);
                    pos5 = green5.PointToClient(pos5);
                }
                txtChar5.Parent = yellow5;
                txtChar5.Location = pos5;
            }
            else
            {
                grey5.Show();
                green5.Hide();
                yellow5.Hide();
                if (guesses == 6)
                {
                    pos5 = this.PointToScreen(txtChar5.Location);
                    pos5 = green5.PointToClient(pos5);
                }
                txtChar5.Parent = grey5;
                txtChar5.Location = pos5;
                if (!(Bank.Contains(guess[4])))
                {
                    BankString = BankString + "  " + guess[4];
                    Bank += (guess[4]);
                }




            };

        }


        private void btnNewGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 NewGame = new Form1();
            NewGame.Closed += (s, args) => this.Close();
            NewGame.Show();
        }

    }   
}
