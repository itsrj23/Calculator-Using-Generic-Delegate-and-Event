namespace CalculatorApplication
{
    public partial class frmCalculator : Form
    {

        CalculatorClass cal;

        double num1;
        double num2;
        string Arithmetic;
        public frmCalculator()
        {
            InitializeComponent();
            cal = new CalculatorClass();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            num1 = Int32.Parse(textBoxInput1.Text);
            num2 = Int32.Parse(textBoxInput2.Text);
           Arithmetic =  cbOperator.Text;
            switch (Arithmetic) 
            {
             case "+":
                 cal.CalculatorEvent += new Formula<double>(cal.GetSum);
                 lblDisplayAnswer.Text = cal.GetSum(num1, num2).ToString();
                 cal.CalculatorEvent -= new Formula<double>(cal.GetSum);
                 break;
                 
             case "-":
                 cal.CalculatorEvent += new Formula<double>(cal.GetDifference);
                 lblDisplayAnswer.Text = cal.GetDifference(num1, num2).ToString();
                 cal.CalculatorEvent -= new Formula<double>(cal.GetDifference);
                 break;
            case "*":
                 cal.CalculatorEvent += new Formula<double>(cal.GetProduct);
                 lblDisplayAnswer.Text = cal.GetProduct(num1, num2).ToString();
                 cal.CalculatorEvent -= new Formula<double>(cal.GetProduct);
                 break;
            case "/":
                 cal.CalculatorEvent += new Formula<double>(cal.GetQuotient);
                 lblDisplayAnswer.Text = cal.GetQuotient(num1, num2).ToString();
                 cal.CalculatorEvent -= new Formula<double>(cal.GetQuotient);
                 break;
            }

        }
    }
}
