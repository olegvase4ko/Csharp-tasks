using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17s
{




    public partial class Form1 : Form
    {
        private Result res;
        public Form1()
        {
            InitializeComponent();
            res = new Result();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a, b, c, d, f;

            a = textBox1.Text;
            b = textBox2.Text;
            c = textBox3.Text;
            d = textBox4.Text;
            f = textBox5.Text;

            listBox1.Items.Clear();
            if (int.TryParse(a, out _) & int.TryParse(b, out _) & int.TryParse(c, out _) & int.TryParse(d, out _) & int.TryParse(f, out _))
            {
                listBox1.Items.Add("Сумма " + res.sum(a, b, c, d, f));
            }
            else
            {
                listBox1.Items.Add("Строка " + res.stroka(a, b, c, d, f));
            }
        }
    }

    public class Result
    {
        public int sum(string a, string b, string c, string d, string e)
        {
            int i;
            i = Convert.ToInt16(a) + Convert.ToInt16(b) + Convert.ToInt16(c) + Convert.ToInt16(d) + Convert.ToInt16(e);

            return i;
        }

        public string stroka(string a, string b, string c, string d, string e)
        {
            string i;
            i = a + " " + b + " " + c + " " + d + " " + e;
            return i;
        }
    }
}
