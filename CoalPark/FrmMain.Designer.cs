﻿namespace CoalPark
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
            this.btnInputKg = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
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
            // 
            // btnInputKg
            // 
            this.btnInputKg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInputKg.Location = new System.Drawing.Point(413, 44);
            this.btnInputKg.Name = "btnInputKg";
            this.btnInputKg.Size = new System.Drawing.Size(120, 120);
            this.btnInputKg.TabIndex = 2;
            this.btnInputKg.Text = "Input Kg";
            this.btnInputKg.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(45, 198);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 120);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(229, 198);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 120);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(413, 198);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 120);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(229, 362);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 120);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 494);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnInputKg);
            this.Controls.Add(this.btnTruckers);
            this.Controls.Add(this.btnEntriesTrukers);
            this.Name = "FrmMain";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEntriesTrukers;
        private System.Windows.Forms.Button btnTruckers;
        private System.Windows.Forms.Button btnInputKg;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnExit;
    }
}
