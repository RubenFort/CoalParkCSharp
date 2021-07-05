using BLL;
using DAL;
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
        TruckDTO dto = new TruckDTO();

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
            FillAllData();
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

        private void FillAllData()
        {
            dto = TruckerBLL.GetEntries();
            dataGridTruckers.DataSource = dto.trucksList;

            cmbCompany.DataSource = dto.companyList;
            cmbCompany.DisplayMember = "name";
            cmbCompany.ValueMember = "id";

            cmbCompany.SelectedIndex = -1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<truck> list = dto.trucksList;
            if (txtTruckId.Text.Trim() != "")
                list = list.Where(x => x.id == Convert.ToInt32(txtTruckId.Text)).ToList();
            if (txtPlate.Text.Trim() != "")
                list = list.Where(x => x.plate.Contains(txtPlate.Text)).ToList();
            if (cmbCompany.SelectedIndex != -1)
                list = list.Where(x => x.company_id == Convert.ToInt32(cmbCompany.SelectedValue)).ToList();
            dataGridTruckers.DataSource = list;
        }
    }
}
