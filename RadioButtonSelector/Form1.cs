namespace RadioButtonSelector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                label1.Text = "1" + radioButton1.Text;
            else if (radioButton2.Checked)
                label1.Text = "2" + radioButton1.Text;
            else if (radioButton3.Checked)
                label1.Text = "3" + radioButton1.Text;
            else
                label1.Text = "No item selected!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
