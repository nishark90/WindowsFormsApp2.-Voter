using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Voter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a= Convert.ToInt32(textBox1.Text);
            string b= (textBox2.Text);
            if ((a >= 18) && (b == "india"))
            {
                MessageBox.Show("Elegible to Vote");
                Console.ReadLine();
            }
            else
                MessageBox.Show("Not elegible to vote");
            Console.ReadLine();
        }
    }
}
