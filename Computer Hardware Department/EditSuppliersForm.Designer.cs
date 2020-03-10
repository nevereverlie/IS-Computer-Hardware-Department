namespace Computer_Hardware_Department
{
    partial class EditSuppliersForm
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
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelIssueId = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.computer_Hardware_DepartmentDataSet = new Computer_Hardware_Department.Computer_Hardware_DepartmentDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliersTableAdapter = new Computer_Hardware_Department.Computer_Hardware_DepartmentDataSetTableAdapters.SuppliersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.computer_Hardware_DepartmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Cancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Cancel.Location = new System.Drawing.Point(111, 168);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(94, 25);
            this.button_Cancel.TabIndex = 38;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // button_OK
            // 
            this.button_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_OK.ForeColor = System.Drawing.Color.Blue;
            this.button_OK.Location = new System.Drawing.Point(47, 118);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(224, 44);
            this.button_OK.TabIndex = 37;
            this.button_OK.Text = "ОК";
            this.button_OK.UseVisualStyleBackColor = false;
            this.button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(129, 77);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(176, 20);
            this.textBoxType.TabIndex = 29;
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(129, 9);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(176, 20);
            this.textBox_Id.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "Вид продукції:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Назва:";
            // 
            // labelIssueId
            // 
            this.labelIssueId.AutoSize = true;
            this.labelIssueId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIssueId.Location = new System.Drawing.Point(12, 9);
            this.labelIssueId.Name = "labelIssueId";
            this.labelIssueId.Size = new System.Drawing.Size(30, 20);
            this.labelIssueId.TabIndex = 27;
            this.labelIssueId.Text = "ID:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(129, 44);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(176, 20);
            this.textBoxName.TabIndex = 39;
            // 
            // computer_Hardware_DepartmentDataSet
            // 
            this.computer_Hardware_DepartmentDataSet.DataSetName = "Computer_Hardware_DepartmentDataSet";
            this.computer_Hardware_DepartmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.computer_Hardware_DepartmentDataSet;
            this.bindingSource1.Position = 0;
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "Suppliers";
            this.suppliersBindingSource.DataSource = this.bindingSource1;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // EditSuppliersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 209);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.textBox_Id);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelIssueId);
            this.Name = "EditSuppliersForm";
            this.Text = "Постачальник";
            this.Load += new System.EventHandler(this.EditSuppliersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.computer_Hardware_DepartmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelIssueId;
        private System.Windows.Forms.TextBox textBoxName;
        private Computer_Hardware_DepartmentDataSet computer_Hardware_DepartmentDataSet;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private Computer_Hardware_DepartmentDataSetTableAdapters.SuppliersTableAdapter suppliersTableAdapter;
    }
}