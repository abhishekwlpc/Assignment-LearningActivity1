using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformApp1
{
    public partial class Form2 : Form
    {

        //Declare Variables
        private int numbera1;
        private int numbera2;
        private int resulta;

        private int intValidation;

        public Form2()
        {
            InitializeComponent();

            //Initialise Variables On form constructors.
            numbera1 = 0;
            numbera2 = 0;

            //Change attribute
            txtResult.ReadOnly = true;

        }

        private void textBox1_Validating(object sender, CancelEventArgs e, ErrorProvider errorProvider)
        {
            errorProvider.SetError(textBox1, "");

            if (!int.TryParse(textBox1.Text, out intValidation))
            {
                errorProvider.SetError(textBox1, "Please fill the required field");
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e, ErrorProvider errorProvider)
        {
            errorProvider.SetError(textBox1, "");

            if (!int.TryParse(textBox1.Text, out intValidation))
            {
                errorProvider.SetError(textBox1, "Please fill the required field");
            }
        }

        private void txtResult_Validating(object sender, CancelEventArgs e, ErrorProvider errorProvider)
        {
            errorProvider.SetError(textBox1, "");

            if (!int.TryParse(textBox1.Text, out intValidation))
            {
                errorProvider.SetError(textBox1, "Please fill the required field");
            }
        }




        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtResult_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtResult_Click(object sender, EventArgs e)
        {

        }

        private void btnSum_Click(object sender, EventArgs e)
        {

            try
            {
                if(ValidateChildren(ValidationConstraints.Enabled))
                {
                    numbera1 = int.Parse(textBox1.Text);
                    numbera2 = int.Parse(textBox2.Text);

                    resulta = (numbera1 + numbera2);

                    txtResult.Text = resulta.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            
            }
        }
    }
}
