using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using RunningLineLibrary;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Input;
using System.Text.RegularExpressions;
using System.Drawing.Text;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Drawing.Design;

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

        private void textBox1_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                runningLine.RunRight(textBox1);
            else if (e.KeyCode == Keys.Left)
                runningLine.RunLeft(textBox1);
        }
    }
}
