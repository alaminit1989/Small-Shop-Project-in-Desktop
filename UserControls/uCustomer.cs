using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCM.Forms;
using SCM.BusinessLogicLayer;
using SCM.Helper;

namespace SCM.UserControls
{
    public partial class uCustomer : UserControl
    {
        DataTable dt = new DataTable();
        Customer objCustomer = new Customer();
        public uCustomer()
        {
            InitializeComponent();
           
                string msg = "";
            dgvCustomer.AutoGenerateColumns = false;
            dt =  objCustomer.CustomerCRUD(4, 0, "",0,"","",0,0,0,ref msg); 
            dgvCustomer.DataSource = dt;
            dgvCustomer.ColumnHeadersDefaultCellStyle.BackColor = Color.Silver;
            dgvCustomer.EnableHeadersVisualStyles = false;

        }

       
        private void BtnItemAdd_Click(object sender, EventArgs e)
        {
            frmCustomer child = new frmCustomer();
            child.FormClosed += new FormClosedEventHandler(Child_FormClosed);
            child.Show();
        }
        void Child_FormClosed(object sender, FormClosedEventArgs e)
        {
            //when child form is closed, this code is executed
            this.Refresh();
            GetCustomerList();
            //this.textBox1.Text = "Alamin";
        }

        private void GetCustomerList()
        {
            
        }

        private void DgvCustomer_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomer.Rows[e.RowIndex];
                User.Id =int.Parse(row.Cells[0].Value.ToString());
                
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (User.Id>0)
            {
                frmCustomer child = new frmCustomer();
                child.FormClosed += new FormClosedEventHandler(Child_FormClosed);
                child.Show();
            }
            else
            {
                MessageBox.Show("Please Select Customer");
            }
           

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (User.Id > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want proceed ?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes && ValidateChildren())
                {


                }
            }
            else
            {
                MessageBox.Show("Please Select Customer");
            }
        }
    }
}
