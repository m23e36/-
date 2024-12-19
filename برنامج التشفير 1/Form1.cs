using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace برنامج_التشفير_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToBase64String(Encoding.Unicode.GetBytes(textBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = Encoding.Unicode.GetString(Convert.FromBase64String(textBox2.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(textBox2.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text (.txt)|*.txt";
            DialogResult dialogResult = sfd.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, textBox2.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
