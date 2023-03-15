using System;
using System.IO;
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
    public partial class Form1 : Form
    {
        string current_file_name;

        public Form1()
        {
            InitializeComponent();
        }

        private void Load_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();

            StreamReader sr = new StreamReader(fileDialog.FileName);

            Init_textbox.Text = sr.ReadToEnd();

            sr.Close();
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();

            StreamWriter sw = new StreamWriter(fileDialog.FileName);

            sw.Write(Init_textbox.Text);

            sw.Close();
        }

        private void Translate_button_Click(object sender, EventArgs e)
        {



            Translate newForm = new Translate(Init_textbox.Text);
            newForm.Show();
            
            
        }
    }
}
