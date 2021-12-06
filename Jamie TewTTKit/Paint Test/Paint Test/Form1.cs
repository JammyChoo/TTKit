using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_Test
{
    
    public partial class Form1 : Form
    {
        int ballX = 100;
        int ballY = 100;
        int xv = 5;
        int yv = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen orangePen = new Pen(Color.DarkOrange, 2);
            Pen cyanPen = new Pen(Color.Cyan, 33);
            Pen pinkPen = new Pen(Color.Pink, 33);
            SolidBrush yellowbrush = new SolidBrush(Color.Yellow);
            SolidBrush purplebrush = new SolidBrush(Color.Purple);

            
            e.Graphics.DrawRectangle(cyanPen, 20, 20, 100, 100);
            e.Graphics.DrawRectangle(pinkPen, 40, 40, 90, 90);
            e.Graphics.FillRectangle(purplebrush, 57, 57, 57, 57);
            e.Graphics.FillRectangle(yellowbrush, 57, 57, 35, 35);
            e.Graphics.DrawEllipse(orangePen, ballX, ballY, 25, 25);

            Image img = Image.FromFile(@"\\sutcfps2.sutc.internal\studentpersonal$\18tewj\Documents\Y10\IT\Images\Ruby Prince Sprout.JPG");

            e.Graphics.DrawImage(img, new Rectangle(200, 200, 200, 200), new Rectangle(300, 0, 770, 1000), GraphicsUnit.Pixel);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ballX += xv;
            ballY += yv;
            if (ballX < 0 || ballX + 25 > pictureBox1.Width) { xv *= -1; }
            if (ballY < 0 || ballY + 25 > pictureBox1.Height) { yv *= -1; }
            Refresh();
        }
    }
}
