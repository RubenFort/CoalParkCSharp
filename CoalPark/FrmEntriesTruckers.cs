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

namespace CoalPark
{
    public partial class FrmEntriesTruckers : Form
    {
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

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            entries entry = new entries();
            //MessageBox.Show(label.Text);
            entry.truck_id = Convert.ToInt32(cmbEntry.SelectedValue);
            entry.driver_id = Convert.ToInt32(cmbEntry.SelectedValue);
            entry.company_id = Convert.ToInt32(cmbEntry.SelectedValue);
            entry.createdat = DateTime.Now;
            entry.entry_date = dtpEntry.Value.Date;
            entry.entry_weight = Convert.ToInt32(txtWeight.Text);
            entry.is_exit = chkExit.Checked;
            EntriesBLL.AddEntry(entry);
            //File.Copy(txtImagePath.Text, @"images\\" + fileName);//Copiar imagen a capeta(persistir datos)
            MessageBox.Show("Entry added");
        }
    }
}
