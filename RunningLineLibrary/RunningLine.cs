using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace RunningLineLibrary
{
    public class RunningLine
    {
        string text;
        public RunningLine()
        {
            text = null;
        }

        public void RunLeft(TextBox textBox1)
        {
            for (int q = 0; q < 3; q++)
            {
                string text = textBox1.Text;
                int j = 0;
                char temp;
                while (j < text.Length)
                {
                    Thread.Sleep(95);
                    textBox1.Text = textBox1.Text.Remove(0, 1);
                    textBox1.Select(textBox1.TextLength - 1, 0);
                    Thread.Sleep(95);
                    textBox1.Text = textBox1.Text.Insert(text.Length - 1, text.Substring(j, 1));
                    j++;
                }
            }
        }

        public void RunRight(TextBox textBox1)
        {
            for (int q = 0; q < 3; q++)
            {
                string text = textBox1.Text;
                int j = text.Length -1;
                char temp;
                while (j >= 0)
                {
                    Thread.Sleep(95);
                    textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1, 1);
                    textBox1.Select(textBox1.TextLength - 1, 0);
                    Thread.Sleep(95);
                    textBox1.Text = textBox1.Text.Insert(0, text.Substring(j, 1));
                    j--;
                }
            }
        }
    }
}
