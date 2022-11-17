using System.Threading;
using System.Windows.Forms;

namespace MyStringLibrary
{
    public class RunningLine
    {
        string text;
        public RunningLine()
        {
            text = null;
        }

        protected internal void RunningLineLeft(TextBox textBox1, int ml_sec_SPEED)
        {
            for (int q = 0; q < 3; q++)
            {
                string text = textBox1.Text;
                int j = 0;

                while (j < text.Length)
                {
                    Thread.Sleep(ml_sec_SPEED);
                    textBox1.Text = textBox1.Text.Remove(0, 1);
                    textBox1.Select(textBox1.TextLength - 1, 0);
                    Thread.Sleep(ml_sec_SPEED);
                    textBox1.Text = textBox1.Text.Insert(text.Length - 1, text.Substring(j, 1));
                    j++;
                }
            }
        }

        protected internal void RunningLineRight(TextBox textBox1, int ml_sec_SPEED)
        {
            for (int q = 0; q < 3; q++)
            {
                string text = textBox1.Text;
                int j = text.Length - 1;

                while (j >= 0)
                {
                    Thread.Sleep(ml_sec_SPEED);
                    textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1, 1);
                    textBox1.Select(textBox1.TextLength - 1, 0);
                    Thread.Sleep(ml_sec_SPEED);
                    textBox1.Text = textBox1.Text.Insert(0, text.Substring(j, 1));
                    j--;
                }
            }
        }
    }
}
