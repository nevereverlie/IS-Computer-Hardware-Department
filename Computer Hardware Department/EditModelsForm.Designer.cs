namespace Computer_Hardware_Department
{
    partial class EditModelsForm
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
            this.textBox_ModelsId = new System.Windows.Forms.TextBox();
            this.labelIssueId = new System.Windows.Forms.Label();
            this.textBox_Model = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.computer_Hardware_DepartmentDataSet = new Computer_Hardware_Department.Computer_Hardware_DepartmentDataSet();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliersTableAdapter = new Computer_Hardware_Department.Computer_Hardware_DepartmentDataSetTableAdapters.SuppliersTableAdapter();
            this.typesOfProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.types_of_ProductsTableAdapter = new Computer_Hardware_Department.Computer_Hardware_DepartmentDataSetTableAdapters.Types_of_ProductsTableAdapter();
            this.comboBox_Type = new System.Windows.Forms.ComboBox();
            this.comboBox_Supplier = new System.Windows.Forms.ComboBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.modelsTableAdapter1 = new Computer_Hardware_Department.Computer_Hardware_DepartmentDataSetTableAdapters.ModelsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computer_Hardware_DepartmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesOfProductsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_ModelsId
            // 
            this.textBox_ModelsId.Location = new System.Drawing.Point(129, 9);
            this.textBox_ModelsId.Name = "textBox_ModelsId";
            this.textBox_ModelsId.Size = new System.Drawing.Size(176, 20);
            this.textBox_ModelsId.TabIndex = 14;
            // 
            // labelIssueId
            // 
            this.labelIssueId.AutoSize = true;
            this.labelIssueId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIssueId.Location = new System.Drawing.Point(12, 9);
            this.labelIssueId.Name = "labelIssueId";
            this.labelIssueId.Size = new System.Drawing.Size(87, 20);
            this.labelIssueId.TabIndex = 13;
            this.labelIssueId.Text = "ID моделі:";
            // 
            // textBox_Model
            // 
            this.textBox_Model.Location = new System.Drawing.Point(129, 44);
            this.textBox_Model.Name = "textBox_Model";
            this.textBox_Model.Size = new System.Drawing.Size(176, 20);
            this.textBox_Model.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Компанія:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Вид товару:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Модель:";
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
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "Suppliers";
            this.suppliersBindingSource.DataSource = this.bindingSource1;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
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
            // comboBox_Type
            // 
            this.comboBox_Type.DataSource = this.typesOfProductsBindingSource;
            this.comboBox_Type.DisplayMember = "Name of the Product";
            this.comboBox_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Type.FormattingEnabled = true;
            this.comboBox_Type.Location = new System.Drawing.Point(128, 112);
            this.comboBox_Type.Name = "comboBox_Type";
            this.comboBox_Type.Size = new System.Drawing.Size(177, 21);
            this.comboBox_Type.TabIndex = 21;
            this.comboBox_Type.ValueMember = "Id";
            // 
            // comboBox_Supplier
            // 
            this.comboBox_Supplier.DataSource = this.suppliersBindingSource;
            this.comboBox_Supplier.DisplayMember = "Name";
            this.comboBox_Supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Supplier.FormattingEnabled = true;
            this.comboBox_Supplier.Location = new System.Drawing.Point(128, 76);
            this.comboBox_Supplier.Name = "comboBox_Supplier";
            this.comboBox_Supplier.Size = new System.Drawing.Size(177, 21);
            this.comboBox_Supplier.TabIndex = 22;
            this.comboBox_Supplier.ValueMember = "Id";
            this.comboBox_Supplier.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Supplier_SelectedIndexChanged);
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Cancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Cancel.Location = new System.Drawing.Point(101, 200);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(94, 25);
            this.button_Cancel.TabIndex = 24;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // button_OK
            // 
            this.button_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_OK.ForeColor = System.Drawing.Color.Blue;
            this.button_OK.Location = new System.Drawing.Point(37, 150);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(224, 44);
            this.button_OK.TabIndex = 23;
            this.button_OK.Text = "ОК";
            this.button_OK.UseVisualStyleBackColor = false;
            this.button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // modelsTableAdapter1
            // 
            this.modelsTableAdapter1.ClearBeforeFill = true;
            // 
            // EditModelsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 240);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.comboBox_Supplier);
            this.Controls.Add(this.comboBox_Type);
            this.Controls.Add(this.textBox_Model);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_ModelsId);
            this.Controls.Add(this.labelIssueId);
            this.Name = "EditModelsForm";
            this.Text = "Модель";
            this.Load += new System.EventHandler(this.EditModelsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computer_Hardware_DepartmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesOfProductsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ModelsId;
        private System.Windows.Forms.Label labelIssueId;
        private System.Windows.Forms.TextBox textBox_Model;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Computer_Hardware_DepartmentDataSet computer_Hardware_DepartmentDataSet;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private Computer_Hardware_DepartmentDataSetTableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        private System.Windows.Forms.BindingSource typesOfProductsBindingSource;
        private Computer_Hardware_DepartmentDataSetTableAdapters.Types_of_ProductsTableAdapter types_of_ProductsTableAdapter;
        private System.Windows.Forms.ComboBox comboBox_Type;
        private System.Windows.Forms.ComboBox comboBox_Supplier;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_OK;
        private Computer_Hardware_DepartmentDataSetTableAdapters.ModelsTableAdapter modelsTableAdapter1;
    }
}