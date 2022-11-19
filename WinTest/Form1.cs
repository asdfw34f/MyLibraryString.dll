using MyStringLibrary;
using System;
using System.Windows.Forms;

namespace WinTest
{
    public partial class Form1 : Form
    {
        RunningLine runningLine;

        public Form1()
        {
            InitializeComponent();
            runningLine = new RunningLine();
        }

        int speed;
        private void textBox1_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            speed = Convert.ToInt32(numericUpDown1.Value) / 50;
            if (e.KeyCode == Keys.Right)
                runningLine.RunningLineRight(textBox1, speed);
            else if (e.KeyCode == Keys.Left)
                runningLine.RunningLineLeft(textBox1, speed);
        }
    }
}
