using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jamie_TewTTKit
{
    public partial class MainMenu : Form
    {
        int ballX = 20;
        int ballY = 10;
        int ballX2 = 10;
        int ballY2 = 20;
        int ballX3 = 20;
        int ballY3 = 20;
        int ballX4 = 10;
        int ballY4 = 10;
        int xv = 1;
        int yv = 1;
        int xv2 = 1;
        int yv2 = 1;
        int xv3 = 1;
        int yv3 = 1;
        int xv4 = 1;
        int yv4 = 1;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch form = new Stopwatch();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentSelector form = new StudentSelector();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DiceRoll form = new DiceRoll();
            form.Show();
            this.Hide();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Countdown form = new Countdown();
            form.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           Interval form = new Interval();
            form.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ballX += xv;
            ballY += yv;
            if (ballX < 0 || ballX + 25 > pictureBox1.Width) { xv *= -1; }
            if (ballY < 0 || ballY + 25 > pictureBox1.Height) { yv *= -1; }
            ballX2 += xv2;
            ballY2 += yv2;
            if (ballX2 < 0 || ballX2 + 25 > pictureBox1.Width) { xv2 *= -1; }
            if (ballY2 < 0 || ballY2 + 25 > pictureBox1.Height) { yv2 *= -1; }
            ballX3 += xv3;
            ballY3 += yv3;
            if (ballX3 < 0 || ballX3 + 25 > pictureBox1.Width) { xv3 *= -1; }
            if (ballY3 < 0 || ballY3 + 25 > pictureBox1.Height) { yv3 *= -1; }
            ballX4 += xv4;
            ballY4 += yv4;
            if (ballX4 < 0 || ballX4 + 25 > pictureBox1.Width) { xv4 *= -1; }
            if (ballY4 < 0 || ballY4 + 25 > pictureBox1.Height) { yv4 *= -1; }
            Refresh();
            // could probably more efficient than this

            label3.Text = DateTime.Now.ToString("HH:mm:ss");
        }

Pen blackPen = new Pen(Color.Black, 1);
Pen orangePen = new Pen(Color.Orange, 1);
Pen tealPen = new Pen(Color.Teal, 1);
Pen bluePen = new Pen(Color.Blue, 1);
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(blackPen, ballX, ballY, 25, 25);
            e.Graphics.DrawEllipse(orangePen, ballX2, ballY2, 25, 25);
            e.Graphics.DrawEllipse(tealPen, ballX3, ballY3, 25, 25);
            e.Graphics.DrawEllipse(bluePen, ballX4, ballY4, 25, 25);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
           Form7 form = new Form7();
           form.Show();
           this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
