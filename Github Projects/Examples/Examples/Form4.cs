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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        //BMI CALCULATE
        //About--->Enter your height and weight to find out your Body Mass Index (BMI).

        private void button1_Click(object sender, EventArgs e)
        {
            double m, b, bmi;
            m=Convert.ToDouble(textBox1.Text);
            b=Convert.ToDouble(textBox2.Text);//Enter the height in meters. For example: 1,80.
            bmi = m / (b * b);

            textBox3.Text = bmi.ToString();

            if (bmi < 18.5) textBox4.Text = "Weak";
            else if (bmi >= 18.5 && bmi < 25) textBox4.Text = "Normal";
            else if (bmi >= 25 && bmi < 30) textBox4.Text = "Fat";
            else textBox4.Text = "Obese";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();
        }
    }
}
