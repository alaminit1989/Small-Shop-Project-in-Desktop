﻿using SCM.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCM
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
      
        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            pnlControl.Controls.Clear();
            pnlControl.Controls.Add(c);
        }
        
        private void BtnProduct_Click(object sender, EventArgs e)
        {
            uProduct prod = new uProduct();
            AddControlsToPanel(prod);
        }

        private void BtnCustomer_Click(object sender, EventArgs e)
        {
            uCustomer customer = new uCustomer();
            AddControlsToPanel(customer);
        }
    }
}
