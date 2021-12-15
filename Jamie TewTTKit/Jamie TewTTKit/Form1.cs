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
        int xv = 1;
        int yv = 1;

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
            if (ballX < 0 || ballX + 30 > pictureBox1.Width) { xv *= -1; }
            if (ballY < 0 || ballY + 30 > pictureBox1.Height) { yv *= -1; }
            Refresh();
            // could probably more efficient than this

            label3.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Image img = Image.FromFile(@"\\sutcfps2.sutc.internal\studentpersonal$\18tewj\Documents\Y10\IT\Images\UTC Logo.JPG");
            e.Graphics.DrawImage(img, new Rectangle(ballX, ballY, 30, 30));
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
