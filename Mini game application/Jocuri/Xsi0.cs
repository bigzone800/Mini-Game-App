using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jocuri
{
    public partial class Xsi0 : Form
    {
        public Xsi0()
        {
            //ACEST PROIECT ESTE REALIZAT DE CATRE OLARIU GABRIEL

            InitializeComponent();
        }
        public int player = 2; //par = Tura lui X; impar = Tura lui O
        public int turns = 0; //numara turele
        public int s1 = 0;
        public int s2 = 0;
        public int sd = 0;//numara meciurile castigate

        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "")
            {

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

                if (CheckDraw() == true)
                {
                    MessageBox.Show("Remiza!!");
                    sd++;
                    NewGame();
                }

                if (CheckWinner() == true)
                {
                    if (button.Text == "X")
                    {
                        MessageBox.Show("X A castigat!!");
                        s1++;
                        NewGame();
                        player = 2;

                    }
                    else
                    {
                        MessageBox.Show("O A castigat!!");
                        s2++;
                        NewGame();
                        player = 1;
                    }

                }
            }
        }

        private void EButton_Click(object sender, EventArgs e)//buton de iesire ce te redirectioneaza catre meniu
        {
            this.Hide();
            Meniu Form2 = new Meniu();
            Form2.ShowDialog();
            this.Close();
        }

        private void Xsi0_Load(object sender, EventArgs e)
        {
            XWins.Text = "X: " + s1;
            OWins.Text = "O: " + s2;
            Remiza.Text = "Remize: " + sd;
        }
        void NewGame()
        {
            if (player % 2 == 0)//in mod normal daca variabila player e para ar trebui sa inceapa X-ul, dar incepe O-ul si nu stiu de ce...
            {    MessageBox.Show("O incepe");
                player++;
            }
            else
            {
                MessageBox.Show("X incepe");
                player++;
            }
            turns = 0;
            A00.Text = A01.Text = A02.Text = A10.Text = A11.Text = A12.Text = A20.Text = A21.Text = A22.Text = "";
            XWins.Text = "X: " + s1;
            OWins.Text = "O: " + s2;
            Remiza.Text = "Remize: " + sd;
        }

        private void NGButton_Click(object sender, EventArgs e)//incepe joc nou
        {
            NewGame();
        }
        bool CheckDraw()
        {
            if ((turns == 9) && CheckWinner() == false)
                return true;
            else
                return false;
        }
        bool CheckWinner()
        {
            //verifica pe orizontala
            if ((A00.Text == A01.Text) && (A01.Text == A02.Text) && A00.Text != "")
                return true;
            else if ((A10.Text == A11.Text) && (A11.Text == A12.Text) && A10.Text != "")
                return true;
            else if ((A20.Text == A21.Text) && (A21.Text == A22.Text) && A20.Text != "")
                return true;


            //verifica pe verticala
            if ((A00.Text == A10.Text) && (A10.Text == A20.Text) && A00.Text != "")
                return true;
            else if ((A01.Text == A11.Text) && (A11.Text == A21.Text) && A01.Text != "")
                return true;
            else if ((A02.Text == A12.Text) && (A12.Text == A22.Text) && A02.Text != "")
                return true;

            //verifica pe diagonala
            if ((A00.Text == A11.Text) && (A11.Text == A22.Text) && A00.Text != "")
                return true;
            else if ((A02.Text == A11.Text) && (A11.Text == A20.Text) && A02.Text != "")
                return true;
            else
                return false;

        }

        private void RButton_Click(object sender, EventArgs e)//buton ce reseteaza progresul jocului
        {
            s1 = s2 = sd = 0;
            NewGame();
        }

        private void CreditLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//un link pentru credits
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/olariu.gabriel.98");

        }
    }
}
