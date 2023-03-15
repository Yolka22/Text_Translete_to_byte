using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Translete_to_byte
{
    public partial class Translate : Form
    {
        public Translate()
        {
            InitializeComponent();

            
        }

        public Translate(string text_to_fill)
        {
            InitializeComponent();


            StringBuilder sb = new StringBuilder();
            foreach (byte b in System.Text.Encoding.Unicode.GetBytes(text_to_fill))
                sb.Append(Convert.ToString(b, 2).PadLeft(8, '0')).Append(' ');

            string binaryStr = sb.ToString();

            textBox1.Text = binaryStr;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
