using SCM.Helper;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SCM.Forms
{
    public partial class frmCustomer : Form
    {
        bool isValidate=true;
        //Utility s = new Utility();
        public frmCustomer()
        {
            InitializeComponent();
        }

       
        private void BtnCustomerCreate_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                MessageBox.Show(" is valid data");
            }
            else
            {
                MessageBox.Show("Please enter valid data");
            }
            
        }

        private void TxtCustomerName_Validating(object sender, CancelEventArgs e)
        {
           Utility.ValidateString(txtCustomerName,  errorValidator, lblCustomer,e);
           
        }

         

        private void TxtMobile_Validating(object sender, CancelEventArgs e)
        {
            Utility.ValidateString(txtMobile, errorValidator, lblMobile, e);

        }

        
        private void TxtAddress_Validating(object sender, CancelEventArgs e)
        {
            Utility.ValidateNumber(txtAddress, errorValidator, lblAdress, e);
           
        }

        private void TxtCredit_Validating(object sender, CancelEventArgs e)
        {

            Utility.ValidateNumber(txtCredit, errorValidator, lblCredit, e);

        }

        private void TxtOpening_Validating(object sender, CancelEventArgs e)
        {
            Utility.ValidateNumber(txtOpening, errorValidator, lblOpening, e);
           
        }
        
    }
}
