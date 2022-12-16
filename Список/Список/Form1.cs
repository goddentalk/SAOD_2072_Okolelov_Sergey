namespace Список
{
    public partial class Form1 : Form
    {
        MyList<int> list;
        public Form1()
        {
            InitializeComponent();
            list = new MyList<int>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                list.Prepend(Convert.ToInt32(textBox1.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            listBox1.Items.Add("Добавлено в начало число: " + $"{textBox1.Text}");

            textBox1.Text = "";
            GGG();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                list.Append(Convert.ToInt32(textBox1.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            listBox1.Items.Add("Добавлено в конец число: " + $"{textBox1.Text}");
            textBox1.Text = "";
            GGG();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                list.Find(Convert.ToInt32(textBox2.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            listBox1.Items.Add("Найдено число: " + $"{textBox2.Text}");
            textBox2.Text = "";
            GGG();
        }

        public void GGG()
        {
            string g = "";
            try
            {
                g = Convert.ToString(list.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            listBox1.Items.Add($"{g}");
            textBox5.Text = list.Count.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                textBox2.Text = Convert.ToString(list.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            listBox1.Items.Add("Текущие элементы списка: " + $"{textBox2.Text}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                list.Remove(Convert.ToInt32(textBox1.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            listBox1.Items.Add("Удалено число: " + $"{textBox1.Text}");
            textBox1.Text = "";
            GGG();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                GGG();
                listBox1.Items.Add("Найдено число: " + $"{list.At(Convert.ToInt32(textBox3.Text))}" + " с индексом " + $"{textBox3.Text}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            textBox3.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                list.Insert(Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox3.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            int t = Convert.ToInt32(textBox3.Text);
            listBox1.Items.Add("Добавлено на " + $"{t} место " + " число: " + $"{textBox4.Text}");
            textBox3.Text = "";
            textBox4.Text = "";
            GGG();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                list.RemoveAt(Convert.ToInt32(textBox3.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            listBox1.Items.Add("Удалено число с индексом " + $"{textBox3.Text}");
            textBox3.Text = "";
            GGG();
        }
    }
}