namespace taimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int h, m, s;
        private void button1_Click(object sender, EventArgs e)
        {
            h = Convert.ToInt32(textBox1.Text);
            m = Convert.ToInt32(textBox2.Text);
            s = Convert.ToInt32(textBox3.Text);



            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                button1.Text = "Пуск";
                button2.Enabled = true;
            }
            else
            {
                timer1.Enabled = true;
                button1.Text = "Стоп";
                button2.Enabled = false;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s = s - 1;
            if (s == -1)
            {
                m = m - 1;
                s = 59;
            }
            if (m == -1)
            {
                h = h - 1;
                m = 59;
            }

            if (h == 0 && m == 0 && s == 0)
            {
                timer1.Stop();
                MessageBox.Show("Время вышло!");
            }

            textBox1.Text = Convert.ToString(h);
            textBox2.Text = Convert.ToString(m);
            textBox3.Text = Convert.ToString(s);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            s = 0;
            h = 0;
            m = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            s = s + 1;
            if (s > 59)
            {
                s = 0;
            }
            textBox3.Text = Convert.ToString(s);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            m = m + 1;
            if (m > 59)
            {
                m = 0;
            }
            textBox2.Text = Convert.ToString(m);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            h = h + 1;
            if (h > 23)
            {
                h = 0;
            }
            textBox1.Text = Convert.ToString(h);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            h = h - 1;
            if (h < 0)
            {
                h = 23;
            }
            textBox1.Text = Convert.ToString(h);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            m = m - 1;
            if (m < 0)
            {
                m = 59;
            }
            textBox2.Text = Convert.ToString(m);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            s = s - 1;
            if (s < 0)
            {
                s = 59;
            }
            textBox3.Text = Convert.ToString(s);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}