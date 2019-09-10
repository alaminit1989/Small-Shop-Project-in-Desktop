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
    public partial class uProduct : UserControl
    {
        DataTable dt;
        BLL obj = new BLL();

        public uProduct()
        {
            InitializeComponent();
            
            StockMenuFalse();
            GetItemList();

        }

        private void UProduct_Load(object sender, EventArgs e)
        {
            dgvItemList.ColumnHeadersDefaultCellStyle.BackColor = Color.Silver;
            dgvItemList.EnableHeadersVisualStyles = false;
        }
        private void StockMenuFalse()
        {
            pnlStockOutput.Visible = false;
            pnlStockInput.Visible = false;
        }

        private void BtnStockInput_Click(object sender, EventArgs e)
        {
            pnlStockOutput.Visible = false;
            pnlStockInput.Visible = true;
        }

        private void BtnStockOutput_Click(object sender, EventArgs e)
        {
            pnlStockInput.Visible = false;
            pnlStockOutput.Visible = true;
        }

        private void UProduct_Click(object sender, EventArgs e)
        {
            StockMenuFalse();
        }

        private void BtnItemAdd_Click(object sender, EventArgs e)
        {
            frmProduct child = new frmProduct();
            child.FormClosed += new FormClosedEventHandler(Child_FormClosed);
            child.Show();
        }


        void Child_FormClosed(object sender, FormClosedEventArgs e)
        {
            //when child form is closed, this code is executed
            this.Refresh();
            GetItemList();

            //this.textBox1.Text = "Alamin";
        }

        private void GetItemList()
        {
            dt = new DataTable();
            dt = obj.GetItemData();
            dgvItemList.DataSource = dt;
        }

        
    }
}
