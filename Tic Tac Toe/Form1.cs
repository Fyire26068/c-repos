using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class tictactoe : Form
    {
        //Class Variables
        public int player = 2; // even = x turn odd = o turn
        public int turns = 0; //counting turns
        public int xWins = 0;
        public int oWins = 0;
        public int ties = 0;


        public tictactoe()
        {
            InitializeComponent();
        }
        void NewGame()
        {
            player = 2;
            turns = 0;
            XWinLbl.Text = "X Wins :   " + xWins;
            OWinLbl.Text = "O Wins :   " + oWins;
            tieLbl.Text = "Ties :   " + ties;
            bttnA1.Text = bttnA2.Text = bttnA3.Text = bttnB1.Text = bttnB2.Text = bttnB3.Text = bttnC1.Text = bttnC2.Text = bttnC3.Text = "";
            bttnA1.Enabled = bttnA2.Enabled = bttnA3.Enabled = bttnB1.Enabled = bttnB2.Enabled = bttnB3.Enabled = bttnC1.Enabled = bttnC2.Enabled = bttnC3.Enabled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.LightYellow;
            XWinLbl.Text = "X Wins :   " + xWins;
            OWinLbl.Text = "O Wins :   " + oWins;
            tieLbl.Text = "Ties :   " + ties;
            bttnA1.BackColor = bttnA2.BackColor = bttnA3.BackColor = bttnB1.BackColor = bttnB2.BackColor = bttnB3.BackColor = bttnC1.BackColor = bttnC2.BackColor = bttnC3.BackColor = newBtn.BackColor = resetBtn.BackColor = exitBtn.BackColor = Color.White;
            resetBtn.BackColor = newBtn.BackColor = exitBtn.BackColor = Color.DarkGray;
        }
        private void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (player % 2 == 0)
            {
                button.Text = "X";
                player++;
                turns++;
            }
            else
            {
                button.Text = "O";
                player++;
                turns++;
            }
            button.Enabled = false;
            button.BackColor = Color.White;

            

            if (checkWin() == true)
            {
                if(button.Text == "X")
                {
                    MessageBox.Show("X Won!");
                    xWins++;
                    NewGame();
                }
                else
                {
                    MessageBox.Show("O Won!");
                    oWins++;
                    NewGame();
                }
            }
            else
            {
                if (checkDraw())
                {
                    MessageBox.Show("Tie Game");
                    ties++;
                    NewGame();
                }
            }
        }

        bool checkDraw()
        {
            if (turns >= 9)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        bool checkWin()
        {
            //horizontal checks
            if ((bttnA1.Text == bttnA2.Text) && (bttnA1.Text == bttnA3.Text) && (bttnA1.Text != ""))
            {
                return true;
            }
            else if ((bttnB1.Text == bttnB2.Text) && (bttnB1.Text==bttnB3.Text) && (bttnB1.Text!= ""))
            {
                return true;
            }
            else if ((bttnC1.Text == bttnC2.Text) && (bttnC1.Text == bttnC3.Text) && (bttnC1.Text != ""))
            {
                return true;
            }
            //vertical checks
            else if ((bttnA1.Text == bttnB1.Text) && (bttnA1.Text == bttnC1.Text) && (bttnA1.Text != ""))
            {
                return true;
            }
            else if ((bttnA2.Text == bttnB2.Text) && (bttnA2.Text == bttnC2.Text) && (bttnA2.Text != ""))
            {
                return true;
            }
            else if ((bttnA3.Text == bttnB3.Text) && (bttnA3.Text == bttnC3.Text) && (bttnA3.Text != ""))
            {
                return true;
            }
            //diagonal checks
            else if ((bttnA1.Text == bttnB2.Text) && (bttnA1.Text == bttnC3.Text) && (bttnA1.Text != ""))
            {
                return true;
            }
            else if ((bttnC1.Text == bttnB2.Text) && (bttnC1.Text == bttnA3.Text) && (bttnC1.Text != ""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            NewGame();
            oWins = 0;
            xWins = 0;
            ties = 0;
            XWinLbl.Text = "X Wins :   " + xWins;
            OWinLbl.Text = "O Wins :   " + oWins;
            tieLbl.Text = "Ties :   " + ties;
        }
    }
}
