using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_5
{
    public partial class Year : Form
    {
        public Year()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int age = int.Parse(textBox1.Text);
                string category = "";

                if (age < 0)
                {
                    MessageBox.Show("Вік не може бути від’ємним!", "Помилка");
                    return;
                }
                else if (age < 13)
                {
                    category = "Дитина";
                }
                else if (age < 18)
                {
                    category = "Підліток";
                }
                else
                {
                    category = "Дорослий";
                }

                label1.Text = $"Результат: {category}";
                listBox1.Items.Add($"Вік: {age} -> {category}");
            }
            catch
            {
                MessageBox.Show("Будь ласка, введіть число!", "Помилка");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Table f3 = new Table();
            f3.Show();
            this.Hide();
        }
    }
}

