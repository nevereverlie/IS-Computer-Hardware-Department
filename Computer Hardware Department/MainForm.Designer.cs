namespace Computer_Hardware_Department
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.computer_Hardware_DepartmentDataSet = new Computer_Hardware_Department.Computer_Hardware_DepartmentDataSet();
            this.modelsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typesOfProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportSellsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.поставкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceAdjustmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typesOfProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonRed = new System.Windows.Forms.Button();
            this.groupBoxRequests = new System.Windows.Forms.GroupBox();
            this.buttonRandReq = new System.Windows.Forms.Button();
            this.buttonReqNVIDIA = new System.Windows.Forms.Button();
            this.buttonReqDelivery = new System.Windows.Forms.Button();
            this.buttonReqToCity = new System.Windows.Forms.Button();
            this.textBoxReqToCity = new System.Windows.Forms.TextBox();
            this.groupBoxFiltr = new System.Windows.Forms.GroupBox();
            this.buttonCancelFilters = new System.Windows.Forms.Button();
            this.buttonApplyFilters = new System.Windows.Forms.Button();
            this.comboBoxFilterEmployee = new System.Windows.Forms.ComboBox();
            this.labelEmployee = new System.Windows.Forms.Label();
            this.textBoxFilterPrice2 = new System.Windows.Forms.TextBox();
            this.labelPriceTo = new System.Windows.Forms.Label();
            this.textBoxFilterPrice1 = new System.Windows.Forms.TextBox();
            this.labelPriceFrom = new System.Windows.Forms.Label();
            this.labelModelPrice = new System.Windows.Forms.Label();
            this.buttonIssue = new System.Windows.Forms.Button();
            this.buttonModels = new System.Windows.Forms.Button();
            this.buttonSupplies = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.suppliersTableAdapter = new Computer_Hardware_Department.Computer_Hardware_DepartmentDataSetTableAdapters.SuppliersTableAdapter();
            this.types_of_ProductsTableAdapter = new Computer_Hardware_Department.Computer_Hardware_DepartmentDataSetTableAdapters.Types_of_ProductsTableAdapter();
            this.modelsTableAdapter = new Computer_Hardware_Department.Computer_Hardware_DepartmentDataSetTableAdapters.ModelsTableAdapter();
            this.issueTableAdapter = new Computer_Hardware_Department.Computer_Hardware_DepartmentDataSetTableAdapters.IssueTableAdapter();
            this.supplyTableAdapter = new Computer_Hardware_Department.Computer_Hardware_DepartmentDataSetTableAdapters.SupplyTableAdapter();
            this.deliveryTableAdapter = new Computer_Hardware_Department.Computer_Hardware_DepartmentDataSetTableAdapters.DeliveryTableAdapter();
            this.employeesTableAdapter = new Computer_Hardware_Department.Computer_Hardware_DepartmentDataSetTableAdapters.EmployeesTableAdapter();
            this.fKIssueToTableEmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSuppliers = new System.Windows.Forms.Button();
            this.buttonTypes = new System.Windows.Forms.Button();
            this.buttonEmployees = new System.Windows.Forms.Button();
            this.buttonDelivery = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computer_Hardware_DepartmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesOfProductsBindingSource)).BeginInit();
            this.groupBoxRequests.SuspendLayout();
            this.groupBoxFiltr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKIssueToTableEmployeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.AllowUserToAddRows = false;
            this.dataGridViewMain.AllowUserToDeleteRows = false;
            this.dataGridViewMain.AllowUserToResizeRows = false;
            this.dataGridViewMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMain.AutoGenerateColumns = false;
            this.dataGridViewMain.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.goodsIdDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.issueDateDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.employeesIdDataGridViewTextBoxColumn});
            this.dataGridViewMain.DataSource = this.issueBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMain.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewMain.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewMain.Location = new System.Drawing.Point(12, 166);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMain.Size = new System.Drawing.Size(1095, 359);
            this.dataGridViewMain.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 72;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.Width = 120;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 120;
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "Middle Name";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "Middle Name";
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            this.middleNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // goodsIdDataGridViewTextBoxColumn
            // 
            this.goodsIdDataGridViewTextBoxColumn.DataPropertyName = "Good\'s Id";
            this.goodsIdDataGridViewTextBoxColumn.HeaderText = "Good\'s Id";
            this.goodsIdDataGridViewTextBoxColumn.Name = "goodsIdDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // issueDateDataGridViewTextBoxColumn
            // 
            this.issueDateDataGridViewTextBoxColumn.DataPropertyName = "Issue Date";
            this.issueDateDataGridViewTextBoxColumn.HeaderText = "Issue Date";
            this.issueDateDataGridViewTextBoxColumn.Name = "issueDateDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // employeesIdDataGridViewTextBoxColumn
            // 
            this.employeesIdDataGridViewTextBoxColumn.DataPropertyName = "Employee\'s Id";
            this.employeesIdDataGridViewTextBoxColumn.HeaderText = "Employee\'s Id";
            this.employeesIdDataGridViewTextBoxColumn.Name = "employeesIdDataGridViewTextBoxColumn";
            // 
            // issueBindingSource
            // 
            this.issueBindingSource.DataMember = "Issue";
            this.issueBindingSource.DataSource = this.bindingSource1;
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
            // modelsBindingSource1
            // 
            this.modelsBindingSource1.DataSource = this.bindingSource1;
            this.modelsBindingSource1.Position = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.databaseToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1490, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Вихід";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modelsToolStripMenuItem,
            this.suppliersToolStripMenuItem,
            this.typesOfProductsToolStripMenuItem,
            this.supplyToolStripMenuItem,
            this.employeesToolStripMenuItem,
            this.deliveryToolStripMenuItem,
            this.issueToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.databaseToolStripMenuItem.Text = "База даних";
            // 
            // modelsToolStripMenuItem
            // 
            this.modelsToolStripMenuItem.Name = "modelsToolStripMenuItem";
            this.modelsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.modelsToolStripMenuItem.Text = "Моделі";
            this.modelsToolStripMenuItem.Click += new System.EventHandler(this.ModelsToolStripMenuItem_Click);
            // 
            // suppliersToolStripMenuItem
            // 
            this.suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            this.suppliersToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.suppliersToolStripMenuItem.Text = "Постачальники";
            this.suppliersToolStripMenuItem.Click += new System.EventHandler(this.SuppliersToolStripMenuItem_Click);
            // 
            // typesOfProductsToolStripMenuItem
            // 
            this.typesOfProductsToolStripMenuItem.Name = "typesOfProductsToolStripMenuItem";
            this.typesOfProductsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.typesOfProductsToolStripMenuItem.Text = "Види товарів";
            this.typesOfProductsToolStripMenuItem.Click += new System.EventHandler(this.TypesOfProductsToolStripMenuItem_Click);
            // 
            // supplyToolStripMenuItem
            // 
            this.supplyToolStripMenuItem.Name = "supplyToolStripMenuItem";
            this.supplyToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.supplyToolStripMenuItem.Text = "Поставки";
            this.supplyToolStripMenuItem.Click += new System.EventHandler(this.SupplyToolStripMenuItem_Click);
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.employeesToolStripMenuItem.Text = "Співробітники";
            this.employeesToolStripMenuItem.Click += new System.EventHandler(this.EmployeesToolStripMenuItem_Click);
            // 
            // deliveryToolStripMenuItem
            // 
            this.deliveryToolStripMenuItem.Name = "deliveryToolStripMenuItem";
            this.deliveryToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.deliveryToolStripMenuItem.Text = "Доставка";
            this.deliveryToolStripMenuItem.Click += new System.EventHandler(this.DeliveryToolStripMenuItem_Click);
            // 
            // issueToolStripMenuItem
            // 
            this.issueToolStripMenuItem.Name = "issueToolStripMenuItem";
            this.issueToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.issueToolStripMenuItem.Text = "Видача";
            this.issueToolStripMenuItem.Click += new System.EventHandler(this.IssueToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportSellsToolStripMenuItem,
            this.toolStripSeparator1,
            this.поставкиToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.reportsToolStripMenuItem.Text = "Звіти...";
            // 
            // reportSellsToolStripMenuItem
            // 
            this.reportSellsToolStripMenuItem.Name = "reportSellsToolStripMenuItem";
            this.reportSellsToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.reportSellsToolStripMenuItem.Text = "Продажі";
            this.reportSellsToolStripMenuItem.Click += new System.EventHandler(this.ReportSellsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(123, 6);
            // 
            // поставкиToolStripMenuItem
            // 
            this.поставкиToolStripMenuItem.Name = "поставкиToolStripMenuItem";
            this.поставкиToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.поставкиToolStripMenuItem.Text = "Поставки";
            this.поставкиToolStripMenuItem.Click += new System.EventHandler(this.ПоставкиToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.queriesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.helpToolStripMenuItem.Text = "Статистики...";
            // 
            // queriesToolStripMenuItem
            // 
            this.queriesToolStripMenuItem.Name = "queriesToolStripMenuItem";
            this.queriesToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.queriesToolStripMenuItem.Text = "Переглянути";
            this.queriesToolStripMenuItem.Click += new System.EventHandler(this.QueriesToolStripMenuItem_Click);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.priceAdjustmentToolStripMenuItem});
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.aToolStripMenuItem.Text = "Адміністратор";
            // 
            // priceAdjustmentToolStripMenuItem
            // 
            this.priceAdjustmentToolStripMenuItem.Name = "priceAdjustmentToolStripMenuItem";
            this.priceAdjustmentToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.priceAdjustmentToolStripMenuItem.Text = "Регулювання цін";
            this.priceAdjustmentToolStripMenuItem.Click += new System.EventHandler(this.PriceAdjustmentToolStripMenuItem_Click);
            // 
            // supplyBindingSource
            // 
            this.supplyBindingSource.DataMember = "Supply";
            this.supplyBindingSource.DataSource = this.bindingSource1;
            // 
            // deliveryBindingSource
            // 
            this.deliveryBindingSource.DataMember = "Delivery";
            this.deliveryBindingSource.DataSource = this.bindingSource1;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.bindingSource1;
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "Suppliers";
            this.suppliersBindingSource.DataSource = this.bindingSource1;
            // 
            // typesOfProductsBindingSource
            // 
            this.typesOfProductsBindingSource.DataMember = "Types of Products";
            this.typesOfProductsBindingSource.DataSource = this.bindingSource1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAdd.FlatAppearance.BorderSize = 2;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.Color.Blue;
            this.buttonAdd.Location = new System.Drawing.Point(12, 531);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(341, 62);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "ДОДАТИ";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonDel.FlatAppearance.BorderSize = 2;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDel.Location = new System.Drawing.Point(876, 531);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(231, 62);
            this.buttonDel.TabIndex = 10;
            this.buttonDel.Text = "ВИДАЛИТИ";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // buttonRed
            // 
            this.buttonRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRed.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonRed.FlatAppearance.BorderSize = 2;
            this.buttonRed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRed.ForeColor = System.Drawing.Color.Black;
            this.buttonRed.Location = new System.Drawing.Point(639, 531);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(231, 62);
            this.buttonRed.TabIndex = 11;
            this.buttonRed.Text = "РЕДАГУВАТИ";
            this.buttonRed.UseVisualStyleBackColor = false;
            this.buttonRed.Click += new System.EventHandler(this.ButtonRed_Click);
            // 
            // groupBoxRequests
            // 
            this.groupBoxRequests.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBoxRequests.BackColor = System.Drawing.Color.White;
            this.groupBoxRequests.Controls.Add(this.buttonRandReq);
            this.groupBoxRequests.Controls.Add(this.buttonReqNVIDIA);
            this.groupBoxRequests.Controls.Add(this.buttonReqDelivery);
            this.groupBoxRequests.Controls.Add(this.buttonReqToCity);
            this.groupBoxRequests.Controls.Add(this.textBoxReqToCity);
            this.groupBoxRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxRequests.Location = new System.Drawing.Point(1125, 166);
            this.groupBoxRequests.Name = "groupBoxRequests";
            this.groupBoxRequests.Size = new System.Drawing.Size(303, 223);
            this.groupBoxRequests.TabIndex = 12;
            this.groupBoxRequests.TabStop = false;
            this.groupBoxRequests.Text = "Запити";
            // 
            // buttonRandReq
            // 
            this.buttonRandReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRandReq.Location = new System.Drawing.Point(6, 175);
            this.buttonRandReq.Name = "buttonRandReq";
            this.buttonRandReq.Size = new System.Drawing.Size(291, 37);
            this.buttonRandReq.TabIndex = 25;
            this.buttonRandReq.Text = "Довільний запит";
            this.buttonRandReq.UseVisualStyleBackColor = true;
            this.buttonRandReq.Click += new System.EventHandler(this.ButtonRandReq_Click);
            // 
            // buttonReqNVIDIA
            // 
            this.buttonReqNVIDIA.Location = new System.Drawing.Point(27, 133);
            this.buttonReqNVIDIA.Name = "buttonReqNVIDIA";
            this.buttonReqNVIDIA.Size = new System.Drawing.Size(249, 31);
            this.buttonReqNVIDIA.TabIndex = 24;
            this.buttonReqNVIDIA.Text = "Продаж: NVIDIA";
            this.buttonReqNVIDIA.UseVisualStyleBackColor = true;
            this.buttonReqNVIDIA.Click += new System.EventHandler(this.ButtonReqNVIDIA_Click);
            // 
            // buttonReqDelivery
            // 
            this.buttonReqDelivery.Location = new System.Drawing.Point(27, 96);
            this.buttonReqDelivery.Name = "buttonReqDelivery";
            this.buttonReqDelivery.Size = new System.Drawing.Size(249, 31);
            this.buttonReqDelivery.TabIndex = 23;
            this.buttonReqDelivery.Text = "Безкоштовна доставка";
            this.buttonReqDelivery.UseVisualStyleBackColor = true;
            this.buttonReqDelivery.Click += new System.EventHandler(this.ButtonReqDelivery_Click);
            // 
            // buttonReqToCity
            // 
            this.buttonReqToCity.Location = new System.Drawing.Point(27, 62);
            this.buttonReqToCity.Name = "buttonReqToCity";
            this.buttonReqToCity.Size = new System.Drawing.Size(249, 31);
            this.buttonReqToCity.TabIndex = 22;
            this.buttonReqToCity.Text = "Товари до міста:";
            this.buttonReqToCity.UseVisualStyleBackColor = true;
            this.buttonReqToCity.Click += new System.EventHandler(this.ButtonReqToCity_Click);
            // 
            // textBoxReqToCity
            // 
            this.textBoxReqToCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxReqToCity.Location = new System.Drawing.Point(27, 26);
            this.textBoxReqToCity.Name = "textBoxReqToCity";
            this.textBoxReqToCity.Size = new System.Drawing.Size(249, 29);
            this.textBoxReqToCity.TabIndex = 2;
            // 
            // groupBoxFiltr
            // 
            this.groupBoxFiltr.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBoxFiltr.BackColor = System.Drawing.Color.White;
            this.groupBoxFiltr.Controls.Add(this.buttonCancelFilters);
            this.groupBoxFiltr.Controls.Add(this.buttonApplyFilters);
            this.groupBoxFiltr.Controls.Add(this.comboBoxFilterEmployee);
            this.groupBoxFiltr.Controls.Add(this.labelEmployee);
            this.groupBoxFiltr.Controls.Add(this.textBoxFilterPrice2);
            this.groupBoxFiltr.Controls.Add(this.labelPriceTo);
            this.groupBoxFiltr.Controls.Add(this.textBoxFilterPrice1);
            this.groupBoxFiltr.Controls.Add(this.labelPriceFrom);
            this.groupBoxFiltr.Controls.Add(this.labelModelPrice);
            this.groupBoxFiltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxFiltr.Location = new System.Drawing.Point(1125, 395);
            this.groupBoxFiltr.Name = "groupBoxFiltr";
            this.groupBoxFiltr.Size = new System.Drawing.Size(303, 198);
            this.groupBoxFiltr.TabIndex = 13;
            this.groupBoxFiltr.TabStop = false;
            this.groupBoxFiltr.Text = "Фільтрація";
            // 
            // buttonCancelFilters
            // 
            this.buttonCancelFilters.Location = new System.Drawing.Point(157, 155);
            this.buttonCancelFilters.Name = "buttonCancelFilters";
            this.buttonCancelFilters.Size = new System.Drawing.Size(140, 31);
            this.buttonCancelFilters.TabIndex = 7;
            this.buttonCancelFilters.Text = "Сброс";
            this.buttonCancelFilters.UseVisualStyleBackColor = true;
            this.buttonCancelFilters.Click += new System.EventHandler(this.ButtonCancelFilters_Click);
            // 
            // buttonApplyFilters
            // 
            this.buttonApplyFilters.Location = new System.Drawing.Point(10, 155);
            this.buttonApplyFilters.Name = "buttonApplyFilters";
            this.buttonApplyFilters.Size = new System.Drawing.Size(140, 31);
            this.buttonApplyFilters.TabIndex = 6;
            this.buttonApplyFilters.Text = "Застосувати";
            this.buttonApplyFilters.UseVisualStyleBackColor = true;
            this.buttonApplyFilters.Click += new System.EventHandler(this.ButtonApplyFilters_Click);
            // 
            // comboBoxFilterEmployee
            // 
            this.comboBoxFilterEmployee.DataSource = this.employeesBindingSource;
            this.comboBoxFilterEmployee.DisplayMember = "Surname";
            this.comboBoxFilterEmployee.FormattingEnabled = true;
            this.comboBoxFilterEmployee.Location = new System.Drawing.Point(10, 111);
            this.comboBoxFilterEmployee.Name = "comboBoxFilterEmployee";
            this.comboBoxFilterEmployee.Size = new System.Drawing.Size(287, 28);
            this.comboBoxFilterEmployee.TabIndex = 5;
            this.comboBoxFilterEmployee.ValueMember = "Id";
            this.comboBoxFilterEmployee.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFilterEmployee_SelectedIndexChanged);
            // 
            // labelEmployee
            // 
            this.labelEmployee.AutoSize = true;
            this.labelEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmployee.Location = new System.Drawing.Point(7, 90);
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(192, 18);
            this.labelEmployee.TabIndex = 5;
            this.labelEmployee.Text = "Відповідальний за видачу:";
            // 
            // textBoxFilterPrice2
            // 
            this.textBoxFilterPrice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFilterPrice2.Location = new System.Drawing.Point(192, 52);
            this.textBoxFilterPrice2.Name = "textBoxFilterPrice2";
            this.textBoxFilterPrice2.Size = new System.Drawing.Size(100, 24);
            this.textBoxFilterPrice2.TabIndex = 4;
            // 
            // labelPriceTo
            // 
            this.labelPriceTo.AutoSize = true;
            this.labelPriceTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPriceTo.Location = new System.Drawing.Point(153, 55);
            this.labelPriceTo.Name = "labelPriceTo";
            this.labelPriceTo.Size = new System.Drawing.Size(33, 18);
            this.labelPriceTo.TabIndex = 3;
            this.labelPriceTo.Text = "До:";
            // 
            // textBoxFilterPrice1
            // 
            this.textBoxFilterPrice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFilterPrice1.Location = new System.Drawing.Point(47, 52);
            this.textBoxFilterPrice1.Name = "textBoxFilterPrice1";
            this.textBoxFilterPrice1.Size = new System.Drawing.Size(100, 24);
            this.textBoxFilterPrice1.TabIndex = 3;
            // 
            // labelPriceFrom
            // 
            this.labelPriceFrom.AutoSize = true;
            this.labelPriceFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPriceFrom.Location = new System.Drawing.Point(7, 55);
            this.labelPriceFrom.Name = "labelPriceFrom";
            this.labelPriceFrom.Size = new System.Drawing.Size(34, 18);
            this.labelPriceFrom.TabIndex = 1;
            this.labelPriceFrom.Text = "Від:";
            // 
            // labelModelPrice
            // 
            this.labelModelPrice.AutoSize = true;
            this.labelModelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelModelPrice.Location = new System.Drawing.Point(7, 26);
            this.labelModelPrice.Name = "labelModelPrice";
            this.labelModelPrice.Size = new System.Drawing.Size(162, 18);
            this.labelModelPrice.TabIndex = 0;
            this.labelModelPrice.Text = "За ціною моделі (грн):";
            // 
            // buttonIssue
            // 
            this.buttonIssue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonIssue.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonIssue.FlatAppearance.BorderSize = 2;
            this.buttonIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonIssue.ForeColor = System.Drawing.Color.Black;
            this.buttonIssue.Location = new System.Drawing.Point(12, 48);
            this.buttonIssue.Name = "buttonIssue";
            this.buttonIssue.Size = new System.Drawing.Size(242, 94);
            this.buttonIssue.TabIndex = 14;
            this.buttonIssue.Text = "Продажі";
            this.buttonIssue.UseVisualStyleBackColor = false;
            this.buttonIssue.Click += new System.EventHandler(this.ButtonIssue_Click);
            // 
            // buttonModels
            // 
            this.buttonModels.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonModels.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonModels.FlatAppearance.BorderSize = 2;
            this.buttonModels.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonModels.ForeColor = System.Drawing.Color.Black;
            this.buttonModels.Location = new System.Drawing.Point(260, 48);
            this.buttonModels.Name = "buttonModels";
            this.buttonModels.Size = new System.Drawing.Size(244, 94);
            this.buttonModels.TabIndex = 15;
            this.buttonModels.Text = "Моделі";
            this.buttonModels.UseVisualStyleBackColor = false;
            this.buttonModels.Click += new System.EventHandler(this.ButtonModels_Click);
            // 
            // buttonSupplies
            // 
            this.buttonSupplies.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSupplies.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSupplies.FlatAppearance.BorderSize = 2;
            this.buttonSupplies.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSupplies.ForeColor = System.Drawing.Color.Black;
            this.buttonSupplies.Location = new System.Drawing.Point(510, 48);
            this.buttonSupplies.Name = "buttonSupplies";
            this.buttonSupplies.Size = new System.Drawing.Size(233, 94);
            this.buttonSupplies.TabIndex = 16;
            this.buttonSupplies.Text = "Поставки";
            this.buttonSupplies.UseVisualStyleBackColor = false;
            this.buttonSupplies.Click += new System.EventHandler(this.ButtonSupplies_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.Location = new System.Drawing.Point(1125, 48);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(303, 40);
            this.textBoxSearch.TabIndex = 1;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Location = new System.Drawing.Point(1125, 94);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(303, 48);
            this.buttonSearch.TabIndex = 18;
            this.buttonSearch.Text = "ПОШУК";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // types_of_ProductsTableAdapter
            // 
            this.types_of_ProductsTableAdapter.ClearBeforeFill = true;
            // 
            // modelsTableAdapter
            // 
            this.modelsTableAdapter.ClearBeforeFill = true;
            // 
            // issueTableAdapter
            // 
            this.issueTableAdapter.ClearBeforeFill = true;
            // 
            // supplyTableAdapter
            // 
            this.supplyTableAdapter.ClearBeforeFill = true;
            // 
            // deliveryTableAdapter
            // 
            this.deliveryTableAdapter.ClearBeforeFill = true;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // fKIssueToTableEmployeesBindingSource
            // 
            this.fKIssueToTableEmployeesBindingSource.DataMember = "FK_Issue_ToTableEmployees";
            this.fKIssueToTableEmployeesBindingSource.DataSource = this.employeesBindingSource;
            // 
            // buttonSuppliers
            // 
            this.buttonSuppliers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSuppliers.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSuppliers.FlatAppearance.BorderSize = 2;
            this.buttonSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSuppliers.ForeColor = System.Drawing.Color.Black;
            this.buttonSuppliers.Location = new System.Drawing.Point(749, 49);
            this.buttonSuppliers.Name = "buttonSuppliers";
            this.buttonSuppliers.Size = new System.Drawing.Size(179, 40);
            this.buttonSuppliers.TabIndex = 19;
            this.buttonSuppliers.Text = "Постачальники";
            this.buttonSuppliers.UseVisualStyleBackColor = false;
            this.buttonSuppliers.Click += new System.EventHandler(this.ButtonSuppliers_Click);
            // 
            // buttonTypes
            // 
            this.buttonTypes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonTypes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonTypes.FlatAppearance.BorderSize = 2;
            this.buttonTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTypes.ForeColor = System.Drawing.Color.Black;
            this.buttonTypes.Location = new System.Drawing.Point(928, 49);
            this.buttonTypes.Name = "buttonTypes";
            this.buttonTypes.Size = new System.Drawing.Size(179, 40);
            this.buttonTypes.TabIndex = 20;
            this.buttonTypes.Text = "Види товарів";
            this.buttonTypes.UseVisualStyleBackColor = false;
            this.buttonTypes.Click += new System.EventHandler(this.ButtonTypes_Click);
            // 
            // buttonEmployees
            // 
            this.buttonEmployees.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonEmployees.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonEmployees.FlatAppearance.BorderSize = 2;
            this.buttonEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEmployees.ForeColor = System.Drawing.Color.Black;
            this.buttonEmployees.Location = new System.Drawing.Point(749, 98);
            this.buttonEmployees.Name = "buttonEmployees";
            this.buttonEmployees.Size = new System.Drawing.Size(179, 40);
            this.buttonEmployees.TabIndex = 21;
            this.buttonEmployees.Text = "Співробітники";
            this.buttonEmployees.UseVisualStyleBackColor = false;
            this.buttonEmployees.Click += new System.EventHandler(this.ButtonEmployees_Click);
            // 
            // buttonDelivery
            // 
            this.buttonDelivery.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonDelivery.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonDelivery.FlatAppearance.BorderSize = 2;
            this.buttonDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelivery.ForeColor = System.Drawing.Color.Black;
            this.buttonDelivery.Location = new System.Drawing.Point(928, 98);
            this.buttonDelivery.Name = "buttonDelivery";
            this.buttonDelivery.Size = new System.Drawing.Size(179, 40);
            this.buttonDelivery.TabIndex = 22;
            this.buttonDelivery.Text = "Доставка";
            this.buttonDelivery.UseVisualStyleBackColor = false;
            this.buttonDelivery.Click += new System.EventHandler(this.ButtonDelivery_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSort.BackColor = System.Drawing.Color.White;
            this.buttonSort.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSort.BackgroundImage")));
            this.buttonSort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSort.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSort.FlatAppearance.BorderSize = 2;
            this.buttonSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSort.ForeColor = System.Drawing.Color.Black;
            this.buttonSort.Location = new System.Drawing.Point(489, 531);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(69, 62);
            this.buttonSort.TabIndex = 23;
            this.buttonSort.UseVisualStyleBackColor = false;
            this.buttonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // buttonFilter
            // 
            this.buttonFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonFilter.BackColor = System.Drawing.Color.White;
            this.buttonFilter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonFilter.BackgroundImage")));
            this.buttonFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFilter.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonFilter.FlatAppearance.BorderSize = 2;
            this.buttonFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFilter.ForeColor = System.Drawing.Color.Black;
            this.buttonFilter.Location = new System.Drawing.Point(564, 531);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(69, 62);
            this.buttonFilter.TabIndex = 24;
            this.buttonFilter.UseVisualStyleBackColor = false;
            this.buttonFilter.Click += new System.EventHandler(this.ButtonFilter_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1490, 605);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonDelivery);
            this.Controls.Add(this.buttonEmployees);
            this.Controls.Add(this.buttonTypes);
            this.Controls.Add(this.buttonSuppliers);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonSupplies);
            this.Controls.Add(this.buttonModels);
            this.Controls.Add(this.buttonIssue);
            this.Controls.Add(this.groupBoxFiltr);
            this.Controls.Add(this.groupBoxRequests);
            this.Controls.Add(this.buttonRed);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridViewMain);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Головна сторінка";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computer_Hardware_DepartmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesOfProductsBindingSource)).EndInit();
            this.groupBoxRequests.ResumeLayout(false);
            this.groupBoxRequests.PerformLayout();
            this.groupBoxFiltr.ResumeLayout(false);
            this.groupBoxFiltr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKIssueToTableEmployeesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private Computer_Hardware_DepartmentDataSet computer_Hardware_DepartmentDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDateDataGridViewTextBoxColumn;
        private Computer_Hardware_DepartmentDataSetTableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        private Computer_Hardware_DepartmentDataSetTableAdapters.Types_of_ProductsTableAdapter types_of_ProductsTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typesOfProductsToolStripMenuItem;
        private System.Windows.Forms.BindingSource modelsBindingSource1;
        private Computer_Hardware_DepartmentDataSetTableAdapters.ModelsTableAdapter modelsTableAdapter;
        private System.Windows.Forms.BindingSource issueBindingSource;
        private Computer_Hardware_DepartmentDataSetTableAdapters.IssueTableAdapter issueTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem supplyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueToolStripMenuItem;
        private System.Windows.Forms.BindingSource supplyBindingSource;
        private Computer_Hardware_DepartmentDataSetTableAdapters.SupplyTableAdapter supplyTableAdapter;
        private System.Windows.Forms.BindingSource deliveryBindingSource;
        private Computer_Hardware_DepartmentDataSetTableAdapters.DeliveryTableAdapter deliveryTableAdapter;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private Computer_Hardware_DepartmentDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private System.Windows.Forms.BindingSource typesOfProductsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeesIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.GroupBox groupBoxRequests;
        private System.Windows.Forms.Button buttonRandReq;
        private System.Windows.Forms.Button buttonReqNVIDIA;
        private System.Windows.Forms.Button buttonReqDelivery;
        private System.Windows.Forms.Button buttonReqToCity;
        private System.Windows.Forms.TextBox textBoxReqToCity;
        private System.Windows.Forms.GroupBox groupBoxFiltr;
        private System.Windows.Forms.Button buttonIssue;
        private System.Windows.Forms.Button buttonModels;
        private System.Windows.Forms.Button buttonSupplies;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonCancelFilters;
        private System.Windows.Forms.Button buttonApplyFilters;
        private System.Windows.Forms.ComboBox comboBoxFilterEmployee;
        private System.Windows.Forms.Label labelEmployee;
        private System.Windows.Forms.TextBox textBoxFilterPrice2;
        private System.Windows.Forms.Label labelPriceTo;
        private System.Windows.Forms.TextBox textBoxFilterPrice1;
        private System.Windows.Forms.Label labelPriceFrom;
        private System.Windows.Forms.Label labelModelPrice;
        private System.Windows.Forms.BindingSource fKIssueToTableEmployeesBindingSource;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportSellsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поставкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priceAdjustmentToolStripMenuItem;
        private System.Windows.Forms.Button buttonSuppliers;
        private System.Windows.Forms.Button buttonTypes;
        private System.Windows.Forms.Button buttonEmployees;
        private System.Windows.Forms.Button buttonDelivery;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button buttonFilter;
    }
}

