using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab_5
{
    public partial class Table : Form
    {
        public Table()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();


            if (!int.TryParse(textBox1.Text, out int number))
            {
                MessageBox.Show("Будь ласка, введіть коректне число!", "Помилка");
                return;
            }
            for (int i = 1; i <= 10; i++)
            {
                int result = number * i;
                listBox1.Items.Add($"{number} x {i} = {result}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
