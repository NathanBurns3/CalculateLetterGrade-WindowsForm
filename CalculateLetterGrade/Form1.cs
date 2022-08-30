namespace CalculateLetterGrade
{
    public partial class CalculateLetterGrade : Form
    {
        public CalculateLetterGrade()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            /******************************
             * This method calculates the 
             * letter grade for a student
             * based on number grade given
            ******************************/

            // get the number grade from the number grade textbox
            double numberGrade = Convert.ToDouble(txtNumberGrade.Text);

            // set the letter grade based on the value of the number grade
            if (numberGrade >= 89.5)
            {
                txtLetterGrade.Text = "A";
            }
            else if (numberGrade >= 79.5)
            {
                txtLetterGrade.Text = "B";
            }
            else if (numberGrade >= 69.5)
            {
                txtLetterGrade.Text = "C";
            }
            else if (numberGrade >= 59.5)
            {
                txtLetterGrade.Text = "D";
            }
            else
            {
                txtLetterGrade.Text = "F";
            }

            // Move the focus to the number grade textbox
            txtNumberGrade.Focus();
        }
    }
}