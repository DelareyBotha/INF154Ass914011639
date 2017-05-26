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

namespace INF154Ass914011639
{
    public partial class INF154Ass9 : Form
    {
        string[] arrayWords;
        public INF154Ass9()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            rtbInput.LoadFile("file.rtf");

            arrayWords = rtbInput.Lines;

        }

        public bool isPalindrome(string text)
        {
            text = text.ToLower();
            string reverse = "";

            int k=text.Length-1;

            while(k > -1)
            {
                reverse += text[k];
                k--;
            }

            if(text == reverse)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public string makePigLatin(string text)
        {
            string pigText = "";
            string temp;
            temp = text;
            temp = temp.ToLower();
            
            if ((temp[0] == 'a')|| (temp[0] == 'e')|| (temp[0] == 'i')|| (temp[0] == 'o')|| (temp[0] == 'i'))
            {
                pigText = text + "way";
            }
            else
            {
                if (text.Length > 1)
                {
                    for (int k = 1; k < text.Length; k++)
                    {
                        pigText += text[k];
                    }
                    pigText += text[0] + "ay";
                }
            }
            return pigText;
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnLoad.PerformClick();
        }

        private void btnMarsSpeak_Click(object sender, EventArgs e)
        {
            
            if (arrayWords != null)
            {
                arrayWords = rtbInput.Lines;
                rtbInput.Clear();

                //If more than 1 word:
                if (arrayWords.Length > 1)
                {
                    //The first to second last word:
                    for (int k = 0; k < arrayWords.Length - 1; k++)
                    {
                        rtbInput.AppendText(makePigLatin(arrayWords[k]));
                        rtbInput.AppendText("\n");
                    }

                    //The last word:
                    rtbInput.AppendText(makePigLatin(arrayWords[arrayWords.Length - 1]));
                }
                //If only one word:
                else if(arrayWords.Length == 1)
                {
                    //The only word:
                    rtbInput.AppendText(makePigLatin(arrayWords[0]));
                }
                
            }
            else
            {
                MessageBox.Show("Please provide words to process first");
            }
        }

        private void btnPalindrome_Click(object sender, EventArgs e)
        {
            if (arrayWords != null)
            {
                arrayWords = rtbInput.Lines;
                rtbInput.Clear();
                if (arrayWords.Length > 1)
                {
                    //The first to second last word:
                    for (int k = 0; k < arrayWords.Length - 1; k++)
                    {
                        if (isPalindrome(arrayWords[k]))
                        {
                            rtbInput.AppendText(arrayWords[k] + "*");
                            rtbInput.AppendText("\n");
                            
                        }
                        else
                        {
                            rtbInput.AppendText(arrayWords[k]);
                            rtbInput.AppendText("\n");
                        }
                    }
                    //The last word:
                    if (isPalindrome(arrayWords[arrayWords.Length - 1]))
                    {
                        rtbInput.AppendText(arrayWords[arrayWords.Length - 1] + "*");
                    }
                    else
                    {
                        rtbInput.AppendText(arrayWords[arrayWords.Length - 1]);
                    }
                }

                else if(arrayWords.Length == 1)
                {
                    //The only word:
                    if (isPalindrome(arrayWords[0]))
                    {
                        rtbInput.AppendText(arrayWords[0] + "*");
                    }
                    else
                    {
                        rtbInput.AppendText(arrayWords[0]);
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Please provide words to process first");
            }

        }

        private void rtbInput_KeyPress(object sender, EventArgs e)
        {
            arrayWords = rtbInput.Lines;
        }


    }
}
