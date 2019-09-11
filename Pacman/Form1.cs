using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Pacman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen titlePen = new Pen(Color.Brown);
            Font titleFont = new Font("Courier New", 16);
            SolidBrush titleBrush = new SolidBrush(Color.DarkBlue);

            g.DrawString("Player 1 Get Ready", titleFont, titleBrush, 10, 50);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pathPen = new Pen(Color.Blue, 20);
            Font titleFont = new Font("Courier New", 16);
            SolidBrush pacBrush = new SolidBrush(Color.Yellow);

            //frame 1
            g.Clear(Color.Black);
            g.DrawLine(pathPen, 40, 60, 240, 60);
            g.DrawLine(pathPen, 40, 140, 240, 140);
            g.FillPie(pacBrush, 40, 75, 50, 50, 30, 300);

            Thread.Sleep(500);

            //frame 2
            g.Clear(Color.Black);
            g.DrawLine(pathPen, 40, 60, 240, 60);
            g.DrawLine(pathPen, 40, 140, 240, 140);
            g.FillPie(pacBrush, 100, 75, 50, 50, 30, 360);

            Thread.Sleep(500);

            //frame 2
            g.Clear(Color.Black);
            g.DrawLine(pathPen, 40, 60, 240, 60);
            g.DrawLine(pathPen, 40, 140, 240, 140);
            g.FillPie(pacBrush, 160, 75, 50, 50, 30, 300);
        }
    }
}
