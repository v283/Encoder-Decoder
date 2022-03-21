using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encoder_forms
{
    public partial class Form1 : Form
    {
        bool temp = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (temp)
            {
                textBox2.Text = Engine.EncoderEngine(textBox1.Text);
            }
            else
            {
                textBox1.Text = Engine.DecoderEngine(textBox2.Text);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            temp = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            temp = false;
        }
    }
}
