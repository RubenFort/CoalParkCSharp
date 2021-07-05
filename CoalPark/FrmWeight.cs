using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL.DTO;
using BLL;

namespace CoalPark
{
    public partial class FrmWeight : Form
    {
        WeightDTO dto = new WeightDTO();

        public FrmWeight()
        {
            InitializeComponent();
        }

        private void FrmWeight_Load(object sender, EventArgs e)
        {
            FillAllData();
        }

        private void FillAllData()
        {
            dto = WeightBLL.GetEntries();
            dataGridWeight.DataSource = dto.weightList;
            dataGridWeight.FirstDisplayedScrollingRowIndex = dataGridWeight.RowCount - 1;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
