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

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CiPE
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }
         Form1 var;
        int value = 0;
        public Form2(Form1 test)
        {
            InitializeComponent();
            
            var = test;
            value = test.value;

        }
        bool[] table = new bool[3] {false, false, false }; 
        private void Form2_Load(object sender, EventArgs e)
        {
            
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
                            value += 1700;
                        }
                        else
                        {
                            table[0] = false;
                            value -= 1700;
                        }

                            break;
                    case "2":
                        if (table[1] == false)
                        {
                            table[1] = true;
                            value += 1800;
                        }
                        else
                        {
                            table[1] = false;
                            value -= 1800;
                        }
                        break;
                    case "3":
                        if(table[2] == false)
                        {
                            table[2] = true;
                            value += 1900;
                        }
                        else
                        {
                            table[2] = false;
                            value -= 1900;
                        }
                        break;
                }
                
            }

            textBox1.Text = value.ToString();
        }

        private void anuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            var.changeNumber(value);


        }
    }
}
