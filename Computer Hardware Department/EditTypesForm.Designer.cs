namespace Computer_Hardware_Department
{
    partial class EditTypesForm
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelIssueId = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.computer_Hardware_DepartmentDataSet = new Computer_Hardware_Department.Computer_Hardware_DepartmentDataSet();
            this.typesOfProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.types_of_ProductsTableAdapter = new Computer_Hardware_Department.Computer_Hardware_DepartmentDataSetTableAdapters.Types_of_ProductsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computer_Hardware_DepartmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesOfProductsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(129, 44);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(176, 20);
            this.textBoxName.TabIndex = 47;
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Cancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Cancel.Location = new System.Drawing.Point(112, 131);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(94, 25);
            this.button_Cancel.TabIndex = 46;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // button_OK
            // 
            this.button_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_OK.ForeColor = System.Drawing.Color.Blue;
            this.button_OK.Location = new System.Drawing.Point(48, 81);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(224, 44);
            this.button_OK.TabIndex = 45;
            this.button_OK.Text = "ОК";
            this.button_OK.UseVisualStyleBackColor = false;
            this.button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(129, 9);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(176, 20);
            this.textBox_Id.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Назва товару:";
            // 
            // labelIssueId
            // 
            this.labelIssueId.AutoSize = true;
            this.labelIssueId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIssueId.Location = new System.Drawing.Point(12, 9);
            this.labelIssueId.Name = "labelIssueId";
            this.labelIssueId.Size = new System.Drawing.Size(30, 20);
            this.labelIssueId.TabIndex = 40;
            this.labelIssueId.Text = "ID:";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.computer_Hardware_DepartmentDataSet;
            this.bindingSource1.Position = 0;
            // 
            // computer_Hardware_DepartmentDataSet
            // 
            this.computer_Hardware_DepartmentDataSet.DataSetName = "Computer_Hardware_DepartmentDataSet";
            this.computer_Hardware_DepartmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typesOfProductsBindingSource
            // 
            this.typesOfProductsBindingSource.DataMember = "Types of Products";
            this.typesOfProductsBindingSource.DataSource = this.bindingSource1;
            // 
            // types_of_ProductsTableAdapter
            // 
            this.types_of_ProductsTableAdapter.ClearBeforeFill = true;
            // 
            // EditTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 173);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.textBox_Id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelIssueId);
            this.Name = "EditTypesForm";
            this.Text = "Вид товару";
            this.Load += new System.EventHandler(this.EditTypesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computer_Hardware_DepartmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesOfProductsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelIssueId;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Computer_Hardware_DepartmentDataSet computer_Hardware_DepartmentDataSet;
        private System.Windows.Forms.BindingSource typesOfProductsBindingSource;
        private Computer_Hardware_DepartmentDataSetTableAdapters.Types_of_ProductsTableAdapter types_of_ProductsTableAdapter;
    }
}