using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
using DAL.DTO;
using BLL;
using System.Data.SqlClient;

namespace CoalPark
{
    public partial class FrmEntriesTruckersList : Form
    {
        EntriesDTO dto = new EntriesDTO();
        TruckDTO truckDto = new TruckDTO();
        EntriesDetailDTO detail = new EntriesDetailDTO();
        EntriesDetailDTO entriesDetailDTO = new EntriesDetailDTO();

        public FrmEntriesTruckersList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAllowed_Click(object sender, EventArgs e)
        {
            int truckValue = Convert.ToInt32(cmbTruck.SelectedValue); ;
            bool allowed = TruckerBLL.IsAllowed(truckValue);

            if (allowed)
                MessageBox.Show("The truck is allowed");
            else
                MessageBox.Show("The truck is not allowed");
            //dataGridEntriesTruckers.DataSource = truckDto.trucksList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmEntriesTruckers frm = new FrmEntriesTruckers();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //FrmEntriesTruckers frm = new FrmEntriesTruckers();
            //frm.detail = entriesDetailDTO;
            //this.Hide();
            //frm.ShowDialog();
            //this.Visible = true;

            if (entriesDetailDTO.id == 0)
                MessageBox.Show("Please select a task on table");
            else
            {
                FrmEntriesTruckers frmEntries = new FrmEntriesTruckers();
                frmEntries.isUpdate = true;
                frmEntries.detail = entriesDetailDTO;
                this.Hide();
                frmEntries.ShowDialog();
                this.Visible = true;
                FillAllData();
            }
        }
        
            private void FillAllData()
            {
                dto = EntriesBLL.GetEntries();
                dataGridEntriesTruckers.DataSource = dto.entriesList;

                cmbTruck.DataSource = dto.trucksList;
                cmbTruck.DisplayMember = "plate";
                cmbTruck.ValueMember = "id";

                cmbTruck.SelectedIndex = -1;
            }

        private void FrmEntriesTruckersList_Load_1(object sender, EventArgs e)
        {
            FillAllData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dto = EntriesBLL.GetTruckEntries(Convert.ToInt32(cmbTruck.SelectedValue));
            dataGridEntriesTruckers.DataSource = dto.entriesList;
        }

        private void dataGridEntriesTruckers_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            entriesDetailDTO.id = Convert.ToInt32(dataGridEntriesTruckers.Rows[e.RowIndex].Cells[0].Value);
            entriesDetailDTO.driverID = Convert.ToInt32(dataGridEntriesTruckers.Rows[e.RowIndex].Cells[2].Value);
            entriesDetailDTO.truckID = Convert.ToInt32(dataGridEntriesTruckers.Rows[e.RowIndex].Cells[3].Value);
            entriesDetailDTO.companyID = Convert.ToInt32(dataGridEntriesTruckers.Rows[e.RowIndex].Cells[4].Value);
            entriesDetailDTO.entryDate = Convert.ToDateTime(dataGridEntriesTruckers.Rows[e.RowIndex].Cells[5].Value);
            entriesDetailDTO.entryWeight = Convert.ToSingle(dataGridEntriesTruckers.Rows[e.RowIndex].Cells[6].Value);
        }
    }
 }

