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

/// <summary>
/// Created by Mr. T.
/// September 2019
/// Demonstration of basic animation and sounds
/// </summary>

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
            SolidBrush pacBrush = new SolidBrush(Color.Yellow);

            SoundPlayer beginSound = new SoundPlayer(Properties.Resources.begin);
            SoundPlayer chompSound = new SoundPlayer(Properties.Resources.chomp);

            //frame 1
            g.Clear(Color.Black);
            beginSound.Play();
            Thread.Sleep(5000);
            chompSound.Play();
            g.DrawLine(pathPen, 40, 60, 240, 60);
            g.DrawLine(pathPen, 40, 140, 240, 140);
            g.FillPie(pacBrush, 40, 75, 50, 50, 30, 300);

            Thread.Sleep(500);

            //frame 2
            g.Clear(Color.Black);
            chompSound.Play();
            g.DrawLine(pathPen, 40, 60, 240, 60);
            g.DrawLine(pathPen, 40, 140, 240, 140);
            g.FillPie(pacBrush, 100, 75, 50, 50, 30, 360);

            Thread.Sleep(500);

            //frame 2
            g.Clear(Color.Black);
            chompSound.Play();
            g.DrawLine(pathPen, 40, 60, 240, 60);
            g.DrawLine(pathPen, 40, 140, 240, 140);
            g.FillPie(pacBrush, 160, 75, 50, 50, 30, 300);
        }
    }
}
