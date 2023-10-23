using System.Diagnostics.Metrics;

namespace sounds
{
    public partial class Form1 : Form
    {
        Thread thread;
        bool leaver = true;
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            leaver = true;
            thread = new Thread(() =>
            {
                Random random = new Random();
                while (leaver)
                {
                    int x = random.Next(Convert.ToInt16(textBox1.Text), Convert.ToInt16(textBox2.Text));
                    int y = random.Next(Convert.ToInt16(textBox4.Text), Convert.ToInt16(textBox3.Text));
                    Console.Beep(x, y);
                    counter++;
                }

            });
            thread.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            leaver = false;
        }
    }
}