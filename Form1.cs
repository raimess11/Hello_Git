namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "RAHMA SAKTI RAHARDIAN")
            {
                label1.Text = "Halo, RAHMA SAKTI RAHARDIAN";
            }
            else
            {
                label1.Text = "User anda salah!";
            }
            textBox1.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}