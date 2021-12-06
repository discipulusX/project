﻿using MassTransit.Monitoring.Performance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ВодителиВАР3
{
    public partial class Form1 : Form
    {
        Model1 db = new Model1(); 
        public Form1()
        {
            InitializeComponent();
        }
        static int counter = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            counter++;
            if (textBox1.Text == "inspector" || textBox2.Text == "inspector") 
            {
                Form2 db = new Form2();
                db.Show(); 
                this.Hide(); 
            }
            else if (counter >= 3) 
            {
                textBox1.Enabled = false; 
                textBox2.Enabled = false; 
                MessageBox.Show("Привышено кол-во попыток. Перезапустите систему.");
            }
            if (textBox1.Text == "" || textBox2.Text == "") 
            {
                MessageBox.Show("Неверный логин и пароль");
                return;
            }
            else if (counter >= 3) 
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                MessageBox.Show("Привышено кол-во попыток. Перезапустите систему.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
