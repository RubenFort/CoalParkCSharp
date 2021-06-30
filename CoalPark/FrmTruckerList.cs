using BLL;
using DAL.DTO;
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
    public partial class FrmTruckerList : Form
    {
        public FrmTruckerList()
        {
            InitializeComponent();
        }

        private void txtTruckId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Utils.isNumberOrPoint(e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmTruckers frm = new FrmTruckers();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmTruckers frm = new FrmTruckers();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void FrmTruckerList_Load(object sender, EventArgs e)
        {
            FillAllData();
        }

        TruckDTO dto = new TruckDTO();
        private void FillAllData()
        {
            dto = TruckerBLL.GetEntries();
            dataGridTruckers.DataSource = dto.trucksList;

            cmbCompany.DataSource = dto.companyList;
            cmbCompany.DisplayMember = "name";
            cmbCompany.ValueMember = "id";

            cmbCompany.SelectedIndex = -1;
        }
    }
}
