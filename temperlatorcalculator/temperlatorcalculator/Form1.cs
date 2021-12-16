namespace temperlatorcalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // get input form text box
            string input = textBoxC.Text;
            //convert c of f
            //f = c * 9/5 + 32
            double c = Convert.ToDouble(input);
            double f = c * 9/5 + 32;
            // show input to textbox
            textBoxF.Text = f.ToString();
        }

        private void buttonconver2_Click(object sender, EventArgs e)
        {
            string input = textBoxF.Text;
            //convert f of c
            //c = (f - 32) * 5 / 9;
            double F = Convert.ToDouble(input);
            double C = (F - 32) * 5 / 9;
            // show input to textbox
            textBoxC.Text = C.ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxC.Text = "";
            textBoxF.Text = "";
            
        }
    }
}