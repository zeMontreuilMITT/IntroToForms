namespace IntroToForms
{
    public partial class Form1 : Form
    {
        private int _operandFormValue;

        public Form1()
        {
            InitializeComponent();
        }

        // private void [Element]_[EventType](object sender, EventArgs e)
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OperandInputField_TextChanged(object sender, EventArgs e)
        {
            if(OperandInputField.Text.Length > 0)
            {
                try
                {
                    _operandFormValue = Int32.Parse(OperandInputField.Text);
                }
                catch (Exception ex)
                {
                    OperandInputField.Text = "";
                    _operandFormValue = 0;
                }
            }
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            int multipliedValue = MathMethods.Multiply(_operandFormValue, 2);
            ProductOutput.Text = multipliedValue.ToString();
        }
    }
}