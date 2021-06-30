using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CoalPark
{
    public partial class FrmDriverList : Form
    {
        public FrmDriverList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmDriver frm = new FrmDriver();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmDriver frm = new FrmDriver();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }
    }
}
