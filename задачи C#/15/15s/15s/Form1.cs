using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
----------- pictureBox
----------- textbox
----------- button

*/
namespace _15s
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private Brush defaultColor = Brushes.Red;
        private Brush[] BrushesArray = { Brushes.Green, Brushes.Blue, Brushes.Yellow };
        private Brush fillColor;
        private int radius;
        private int? x = null;
        private int? y = null;
        private bool isButtonClicked = false;
        public Form1()
        {
            InitializeComponent();
            graphics = pictureBox1.CreateGraphics();
            fillColor = defaultColor;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            graphics.Clear(pictureBox1.BackColor);
            radius = System.Int32.Parse(textBox1.Text);
            x = e.X;
            y = e.Y;
            graphics.FillEllipse(fillColor, x.Value - radius, y.Value - radius, radius * 2, radius * 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isButtonClicked = !isButtonClicked;
            if (isButtonClicked)
            {
                fillColor = BrushesArray[new Random().Next(0, BrushesArray.Length)];
                if (x != null && y != null)
                {
                    graphics.FillEllipse(fillColor, x.Value - radius, y.Value - radius, radius * 2, radius * 2);
                }
            }
            else
            {
                fillColor = defaultColor;
                if (x != null && y != null)
                {
                    graphics.FillEllipse(fillColor, x.Value - radius, y.Value - radius, radius * 2, radius * 2);
                }
            }
        }
    }
    
}
