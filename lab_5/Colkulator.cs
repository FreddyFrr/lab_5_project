using System;
using System.Windows.Forms;

namespace lab_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            button3.Click += button3_Click;
            button4.Click += button4_Click;
        }
        private void Calculate(char operation)
        {
            if (!double.TryParse(textBox1.Text, out double num1) ||
                !double.TryParse(textBox2.Text, out double num2))
            {
                MessageBox.Show("Будь ласка, введіть коректні числові значення!", "Помилка");
                return;
            }

            double result = 0;
            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        MessageBox.Show("Ділення на нуль неможливе!", "Помилка");
                        return;
                    }
                    result = num1 / num2;
                    break;
                default:
                    MessageBox.Show("Невідома операція", "Помилка");
                    return;
            }

            label1.Text = $"Результат: {result}";
            listBox1.Items.Add($"{num1} {operation} {num2} = {result}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculate('+');
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calculate('-');
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calculate('*');
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Calculate('/');
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Year f2 = new Year();
            f2.Show();
            this.Hide();
        }
    }
}