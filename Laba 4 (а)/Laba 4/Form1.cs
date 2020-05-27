using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Draw();
        }
        private void Draw()
        {           
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black);
            graph.DrawRectangle(pen, 798, 1, 100, 100);//квадрат   
            SolidBrush solidBrush = new SolidBrush(Color.Red);
            graph.FillEllipse(solidBrush, 1, 260, 100, 100);//коло                
            graph.DrawLine(pen, 1, 100, 100, 100);//трикутник
            graph.DrawLine(pen, 1, 100, 50, 1);
            graph.DrawLine(pen, 50, 1, 100, 100);
            graph.DrawEllipse(pen, 648, 291, 250, 70);//еліпс
            pictureBox1.Image = bmp;
        }
    }
}
