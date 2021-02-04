using System;
using System.Drawing;
using System.Windows.Forms;

namespace Jogo1
{
    public partial class Form1 : Form
    {

        public int top1   = 0;
        public int Width1 = 0;
        public int left1  = 0;
        public int heit1  = 0;

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 50;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Width1 = 865;
            label2.Text = "0";
            label3.Text = "865";
            label4.Text = "52";
            label5.Text = "620";

            label1.Text = DateTime.Now.ToString();

            if (pictureBox1.Left > 0) { pictureBox1.Left = pictureBox1.Left - 1; } else { pictureBox1.Left = Width1; }
            if (pictureBox2.Left > 0) { pictureBox2.Left = pictureBox2.Left - 1; } else { pictureBox2.Left = Width1; }
            if (pictureBox3.Left > 0) { pictureBox3.Left = pictureBox3.Left - 1; } else { pictureBox3.Left = Width1; }
            if (pictureBox4.Left > 0) { pictureBox4.Left = pictureBox4.Left - 1; } else { pictureBox4.Left = Width1; }
            if (pictureBox5.Left > 0) { pictureBox5.Left = pictureBox5.Left - 1; } else { pictureBox5.Left = Width1; }
            if (pictureBox6.Left > 0) { pictureBox6.Left = pictureBox6.Left - 1; } else { pictureBox6.Left = Width1; }
            if (pictureBox7.Left > 0) { pictureBox7.Left = pictureBox7.Left - 1; } else { pictureBox7.Left = Width1; }
            if (pictureBox8.Left > 0) { pictureBox8.Left = pictureBox8.Left - 1; } else { pictureBox8.Left = Width1; }
            if (pictureBox9.Left > 0) { pictureBox9.Left = pictureBox9.Left - 1; } else { pictureBox9.Left = Width1; }
            if (pictureBox10.Left > 0) { pictureBox10.Left = pictureBox10.Left - 1; } else { pictureBox10.Left = Width1; }
            if (pictureBox11.Left > 0) { pictureBox11.Left = pictureBox11.Left - 1; } else { pictureBox11.Left = Width1; }
            if (pictureBox12.Left > 0) { pictureBox12.Left = pictureBox12.Left - 1; } else { pictureBox12.Left = Width1; }
            pictureBox14.Visible = false;


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                pictureBox13.Location = new Point(pictureBox13.Location.X, pictureBox13.Location.Y - 10);
                label6.Text = "Seta para Cima.";
                pictureBox14.Location = new Point(pictureBox14.Location.X + 10, pictureBox14.Location.Y);
            }

            if (e.KeyCode == Keys.Down)
            {
                pictureBox13.Location = new Point(pictureBox13.Location.X, pictureBox13.Location.Y + 10);
                label6.Text = "Seta para Baixo.";
                pictureBox14.Location = new Point(pictureBox14.Location.X + 10, pictureBox14.Location.Y);
            }

            if (e.KeyCode == Keys.Left)
            {
                pictureBox13.Location = new Point(pictureBox13.Location.X - 10, pictureBox13.Location.Y);
                label6.Text = "Seta para Direita.";
                pictureBox14.Location = new Point(pictureBox14.Location.X + 10, pictureBox14.Location.Y);
            }

            if (e.KeyCode == Keys.Right)
            {
                pictureBox13.Location = new Point(pictureBox13.Location.X + 10, pictureBox13.Location.Y);
                label6.Text = "Seta para Esquerda.";
                pictureBox14.Location = new Point(pictureBox14.Location.X + 10, pictureBox14.Location.Y);
            }

            if (e.KeyCode == Keys.Space)
            {
                pictureBox13.Location = new Point(pictureBox13.Location.X + 10, pictureBox13.Location.Y);
                label6.Text = "Torpedos Fotonicos.";
                pictureBox14.Location = new Point(pictureBox14.Location.X + 10, pictureBox14.Location.Y);
            }

            if (e.KeyCode == Keys.Z)
            {
                pictureBox13.Location = new Point(pictureBox13.Location.X - 1, pictureBox13.Location.Y);
                label6.Text = "Tiros de Fazer.";
                pictureBox14.Location = new Point(pictureBox13.Location.X + 240, pictureBox13.Location.Y + 20);
                pictureBox14.Visible = true;
            }
        }
    }

}
