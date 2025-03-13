using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CiPE
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Form1 var;
        int value = 0;
        
        public Form3(Form1 test)
        {
            InitializeComponent();

            var = test;
            value = test.value;

        }
        bool[] table = new bool[4] { false, false, false, false };
        bool[] table2 = new bool[3] { false, false, false };
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        
    
                int tes = listBox1.SelectedIndex;
                
             
                switch (tes.ToString())
                {

                    case "0":
                        if (table2[0] == false)
                        {
                            table2[0] = true;
                            value += 700;
                        }
                        else
                        {
                            table2[0] = false;
                            value -= 700;
                        }

                        break;
                    case "1":
                        if (table2[1] == false)
                        {
                            table2[1] = true;
                            value += 800;
                        }
                        else
                        {
                            table2[1] = false;
                            value -= 800;
                        }
                        break;
                    case "2":
                        if (table2[2] == false)
                        {
                            table2[2] = true;
                            value += 900;
                        }
                        else
                        {
                            table2[2] = false;
                            value -= 900;
                        }
                        break;
                }
          

            textBox2.Text = value.ToString();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {

                switch (item.Tag.ToString())
                {

                    case "1":
                        if (table[0] == false)
                        {
                            table[0] = true;
                            value += 1999;
                        }
                        else
                        {
                            table[0] = false;
                            value -= 1999;
                        }

                        break;
                    case "2":
                        if (table[1] == false)
                        {
                            table[1] = true;
                            value += 2999;
                        }
                        else
                        {
                            table[1] = false;
                            value -= 2999;
                        }
                        break;
                    case "3":
                        if (table[2] == false)
                        {
                            table[2] = true;
                            value += 999;
                        }
                        else
                        {
                            table[2] = false;
                            value -= 999;
                        }
                        break;
                    case "4":
                        if (table[3] == false)
                        {
                            table[3] = true;
                            value += 2000;
                        }
                        else
                        {
                            table[3] = false;
                            value -= 2000;
                        }
                        break;
                }

            }

            textBox1.Text = value.ToString();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            var.changeNumber(value);
        }

        private void anuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
