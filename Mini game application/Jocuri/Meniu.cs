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
    public partial class Meniu : Form
    {
        public Meniu()
        {
            //ACEST PROIECT ESTE REALIZAT DE CATRE OLARIU GABRIEL

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//buton ce te redirectioneaza catre maze
        {
            this.Hide();
            Nivel1 Form2 = new Nivel1();
            Form2.ShowDialog();
            this.Close();
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            pictureBox1.Show();
        }

        private void Meniu_Load(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            pictureBox2.Hide();
        }

        private void button2_Click(object sender, EventArgs e)//buton ce te redirectioneaza catre X%O
        {
            this.Hide();
            Xsi0 Form2 = new Xsi0();
            Form2.ShowDialog();
            this.Close();
        }

        private void Meniu_Enter(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            pictureBox2.Hide();
        }

        private void button2_Enter(object sender, EventArgs e)
        {
            pictureBox2.Show();
        }

        private void label1_Enter(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            pictureBox2.Hide();
        }

        private void CreditLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//un link pentru credits
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/olariu.gabriel.98");
        }
    }
}
