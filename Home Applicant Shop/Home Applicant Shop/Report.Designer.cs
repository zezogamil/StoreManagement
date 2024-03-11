namespace Home_Applicant_Shop
{
    partial class Report
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxReports = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Goodslbl = new System.Windows.Forms.Label();
            this.Valuelbl = new System.Windows.Forms.Label();
            this.listBoxReport = new System.Windows.Forms.ListBox();
            this.Backbtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.Percentagelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shop Statistics Report ";
            // 
            // comboBoxReports
            // 
            this.comboBoxReports.FormattingEnabled = true;
            this.comboBoxReports.Items.AddRange(new object[] {
            "All",
            "Electronics ",
            "Fridge",
            "Console"});
            this.comboBoxReports.Location = new System.Drawing.Point(33, 113);
            this.comboBoxReports.Name = "comboBoxReports";
            this.comboBoxReports.Size = new System.Drawing.Size(711, 21);
            this.comboBoxReports.TabIndex = 1;
            this.comboBoxReports.SelectedIndexChanged += new System.EventHandler(this.comboBoxReports_SelectedIndexChanged_1);
            this.comboBoxReports.MouseEnter += new System.EventHandler(this.comboBoxReports_MouseEnter);
            this.comboBoxReports.MouseLeave += new System.EventHandler(this.comboBoxReports_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Goods In Stock :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Value of Goods :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "percentage :";
            // 
            // Goodslbl
            // 
            this.Goodslbl.AutoSize = true;
            this.Goodslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Goodslbl.Location = new System.Drawing.Point(265, 169);
            this.Goodslbl.Name = "Goodslbl";
            this.Goodslbl.Size = new System.Drawing.Size(93, 24);
            this.Goodslbl.TabIndex = 7;
            this.Goodslbl.Text = "Goodslbl";
            // 
            // Valuelbl
            // 
            this.Valuelbl.AutoSize = true;
            this.Valuelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valuelbl.ForeColor = System.Drawing.Color.Green;
            this.Valuelbl.Location = new System.Drawing.Point(265, 221);
            this.Valuelbl.Name = "Valuelbl";
            this.Valuelbl.Size = new System.Drawing.Size(86, 24);
            this.Valuelbl.TabIndex = 8;
            this.Valuelbl.Text = "Valuelbl";
            // 
            // listBoxReport
            // 
            this.listBoxReport.FormattingEnabled = true;
            this.listBoxReport.Location = new System.Drawing.Point(427, 169);
            this.listBoxReport.Name = "listBoxReport";
            this.listBoxReport.Size = new System.Drawing.Size(326, 199);
            this.listBoxReport.TabIndex = 11;
            this.listBoxReport.SelectedIndexChanged += new System.EventHandler(this.listBoxReport_SelectedIndexChanged);
            // 
            // Backbtn
            // 
            this.Backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Backbtn.Location = new System.Drawing.Point(98, 391);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(242, 47);
            this.Backbtn.TabIndex = 12;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = true;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.ForeColor = System.Drawing.Color.Green;
            this.Addbtn.Location = new System.Drawing.Point(458, 391);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(242, 47);
            this.Addbtn.TabIndex = 13;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // Percentagelbl
            // 
            this.Percentagelbl.AutoSize = true;
            this.Percentagelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Percentagelbl.Location = new System.Drawing.Point(265, 279);
            this.Percentagelbl.Name = "Percentagelbl";
            this.Percentagelbl.Size = new System.Drawing.Size(139, 24);
            this.Percentagelbl.TabIndex = 9;
            this.Percentagelbl.Text = "Percentagelbl";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.listBoxReport);
            this.Controls.Add(this.Percentagelbl);
            this.Controls.Add(this.Valuelbl);
            this.Controls.Add(this.Goodslbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxReports);
            this.Controls.Add(this.label1);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxReports;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Goodslbl;
        private System.Windows.Forms.Label Valuelbl;
        private System.Windows.Forms.ListBox listBoxReport;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Label Percentagelbl;
    }
}