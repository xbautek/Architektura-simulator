using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Architektura___8086_simulator
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

        private void MOVAXBX_Click(object sender, EventArgs e)
        {
            textBoxAX.Text = textBoxBX.Text;
        }

        private void MOVAXCX_Click(object sender, EventArgs e)
        {
            textBoxAX.Text = textBoxCX.Text;
        }

        private void MOVAXDX_Click(object sender, EventArgs e)
        {
            textBoxAX.Text = textBoxDX.Text;
        }

        private void MOVBXAX_Click(object sender, EventArgs e)
        {
            textBoxBX.Text = textBoxAX.Text;
        }

        private void MOVBXCX_Click(object sender, EventArgs e)
        {
            textBoxBX.Text = textBoxCX.Text;
        }

        private void MOVBXDX_Click(object sender, EventArgs e)
        {
            textBoxBX.Text = textBoxDX.Text;
        }

        private void MOVCXAX_Click(object sender, EventArgs e)
        {
            textBoxCX.Text = textBoxAX.Text;
        }

        private void MOVCXBX_Click(object sender, EventArgs e)
        {
            textBoxCX.Text = textBoxBX.Text;
        }

        private void MOVCXDX_Click(object sender, EventArgs e)
        {
            textBoxCX.Text = textBoxDX.Text;
        }

        private void MOVDXAX_Click(object sender, EventArgs e)
        {
            textBoxDX.Text = textBoxAX.Text;
        }

        private void MOVDXBX_Click(object sender, EventArgs e)
        {
            textBoxDX.Text = textBoxBX.Text;
        }

        private void MOVDXCX_Click(object sender, EventArgs e)
        {
            textBoxDX.Text = textBoxCX.Text;
        }

        private void MOVAXVAR_Click(object sender, EventArgs e)
        {
            textBoxAX.Text = VARIABLE.Text;
        }

        private void MOVBXVAR_Click(object sender, EventArgs e)
        {
            textBoxBX.Text = VARIABLE.Text;
        }

        private void MOVCXVAR_Click(object sender, EventArgs e)
        {
            textBoxCX.Text = VARIABLE.Text;
        }

        private void MOVDXVAR_Click(object sender, EventArgs e)
        {
            textBoxDX.Text = VARIABLE.Text;
        }

        private void RESET_Click(object sender, EventArgs e)
        {
            textBoxAX.ResetText();
            textBoxBX.ResetText();
            textBoxCX.ResetText();
            textBoxDX.ResetText();
        }

        private void TextBoxAX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) ||
                char.IsSymbol(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) ||
                char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }


            if (int.TryParse(textBoxAX.Text, out int number))
            {
                if (number <= 65536)
                {
                    textBoxAX.Text = number.ToString();
                }
                else
                {
                    textBoxAX.Text = "65536";
                }
            }
            else
            {

            }
        }

        private void XCHGAXBX_Click(object sender, EventArgs e)
        {
            (textBoxBX.Text, textBoxAX.Text) = (textBoxAX.Text, textBoxBX.Text);
        }

        private void XCHGAXCX_Click(object sender, EventArgs e)
        {
            (textBoxCX.Text, textBoxAX.Text) = (textBoxAX.Text, textBoxCX.Text);
        }

        private void XCHGAXDX_Click(object sender, EventArgs e)
        {
            (textBoxDX.Text, textBoxAX.Text) = (textBoxAX.Text, textBoxDX.Text);
        }

        private void XCHGBXCX_Click(object sender, EventArgs e)
        {
            (textBoxCX.Text, textBoxBX.Text) = (textBoxBX.Text, textBoxCX.Text);
        }

        private void XCHGBXDX_Click(object sender, EventArgs e)
        {
            (textBoxDX.Text, textBoxBX.Text) = (textBoxBX.Text, textBoxDX.Text);
        }

        private void XCHGCXDX_Click(object sender, EventArgs e)
        {
            (textBoxDX.Text, textBoxCX.Text) = (textBoxCX.Text, textBoxDX.Text);
        }
    }
}
