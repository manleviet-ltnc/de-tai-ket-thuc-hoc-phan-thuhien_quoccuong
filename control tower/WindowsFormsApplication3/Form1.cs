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
        Boolean up = false, down = false;
        Airplane airplane = new Airplane();
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
                bt1.Image = Image.FromFile("D\\maybay.jpg"); 
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
            Graphics g = this.CreateGraphics();
            foreach (Point p in path)
                g.Dispose();
                
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            beginDraw = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            beginDraw = false;
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up && down == false)
            {
                up = true;
                down = false;
            }

            if (e.KeyData == Keys.Down && up == false)
            {
                down = true;
                up = false;
            }
        }
    }
}