namespace Activity_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void subButt1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                luckNum.Text = rnd.Next(10).ToString();
            }
        }
    }
}