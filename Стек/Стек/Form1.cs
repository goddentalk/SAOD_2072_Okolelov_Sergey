using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Стек
{
    public partial class Form1 : Form
    {
        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox2.Text);
            stack = new MyStack<string>(n);
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

            textBox3.Text = Convert.ToString(stack.Count);
            textBox4.Text = Convert.ToString(stack.Capacity);
        }


        MyStack<string> stack;
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (stack.IsNoFull())
            {
                stack.Push(textBox1.Text);
                Visual();
                textBox1.Clear();
            }
            else label1.Text = "Стек переполнен";
            textBox1.Focus();
            textBox3.Text = Convert.ToString(stack.Count);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (stack.IsEmpty())
            {
                label1.Text = "Стек пуст";
            }
            else
            {
                label2.Text = stack.Pop();
                Visual();
            }
            textBox3.Text = Convert.ToString(stack.Count);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (stack.IsEmpty())
            {
                label1.Text = "Стек пуст";
            }
            else
            {
                label2.Text = stack.Top();
                Visual();
            }
        }
        private void Visual()
        {
            if (stack.size == 0)
            {
                dataGridView1.RowCount = 1;
                dataGridView1.ColumnCount = 1;
                dataGridView1.Rows[0].Cells[0].Value = "";
            }
            else
            {
                dataGridView1.RowCount = 1;
                dataGridView1.ColumnCount = stack.size;
            }
            string[] s = stack.ToArray();
            for (int i = 0; i < stack.size; i++)
            {
                dataGridView1.Rows[0].Cells[i].Value = s[i];
            }


        }

    }
}
