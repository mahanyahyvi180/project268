using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp150
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Point[] p = new Point[] { new Point(100, 100), new Point(200, 100), new Point(250, 200), new Point(200, 300), new Point(100, 300), new Point(50, 200) };
            Graphics g = this.CreateGraphics();
            //Pen pe = new Pen(Color.Pink, 5);
            //SolidBrush mybrush = new SolidBrush(Color.Pink);
            System.Drawing.Drawing2D.HatchBrush mybrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.Cross, Color.LimeGreen);
            g.FillPolygon(mybrush, p);
        }
    }
}
