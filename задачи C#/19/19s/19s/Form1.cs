﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19s
{
    public partial class Form1 : Form
    {
        private Person str;
        public Form1()
        {
            InitializeComponent();
            str = new Person();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            str.Name = Convert.ToString(textBox1.Text);
            str.Age = Convert.ToInt32(textBox2.Text);
            str.Rost = Convert.ToSingle(textBox3.Text);
            str.Wes = Convert.ToSingle(textBox4.Text);

            Random rnd = new Random();
            str.Id = rnd.Next(1, 100);
            listBox1.Items.Add("Номер " + str.Id);
            listBox1.Items.Add("Имя " + str.Name);
            listBox1.Items.Add("Возраст " + str.Age);
            listBox1.Items.Add("Рост " + str.Rost);
            listBox1.Items.Add("Вес " + str.Wes);
        }
    }
    public struct Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }
        public float Rost { get; set; }

        public float Wes { get; set; }
    }
}
