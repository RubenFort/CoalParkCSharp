using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
using BLL;
using DAL.DTO;

namespace CoalPark
{
    public partial class FrmTruckers : Form
    {
        TruckDTO dto = new TruckDTO();

        public FrmTruckers()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Utils.isNumber(e);
        }

        private void FrmTruckers_Load(object sender, EventArgs e)
        {
            FillAllData();
        }

        private void FillAllData()
        {
            dto = TruckerBLL.GetEntries();

            cmbDriverID.DataSource = dto.driveList;
            cmbDriverID.DisplayMember = "name";
            cmbDriverID.ValueMember = "id";

            cmbDriverID.SelectedIndex = -1;
            cmbCompany.DataSource = dto.companyList;
            cmbCompany.DisplayMember = "name";
            cmbCompany.ValueMember = "id";

            cmbCompany.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                truck truck = new truck();
                //MessageBox.Show(label.Text);
                truck.id = Convert.ToInt32(txtTruckID.Text);
                truck.plate = txtPlate.Text;
                truck.company_id = Convert.ToInt32(cmbCompany.SelectedValue);
                truck.createdat = DateTime.Now;
                truck.model = txtModel.Text;
                truck.allowed = chkIsAllowed.Checked;
                TruckerBLL.AddEntry(truck);
                //File.Copy(txtImagePath.Text, @"images\\" + fileName);//Copiar imagen a capeta(persistir datos)
                MessageBox.Show("Truck added");
            }
            catch (Exception)
            {
                MessageBox.Show("Truck not added");
            }
        }
    }
}
