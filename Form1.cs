namespace Assignment5_OlgaGrisina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            randomNumber();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p = int.Parse(textBox1.Text);
            int r = int.Parse(answer.Text);
            if (p < r)
            {
                label1.Text = "Too low, try again";
            }
            else if(p > r) 
            {
                label1.Text = "Too high, try again.";
            }
            else 
            {
                label1.Text = "Congratulations!\nRight answer:";
                answer.Visible = true;
            }
        }

        private int randomNumber()
        {
            Random rnd = new Random();
            int r = rnd.Next(1,100);
            answer.Text = r.ToString();
            return r;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            answer.Visible = false;
            label1.Text = "";
            textBox1.Text = "";
            randomNumber();
        }
    }
}