using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CiPE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string text;
        public int value = 0;
        public delegate void Form1Delegate(int var);
        public  void changeNumber(int var)
        {
            value += var;
            textBox2.Text = value.ToString();
            
            
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 test = new Form2(this);
            test.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 test = new Form3(this);
            test.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
