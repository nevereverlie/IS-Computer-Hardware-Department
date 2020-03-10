namespace Computer_Hardware_Department
{
    partial class EditSuppliesForm
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
            this.comboBox_ToCity = new System.Windows.Forms.ComboBox();
            this.deliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.computer_Hardware_DepartmentDataSet = new Computer_Hardware_Department.Computer_Hardware_DepartmentDataSet();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.textBox_Amount = new System.Windows.Forms.TextBox();
            this.textBox_SupplyId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelIssueId = new System.Windows.Forms.Label();
            this.comboBox_Model = new System.Windows.Forms.ComboBox();
            this.modelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.modelsTableAdapter = new Computer_Hardware_Department.Computer_Hardware_DepartmentDataSetTableAdapters.ModelsTableAdapter();
            this.deliveryTableAdapter = new Computer_Hardware_Department.Computer_Hardware_DepartmentDataSetTableAdapters.DeliveryTableAdapter();
            this.supplyTableAdapter1 = new Computer_Hardware_Department.Computer_Hardware_DepartmentDataSetTableAdapters.SupplyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computer_Hardware_DepartmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_ToCity
            // 
            this.comboBox_ToCity.DataSource = this.deliveryBindingSource;
            this.comboBox_ToCity.DisplayMember = "City";
            this.comboBox_ToCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ToCity.FormattingEnabled = true;
            this.comboBox_ToCity.Location = new System.Drawing.Point(129, 147);
            this.comboBox_ToCity.Name = "comboBox_ToCity";
            this.comboBox_ToCity.Size = new System.Drawing.Size(177, 21);
            this.comboBox_ToCity.TabIndex = 18;
            this.comboBox_ToCity.ValueMember = "Id";
            // 
            // deliveryBindingSource
            // 
            this.deliveryBindingSource.DataMember = "Delivery";
            this.deliveryBindingSource.DataSource = this.bindingSource1;
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
            // textBox_Price
            // 
            this.textBox_Price.Location = new System.Drawing.Point(129, 77);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(176, 20);
            this.textBox_Price.TabIndex = 16;
            // 
            // textBox_Amount
            // 
            this.textBox_Amount.Location = new System.Drawing.Point(129, 113);
            this.textBox_Amount.Name = "textBox_Amount";
            this.textBox_Amount.Size = new System.Drawing.Size(176, 20);
            this.textBox_Amount.TabIndex = 17;
            // 
            // textBox_SupplyId
            // 
            this.textBox_SupplyId.Location = new System.Drawing.Point(129, 9);
            this.textBox_SupplyId.Name = "textBox_SupplyId";
            this.textBox_SupplyId.Size = new System.Drawing.Size(176, 20);
            this.textBox_SupplyId.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Ціна моделі:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Кількість:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "До міста:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Модель:";
            // 
            // labelIssueId
            // 
            this.labelIssueId.AutoSize = true;
            this.labelIssueId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIssueId.Location = new System.Drawing.Point(12, 9);
            this.labelIssueId.Name = "labelIssueId";
            this.labelIssueId.Size = new System.Drawing.Size(117, 20);
            this.labelIssueId.TabIndex = 13;
            this.labelIssueId.Text = "Код поставки:";
            // 
            // comboBox_Model
            // 
            this.comboBox_Model.DataSource = this.modelsBindingSource;
            this.comboBox_Model.DisplayMember = "Model";
            this.comboBox_Model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Model.FormattingEnabled = true;
            this.comboBox_Model.Location = new System.Drawing.Point(129, 43);
            this.comboBox_Model.Name = "comboBox_Model";
            this.comboBox_Model.Size = new System.Drawing.Size(177, 21);
            this.comboBox_Model.TabIndex = 23;
            this.comboBox_Model.ValueMember = "Id";
            // 
            // modelsBindingSource
            // 
            this.modelsBindingSource.DataMember = "Models";
            this.modelsBindingSource.DataSource = this.bindingSource1;
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Cancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Cancel.Location = new System.Drawing.Point(108, 233);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(94, 25);
            this.button_Cancel.TabIndex = 26;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // button_OK
            // 
            this.button_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_OK.ForeColor = System.Drawing.Color.Blue;
            this.button_OK.Location = new System.Drawing.Point(44, 183);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(224, 44);
            this.button_OK.TabIndex = 25;
            this.button_OK.Text = "ОК";
            this.button_OK.UseVisualStyleBackColor = false;
            this.button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // modelsTableAdapter
            // 
            this.modelsTableAdapter.ClearBeforeFill = true;
            // 
            // deliveryTableAdapter
            // 
            this.deliveryTableAdapter.ClearBeforeFill = true;
            // 
            // supplyTableAdapter1
            // 
            this.supplyTableAdapter1.ClearBeforeFill = true;
            // 
            // EditSuppliesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 275);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.comboBox_Model);
            this.Controls.Add(this.comboBox_ToCity);
            this.Controls.Add(this.textBox_Price);
            this.Controls.Add(this.textBox_Amount);
            this.Controls.Add(this.textBox_SupplyId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelIssueId);
            this.Name = "EditSuppliesForm";
            this.Text = "Поставка";
            this.Load += new System.EventHandler(this.EditSuppliesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computer_Hardware_DepartmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_ToCity;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.TextBox textBox_Amount;
        private System.Windows.Forms.TextBox textBox_SupplyId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelIssueId;
        private System.Windows.Forms.ComboBox comboBox_Model;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Computer_Hardware_DepartmentDataSet computer_Hardware_DepartmentDataSet;
        private System.Windows.Forms.BindingSource modelsBindingSource;
        private Computer_Hardware_DepartmentDataSetTableAdapters.ModelsTableAdapter modelsTableAdapter;
        private System.Windows.Forms.BindingSource deliveryBindingSource;
        private Computer_Hardware_DepartmentDataSetTableAdapters.DeliveryTableAdapter deliveryTableAdapter;
        private Computer_Hardware_DepartmentDataSetTableAdapters.SupplyTableAdapter supplyTableAdapter1;
    }
}