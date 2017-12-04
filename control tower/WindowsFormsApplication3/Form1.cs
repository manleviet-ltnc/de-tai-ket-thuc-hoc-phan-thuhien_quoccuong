using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        List<Point> path = new List<Point>();
        bool beginDraw = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                bt1.Image = Image.FromFile("D\\maybay.jpg");
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (beginDraw)
            {
                path.Add(e.Location);
            }
            DrawPath();
        }

        private void DrawPath()
        {
            Graphics g = new Graphics(this);
            foreach (Point p in path)
                g.DrawRectangle(
                
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            beginDraw = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            beginDraw = false;
        }
    }
}