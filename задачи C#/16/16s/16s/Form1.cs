using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16s
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);
            var prism = new Prism(a, b, c);
            textBox4.Text = prism.CalcualteArea().ToString();
        }
       
    }
    public class Prism
    {
        public int SideA { get; set; }
        public int SideB { get; set; }
        public int SideC { get; set; }

        public Prism(int a, int b, int c)
        {
            SideA = a;
            SideB = b;
            SideC = c;
        }

        public int CalcualteArea()
        {
            return 2 * (SideA * SideC + SideB * SideC + SideA * SideB);
        }
    }
}
