namespace Calculator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if(textBox1.Text !="" &&textBox2.Text != "")
            {
                int num1=int.Parse(textBox1.Text);
                int num2=int.Parse(textBox2.Text);
                int result=num1+num2;
                label3.Text="Addition is:" +result.ToString();
                label3.Visible=true;
            }
            else
            {
                MessageBox.Show("please fill both text field");
            }
        }

        private void subbtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                int result = num1 - num2;
                label3.Text = "Subtraction is:" + result.ToString();
                label3.Visible = true;
            }
            else
            {
                MessageBox.Show("please fill both text field");
            }
        }

        private void multbtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                int result = num1 * num2;
                label3.Text = "Multiplication is:" + result.ToString();
                label3.Visible = true;
            }
            else
            {
                MessageBox.Show("please fill both text field");
            }
        }

        private void Divibtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                int result = num1 / num2;
                label3.Text = "Division is:" + result.ToString();
                label3.Visible = true;
            }
            else
            {
                MessageBox.Show("please fill both text field");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you want to exit Calculator");
;
        }
    }
}