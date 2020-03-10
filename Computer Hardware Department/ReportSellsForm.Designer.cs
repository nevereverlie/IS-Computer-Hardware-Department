namespace Computer_Hardware_Department
{
    partial class ReportSellsForm
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
            this.IssueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Computer_Hardware_DepartmentDataSet = new Computer_Hardware_Department.Computer_Hardware_DepartmentDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.buttonMakeReport = new System.Windows.Forms.Button();
            this.IssueTableAdapter = new Computer_Hardware_Department.Computer_Hardware_DepartmentDataSetTableAdapters.IssueTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.IssueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Computer_Hardware_DepartmentDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // IssueBindingSource
            // 
            this.IssueBindingSource.DataMember = "Issue";
            this.IssueBindingSource.DataSource = this.Computer_Hardware_DepartmentDataSet;
            // 
            // Computer_Hardware_DepartmentDataSet
            // 
            this.Computer_Hardware_DepartmentDataSet.DataSetName = "Computer_Hardware_DepartmentDataSet";
            this.Computer_Hardware_DepartmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Computer_Hardware_Department.ReportSells.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 53);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1178, 424);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Від:";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerFrom.Location = new System.Drawing.Point(61, 12);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 29);
            this.dateTimePickerFrom.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(316, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "До:";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerTo.Location = new System.Drawing.Point(362, 12);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 29);
            this.dateTimePickerTo.TabIndex = 4;
            // 
            // buttonMakeReport
            // 
            this.buttonMakeReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonMakeReport.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.buttonMakeReport.FlatAppearance.BorderSize = 3;
            this.buttonMakeReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMakeReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMakeReport.Location = new System.Drawing.Point(653, 10);
            this.buttonMakeReport.Name = "buttonMakeReport";
            this.buttonMakeReport.Size = new System.Drawing.Size(157, 35);
            this.buttonMakeReport.TabIndex = 5;
            this.buttonMakeReport.Text = "Завантажити";
            this.buttonMakeReport.UseVisualStyleBackColor = false;
            this.buttonMakeReport.Click += new System.EventHandler(this.ButtonMakeReport_Click);
            // 
            // IssueTableAdapter
            // 
            this.IssueTableAdapter.ClearBeforeFill = true;
            // 
            // ReportSellsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 489);
            this.Controls.Add(this.buttonMakeReport);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportSellsForm";
            this.Text = "Звіз з продаж";
            this.Load += new System.EventHandler(this.ReportSells_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IssueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Computer_Hardware_DepartmentDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Button buttonMakeReport;
        private System.Windows.Forms.BindingSource IssueBindingSource;
        private Computer_Hardware_DepartmentDataSet Computer_Hardware_DepartmentDataSet;
        private Computer_Hardware_DepartmentDataSetTableAdapters.IssueTableAdapter IssueTableAdapter;
    }
}