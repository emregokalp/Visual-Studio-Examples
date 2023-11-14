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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        //Paint Example
        //About-->Press and hold the mouse, then draw by dragging.
        int x1, y1;

        private void Form3_MouseUp(object sender, MouseEventArgs e)
        {
            Graphics line = this.CreateGraphics();
            Pen pen = new Pen(Color.BlueViolet, 5);
            line.DrawLine(pen, x1, y1, e.X, e.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            x1 = e.X;
            y1 = e.Y;
        }
    }
}
