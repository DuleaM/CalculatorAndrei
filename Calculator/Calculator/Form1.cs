namespace Calculator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void one_Click(object sender, EventArgs e)
        {
            calc.Text += "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            calc.Text += "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            calc.Text += "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            calc.Text += "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            calc.Text += "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            calc.Text += "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            calc.Text += "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            calc.Text += "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            calc.Text += "9";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            calc.Text += "-";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            calc.Text += "+";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            calc.Text += "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            calc.Text = "";
        }

        private void equals_Click(object sender, EventArgs e)
        {
            string calcul = calc.Text;
            string forma_poloneza = getFormaPoloneza(calcul);
            string result = getResult(forma_poloneza);

            MessageBox.Show(result);
        }
        
        private string getFormaPoloneza(string calcul)
        {
            string forma_poloneza = calcul;

            return forma_poloneza;
        }

        private string getResult(string forma_poloneza)
        {
            string result = forma_poloneza;

            return result;  

        }
    }

}