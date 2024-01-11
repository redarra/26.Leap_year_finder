namespace _26.Leap_year_finder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(textBox1.Text) % 4 == 0)
            {
                MessageBox.Show(textBox1.Text + " is a leap year!");
            }
            else { MessageBox.Show(textBox1.Text + " is not a leap year!"); }
            textBox1.Text = "";

        }
    }
}