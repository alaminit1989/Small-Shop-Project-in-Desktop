using SCM.BusinessLogicLayer;
using SCM.Helper;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace SCM.Forms
{
    public partial class frmCustomer : Form
    {
        Customer objCustomer = new Customer();
        DataTable dt = new DataTable();
        public frmCustomer()
        {
            InitializeComponent();
            if (User.Id > 0)
            {
                btnCustomerCreate.Visible = false;
                btnEdit.Visible = true;
                lblHeader.Text = "Customer Edit";
                try
                {
                    string msg = "";

                   dt= objCustomer.CustomerCRUD(5, User.Id, txtCustomerName.Text, 1, txtMobile.Text, txtAddress.Text, 0, 0, 0, ref msg);
                    if (dt.Rows.Count > 0)
                    {
                        txtCustomerName.Text = dt.Rows[0]["strCustomer"].ToString();
                        txtMobile.Text = dt.Rows[0]["strMobileNo"].ToString();
                        txtAddress.Text = dt.Rows[0]["strAddress"].ToString();
                        txtCredit.Text = dt.Rows[0]["decCreditBlance"].ToString();
                        txtOpening.Text = dt.Rows[0]["decOpeningBlance"].ToString();
                    }
                }
                catch { }
            }
        }

       
        private void BtnCustomerCreate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want proceed ?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes && ValidateChildren())
            {
                try
                {
                    string msg = "";
                  
                    objCustomer.CustomerCRUD(1, 0, txtCustomerName.Text, 1, txtMobile.Text, txtAddress.Text,Convert.ToDecimal(txtCredit.Text), Convert.ToDecimal(txtOpening.Text), 0, ref msg);
                    MessageBox.Show(msg);
                }
                catch { }


               
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
            Utility.ValidateString(txtAddress, errorValidator, lblAdress, e);
           
        }

        private void TxtCredit_Validating(object sender, CancelEventArgs e)
        {

            Utility.ValidateNumber(txtCredit, errorValidator, lblCredit, e);

        }

        private void TxtOpening_Validating(object sender, CancelEventArgs e)
        {
            Utility.ValidateNumber(txtOpening, errorValidator, lblOpening, e);
           
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want proceed ?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes && ValidateChildren())
            {
                try
                {
                    string msg = "";

                    objCustomer.CustomerCRUD(2,User.Id, txtCustomerName.Text, 1, txtMobile.Text, txtAddress.Text, Convert.ToDecimal(txtCredit.Text), Convert.ToDecimal(txtOpening.Text), 0, ref msg);
                    MessageBox.Show(msg);
                }
                catch { }



            }
            else
            {
                MessageBox.Show("Please enter valid data");
            }
        }
    }
}
