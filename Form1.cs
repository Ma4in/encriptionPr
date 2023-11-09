using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace encriptionPr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int defLang = 1;

        private void cLang_Click(object sender, EventArgs e)
        {
            if (defLang == 1) { 
                defLang = 0; 
                cLang.Text = "ENG";
                MainText.Text = "";
                encriptedText.Text = "";
                codeWord.Text = "";
            }
            else { 
                defLang = 1; 
                cLang.Text = "RUS";
                MainText.Text = "";
                encriptedText.Text = "";
                codeWord.Text = "";
            }
        }

        private void encriptType_SelectedIndexChanged(object sender, EventArgs e)
        {
            codeWord.Text = "";
            if ((encriptType.SelectedIndex == 0) || (encriptType.SelectedIndex == 3))
            {
                label3.Visible = true;
                codeWord.Visible = true;
                encriptButton.Enabled = false;
                decriptButton.Enabled = false;
            } else
            {
                label3.Visible = false;
                codeWord.Visible = false;
                encriptButton.Enabled = true;
                decriptButton.Enabled = true;
            }
        }

        private void codeWord_TextChanged(object sender, EventArgs e)
        {
            if (codeWord.Text.Length < 3)
            {
                encriptButton.Enabled = false;
                decriptButton.Enabled = false;
            } else
            {
                encriptButton.Enabled = true;
                decriptButton.Enabled = true;
            }
        }

        private void MainText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (defLang == 1)
            {
                if ((e.KeyChar >= 'А') && (e.KeyChar <= 'я'))
                {
                    return;
                }
            }
            else
            {
                if ((e.KeyChar >= 'A') && (e.KeyChar <= 'z'))
                {
                    return;
                }
            }
            e.Handled = true;
        }

        private void codeWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (defLang == 1)
            {
                if ((e.KeyChar >= 'А') && (e.KeyChar <= 'я'))
                {
                    return;
                }
            }
            else
            {
                if ((e.KeyChar >= 'A') && (e.KeyChar <= 'z'))
                {
                    return;
                }
            }
            e.Handled = true;
        }

        private void encriptedText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (defLang == 1)
            {
                if ((e.KeyChar >= 'А') && (e.KeyChar <= 'я'))
                {
                    return;
                }
            }
            else
            {
                if ((e.KeyChar >= 'A') && (e.KeyChar <= 'z'))
                {
                    return;
                }
            }
            e.Handled = true;
        }

        private void encriptButton_Click(object sender, EventArgs e)
        {
            if (encriptType.SelectedIndex == 0)
            {
                encriptedText.Text = encriptionMethods.podstanovka(MainText.Text, codeWord.Text, defLang);
            }

            if (encriptType.SelectedIndex == 1)
            {
                encriptedText.Text = encriptionMethods.perestanovka(MainText.Text);
            }

            if (encriptType.SelectedIndex == 2)
            {
                encriptedText.Text = encriptionMethods.podmena(MainText.Text, defLang);
            }

            if (encriptType.SelectedIndex == 3)
            {
                encriptedText.Text = encriptionMethods.gammirovanie(MainText.Text, codeWord.Text);
            }
        }

        private void decriptButton_Click(object sender, EventArgs e)
        {
            if (encriptType.SelectedIndex == 0)
            {
                encriptedText.Text = encriptionMethods.decriptPodstanovka(MainText.Text, codeWord.Text, defLang);
            }

            if (encriptType.SelectedIndex == 1)
            {
                encriptedText.Text = encriptionMethods.decriptPerestanovka(MainText.Text);
            }

            if (encriptType.SelectedIndex == 2)
            {
                encriptedText.Text = encriptionMethods.dePodmena(MainText.Text, defLang);
            }

            if (encriptType.SelectedIndex == 3)
            {
                encriptedText.Text = encriptionMethods.deGammirovanie(MainText.Text, codeWord.Text);
            }
        }
    }
}
