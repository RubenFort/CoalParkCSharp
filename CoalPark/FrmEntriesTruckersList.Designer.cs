namespace CoalPark
{
    partial class FrmEntriesTruckersList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTruck = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAllowed = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataGridEntriesTruckers = new System.Windows.Forms.DataGridView();
            this.eNTRIESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coalParkDataSet = new CoalPark.CoalParkDataSet();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.eNTRIESTableAdapter = new CoalPark.CoalParkDataSetTableAdapters.ENTRIESTableAdapter();
            this.frmEntriesTruckersListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEntriesTruckers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNTRIESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coalParkDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmEntriesTruckersListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Truck";
            // 
            // cmbTruck
            // 
            this.cmbTruck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTruck.FormattingEnabled = true;
            this.cmbTruck.Location = new System.Drawing.Point(133, 31);
            this.cmbTruck.Name = "cmbTruck";
            this.cmbTruck.Size = new System.Drawing.Size(200, 28);
            this.cmbTruck.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(158, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(447, 24);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 40);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAllowed
            // 
            this.btnAllowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllowed.Location = new System.Drawing.Point(384, 31);
            this.btnAllowed.Name = "btnAllowed";
            this.btnAllowed.Size = new System.Drawing.Size(94, 28);
            this.btnAllowed.TabIndex = 1;
            this.btnAllowed.Text = "isAllowed";
            this.btnAllowed.UseVisualStyleBackColor = true;
            this.btnAllowed.Click += new System.EventHandler(this.btnAllowed_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(302, 24);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 40);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dataGridEntriesTruckers
            // 
            this.dataGridEntriesTruckers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEntriesTruckers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEntriesTruckers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridEntriesTruckers.Location = new System.Drawing.Point(0, 93);
            this.dataGridEntriesTruckers.MultiSelect = false;
            this.dataGridEntriesTruckers.Name = "dataGridEntriesTruckers";
            this.dataGridEntriesTruckers.Size = new System.Drawing.Size(719, 308);
            this.dataGridEntriesTruckers.TabIndex = 0;
            this.dataGridEntriesTruckers.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEntriesTruckers_RowEnter_1);
            // 
            // eNTRIESBindingSource
            // 
            this.eNTRIESBindingSource.DataMember = "ENTRIES";
            this.eNTRIESBindingSource.DataSource = this.coalParkDataSet;
            // 
            // coalParkDataSet
            // 
            this.coalParkDataSet.DataSetName = "CoalParkDataSet";
            this.coalParkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(536, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 40);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbTruck);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnAllowed);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 93);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 401);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(719, 104);
            this.panel2.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(316, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "The weight will be displayed with a maximum of 3 decimal places";
            // 
            // eNTRIESTableAdapter
            // 
            this.eNTRIESTableAdapter.ClearBeforeFill = true;
            // 
            // frmEntriesTruckersListBindingSource
            // 
            this.frmEntriesTruckersListBindingSource.DataSource = typeof(CoalPark.FrmEntriesTruckersList);
            // 
            // FrmEntriesTruckersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 505);
            this.Controls.Add(this.dataGridEntriesTruckers);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmEntriesTruckersList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entries Truckers List";
            this.Load += new System.EventHandler(this.FrmEntriesTruckersList_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEntriesTruckers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNTRIESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coalParkDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmEntriesTruckersListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTruck;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAllowed;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dataGridEntriesTruckers;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private CoalParkDataSet coalParkDataSet;
        private System.Windows.Forms.BindingSource eNTRIESBindingSource;
        private CoalParkDataSetTableAdapters.ENTRIESTableAdapter eNTRIESTableAdapter;
        private System.Windows.Forms.BindingSource frmEntriesTruckersListBindingSource;
        private System.Windows.Forms.Label label2;
    }
}