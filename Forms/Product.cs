using SCM.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCM.Forms
{
    public partial class frmProduct : Form
    {
        DataTable dt; BLL obj = new BLL();

        string strItemCode, strItemName, strDescription, strUOM, strItemType;
        decimal monBuyPrice, monSalesPrice, monDiscount;

        public frmProduct()
        {
            InitializeComponent();
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            try
            {
                GetItemType(1);
                GetUOM(2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }            
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
         
        }

        private void GetItemType(int intPart)
        {
            dt = new DataTable();
            dt = obj.GetAllDropDownData(intPart);
            cmbItemType.DataSource = dt;
            cmbItemType.DisplayMember = "strItemTypeName";
            cmbItemType.ValueMember = "intItemTypeID";
            cmbItemType.SelectedValue = "0";
        }
        private void GetUOM(int intPart)
        {
            dt = new DataTable();
            dt = obj.GetAllDropDownData(intPart);
            cmbUOM.DataSource = dt;
            cmbUOM.DisplayMember = "strUOM";
            cmbUOM.ValueMember = "intUOMID";
            cmbUOM.SelectedValue = "0";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want proceed ?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                
                try
                {
                    if (txtItemCode.Text != "") { strItemCode = txtItemCode.Text; }
                    else { MessageBox.Show("Please item code input."); return; }

                    if (txtItemName.Text != "") { strItemName = txtItemName.Text; }
                    else { MessageBox.Show("Please item name input."); return; }

                    if (txtItemDesc.Text != "") { strDescription = txtItemDesc.Text; }
                    else { strDescription = strItemName; }

                    
                    strUOM = cmbUOM.Text;
                    strItemType = cmbItemType.Text;
                    try { monBuyPrice = decimal.Parse(txtBuyPrice.Text); }
                    catch { MessageBox.Show("Please valid buy price input."); return; }
                    try { monSalesPrice = decimal.Parse(txtSalesPrice.Text); }
                    catch { MessageBox.Show("Please valid sales price input."); return; }
                    try
                    {
                        if (txtItemDesc.Text != "") { monDiscount = decimal.Parse(txtItemDesc.Text); }
                        else { monDiscount = 0; }
                    }
                    catch { MessageBox.Show("Please valid discount input."); return; }

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message);
                }
            }            
        }

        
    }
}
