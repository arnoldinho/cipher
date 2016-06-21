using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szyfrant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CipherFacade cipher = new CipherFacade();
            if (radioButton1.Checked == true)
                richTextBox2.Text = cipher.CaesarEncrypt(richTextBox1.Text);
            else if (radioButton2.Checked == true)
                richTextBox2.Text = cipher.Rot13Encrypt(richTextBox1.Text);
            else if (radioButton3.Checked == true)
                richTextBox2.Text = cipher.AESEncrypt(richTextBox1.Text);
            else if (radioButton4.Checked == true)
                richTextBox2.Text = cipher.RSAEncrypt(richTextBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CipherFacade cipher = new CipherFacade();
            if (radioButton5.Checked == true)
                richTextBox3.Text = cipher.Rot13Decrypt(richTextBox4.Text);
            else if (radioButton6.Checked == true)
                richTextBox3.Text = cipher.AESDeccrypt(richTextBox4.Text);
            else if (radioButton7.Checked == true)
                richTextBox3.Text = cipher.CaesarDecrypt(richTextBox4.Text);
            else if (radioButton8.Checked == true)
                richTextBox3.Text = cipher.RSADecrypt(richTextBox4.Text);
        }

    }
}
