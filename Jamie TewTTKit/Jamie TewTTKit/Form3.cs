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
    public partial class StudentSelector : Form
    {
        public StudentSelector()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if(listBox1.Items.Count>0) //More than 0 people in List
            {
                int studentNum = rnd.Next(0, listBox1.Items.Count);
                textBox1.Text = listBox1.Items[studentNum].ToString();
                listBox1.Items.RemoveAt(studentNum);
            }
            else
            {
                MessageBox.Show("List Empty");
            }
        }

        private void StudentSelector_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainMenu form = new MainMenu();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
            textBox1.AppendText(listBox1.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
