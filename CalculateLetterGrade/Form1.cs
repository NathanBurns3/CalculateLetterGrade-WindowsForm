namespace CalculateLetterGrade
{
    public partial class CalculateLetterGrade : Form
    {
        public CalculateLetterGrade()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double letterGrade = Convert.ToDouble(txtNumberGrade.Text);

            if (letterGrade >= 89.5)
            {
                txtLetterGrade.Text = "A";
            }
            else if (letterGrade >= 79.5)
            {
                txtLetterGrade.Text = "B";
            }
            else if (letterGrade >= 69.5)
            {
                txtLetterGrade.Text = "C";
            }
            else if (letterGrade >= 59.5)
            {
                txtLetterGrade.Text = "D";
            }
            else
            {
                txtLetterGrade.Text = "F";
            }

            txtNumberGrade.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}