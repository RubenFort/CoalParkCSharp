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
    public partial class FrmEntriesTruckers : Form
    {
        EntriesDTO dto = new EntriesDTO();
        public EntriesDetailDTO detail = new EntriesDetailDTO();
        public bool isUpdate = false;
        entries entries = new entries();

        public FrmEntriesTruckers()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Utils.isNumberOrPoint(e);
        }



        private void FrmEntriesTruckers_Load(object sender, EventArgs e)
        {
            FillAllData();

            if (isUpdate)
            {
                txtWeight.Text = detail.entryWeight.ToString();

                cmbTruck.DataSource = dto.trucksList;
                cmbTruck.DisplayMember = "plate";
                cmbTruck.ValueMember = "ID";
                cmbTruck.SelectedValue = detail.truckID;

                cmbCompaniID.DataSource = dto.companyList;
                cmbCompaniID.DisplayMember = "name";
                cmbCompaniID.ValueMember = "ID";
                cmbCompaniID.SelectedValue = detail.companyID;

                cmbDriverID.DataSource = dto.driveList;
                cmbDriverID.DisplayMember = "name";
                cmbDriverID.ValueMember = "ID";
                cmbDriverID.SelectedValue = detail.driverID;

                chkExit.Checked = detail.isExit;
            }
            else
            {
                if (!isUpdate)
                {
                    try
                    {
                        entries.id = Convert.ToInt32(cmbTruck.SelectedValue);
                        entries.driver_id = Convert.ToInt32(cmbDriverID.SelectedValue);
                        entries.company_id = Convert.ToInt32(cmbCompaniID.SelectedValue);
                        entries.entry_weight = Double.Parse(txtWeight.Text.ToString());
                        entries.entry_date = dtpEntry.Value;
                        entries.is_exit = chkExit.Checked;
                        EntriesBLL.AddEntry(entries);
                        MessageBox.Show("Entry was added");
                        clearFilters();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error in load data");
                    }
                        
                }
                else if (isUpdate)
                {
                    try
                    {
                        DialogResult result = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            entries update = new entries();

                            update.truck_id = Convert.ToInt32(cmbTruck.SelectedValue);
                            update.driver_id = Convert.ToInt32(cmbDriverID.SelectedValue);
                            update.company_id = Convert.ToInt32(cmbCompaniID.SelectedValue);
                            update.entry_weight = Convert.ToDouble(txtWeight.Text.ToString());
                            update.is_exit = chkExit.Checked;
                            EntriesBLL.UpdateEntry(update);
                            MessageBox.Show("Entry was update");
                            this.Close();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error in load data");
                    }
                        
                }
            }
        }

        private void clearFilters()
        {
            cmbDriverID.SelectedValue = -1;
            cmbTruck.SelectedValue = -1;
            cmbCompaniID.SelectedValue = -1;
            txtWeight.Clear();
            dtpEntry.Value = DateTime.Now;
        }
        private void FillAllData()
        {
            dto = EntriesBLL.GetEntries();

            cmbTruck.DataSource = dto.trucksList;
            cmbTruck.DisplayMember = "plate";
            cmbTruck.ValueMember = "id";

            cmbTruck.SelectedIndex = -1;
            cmbDriverID.DataSource = dto.driveList;
            cmbDriverID.DisplayMember = "name";
            cmbDriverID.ValueMember = "id";

            cmbDriverID.SelectedIndex = -1;
            cmbCompaniID.DataSource = dto.companyList;
            cmbCompaniID.DisplayMember = "name";
            cmbCompaniID.ValueMember = "id";

            cmbCompaniID.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                entries entry = new entries();
                //MessageBox.Show(label.Text);
                entry.truck_id = Convert.ToInt32(cmbTruck.SelectedValue);
                entry.driver_id = Convert.ToInt32(cmbTruck.SelectedValue);
                entry.company_id = Convert.ToInt32(cmbTruck.SelectedValue);
                entry.createdat = DateTime.Now;
                entry.entry_date = dtpEntry.Value.Date;
                entry.entry_weight = Convert.ToInt32(txtWeight.Text);
                entry.is_exit = chkExit.Checked;
                EntriesBLL.AddEntry(entry);
                MessageBox.Show("Entry added");
            }
            catch (Exception)
            {
                MessageBox.Show("Truck not added");
            }
        }
    }
}
