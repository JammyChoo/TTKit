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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainMenu form = new MainMenu();
            form.Show();
            this.Hide();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            ///Random = rnd new Random();
            for (int i = 0; i < 10; i++)
            {
                ///classList[i] = i;
                ///textBox1.AppendText(classList[i].ToString() + "\r\n");
            }
            for (int i = 0; i < 10; i++)
            {
                ///int rnum = rnd.Next(0, 10);
                ///int temp = classList[i];
                ///classList[i] = classList[rnum];
                ///classList[rnum] = temp;
            }
            for (int i = 0; i < 10; i++)
            {
                ///textBox1.AppendText(classList[i].ToString() + "\r\n");

            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
