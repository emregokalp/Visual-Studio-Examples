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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //Button Catch Game
        //About-->Try to catch the button.

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random r = new Random();
            button1.Top = r.Next(this.Height - button1.Height);
            button1.Left = r.Next(this.Width - button1.Width);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulations!");
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space || e.KeyChar == (char)Keys.Enter) ;//Check for enter
            MessageBox.Show("No Tricks!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
