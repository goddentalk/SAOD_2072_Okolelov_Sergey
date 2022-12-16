namespace Очередь
{
    public partial class Form1 : Form
    {

        MyQueue<string> queue;
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            textBox1.Enabled = false;


        }

        private void Visual()
        {
            if (queue.size == 0)
            {
                dataGridView1.RowCount = 1;
                dataGridView1.ColumnCount = 1;
                dataGridView1.Rows[0].Cells[0].Value = "";
            }
            else
            {
                dataGridView1.RowCount = 1;
                dataGridView1.ColumnCount = queue.size;
            }
            string[] s = queue.ToArray();
            for (int i = 0; i < queue.size; i++)
            {
                dataGridView1.Rows[0].Cells[i].Value = s[i];
            }


        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox2.Text);
            queue = new MyQueue<string>(n);
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Clear();

            textBox3.Text = Convert.ToString(queue.Count);
            textBox4.Text = Convert.ToString(queue.Capacity);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (queue.IsNoFull())
            {
                queue.Enqueue(textBox1.Text);
                Visual();
                textBox1.Clear();
            }
            else label1.Text = "Очередь переполнена";
            textBox1.Focus();
            textBox3.Text = Convert.ToString(queue.Count);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!queue.IsEmpty())
            {
                label2.Text = queue.Peek();
                queue.Dequeue();
                Visual();
                textBox1.Clear();
                
            }
            else label1.Text = "Очередь пуста";
            textBox1.Focus();
            textBox3.Text = Convert.ToString(queue.Count);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (queue.IsEmpty())
            {
                label1.Text = "Очередь пуста";
            }
            else
            {
                label2.Text = queue.Peek();
                Visual();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            queue = null;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            textBox1.Enabled = false;
            label2.Text = "";
            label1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            dataGridView1.Rows.Clear();
        }
    }
}