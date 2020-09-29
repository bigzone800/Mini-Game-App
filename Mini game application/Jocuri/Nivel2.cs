using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Jocuri
{
    public partial class Nivel2 : Form
    {
        public Nivel2()
        {
            //ACEST PROIECT ESTE REALIZAT DE CATRE OLARIU GABRIEL

            InitializeComponent();
            MoveToStart();
        }

        private void label3_MouseEnter(object sender, EventArgs e)//cand atingi peretii
        {
            MoveToStart();
        }
        private void MoveToStart()//pozitia de plecare
        {
            Point startingPoint = panel1.Location;
            startingPoint.Offset(30, 30);
            Cursor.Position = PointToScreen(startingPoint);
        }

        private void label1_MouseEnter(object sender, EventArgs e)//cand ajungi la finish
        {
            SoundPlayer sndPlayer = new SoundPlayer(Properties.Resources.sunet);
            sndPlayer.Play();
            
            MessageBox.Show("Felicitari. Ai terminat jocul");
            this.Hide();
            Meniu Form2 = new Meniu();
            Form2.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)//buton ce te redirectioneaza catre meniu
        {
            this.Hide();
            Meniu Form2 = new Meniu();
            Form2.ShowDialog();
            this.Close();
        }

        private void CreditLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//un link pentru credits
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/olariu.gabriel.98");
        }
    }
}
