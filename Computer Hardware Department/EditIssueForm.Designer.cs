namespace Computer_Hardware_Department
{
    partial class EditIssueForm
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
            this.labelIssueId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_IssueId = new System.Windows.Forms.TextBox();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.textBox_MiddleName = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Surname = new System.Windows.Forms.TextBox();
            this.dateTimePicker_IssueDate = new System.Windows.Forms.DateTimePicker();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.comboBox_GoodId = new System.Windows.Forms.ComboBox();
            this.typesOfProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.computer_Hardware_DepartmentDataSet = new Computer_Hardware_Department.Computer_Hardware_DepartmentDataSet();
            this.comboBox_City = new System.Windows.Forms.ComboBox();
            this.deliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.types_of_ProductsTableAdapter = new Computer_Hardware_Department.Computer_Hardware_DepartmentDataSetTableAdapters.Types_of_ProductsTableAdapter();
            this.comboBox_ModelsId = new System.Windows.Forms.ComboBox();
            this.modelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_Employee = new System.Windows.Forms.ComboBox();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelsTableAdapter1 = new Computer_Hardware_Department.Computer_Hardware_DepartmentDataSetTableAdapters.ModelsTableAdapter();
            this.deliveryTableAdapter1 = new Computer_Hardware_Department.Computer_Hardware_DepartmentDataSetTableAdapters.DeliveryTableAdapter();
            this.employeesTableAdapter1 = new Computer_Hardware_Department.Computer_Hardware_DepartmentDataSetTableAdapters.EmployeesTableAdapter();
            this.issueTableAdapter1 = new Computer_Hardware_Department.Computer_Hardware_DepartmentDataSetTableAdapters.IssueTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.typesOfProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computer_Hardware_DepartmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIssueId
            // 
            this.labelIssueId.AutoSize = true;
            this.labelIssueId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIssueId.Location = new System.Drawing.Point(12, 9);
            this.labelIssueId.Name = "labelIssueId";
            this.labelIssueId.Size = new System.Drawing.Size(109, 20);
            this.labelIssueId.TabIndex = 0;
            this.labelIssueId.Text = "№ накладної:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Прізвище:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Співробітник:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Місто:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Дата видачі:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Телефон:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Модель:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Вид товару:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "По батькові:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Ім\'я:";
            // 
            // textBox_IssueId
            // 
            this.textBox_IssueId.Location = new System.Drawing.Point(129, 9);
            this.textBox_IssueId.Name = "textBox_IssueId";
            this.textBox_IssueId.Size = new System.Drawing.Size(176, 20);
            this.textBox_IssueId.TabIndex = 12;
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Location = new System.Drawing.Point(129, 220);
            this.textBox_Phone.MaxLength = 12;
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(176, 20);
            this.textBox_Phone.TabIndex = 6;
            // 
            // textBox_MiddleName
            // 
            this.textBox_MiddleName.Location = new System.Drawing.Point(129, 113);
            this.textBox_MiddleName.Name = "textBox_MiddleName";
            this.textBox_MiddleName.Size = new System.Drawing.Size(176, 20);
            this.textBox_MiddleName.TabIndex = 3;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(129, 77);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(176, 20);
            this.textBox_Name.TabIndex = 2;
            // 
            // textBox_Surname
            // 
            this.textBox_Surname.Location = new System.Drawing.Point(129, 44);
            this.textBox_Surname.Name = "textBox_Surname";
            this.textBox_Surname.Size = new System.Drawing.Size(176, 20);
            this.textBox_Surname.TabIndex = 1;
            // 
            // dateTimePicker_IssueDate
            // 
            this.dateTimePicker_IssueDate.Location = new System.Drawing.Point(129, 257);
            this.dateTimePicker_IssueDate.MaxDate = new System.DateTime(3000, 12, 12, 0, 0, 0, 0);
            this.dateTimePicker_IssueDate.MinDate = new System.DateTime(2019, 12, 26, 0, 0, 0, 0);
            this.dateTimePicker_IssueDate.Name = "dateTimePicker_IssueDate";
            this.dateTimePicker_IssueDate.Size = new System.Drawing.Size(177, 20);
            this.dateTimePicker_IssueDate.TabIndex = 7;
            this.dateTimePicker_IssueDate.Value = new System.DateTime(2019, 12, 26, 0, 0, 0, 0);
            // 
            // button_OK
            // 
            this.button_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_OK.ForeColor = System.Drawing.Color.Blue;
            this.button_OK.Location = new System.Drawing.Point(55, 356);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(224, 44);
            this.button_OK.TabIndex = 10;
            this.button_OK.Text = "ОК";
            this.button_OK.UseVisualStyleBackColor = false;
            this.button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Cancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Cancel.Location = new System.Drawing.Point(119, 406);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(94, 25);
            this.button_Cancel.TabIndex = 11;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // comboBox_GoodId
            // 
            this.comboBox_GoodId.DataSource = this.typesOfProductsBindingSource;
            this.comboBox_GoodId.DisplayMember = "Name of the Product";
            this.comboBox_GoodId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_GoodId.FormattingEnabled = true;
            this.comboBox_GoodId.Location = new System.Drawing.Point(129, 147);
            this.comboBox_GoodId.Name = "comboBox_GoodId";
            this.comboBox_GoodId.Size = new System.Drawing.Size(177, 21);
            this.comboBox_GoodId.TabIndex = 4;
            this.comboBox_GoodId.ValueMember = "Id";
            this.comboBox_GoodId.SelectedIndexChanged += new System.EventHandler(this.ComboBox_GoodId_SelectedIndexChanged);
            // 
            // typesOfProductsBindingSource
            // 
            this.typesOfProductsBindingSource.DataMember = "Types of Products";
            this.typesOfProductsBindingSource.DataSource = this.bindingSource1;
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
            // comboBox_City
            // 
            this.comboBox_City.DataSource = this.deliveryBindingSource;
            this.comboBox_City.DisplayMember = "City";
            this.comboBox_City.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_City.FormattingEnabled = true;
            this.comboBox_City.Location = new System.Drawing.Point(129, 291);
            this.comboBox_City.Name = "comboBox_City";
            this.comboBox_City.Size = new System.Drawing.Size(177, 21);
            this.comboBox_City.TabIndex = 8;
            this.comboBox_City.ValueMember = "Id";
            // 
            // deliveryBindingSource
            // 
            this.deliveryBindingSource.DataMember = "Delivery";
            this.deliveryBindingSource.DataSource = this.bindingSource1;
            // 
            // types_of_ProductsTableAdapter
            // 
            this.types_of_ProductsTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox_ModelsId
            // 
            this.comboBox_ModelsId.DataSource = this.modelsBindingSource;
            this.comboBox_ModelsId.DisplayMember = "Model";
            this.comboBox_ModelsId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ModelsId.FormattingEnabled = true;
            this.comboBox_ModelsId.Location = new System.Drawing.Point(128, 183);
            this.comboBox_ModelsId.Name = "comboBox_ModelsId";
            this.comboBox_ModelsId.Size = new System.Drawing.Size(177, 21);
            this.comboBox_ModelsId.TabIndex = 5;
            this.comboBox_ModelsId.ValueMember = "Id";
            this.comboBox_ModelsId.SelectedIndexChanged += new System.EventHandler(this.ComboBox_ModelsId_SelectedIndexChanged);
            // 
            // modelsBindingSource
            // 
            this.modelsBindingSource.DataMember = "Models";
            this.modelsBindingSource.DataSource = this.bindingSource1;
            // 
            // comboBox_Employee
            // 
            this.comboBox_Employee.DataSource = this.employeesBindingSource;
            this.comboBox_Employee.DisplayMember = "Id";
            this.comboBox_Employee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Employee.FormattingEnabled = true;
            this.comboBox_Employee.Location = new System.Drawing.Point(128, 329);
            this.comboBox_Employee.Name = "comboBox_Employee";
            this.comboBox_Employee.Size = new System.Drawing.Size(177, 21);
            this.comboBox_Employee.TabIndex = 9;
            this.comboBox_Employee.ValueMember = "Id";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.bindingSource1;
            // 
            // modelsTableAdapter1
            // 
            this.modelsTableAdapter1.ClearBeforeFill = true;
            // 
            // deliveryTableAdapter1
            // 
            this.deliveryTableAdapter1.ClearBeforeFill = true;
            // 
            // employeesTableAdapter1
            // 
            this.employeesTableAdapter1.ClearBeforeFill = true;
            // 
            // issueTableAdapter1
            // 
            this.issueTableAdapter1.ClearBeforeFill = true;
            // 
            // EditIssueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 436);
            this.Controls.Add(this.comboBox_Employee);
            this.Controls.Add(this.comboBox_ModelsId);
            this.Controls.Add(this.comboBox_City);
            this.Controls.Add(this.comboBox_GoodId);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.dateTimePicker_IssueDate);
            this.Controls.Add(this.textBox_Surname);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.textBox_MiddleName);
            this.Controls.Add(this.textBox_Phone);
            this.Controls.Add(this.textBox_IssueId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelIssueId);
            this.Name = "EditIssueForm";
            this.Text = "Видача";
            ((System.ComponentModel.ISupportInitialize)(this.typesOfProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computer_Hardware_DepartmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIssueId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_IssueId;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.TextBox textBox_MiddleName;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Surname;
        private System.Windows.Forms.DateTimePicker dateTimePicker_IssueDate;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.ComboBox comboBox_GoodId;
        private System.Windows.Forms.ComboBox comboBox_City;
        private Computer_Hardware_DepartmentDataSet computer_Hardware_DepartmentDataSet;
        private Computer_Hardware_DepartmentDataSetTableAdapters.Types_of_ProductsTableAdapter types_of_ProductsTableAdapter;
        private System.Windows.Forms.ComboBox comboBox_ModelsId;
        private Computer_Hardware_DepartmentDataSetTableAdapters.ModelsTableAdapter modelsTableAdapter;
        private Computer_Hardware_DepartmentDataSetTableAdapters.DeliveryTableAdapter deliveryTableAdapter;
        private System.Windows.Forms.ComboBox comboBox_Employee;
        private Computer_Hardware_DepartmentDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Computer_Hardware_DepartmentDataSetTableAdapters.ModelsTableAdapter modelsTableAdapter1;
        private Computer_Hardware_DepartmentDataSetTableAdapters.DeliveryTableAdapter deliveryTableAdapter1;
        private Computer_Hardware_DepartmentDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter1;
        private Computer_Hardware_DepartmentDataSetTableAdapters.IssueTableAdapter issueTableAdapter1;
        private System.Windows.Forms.BindingSource typesOfProductsBindingSource;
        private System.Windows.Forms.BindingSource deliveryBindingSource;
        private System.Windows.Forms.BindingSource modelsBindingSource;
        private System.Windows.Forms.BindingSource employeesBindingSource;
    }
}