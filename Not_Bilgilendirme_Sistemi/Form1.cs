using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Not_Bilgilendirme_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            double sa, aq, ME, tp, FE, sdurum;

            sa = Convert.ToDouble(textBox1.Text);
            aq = Convert.ToDouble(textBox2.Text);
            ME = Convert.ToDouble(textBox3.Text);
            tp = Convert.ToDouble(textBox4.Text);
            FE = Convert.ToDouble(textBox5.Text);

            sdurum = sa * 5 / 100 + aq * 15 / 100 + ME * 25 / 100 + tp * 15 / 100 + FE * 40 / 100;

            if (sdurum >= 35.5)
            {
                MessageBox.Show("Öğrenci Dersten Geçmişstir.");
                richTextBox1.Text = sdurum.ToString("0.00") + "/100 " + "-- Öğrenci Dersten Geçmişstir.";

            }

            else
            {
                MessageBox.Show("Öğrenci Dersten Kalmıştır.");
                richTextBox1.Text = sdurum.ToString("0.00") +"/100 "+ "-- Öğrenci Dersten Kalmıştır.";

            }





        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
