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
    public partial class Nivel1 : Form
    {
        public Nivel1()
        {
            //ACEST PROIECT ESTE REALIZAT DE CATRE OLARIU GABRIEL

            InitializeComponent();
            MoveToStart();
            timer1.Start();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Felicitari. Pregateste-te pentru nivelul urmator.");
            this.Hide();
            Nivel2 Form2 = new Nivel2();
            Form2.ShowDialog();
            this.Close();
        }

        private void label8_MouseEnter(object sender, EventArgs e)//cand atingi peretii
        {
            MoveToStart();
        }
        private void MoveToStart()//pozitia de plecare
        {
            Point startingPoint = panel1.Location;
            startingPoint.Offset(30, 30);
            Cursor.Position = PointToScreen(startingPoint);
        }

        private void timer1_Tick(object sender, EventArgs e)//labelul ce se misca
        {
            label7.Location = new Point(label7.Location.X + 10, label7.Location.Y);

            if (label7.Location.X > this.Width)
            {
                label7.Location = new Point(0 - label7.Width, label7.Location.Y);
            }
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
