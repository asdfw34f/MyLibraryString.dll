using MyStringLibrary;
using System;
using System.Windows.Forms;

namespace WinTest
{
    public partial class Form1 : Form
    {
        RunningLine runningLine;
        CheckingString checkName;

        public Form1()
        {
            InitializeComponent();
            runningLine = new RunningLine();
            checkName = new CheckingString();
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox1.Text = "Язык";

        }

        private void textBox1_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            int speed = Convert.ToInt32(numericUpDown1.Value) / 50;
            if (e.KeyCode == Keys.Right)
                runningLine.RunningLineRight(textBox1, speed);
            else if (e.KeyCode == Keys.Left)
                runningLine.RunningLineLeft(textBox1, speed);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                textBox1.Text = checkName.RedactRightName_RU(textBox1.Text);
            else if (comboBox1.SelectedIndex == 1)
                textBox1.Text = checkName.RedactRightName_ENG(textBox1.Text);
        }

        private void comboBox1_selected_changed(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0)
                button1.Text = "Check your Name";
            else 
                button1.Text = "Проверить ваше Имя";
        }
    }
}
