namespace CoalPark
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnWeight = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTruckers = new System.Windows.Forms.Button();
            this.btnEntriesTrukers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWeight
            // 
            this.btnWeight.AutoEllipsis = true;
            this.btnWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeight.Image = global::CoalPark.Properties.Resources.weighing_machine;
            this.btnWeight.Location = new System.Drawing.Point(330, 26);
            this.btnWeight.Name = "btnWeight";
            this.btnWeight.Size = new System.Drawing.Size(120, 120);
            this.btnWeight.TabIndex = 2;
            this.btnWeight.Text = "Weight/Day";
            this.btnWeight.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWeight.UseVisualStyleBackColor = false;
            this.btnWeight.Click += new System.EventHandler(this.btnWeight_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Maroon;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = global::CoalPark.Properties.Resources.disable_remove_delete_exit_close_11881;
            this.btnExit.Location = new System.Drawing.Point(177, 177);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 120);
            this.btnExit.TabIndex = 3;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnTruckers
            // 
            this.btnTruckers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTruckers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTruckers.Image = global::CoalPark.Properties.Resources.delivery_truck;
            this.btnTruckers.Location = new System.Drawing.Point(177, 26);
            this.btnTruckers.Name = "btnTruckers";
            this.btnTruckers.Size = new System.Drawing.Size(120, 120);
            this.btnTruckers.TabIndex = 1;
            this.btnTruckers.Text = "Truckers";
            this.btnTruckers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTruckers.UseVisualStyleBackColor = false;
            this.btnTruckers.Click += new System.EventHandler(this.btnTruckers_Click);
            // 
            // btnEntriesTrukers
            // 
            this.btnEntriesTrukers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEntriesTrukers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntriesTrukers.Image = global::CoalPark.Properties.Resources.entry__1_;
            this.btnEntriesTrukers.Location = new System.Drawing.Point(24, 26);
            this.btnEntriesTrukers.Name = "btnEntriesTrukers";
            this.btnEntriesTrukers.Size = new System.Drawing.Size(120, 120);
            this.btnEntriesTrukers.TabIndex = 0;
            this.btnEntriesTrukers.Text = "Entries";
            this.btnEntriesTrukers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEntriesTrukers.UseVisualStyleBackColor = false;
            this.btnEntriesTrukers.Click += new System.EventHandler(this.btnEntriesTrukers_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 322);
            this.Controls.Add(this.btnWeight);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTruckers);
            this.Controls.Add(this.btnEntriesTrukers);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEntriesTrukers;
        private System.Windows.Forms.Button btnTruckers;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnWeight;
    }
}

