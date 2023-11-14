using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examples
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        //Stopwatch and color changing example
        

        int clickn =0;
        int number = 60;
        private void button1_Click(object sender, EventArgs e)
        {
            clickn++;
            if (clickn % 2 == 1) timer1.Start();
            else timer1.Stop();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (number >= 0)
            {
                label1.Text = number.ToString();
                number--;

                int c = number % 5;
                switch (c)
                {
                    case 1: this.BackColor = Color.Blue; break;
                    case 2: this.BackColor = Color.Yellow; break;
                    case 3: this.BackColor = Color.Green; break;
                    case 4: this.BackColor = Color.Purple; break;
                    case 0: this.BackColor = Color.Magenta; break;
                }
            }
            else
            {
                number = 60;
                label1.Text = number.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();
            this.Hide();
        }
    }
}
