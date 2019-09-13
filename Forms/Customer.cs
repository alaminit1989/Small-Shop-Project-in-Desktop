using SCM.BusinessLogicLayer;
using SCM.Helper;
using SCM.Model;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace SCM.Forms
{
    public partial class frmCustomer : Form
    {
        Customer_BLL objCustomer = new Customer_BLL();
        Customers cust = new Customers();
        DataTable dt = new DataTable();
        string msg = "";
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
                    
                    cust.intPart = 5;
                    cust.intId = User.Id;
                    dt= objCustomer.CustomerCRUD(cust, ref msg);
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
                   
                    cust.intPart = 1; 
                    cust.intUnitID = 2;
                    cust.strCustomer = txtCustomerName.Text;
                    cust.strMobileNo = txtMobile.Text;
                    cust.strAddress = txtAddress.Text;
                    cust.decCreditBlance = Convert.ToDecimal(txtCredit.Text);
                    cust.decOpeningBlance = Convert.ToDecimal(txtOpening.Text);
                    objCustomer.CustomerCRUD(cust, ref msg);
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
                   
                    cust.intPart = 2;
                    cust.intId = User.Id;
                    cust.intUnitID = 2;
                    cust.strCustomer = txtCustomerName.Text;
                    cust.strMobileNo = txtMobile.Text;
                    cust.strAddress = txtAddress.Text;
                    cust.decCreditBlance = Convert.ToDecimal(txtCredit.Text);
                    cust.decOpeningBlance = Convert.ToDecimal(txtOpening.Text); 
                    objCustomer.GetCustomer(cust, ref msg);
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
