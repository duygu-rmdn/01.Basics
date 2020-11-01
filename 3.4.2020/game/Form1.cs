using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class Form1 : Form
    {
        bool ezi = true;
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ezi = true;
            button1.BackColor = Color.Blue;
            button2.BackColor = Color.Gray;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ezi = false;
            button2.BackColor = Color.Blue;
            button1.BackColor = Color.Gray;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int coin = new Random().Next(0,2);
     
            if (coin == 0)
            {
                label1.Text = "ezi";
                if (ezi == true)
                    {
                    button3.BackColor = Color.Green;
                }
                else
                {
                    button3.BackColor = Color.Red;
                }
            }
            else
            {
                label1.Text = "tura";
                if (ezi == false)
                {
                    button3.BackColor = Color.Green;
                }
                else
                {
                    button3.BackColor = Color.Red;
                }

            }
        }
        
    }
}
