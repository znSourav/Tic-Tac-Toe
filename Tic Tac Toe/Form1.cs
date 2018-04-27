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
    public partial class TicHome : Form
    {
        bool p1 = true, p2 = false;
        string p1T = "", p2T = "", playerlab = "Player 1";

        public TicHome()
        {
            InitializeComponent();
        }

        public void win()
        {
            if((button1.Text=="X" && button2.Text == "X" && button3.Text == "X") || (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"))
            {
                if(playerlab == "Player 1")
                {
                    PlayerP.Text = "Player 2 Wins";
                    SignLabel.Text = "";
                    button1.Enabled = false; button2.Enabled = false; button3.Enabled = false;
                    button4.Enabled = false; button5.Enabled = false; button6.Enabled = false;
                    button7.Enabled = false; button8.Enabled = false; button9.Enabled = false;
                    ReplayButton.Enabled = true;
                }
                else if(playerlab == "Player 2")
                {
                    PlayerP.Text = "Player 1 Wins";
                    SignLabel.Text = "";
                    button1.Enabled = false; button2.Enabled = false; button3.Enabled = false;
                    button4.Enabled = false; button5.Enabled = false; button6.Enabled = false;
                    button7.Enabled = false; button8.Enabled = false; button9.Enabled = false;
                    ReplayButton.Enabled = true;

                }
            }
            else if((button1.Text == "X" && button4.Text == "X" && button7.Text == "X") || (button1.Text == "O" && button4.Text == "O" && button7.Text == "O"))
            {
                if (playerlab == "Player 1")
                {
                    PlayerP.Text = "Player 2 Wins";
                    SignLabel.Text = "";
                    button1.Enabled = false; button2.Enabled = false; button3.Enabled = false;
                    button4.Enabled = false; button5.Enabled = false; button6.Enabled = false;
                    button7.Enabled = false; button8.Enabled = false; button9.Enabled = false;
                    ReplayButton.Enabled = true;
                }
                else if (playerlab == "Player 2")
                {
                    PlayerP.Text = "Player 1 Wins";
                    SignLabel.Text = "";
                    button1.Enabled = false; button2.Enabled = false; button3.Enabled = false;
                    button4.Enabled = false; button5.Enabled = false; button6.Enabled = false;
                    button7.Enabled = false; button8.Enabled = false; button9.Enabled = false;
                    ReplayButton.Enabled = true;

                }
            }
            else if ((button1.Text == "X" && button5.Text == "X" && button9.Text == "X") || (button1.Text == "O" && button5.Text == "O" && button9.Text == "O"))
            {
                if (playerlab == "Player 1")
                {
                    PlayerP.Text = "Player 2 Wins";
                    SignLabel.Text = "";
                    button1.Enabled = false; button2.Enabled = false; button3.Enabled = false;
                    button4.Enabled = false; button5.Enabled = false; button6.Enabled = false;
                    button7.Enabled = false; button8.Enabled = false; button9.Enabled = false;
                    ReplayButton.Enabled = true;
                }
                else if (playerlab == "Player 2")
                {
                    PlayerP.Text = "Player 1 Wins";
                    SignLabel.Text = "";
                    button1.Enabled = false; button2.Enabled = false; button3.Enabled = false;
                    button4.Enabled = false; button5.Enabled = false; button6.Enabled = false;
                    button7.Enabled = false; button8.Enabled = false; button9.Enabled = false;
                    ReplayButton.Enabled = true;

                }
            }
            else if ((button3.Text == "X" && button5.Text == "X" && button7.Text == "X") || (button3.Text == "O" && button5.Text == "O" && button7.Text == "O"))
            {
                if (playerlab == "Player 1")
                {
                    PlayerP.Text = "Player 2 Wins";
                    SignLabel.Text = "";
                    button1.Enabled = false; button2.Enabled = false; button3.Enabled = false;
                    button4.Enabled = false; button5.Enabled = false; button6.Enabled = false;
                    button7.Enabled = false; button8.Enabled = false; button9.Enabled = false;
                    ReplayButton.Enabled = true;
                }
                else if (playerlab == "Player 2")
                {
                    PlayerP.Text = "Player 1 Wins";
                    SignLabel.Text = "";
                    button1.Enabled = false; button2.Enabled = false; button3.Enabled = false;
                    button4.Enabled = false; button5.Enabled = false; button6.Enabled = false;
                    button7.Enabled = false; button8.Enabled = false; button9.Enabled = false;
                    ReplayButton.Enabled = true;

                }
            }
            else if ((button3.Text == "X" && button6.Text == "X" && button9.Text == "X") || (button3.Text == "O" && button6.Text == "O" && button9.Text == "O"))
            {
                if (playerlab == "Player 1")
                {
                    PlayerP.Text = "Player 2 Wins";
                    SignLabel.Text = "";
                    button1.Enabled = false; button2.Enabled = false; button3.Enabled = false;
                    button4.Enabled = false; button5.Enabled = false; button6.Enabled = false;
                    button7.Enabled = false; button8.Enabled = false; button9.Enabled = false;
                    ReplayButton.Enabled = true;
                }
                else if (playerlab == "Player 2")
                {
                    PlayerP.Text = "Player 1 Wins";
                    SignLabel.Text = "";
                    button1.Enabled = false; button2.Enabled = false; button3.Enabled = false;
                    button4.Enabled = false; button5.Enabled = false; button6.Enabled = false;
                    button7.Enabled = false; button8.Enabled = false; button9.Enabled = false;
                    ReplayButton.Enabled = true;

                }
            }
            else if ((button2.Text == "X" && button5.Text == "X" && button8.Text == "X") || (button2.Text == "O" && button5.Text == "O" && button8.Text == "O"))
            {
                if (playerlab == "Player 1")
                {
                    PlayerP.Text = "Player 2 Wins";
                    SignLabel.Text = "";
                    button1.Enabled = false; button2.Enabled = false; button3.Enabled = false;
                    button4.Enabled = false; button5.Enabled = false; button6.Enabled = false;
                    button7.Enabled = false; button8.Enabled = false; button9.Enabled = false;
                    ReplayButton.Enabled = true;
                }
                else if (playerlab == "Player 2")
                {
                    PlayerP.Text = "Player 1 Wins";
                    SignLabel.Text = "";
                    button1.Enabled = false; button2.Enabled = false; button3.Enabled = false;
                    button4.Enabled = false; button5.Enabled = false; button6.Enabled = false;
                    button7.Enabled = false; button8.Enabled = false; button9.Enabled = false;
                    ReplayButton.Enabled = true;

                }
            }
            else if ((button4.Text == "X" && button5.Text == "X" && button6.Text == "X") || (button4.Text == "O" && button5.Text == "O" && button6.Text == "O"))
            {
                if (playerlab == "Player 1")
                {
                    PlayerP.Text = "Player 2 Wins";
                    SignLabel.Text = "";
                    button1.Enabled = false; button2.Enabled = false; button3.Enabled = false;
                    button4.Enabled = false; button5.Enabled = false; button6.Enabled = false;
                    button7.Enabled = false; button8.Enabled = false; button9.Enabled = false;
                    ReplayButton.Enabled = true;
                }
                else if (playerlab == "Player 2")
                {
                    PlayerP.Text = "Player 1 Wins";
                    SignLabel.Text = "";
                    button1.Enabled = false; button2.Enabled = false; button3.Enabled = false;
                    button4.Enabled = false; button5.Enabled = false; button6.Enabled = false;
                    button7.Enabled = false; button8.Enabled = false; button9.Enabled = false;
                    ReplayButton.Enabled = true;

                }
            }
            else if ((button7.Text == "X" && button8.Text == "X" && button9.Text == "X") || (button7.Text == "O" && button8.Text == "O" && button9.Text == "O"))
            {
                if (playerlab == "Player 1")
                {
                    PlayerP.Text = "Player 2 Wins";
                    SignLabel.Text = "";
                    button1.Enabled = false; button2.Enabled = false; button3.Enabled = false;
                    button4.Enabled = false; button5.Enabled = false; button6.Enabled = false;
                    button7.Enabled = false; button8.Enabled = false; button9.Enabled = false;
                    ReplayButton.Enabled = true;
                }
                else if (playerlab == "Player 2")
                {
                    PlayerP.Text = "Player 1 Wins";
                    SignLabel.Text = "";
                    button1.Enabled = false; button2.Enabled = false; button3.Enabled = false;
                    button4.Enabled = false; button5.Enabled = false; button6.Enabled = false;
                    button7.Enabled = false; button8.Enabled = false; button9.Enabled = false;
                    ReplayButton.Enabled = true;

                }
            }

        }

        public void reset()
        {
            if (Player1RBX.Checked == true)
            {
                SignLabel.Text = "X";
            }
            else if(Player1RBO.Checked == true)
            {
                SignLabel.Text = "O";
            }
            PlayerP.Text = "Player 1";
            button1.Enabled = true; button2.Enabled = true; button3.Enabled = true;
            button4.Enabled = true; button5.Enabled = true; button6.Enabled = true;
            button7.Enabled = true; button8.Enabled = true; button9.Enabled = true;
            ReplayButton.Enabled = false;

            button1.Text = " "; button2.Text = "  "; button3.Text = "   ";
            button4.Text = "    "; button5.Text = "     "; button6.Text = "      ";
            button7.Text = "       "; button8.Text = "        "; button9.Text = "         ";
            p1 = true;  p2 = false;
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            string buttonText = ((Button)sender).Text;
            string radioText="" ;
            if (buttonText == StartButton.Text)
            {
                if((Player1RBX.Checked==true || Player1RBO.Checked==true) && (Player2RBX.Checked == true || Player2RBO.Checked == true))
                {
                    if(Player2RBX.Checked == true)
                    {
                        radioText = Player2RBX.Text;
                    }
                    else if(Player2RBO.Checked == true)
                    {
                        radioText = Player2RBO.Text;
                    }

                    if((Player1RBX.Checked==true && Player1RBX.Text!= radioText) || (Player1RBO.Checked == true && Player1RBO.Text != radioText))
                    {
                        gamePanel.Visible = true;
                        if (Player1RBX.Checked == true)
                        {
                            p1T = "X";
                            p2T = "O";
                        }
                        else if((Player1RBO.Checked == true))
                        {
                            p1T = "O";
                            p2T = "X";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Select Different sign", "Caution", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Select Player", "Caution", MessageBoxButtons.OK);
                }
            }
            if (Player1RBX.Checked == true)
            {
                SignLabel.Text = "X";
            }
            else if (Player1RBO.Checked == true)
            {
                SignLabel.Text = "O";
            }
            if (buttonText == button1.Text)
            {
                if (p1)
                {
                    button1.Text = p1T;
                    playerlab = "Player 2";
                    PlayerP.Text = playerlab;
                    SignLabel.Text = p2T;
                    button1.Enabled = false;
                    p1 = false;
                    p2 = true;
                }
                else if (p2)
                {
                    button1.Text = p2T;
                    playerlab = "Player 2";
                    PlayerP.Text = playerlab;
                    SignLabel.Text = p1T;
                    button1.Enabled = false;
                    p1 = true;
                    p2 = false;
                }
                win();
            }
            else if (buttonText == button2.Text)
            {
                if (p1)
                {
                    button2.Text = p1T;
                    button2.Enabled = false;
                    playerlab = "Player 2";
                    PlayerP.Text = playerlab;
                    SignLabel.Text = p2T;
                    p1 = false;
                    p2 = true;
                }
                else if (p2)
                {
                    button2.Text = p2T;
                    playerlab = "Player 1";
                    PlayerP.Text = playerlab;
                    SignLabel.Text = p1T;
                    button2.Enabled = false;
                    p1 = true;
                    p2 = false;
                }
                win();
            }
            else if (buttonText == button3.Text)
            {
                if (p1)
                {
                    button3.Text = p1T;
                    playerlab = "Player 2";
                    PlayerP.Text = playerlab;
                    SignLabel.Text = p2T;
                    button3.Enabled = false;
                    p1 = false;
                    p2 = true;
                }
                else if (p2)
                {
                    button3.Text = p2T;
                    playerlab = "Player 1";
                    PlayerP.Text = playerlab;
                    SignLabel.Text = p1T;
                    button3.Enabled = false;
                    p1 = true;
                    p2 = false;
                }
                win();
            }
            else if (buttonText == button4.Text)
            {
                if (p1)
                {
                    button4.Text = p1T;
                    playerlab = "Player 2";
                    PlayerP.Text = playerlab;
                    SignLabel.Text = p2T;
                    button4.Enabled = false;
                    p1 = false;
                    p2 = true;
                }
                else if (p2)
                {
                    button4.Text = p2T;
                    playerlab = "Player 1";
                    PlayerP.Text = playerlab;
                    SignLabel.Text = p1T;
                    button4.Enabled = false;
                    p1 = true;
                    p2 = false;
                }
                win();
            }
            else if (buttonText == button5.Text)
            {
                if (p1)
                {
                    button5.Text = p1T;
                    playerlab = "Player 2";
                    PlayerP.Text = playerlab;
                    SignLabel.Text = p2T;
                    button5.Enabled = false;
                    p1 = false;
                    p2 = true;
                }
                else if (p2)
                {
                    button5.Text = p2T;
                    playerlab = "Player 1";
                    PlayerP.Text = playerlab;
                    SignLabel.Text = p1T;
                    button5.Enabled = false;
                    p1 = true;
                    p2 = false;
                }
                win();
            }
            else if (buttonText == button6.Text)
            {
                if (p1)
                {
                    button6.Text = p1T;
                    playerlab = "Player 2";
                    PlayerP.Text = playerlab;
                    SignLabel.Text = p2T;
                    button6.Enabled = false;
                    p1 = false;
                    p2 = true;
                }
                else if (p2)
                {
                    button6.Text = p2T;
                    playerlab = "Player 1";
                    PlayerP.Text = playerlab;
                    SignLabel.Text = p1T;
                    button6.Enabled = false;
                    p1 = true;
                    p2 = false;
                }
                win();
            }
           else  if (buttonText == button7.Text)
            {
                if (p1)
                {
                    button7.Text = p1T;
                    playerlab = "Player 2";
                    PlayerP.Text = playerlab;
                    SignLabel.Text = p2T;
                    button7.Enabled = false;
                    p1 = false;
                    p2 = true;
                }
                else if (p2)
                {
                    button7.Text = p2T;
                    playerlab = "Player 1";
                    PlayerP.Text = playerlab;
                    SignLabel.Text = p1T;
                    button7.Enabled = false;
                    p1 = true;
                    p2 = false;
                }
                win();
            }
           else if (buttonText == button8.Text)
            {
                if (p1)
                {
                    button8.Text = p1T;
                    playerlab = "Player 2";
                    PlayerP.Text = playerlab;
                    SignLabel.Text = p2T;
                    button8.Enabled = false;
                    p1 = false;
                    p2 = true;
                }
                else if (p2)
                {
                    button8.Text = p2T;
                    playerlab = "Player 1";
                    PlayerP.Text = playerlab;
                    SignLabel.Text = p1T;
                    button8.Enabled = false;
                    p1 = true;
                    p2 = false;
                }
                win();
            }
            else if (buttonText == button9.Text)
            {
                if (p1)
                {
                    button9.Text = p1T;
                    playerlab = "Player 2";
                    PlayerP.Text = playerlab;
                    SignLabel.Text = p2T;
                    button9.Enabled = false;
                    p1 = false;
                    p2 = true;
                }
                else if (p2)
                {
                    button9.Text = p2T;
                    playerlab = "Player 1";
                    PlayerP.Text = playerlab;
                    SignLabel.Text = p1T;
                    button9.Enabled = false;
                    p1 = true;
                    p2 = false;
                }
                win();
            }
            if(button1.Enabled==false && button2.Enabled == false && button3.Enabled == false && button4.Enabled == false && button5.Enabled == false && button6.Enabled == false && button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
            {
                ReplayButton.Enabled = true;
            }
            if (buttonText == ExitButton.Text)
            {
                Application.Exit();
            }
            else if(buttonText==ReplayButton.Text)
            {
                reset();
            }
        }
    }
}
