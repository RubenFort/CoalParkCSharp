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
            this.btnEntriesTrukers = new System.Windows.Forms.Button();
            this.btnTruckers = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnWeight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEntriesTrukers
            // 
            this.btnEntriesTrukers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntriesTrukers.Location = new System.Drawing.Point(45, 44);
            this.btnEntriesTrukers.Name = "btnEntriesTrukers";
            this.btnEntriesTrukers.Size = new System.Drawing.Size(120, 120);
            this.btnEntriesTrukers.TabIndex = 0;
            this.btnEntriesTrukers.Text = "Entries Truckers";
            this.btnEntriesTrukers.UseVisualStyleBackColor = true;
            this.btnEntriesTrukers.Click += new System.EventHandler(this.btnEntriesTrukers_Click);
            // 
            // btnTruckers
            // 
            this.btnTruckers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTruckers.Location = new System.Drawing.Point(229, 44);
            this.btnTruckers.Name = "btnTruckers";
            this.btnTruckers.Size = new System.Drawing.Size(120, 120);
            this.btnTruckers.TabIndex = 1;
            this.btnTruckers.Text = "Truckers";
            this.btnTruckers.UseVisualStyleBackColor = true;
            this.btnTruckers.Click += new System.EventHandler(this.btnTruckers_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(229, 210);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 120);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnWeight
            // 
            this.btnWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeight.Location = new System.Drawing.Point(410, 44);
            this.btnWeight.Name = "btnWeight";
            this.btnWeight.Size = new System.Drawing.Size(120, 120);
            this.btnWeight.TabIndex = 3;
            this.btnWeight.Text = "Weight/Day";
            this.btnWeight.UseVisualStyleBackColor = true;
            this.btnWeight.Click += new System.EventHandler(this.btnWeight_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 374);
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

