using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _20s
{
    public partial class Form1 : Form
    {
        int[] arr = new int[10];
        Random rnd;
        public Form1()
        {
            InitializeComponent();
            rnd = new Random();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                arr[i] = rnd.Next(0, 100);
                listBox1.Items.Add(arr[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            string s = d.ToString("dd/MM/yyyy") + "_" + d.ToString("HH/mm") + ".txt";
            using (StreamWriter sw = new StreamWriter(s, true))
            {
                for (int i = 0; i < 10; i++)
                {

                    sw.WriteLine(arr[i]);
                }
            }
        }
    }
}
