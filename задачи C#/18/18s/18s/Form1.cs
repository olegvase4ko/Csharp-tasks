using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18s
{
    public partial class Form1 : Form
    {
        private chislo a;
        public Form1()
        {
            InitializeComponent();
            a = new chislo();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            a.pi = (decimal)Math.PI;
            listBox1.Items.Add("Число пи равно = " + a.pi);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
    public class chislo
    {
        public decimal pi { get; set; }

    }
}
