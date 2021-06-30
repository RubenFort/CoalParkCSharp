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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntriesTrukers_Click(object sender, EventArgs e)
        {
            FrmEntriesTruckersList frm = new FrmEntriesTruckersList();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnTruckers_Click(object sender, EventArgs e)
        {
            FrmTruckerList frm = new FrmTruckerList();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }
    }
}
