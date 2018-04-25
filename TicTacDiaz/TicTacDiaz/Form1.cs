using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacDiaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClearAllGameComponents();
        }

        private void ClearAllGameComponents()
        {
            Control.ControlCollection coll = Controls;
            foreach (Control c in coll)
            {
                if ((c != null) && (c is Button))
                {
                    if ((c.Name != "btnNew") && (c.Name != "btnExit"))
                    {
                        c.Text = "";
                        c.BackColor = SystemColors.Control;
                        c.Enabled = true;
                    }
                    winLineCol1.Visible = false;
                    winLineCol2.Visible = false;
                    winLineCol3.Visible = false;
                    winLineRow1.Visible = false;
                    winLineRow2.Visible = false;
                    winLineRow3.Visible = false;
                    winLineDiagLTR.Visible = false;
                    winLineDiagRTL.Visible = false;
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearAllGameComponents();
        }

        private void NewGame()
        {
            ClearAllGameComponents();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearAllGameComponents();
        }

        private void DisableButtons()
        {
            Control.ControlCollection coll = Controls;
            foreach (Control c in coll)
            {
                if (c is Button)

                    if ((c.Name != "btnNew") && (c.Name != "btnExit"))
                    {
                        c.Enabled = false;
                    }
            }
        }

        private void ComputersTurn()
        {
            Control.ControlCollection coll = Controls;
            foreach (Control c in coll)
            {
                if ((c != null) && (c is Button))
                {
                    if ((c.Name != "btnNew") && (c.Name != "btnExit"))
                    {
                        if (c.Enabled == true)
                        {
                            #region(OFFENSE)

                            if (((btn1.Text == "O") && (btn4.Text == "O") && (btn7.Enabled)))
                            {
                                btn7.Text = "O";
                                btn7.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }

                            else if (((btn1.Text == "O") && (btn7.Text == "O") && (btn4.Enabled)))
                            {
                                btn4.Text = "O";
                                btn4.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }
                            else if (((btn7.Text == "O") && (btn4.Text == "O") && (btn1.Enabled)))
                            {
                                btn1.Text = "O";
                                btn1.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }
                            //column 2 defense
                            else if (((btn2.Text == "O") && (btn5.Text == "O") && (btn8.Enabled)))
                            {
                                btn8.Text = "O";
                                btn8.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }
                            else if (((btn8.Text == "O") && (btn2.Text == "O") && (btn5.Enabled)))
                            {
                                btn5.Text = "O";
                                btn5.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }
                            else if (((btn8.Text == "O") && (btn5.Text == "O") && (btn2.Enabled)))
                            {
                                btn4.Text = "O";
                                btn4.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }
                            //Column 3 defense
                            else if (((btn9.Text == "O") && (btn6.Text == "O") && (btn3.Enabled)))
                            {
                                btn3.Text = "O";
                                btn3.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }
                            else if (((btn9.Text == "O") && (btn3.Text == "O") && (btn6.Enabled)))
                            {
                                btn6.Text = "O";
                                btn6.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }
                            else if (((btn6.Text == "O") && (btn3.Text == "O") && (btn9.Enabled)))
                            {
                                btn9.Text = "O";
                                btn9.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }
                            #region(Diaganol Defense)
                            //LTR Diaganol
                            else if (((btn9.Text == "O") && (btn5.Text == "O") && (btn1.Enabled)))
                            {
                                btn1.Text = "O";
                                btn1.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }
                            else if (((btn9.Text == "O") && (btn1.Text == "O") && (btn5.Enabled)))
                            {
                                btn5.Text = "O";
                                btn5.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }
                            else if (((btn5.Text == "O") && (btn1.Text == "O") && (btn9.Enabled)))
                            {
                                btn9.Text = "O";
                                btn9.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }

                            else if (((btn3.Text == "O") && (btn5.Text == "O") && (btn7.Enabled)))
                            {
                                btn7.Text = "O";
                                btn7.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }
                            else if (((btn3.Text == "O") && (btn7.Text == "O") && (btn5.Enabled)))
                            {
                                btn5.Text = "O";
                                btn5.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }
                            else if (((btn5.Text == "O") && (btn7.Text == "O") && (btn3.Enabled)))
                            {
                                btn3.Text = "O";
                                btn3.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }

                            #endregion

                            //row one defense
                            else if (((btn1.Text == "O") && (btn2.Text == "O") && (btn3.Enabled)))
                            {
                                btn3.Text = "O";
                                btn3.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }
                            else if (((btn3.Text == "O") && (btn2.Text == "O") && (btn1.Enabled)))
                            {
                                btn1.Text = "O";
                                btn1.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }
                            else if (((btn3.Text == "O") && (btn1.Text == "O") && (btn2.Enabled)))
                            {
                                btn2.Text = "O";
                                btn2.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }
                            //row 2 defense
                            else if (((btn4.Text == "O") && (btn5.Text == "O") && (btn6.Enabled)))
                            {
                                btn6.Text = "O";
                                btn6.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }
                            else if (((btn4.Text == "O") && (btn6.Text == "O") && (btn5.Enabled)))
                            {
                                btn5.Text = "O";
                                btn5.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }
                            else if (((btn6.Text == "O") && (btn5.Text == "O") && (btn4.Enabled)))
                            {
                                btn4.Text = "O";
                                btn4.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }
                            //row 3 defense
                            else if (((btn7.Text == "O") && (btn8.Text == "O") && (btn9.Enabled)))
                            {
                                btn9.Text = "O";
                                btn9.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }
                            else if (((btn9.Text == "O") && (btn8.Text == "O") && (btn7.Enabled)))
                            {
                                btn7.Text = "O";
                                btn7.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }

                            else if (((btn7.Text == "O") && (btn9.Text == "O") && (btn8.Enabled)))
                            {
                                btn7.Text = "O";
                                btn7.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }
                               
                           

                            #endregion
                            #region(column defense)

                            //column one defense
                            else if (((btn1.Text == "X") && (btn4.Text == "X") && (btn7.Enabled)))
                            {
                                btn7.Text = "O";
                                btn7.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }

                            else if (((btn1.Text == "X") && (btn7.Text == "X") && (btn4.Enabled)))
                            {
                                btn4.Text = "O";
                                btn4.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }
                            else if (((btn7.Text == "X") && (btn4.Text == "X") && (btn1.Enabled)))
                            {
                                btn1.Text = "O";
                                btn1.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }
                                //column 2 defense
                            else if (((btn2.Text == "X") && (btn5.Text == "X") && (btn8.Enabled)))
                            {
                                btn8.Text = "O";
                                btn8.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }
                            else if (((btn8.Text == "X") && (btn2.Text == "X") && (btn5.Enabled)))
                            {
                                btn5.Text = "O";
                                btn5.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }
                            else if (((btn8.Text == "X") && (btn5.Text == "X") && (btn2.Enabled)))
                            {
                                btn4.Text = "O";
                                btn4.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }
                                //Column 3 defense
                            else if (((btn9.Text == "X") && (btn6.Text == "X") && (btn3.Enabled)))
                            {
                                btn3.Text = "O";
                                btn3.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }
                            else if (((btn9.Text == "X") && (btn3.Text == "X") && (btn6.Enabled)))
                            {
                                btn6.Text = "O";
                                btn6.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }
                            else if (((btn6.Text == "X") && (btn3.Text == "X") && (btn9.Enabled)))
                            {
                                btn9.Text = "O";
                                btn9.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }
                                #endregion(Column Defense)
                             #region(Diaganol Defense)
                                //LTR Diaganol
                            else if (((btn9.Text == "X") && (btn5.Text == "X") && (btn1.Enabled)))
                            {
                                btn1.Text = "O";
                                btn1.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }
                            else if (((btn9.Text == "X") && (btn1.Text == "X") && (btn5.Enabled)))
                            {
                                btn5.Text = "O";
                                btn5.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }
                            else if (((btn5.Text == "X") && (btn1.Text == "X") && (btn9.Enabled)))
                            {
                                btn9.Text = "O";
                                btn9.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }

                            else if (((btn3.Text == "X") && (btn5.Text == "X") && (btn7.Enabled)))
                            {
                                btn7.Text = "O";
                                btn7.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }
                            else if (((btn3.Text == "X") && (btn7.Text == "X") && (btn5.Enabled)))
                            {
                                btn5.Text = "O";
                                btn5.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }
                            else if (((btn5.Text == "X") && (btn7.Text == "X") && (btn3.Enabled)))
                            {
                                btn3.Text = "O";
                                btn3.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }
                            

                            #endregion

                            #region(row defense)

                            //row one defense
                            else if (((btn1.Text == "X") && (btn2.Text == "X") && (btn3.Enabled)))
                            {
                                btn3.Text = "O";
                                btn3.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }
                            else if (((btn3.Text == "X") && (btn2.Text == "X") && (btn1.Enabled)))
                            {
                                btn1.Text = "O";
                                btn1.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }
                            else if (((btn3.Text == "X") && (btn1.Text == "X") && (btn2.Enabled)))
                            {
                                btn2.Text = "O";
                                btn2.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }
                                //row 2 defense
                            else if (((btn4.Text == "X") && (btn5.Text == "X") && (btn6.Enabled)))
                            {
                                btn6.Text = "O";
                                btn6.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }
                            else if (((btn4.Text == "X") && (btn6.Text == "X") && (btn5.Enabled)))
                            {
                                btn5.Text = "O";
                                btn5.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }
                            else if (((btn6.Text == "X") && (btn5.Text == "X") && (btn4.Enabled)))
                            {
                                btn4.Text = "O";
                                btn4.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }
                                //row 3 defense
                            else if (((btn7.Text == "X") && (btn8.Text == "X") && (btn9.Enabled)))
                            {
                                btn9.Text = "O";
                                btn9.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }
                            else if (((btn9.Text == "X") && (btn8.Text == "X") && (btn7.Enabled)))
                            {
                                btn7.Text = "O";
                                btn7.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }

                            else if (((btn7.Text == "X") && (btn9.Text == "X") && (btn8.Enabled)))
                            {
                                btn7.Text = "O";
                                btn7.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }

                            else
                            {
                                c.Text = "O";
                                c.Enabled = false;
                                CheckComputerWinner();
                                return;
                            }

                            #endregion

                        }
         


                    }
                }
            }
        }



        private void CheckComputerWinner()
        {
            if ((btn1.Text == "O") && (btn2.Text == "O") && (btn3.Text == "O"))
            {
                btn1.BackColor = Color.IndianRed;
                btn2.BackColor = Color.IndianRed;
                btn3.BackColor = Color.IndianRed;
                btn1.SendToBack();
                btn2.SendToBack();
                btn3.SendToBack();
                winLineRow1.Visible = true;
                MessageBox.Show("COMPUTER WINS. YOU LOSE.");
                DisableButtons();
                return;
            }


            else if ((btn4.Text == "O") && (btn5.Text == "O") && (btn6.Text == "O"))
            {
                btn4.BackColor = Color.IndianRed;
                btn5.BackColor = Color.IndianRed;
                btn6.BackColor = Color.IndianRed;
                btn4.SendToBack();
                btn5.SendToBack();
                btn6.SendToBack();
                winLineRow2.Visible = true;
                MessageBox.Show("COMPUTER WINS. YOU LOSE.");
                DisableButtons();
                return;
            }

            else if ((btn7.Text == "O") && (btn8.Text == "O") && (btn9.Text == "O"))
            {
                btn7.BackColor = Color.IndianRed;
                btn8.BackColor = Color.IndianRed;
                btn9.BackColor = Color.IndianRed;
                btn7.SendToBack();
                btn8.SendToBack();
                btn9.SendToBack();
                winLineRow3.Visible = true;
                MessageBox.Show("COMPUTER WINS. YOU LOSE.");
                DisableButtons();
                return;
            }

            else if ((btn1.Text == "O") && (btn5.Text == "O") && (btn9.Text == "O"))
            {
                btn1.BackColor = Color.IndianRed;
                btn5.BackColor = Color.IndianRed;
                btn9.BackColor = Color.IndianRed;
                btn1.SendToBack();
                btn5.SendToBack();
                btn9.SendToBack();
                winLineDiagLTR.Visible = true;
                MessageBox.Show("COMPUTER WINS. YOU LOSE.");
                DisableButtons();
                return;
            }

            else if ((btn3.Text == "O") && (btn5.Text == "O") && (btn7.Text == "O"))
            {
                btn3.BackColor = Color.IndianRed;
                btn5.BackColor = Color.IndianRed;
                btn7.BackColor = Color.IndianRed;
                btn3.SendToBack();
                btn5.SendToBack();
                btn7.SendToBack();
                winLineDiagRTL.Visible = true;
                MessageBox.Show("COMPUTER WINS. YOU LOSE.");
                DisableButtons();
                return;
            }


            else if ((btn1.Text == "O") && (btn4.Text == "O") && (btn7.Text == "O"))
            {
                btn1.BackColor = Color.IndianRed;

                btn4.BackColor = Color.IndianRed;
                btn7.BackColor = Color.IndianRed;
                btn1.SendToBack();
                btn4.SendToBack();
                btn7.SendToBack();
                winLineCol1.Visible = true;
                MessageBox.Show("COMPUTER WINS. YOU LOSE.");
                DisableButtons();
                return;
            }

            else if ((btn2.Text == "O") && (btn5.Text == "O") && (btn8.Text == "O"))
            {
                btn2.BackColor = Color.IndianRed;

                btn5.BackColor = Color.IndianRed;
                btn8.BackColor = Color.IndianRed;
                btn2.SendToBack();
                btn5.SendToBack();
                btn8.SendToBack();
                winLineCol2.Visible = true;
                MessageBox.Show("COMPUTER WINS. YOU LOSE.");
                DisableButtons();
                return;
            }
               else if ((btn3.Text == "O") && (btn6.Text == "O") && (btn9.Text == "O"))
               {
                btn3.BackColor = Color.IndianRed;
                btn6.BackColor = Color.IndianRed;
                btn9.BackColor = Color.IndianRed;
                btn3.SendToBack();
                btn6.SendToBack();
                btn9.SendToBack();
                winLineCol3.Visible = true;
                MessageBox.Show("COMPUTER WINS. YOU LOSE.");
                DisableButtons();
                return;
                }


        }



        private void CheckWinner()
        {
            if ((btn1.Text == "X") && (btn2.Text == "X") && (btn3.Text == "X"))

            {
                btn1.BackColor = Color.IndianRed;
                btn2.BackColor = Color.IndianRed;
                btn3.BackColor = Color.IndianRed;
                btn1.SendToBack();
                btn2.SendToBack();
                btn3.SendToBack();
                winLineRow1.Visible = true;
                MessageBox.Show("YOU WIN!");
                DisableButtons();
            }
               


            else if ((btn4.Text == "X") && (btn5.Text == "X") && (btn6.Text == "X"))
            {
                btn4.BackColor = Color.IndianRed;
                btn5.BackColor = Color.IndianRed;
                btn6.BackColor = Color.IndianRed;
                btn4.SendToBack();
                btn5.SendToBack();
                btn6.SendToBack();
                winLineRow2.Visible = true;
                MessageBox.Show("YOU WIN!");
                DisableButtons();
            }

            else if ((btn7.Text == "X") && (btn8.Text == "X") && (btn9.Text == "X"))
            {
                btn7.BackColor = Color.IndianRed;
                btn8.BackColor = Color.IndianRed;
                btn9.BackColor = Color.IndianRed;
                btn7.SendToBack();
                btn8.SendToBack();
                btn9.SendToBack();
                winLineRow3.Visible = true;
                MessageBox.Show("YOU WIN!");
                DisableButtons();
            }

            else if ((btn1.Text == "X") && (btn5.Text == "X") && (btn9.Text == "X"))
            {
                btn1.BackColor = Color.IndianRed;
                btn5.BackColor = Color.IndianRed;
                btn9.BackColor = Color.IndianRed;
                btn1.SendToBack();
                btn5.SendToBack();
                btn9.SendToBack();
                winLineDiagLTR.Visible = true;
                MessageBox.Show("YOU WIN!");
                DisableButtons();
            }

            else if ((btn3.Text == "X") && (btn5.Text == "X") && (btn7.Text == "X"))
            {
                btn3.BackColor = Color.IndianRed;
                btn5.BackColor = Color.IndianRed;
                btn7.BackColor = Color.IndianRed;
                btn3.SendToBack();
                btn5.SendToBack();
                btn7.SendToBack();
                winLineDiagRTL.Visible = true;
                MessageBox.Show("YOU WIN!");
                DisableButtons();
            }


            else if ((btn1.Text == "X") && (btn4.Text == "X") && (btn7.Text == "X"))
            {
                btn1.BackColor = Color.IndianRed;

                btn4.BackColor = Color.IndianRed;
                btn7.BackColor = Color.IndianRed;
                btn1.SendToBack();
                btn4.SendToBack();
                btn7.SendToBack();
                winLineCol1.Visible = true;
                MessageBox.Show("YOU WIN!");
                DisableButtons();
            }

            else if ((btn2.Text == "X") && (btn5.Text == "X") && (btn8.Text == "X"))
            {
                btn2.BackColor = Color.IndianRed;

                btn5.BackColor = Color.IndianRed;
                btn8.BackColor = Color.IndianRed;
                btn2.SendToBack();
                btn5.SendToBack();
                btn8.SendToBack();
                winLineCol2.Visible = true;
                MessageBox.Show("YOU WIN!");
                DisableButtons();
            }
            else if ((btn3.Text == "X") && (btn6.Text == "X") && (btn9.Text == "X"))
            {
                btn3.BackColor = Color.IndianRed;

                btn6.BackColor = Color.IndianRed;
                btn9.BackColor = Color.IndianRed;
                btn3.SendToBack();
                btn6.SendToBack();
                btn9.SendToBack();
                winLineCol3.Visible = true;
                MessageBox.Show("YOU WIN!");
                DisableButtons();
            }
            ComputersTurn();
        }

       

        private void btn1_Click(object sender, EventArgs e)
        {
            btn1.Text = "X";
            btn1.Enabled = false;
            CheckWinner();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btn2.Text = "X";
            btn2.Enabled = false;
            CheckWinner();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btn3.Text = "X";
            btn3.Enabled = false;
            CheckWinner();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            btn4.Text = "X";
            btn4.Enabled = false;
            CheckWinner();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            btn5.Text = "X";
            btn5.Enabled = false;
            CheckWinner();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            btn6.Text = "X";
            btn6.Enabled = false;
            CheckWinner();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            btn9.Text = "X";
            btn9.Enabled = false;
            CheckWinner();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            btn8.Text = "X";
            btn8.Enabled = false;
            CheckWinner();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            btn7.Text = "X";
            btn7.Enabled = false;
            CheckWinner();
        }
    }
}