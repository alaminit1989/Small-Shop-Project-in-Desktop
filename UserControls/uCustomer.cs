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

namespace SCM.UserControls
{
    public partial class uCustomer : UserControl
    {
        public uCustomer()
        {
            InitializeComponent();
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
    }
}
