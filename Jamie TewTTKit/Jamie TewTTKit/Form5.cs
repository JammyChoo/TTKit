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
    public partial class Countdown : Form
    {
        float countDown = 50;
        public Countdown()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainMenu form = new MainMenu();
            form.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countDown -= timer1.Interval * 0.001f;
            textBox1.Text = countDown.ToString("0.00");
            if (countDown < 0)
            {
                timer1.Enabled = false;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            button1.Show();
            button3.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            countDown = float.Parse(textBox1.Text);
            timer1.Enabled = true;
            button3.Show();
            button1.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
