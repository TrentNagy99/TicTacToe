using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool turn = true;
        public bool isWinner = false;
        public int OWins = 0;
        public int XWins = 0;

        private void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if(button.Text == "" && !isWinner)
            {
                if (turn)
                {
                    button.Text = "X";
                    turn = !turn;
                    CheckWin();
                }
                else
                {
                    button.Text = "O";
                    turn = !turn;
                    CheckWin();
                }
            }
            else
            {
                MessageBox.Show("The game is over.");
            }
        }

        private void CheckWin()
        {
            //Horizontal checking.
            if ((btnTL.Text == btnTM.Text && btnTM.Text == btnTR.Text) && btnTL.Text != "")
                isWinner = true;
            if ((btnCL.Text == btnCM.Text && btnCM.Text == btnCR.Text) && btnCL.Text != "")
                isWinner = true;
            if ((btnBL.Text == btnBM.Text && btnBM.Text == btnBR.Text) && btnBL.Text != "")
                isWinner = true;

            //Vertical checking
            if ((btnTL.Text == btnCL.Text && btnCL.Text == btnBL.Text) && btnTL.Text != "")
                isWinner = true;
            if ((btnTM.Text == btnCM.Text && btnCM.Text == btnBM.Text) && btnTM.Text != "")
                isWinner = true;
            if ((btnTR.Text == btnCR.Text && btnCR.Text == btnBR.Text) && btnTR.Text != "")
                isWinner = true;
            
            //Diagonal checking
            if ((btnTL.Text == btnCM.Text && btnCM.Text == btnBR.Text) && btnTL.Text != "")
                isWinner = true;
            if ((btnTR.Text == btnCM.Text && btnCM.Text == btnBL.Text) && btnTR.Text != "")
                isWinner = true;

            if (isWinner)
            {
                if (turn)
                {
                    MessageBox.Show("O wins.");
                    OWins++;
                    lblOWins.Text = OWins.ToString();
                }
                else
                {
                    MessageBox.Show("X wins.");
                    XWins++;
                    lblXWins.Text = XWins.ToString();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            OWins = 0;
            XWins = 0;
            lblOWins.Text = OWins.ToString();
            lblXWins.Text = XWins.ToString();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            foreach(Button b in gameBoard.Controls)
            {
                Button button = b;
                b.Text = "";
                isWinner = false;
                turn = true;
            }
        }
    }
}
