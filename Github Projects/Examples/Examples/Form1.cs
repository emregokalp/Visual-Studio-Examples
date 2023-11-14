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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Maze Game
        //About-->Take the mouse to the green button without touching the red columns.

        private void button1_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Game Over!");
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Game Over!");
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Game Over!");
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Game Over!");
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Game Over!");
        }

        private void button9_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Game Over!");
        }

 

        private void button7_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Game Over!");
        }

        private void button8_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Game Over!");
        }

        private void button10_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulations!");
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }
    }
}
