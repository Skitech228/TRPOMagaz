using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp33
{
    public partial class Form1 : Form
    {
        List<Товар> a = new List<Товар>();
        List<Продавец_консультант> prod = new List<Продавец_консультант>();
        Продавец_консультант prodav = new Продавец_консультант();
        Магазин магазин = new Магазин();
        public Form1()
        {
            InitializeComponent();          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Text != "" && textBox3.Text != "")
                button1.Enabled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Text != "" && textBox3.Text != "")
                button1.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            textBox2.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            int n = int.Parse(textBox1.Text);
            магазин.bonus = int.Parse(textBox3.Text);
            prod = new List<Продавец_консультант>();
            for (int i = 0; i < n; i++)
            {
                prodav = new Продавец_консультант(i + 1);
                prod.Add(prodav);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            магазин.Add(a, textBox5.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox2.Text) <= prod.Count-1)
                магазин.Prod(a, textBox4.Text, prod[int.Parse(textBox2.Text)]);
            else
                MessageBox.Show("Низя");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label11.Text=Convert.ToString(магазин.Vir(prod));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox6.Text) <= prod.Count-1)
                label12.Text = Convert.ToString(магазин.ZP(prod[int.Parse(textBox6.Text)]));
            else
                MessageBox.Show("Низя");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
