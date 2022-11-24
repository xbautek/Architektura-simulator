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
            textBoxLog.Text = "Successfully moved from BX to AX" + Environment.NewLine + textBoxLog.Text;
        }

        private void MOVAXCX_Click(object sender, EventArgs e)
        {
            textBoxAX.Text = textBoxCX.Text;
            textBoxLog.Text = "Successfully moved from CX to AX" + Environment.NewLine + textBoxLog.Text;
        }

        private void MOVAXDX_Click(object sender, EventArgs e)
        {
            textBoxAX.Text = textBoxDX.Text;
            textBoxLog.Text = "Successfully moved from DX to AX" + Environment.NewLine + textBoxLog.Text;
        }

        private void MOVBXAX_Click(object sender, EventArgs e)
        {
            textBoxBX.Text = textBoxAX.Text;
            textBoxLog.Text = "Successfully moved from AX to BX" + Environment.NewLine + textBoxLog.Text;
        }

        private void MOVBXCX_Click(object sender, EventArgs e)
        {
            textBoxBX.Text = textBoxCX.Text;
            textBoxLog.Text = "Successfully moved from CX to BX" + Environment.NewLine + textBoxLog.Text;
        }

        private void MOVBXDX_Click(object sender, EventArgs e)
        {
            textBoxBX.Text = textBoxDX.Text;
            textBoxLog.Text = "Successfully moved from DX to BX" + Environment.NewLine + textBoxLog.Text;
        }

        private void MOVCXAX_Click(object sender, EventArgs e)
        {
            textBoxCX.Text = textBoxAX.Text;
            textBoxLog.Text = "Successfully moved from AX to CX" + Environment.NewLine + textBoxLog.Text;
        }

        private void MOVCXBX_Click(object sender, EventArgs e)
        {
            textBoxCX.Text = textBoxBX.Text;
            textBoxLog.Text = "Successfully moved from BX to CX" + Environment.NewLine + textBoxLog.Text;
        }

        private void MOVCXDX_Click(object sender, EventArgs e)
        {
            textBoxCX.Text = textBoxDX.Text;
            textBoxLog.Text = "Successfully moved from DX to CX" + Environment.NewLine + textBoxLog.Text;
        }

        private void MOVDXAX_Click(object sender, EventArgs e)
        {
            textBoxDX.Text = textBoxAX.Text;
            textBoxLog.Text = "Successfully moved from AX to DX" + Environment.NewLine + textBoxLog.Text;
        }

        private void MOVDXBX_Click(object sender, EventArgs e)
        {
            textBoxDX.Text = textBoxBX.Text;
            textBoxLog.Text = "Successfully moved from BX to DX" + Environment.NewLine + textBoxLog.Text;
        }

        private void MOVDXCX_Click(object sender, EventArgs e)
        {
            textBoxDX.Text = textBoxCX.Text;
            textBoxLog.Text = "Successfully moved from CX to DX" + Environment.NewLine + textBoxLog.Text;
        }

        private void MOVAXVAR_Click(object sender, EventArgs e)
        {
            textBoxAX.Text = VARIABLE.Text;
            textBoxLog.Text = "Successfully moved from VAR to AX" + Environment.NewLine + textBoxLog.Text;
        }

        private void MOVBXVAR_Click(object sender, EventArgs e)
        {
            textBoxBX.Text = VARIABLE.Text;
            textBoxLog.Text = "Successfully moved from VAR to BX" + Environment.NewLine + textBoxLog.Text;
        }

        private void MOVCXVAR_Click(object sender, EventArgs e)
        {
            textBoxCX.Text = VARIABLE.Text;
            textBoxLog.Text = "Successfully moved from VAR to CX" + Environment.NewLine + textBoxLog.Text;
        }

        private void MOVDXVAR_Click(object sender, EventArgs e)
        {
            textBoxDX.Text = VARIABLE.Text;
            textBoxLog.Text = "Successfully moved from VAR to DX" + Environment.NewLine + textBoxLog.Text;
        }

        private void RESET_Click(object sender, EventArgs e)
        {
            textBoxAX.ResetText();
            textBoxBX.ResetText();
            textBoxCX.ResetText();
            textBoxDX.ResetText();
            textBoxLog.ResetText();
            VARIABLE.ResetText();
        }

        private void TextBoxAX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) ||
                char.IsSymbol(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) ||
                char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                textBoxLog.Text = "AX| Only numbers allowed" + Environment.NewLine + textBoxLog.Text;
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
                    textBoxLog.Text = "AX| Maximum size: 65536" + Environment.NewLine + textBoxLog.Text;
                }
            }
        }

        private void XCHGAXBX_Click(object sender, EventArgs e)
        {
            (textBoxBX.Text, textBoxAX.Text) = (textBoxAX.Text, textBoxBX.Text);
            textBoxLog.Text = "Successfully exchanged AX with BX" + Environment.NewLine + textBoxLog.Text;
        }

        private void XCHGAXCX_Click(object sender, EventArgs e)
        {
            (textBoxCX.Text, textBoxAX.Text) = (textBoxAX.Text, textBoxCX.Text);
            textBoxLog.Text = "Successfully exchanged AX with CX" + Environment.NewLine + textBoxLog.Text;
        }

        private void XCHGAXDX_Click(object sender, EventArgs e)
        {
            (textBoxDX.Text, textBoxAX.Text) = (textBoxAX.Text, textBoxDX.Text);
            textBoxLog.Text = "Successfully exchanged AX with DX" + Environment.NewLine + textBoxLog.Text;
        }

        private void XCHGBXCX_Click(object sender, EventArgs e)
        {
            (textBoxCX.Text, textBoxBX.Text) = (textBoxBX.Text, textBoxCX.Text);
            textBoxLog.Text = "Successfully exchanged BX with CX" + Environment.NewLine + textBoxLog.Text;
        }

        private void XCHGBXDX_Click(object sender, EventArgs e)
        {
            (textBoxDX.Text, textBoxBX.Text) = (textBoxBX.Text, textBoxDX.Text);
            textBoxLog.Text = "Successfully exchanged BX with DX" + Environment.NewLine + textBoxLog.Text;
        }

        private void XCHGCXDX_Click(object sender, EventArgs e)
        {
            (textBoxDX.Text, textBoxCX.Text) = (textBoxCX.Text, textBoxDX.Text);
            textBoxLog.Text = "Successfully exchanged CX with DX" + Environment.NewLine + textBoxLog.Text;
        }

        private void textBoxBX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) ||
                char.IsSymbol(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) ||
                char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                textBoxLog.Text = "BX| Only numbers allowed" + Environment.NewLine + textBoxLog.Text;
            }


            if (int.TryParse(textBoxBX.Text, out int number4))
            {
                if (number4 <= 65536)
                {
                    textBoxBX.Text = number4.ToString();
                }
                else
                {
                    textBoxBX.Text = "65536";
                    textBoxLog.Text = "BX| Maximum size: 65536" + Environment.NewLine + textBoxLog.Text;
                }
            }
        }

        private void textBoxCX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) ||
                char.IsSymbol(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) ||
                char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                textBoxLog.Text = "CX| Only numbers allowed" + Environment.NewLine + textBoxLog.Text;
            }


            if (int.TryParse(textBoxCX.Text, out int number3))
            {
                if (number3 <= 65536)
                {
                    textBoxCX.Text = number3.ToString();
                }
                else
                {
                    textBoxCX.Text = "65536";
                    textBoxLog.Text = "CX| Maximum size: 65536" + Environment.NewLine + textBoxLog.Text;
                }
            }
        }

        private void textBoxDX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) ||
                char.IsSymbol(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) ||
                char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                textBoxLog.Text = "DX| Only numbers allowed" + Environment.NewLine + textBoxLog.Text;
            }


            if (int.TryParse(textBoxDX.Text, out int number2))
            {
                if (number2 <= 65536)
                {
                    textBoxDX.Text = number2.ToString();
                }
                else
                {
                    textBoxDX.Text = "65536";
                    textBoxLog.Text = "DX| Maximum size: 65536" + Environment.NewLine + textBoxLog.Text;
                }
            }
        }

        private void textBoxHelp_Click(object sender, EventArgs e)
        {
            var form2 = new HelpForm();
            form2.Show();
        }

        private void VARIABLE_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (char.IsLetter(e.KeyChar) ||
                char.IsSymbol(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) ||
                char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                textBoxLog.Text = "VAR| Only numbers allowed" + Environment.NewLine + textBoxLog.Text;
            }


            if (int.TryParse(VARIABLE.Text, out int number1))
            {
                if (number1 <= 65536)
                {
                    VARIABLE.Text = number1.ToString();
                }
                else
                {
                    VARIABLE.Text = "65536";
                    textBoxLog.Text = "VAR| Maximum size: 65536" + Environment.NewLine + textBoxLog.Text;
                }
            }
        }
    }
}
