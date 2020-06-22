using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NumbersOnly_Textbox_Override
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
            if (textBoxNumbersOnly2.NumbersOnly == true)
            {
                textBoxNumbersOnly2.NumbersOnly = false;
                textBoxNumbersOnly2.Multiline = true;
                textBoxNumbersOnly2.Size = new Size(textBoxNumbersOnly2.Width, 100);
            }
            else
                textBoxNumbersOnly2.NumbersOnly = true;

        }
    }
}
