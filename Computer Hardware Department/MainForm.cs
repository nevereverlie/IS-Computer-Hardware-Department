using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Hardware_Department
{
    public partial class MainForm : Form
    {
        public const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\БД\БД Лаба 3 - SQL Запросы\Computer Hardware Department\Computer Hardware Department\Computer Hardware Department.mdf;Integrated Security=True";
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computer_Hardware_DepartmentDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.computer_Hardware_DepartmentDataSet.Employees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computer_Hardware_DepartmentDataSet.Delivery". При необходимости она может быть перемещена или удалена.
            this.deliveryTableAdapter.Fill(this.computer_Hardware_DepartmentDataSet.Delivery);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computer_Hardware_DepartmentDataSet.Supply". При необходимости она может быть перемещена или удалена.
            this.supplyTableAdapter.Fill(this.computer_Hardware_DepartmentDataSet.Supply);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computer_Hardware_DepartmentDataSet.Issue". При необходимости она может быть перемещена или удалена.
            this.issueTableAdapter.Fill(this.computer_Hardware_DepartmentDataSet.Issue);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computer_Hardware_DepartmentDataSet.Types_of_Products". При необходимости она может быть перемещена или удалена.
            this.types_of_ProductsTableAdapter.Fill(this.computer_Hardware_DepartmentDataSet.Types_of_Products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computer_Hardware_DepartmentDataSet.Suppliers". При необходимости она может быть перемещена или удалена.
            this.suppliersTableAdapter.Fill(this.computer_Hardware_DepartmentDataSet.Suppliers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computer_Hardware_DepartmentDataSet.Models". При необходимости она может быть перемещена или удалена.
            this.modelsTableAdapter.Fill(this.computer_Hardware_DepartmentDataSet.Models);
            dataGridViewMain.AutoGenerateColumns = true;
            dataGridViewMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMain.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            comboBoxFilterEmployee.Text = "";
            ButtonIssue_ActiveCaption();
            EnableEmployeeFilters();
            dataGridViewMain.ClearSelection();

            this.menuStrip1.Items.OfType<ToolStripMenuItem>().ToList().ForEach(x =>
            {
                x.MouseHover += (obj, arg) => ((ToolStripDropDownItem)obj).ShowDropDown();
            });
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            modelsTableAdapter.Update(computer_Hardware_DepartmentDataSet);
            suppliersTableAdapter.Update(computer_Hardware_DepartmentDataSet);
            types_of_ProductsTableAdapter.Update(computer_Hardware_DepartmentDataSet);
            issueTableAdapter.Update(computer_Hardware_DepartmentDataSet);
            supplyTableAdapter.Update(computer_Hardware_DepartmentDataSet);
            employeesTableAdapter.Update(computer_Hardware_DepartmentDataSet);
            deliveryTableAdapter.Update(computer_Hardware_DepartmentDataSet);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ModelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewMain.DataSource = modelsBindingSource1;
            ButtonModels_ActiveCaption();
            ButtonsAddRedDel_Enable();
            dataGridViewMain.ClearSelection();
        }

        private void SuppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewMain.DataSource = suppliersBindingSource;
            ButtonsIssueModelsSupplies_ClearCelection();
            ButtonsAddRedDel_Disable();
            dataGridViewMain.ClearSelection();
        }

        private void TypesOfProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewMain.DataSource = typesOfProductsBindingSource;
            ButtonsIssueModelsSupplies_ClearCelection();
            ButtonsAddRedDel_Disable();
            dataGridViewMain.ClearSelection();
        }
        
        private void SupplyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewMain.DataSource = supplyBindingSource;
            ButtonSupplies_AcriveCaption();
            ButtonsAddRedDel_Enable();
            dataGridViewMain.ClearSelection();
        }

        private void EmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewMain.DataSource = employeesBindingSource;
            ButtonsIssueModelsSupplies_ClearCelection();
            ButtonsAddRedDel_Disable();
            dataGridViewMain.ClearSelection();
        }

        private void DeliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewMain.DataSource = deliveryBindingSource;
            ButtonsIssueModelsSupplies_ClearCelection();
            ButtonsAddRedDel_Disable();
            dataGridViewMain.ClearSelection();
        }

        private void IssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewMain.DataSource = issueBindingSource;
            ButtonIssue_ActiveCaption();
            ButtonsAddRedDel_Enable();
            dataGridViewMain.ClearSelection();
        }

        
        private void QueryEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var queryEdit = new QueryEdit();
            queryEdit.Show();
        }


        
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit.isChanging = false;
            var editForm = new EditIssueForm();
            editForm.ShowDialog();
            issueTableAdapter.Fill(computer_Hardware_DepartmentDataSet.Issue);
            computer_Hardware_DepartmentDataSet.AcceptChanges();
        }

        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit.isChanging = true;
            var issueDataTable = new Computer_Hardware_DepartmentDataSet.IssueDataTable();
            issueTableAdapter.Fill(issueDataTable);
            var selected = dataGridViewMain.CurrentRow;
            var row = selected.Cells;
            EditIssueForm editForm = new EditIssueForm(
                Convert.ToInt32(row[0].Value),
                row[1].Value.ToString(),
                row[2].Value.ToString(),
                row[3].Value.ToString(),
                Convert.ToInt32(row[4].Value),
                Convert.ToInt32(row[5].Value),
                row[6].Value.ToString(),
                Convert.ToDateTime(row[7].Value),
                Convert.ToInt32(row[8].Value),
                Convert.ToInt32(row[9].Value)
            );
            editForm.ShowDialog();
            issueTableAdapter.Fill(computer_Hardware_DepartmentDataSet.Issue);
            computer_Hardware_DepartmentDataSet.AcceptChanges();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            issueTableAdapter.DeleteQuery(
                Convert.ToInt32(dataGridViewMain.SelectedRows[0].Cells[0].Value)
            );
            issueTableAdapter.Fill(computer_Hardware_DepartmentDataSet.Issue);
            computer_Hardware_DepartmentDataSet.AcceptChanges();
        }

        public static int LastId { get; set; }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Edit.isChanging = false;
            LastId = Convert.ToInt32(dataGridViewMain.RowCount);
            try
            {
                if (dataGridViewMain.DataSource == issueBindingSource)
                {
                    EditIssueForm editIssue = new EditIssueForm();
                    editIssue.ShowDialog();
                    issueTableAdapter.Fill(computer_Hardware_DepartmentDataSet.Issue);
                    computer_Hardware_DepartmentDataSet.AcceptChanges();
                }
                else if (dataGridViewMain.DataSource == modelsBindingSource1)
                {
                    EditModelsForm editModels = new EditModelsForm();
                    editModels.ShowDialog();
                    modelsTableAdapter.Fill(computer_Hardware_DepartmentDataSet.Models);
                    computer_Hardware_DepartmentDataSet.AcceptChanges();
                }
                else if (dataGridViewMain.DataSource == supplyBindingSource)
                {
                    EditSuppliesForm editSupplies = new EditSuppliesForm();
                    editSupplies.ShowDialog();
                    supplyTableAdapter.Fill(computer_Hardware_DepartmentDataSet.Supply);
                    computer_Hardware_DepartmentDataSet.AcceptChanges();
                }
                else if (dataGridViewMain.DataSource == suppliersBindingSource)
                {
                    EditSuppliersForm editSuppliers = new EditSuppliersForm();
                    editSuppliers.ShowDialog();
                    suppliersTableAdapter.Fill(computer_Hardware_DepartmentDataSet.Suppliers);
                    computer_Hardware_DepartmentDataSet.AcceptChanges();
                }
                else if (dataGridViewMain.DataSource == typesOfProductsBindingSource)
                {
                    EditTypesForm editTypes = new EditTypesForm();
                    editTypes.ShowDialog();
                    types_of_ProductsTableAdapter.Fill(computer_Hardware_DepartmentDataSet.Types_of_Products);
                    computer_Hardware_DepartmentDataSet.AcceptChanges();
                }
                else if (dataGridViewMain.DataSource == employeesBindingSource)
                {
                    EditEmployeesForm editEmployees = new EditEmployeesForm();
                    editEmployees.ShowDialog();
                    employeesTableAdapter.Fill(computer_Hardware_DepartmentDataSet.Employees);
                    computer_Hardware_DepartmentDataSet.AcceptChanges();
                }
                else if (dataGridViewMain.DataSource == deliveryBindingSource)
                {
                    EditDeliveryForm editDelivery = new EditDeliveryForm();
                    editDelivery.ShowDialog();
                    deliveryTableAdapter.Fill(computer_Hardware_DepartmentDataSet.Delivery);
                    computer_Hardware_DepartmentDataSet.AcceptChanges();
                }
                dataGridViewMain.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonRed_Click(object sender, EventArgs e)
        {
            Edit.isChanging = true;
            var selected = dataGridViewMain.CurrentRow;
            var row = selected.Cells;
            try
            {
                if (dataGridViewMain.DataSource == issueBindingSource)
                {
                    var issueDataTable = new Computer_Hardware_DepartmentDataSet.IssueDataTable();
                    issueTableAdapter.Fill(issueDataTable);
                    EditIssueForm editForm = new EditIssueForm(Convert.ToInt32(row[0].Value),
                                                                row[1].Value.ToString(),
                                                                row[2].Value.ToString(),
                                                                row[3].Value.ToString(),
                                                                Convert.ToInt32(row[4].Value),
                                                                Convert.ToInt32(row[5].Value),
                                                                row[6].Value.ToString(),
                                                                Convert.ToDateTime(row[7].Value),
                                                                Convert.ToInt32(row[8].Value),
                                                                Convert.ToInt32(row[9].Value)
                    );
                    editForm.ShowDialog();
                    issueTableAdapter.Fill(computer_Hardware_DepartmentDataSet.Issue);
                    computer_Hardware_DepartmentDataSet.AcceptChanges();
                }
                else if (dataGridViewMain.DataSource == modelsBindingSource1)
                {
                    var modelDataTable = new Computer_Hardware_DepartmentDataSet.ModelsDataTable();
                    modelsTableAdapter.Fill(modelDataTable);
                    EditModelsForm editModels = new EditModelsForm(Convert.ToInt32(row[0].Value),
                                                                    row[1].Value.ToString(),
                                                                    Convert.ToInt32(row[2].Value),
                                                                    Convert.ToInt32(row[3].Value)
                    );
                    editModels.ShowDialog();
                    modelsTableAdapter.Fill(computer_Hardware_DepartmentDataSet.Models);
                    computer_Hardware_DepartmentDataSet.AcceptChanges();
                }
                else if (dataGridViewMain.DataSource == supplyBindingSource)
                {
                    var supplyDataTable = new Computer_Hardware_DepartmentDataSet.SupplyDataTable();
                    supplyTableAdapter.Fill(supplyDataTable);
                    EditSuppliesForm editSupplies = new EditSuppliesForm(Convert.ToInt32(row[0].Value),
                                                                         Convert.ToInt32(row[1].Value),
                                                                         Convert.ToDecimal(row[2].Value),
                                                                         Convert.ToInt32(row[3].Value),
                                                                         Convert.ToInt32(row[4].Value));
                    editSupplies.ShowDialog();
                    supplyTableAdapter.Fill(computer_Hardware_DepartmentDataSet.Supply);
                    computer_Hardware_DepartmentDataSet.AcceptChanges();
                }
                else if (dataGridViewMain.DataSource == suppliersBindingSource)
                {
                    var suppliersDataTable = new Computer_Hardware_DepartmentDataSet.SuppliersDataTable();
                    suppliersTableAdapter.Fill(suppliersDataTable);
                    EditSuppliersForm editSuppliers = new EditSuppliersForm(Convert.ToInt32(row[0].Value),
                                                                            row[1].Value.ToString(),
                                                                            row[2].Value.ToString());
                    editSuppliers.ShowDialog();
                    suppliersTableAdapter.Fill(computer_Hardware_DepartmentDataSet.Suppliers);
                    computer_Hardware_DepartmentDataSet.AcceptChanges();
                }
                else if (dataGridViewMain.DataSource == typesOfProductsBindingSource)
                {
                    var typesOfProductsDataTable = new Computer_Hardware_DepartmentDataSet.Types_of_ProductsDataTable();
                    types_of_ProductsTableAdapter.Fill(typesOfProductsDataTable);
                    EditTypesForm editTypes = new EditTypesForm(Convert.ToInt32(row[0].Value), row[1].Value.ToString());
                    editTypes.ShowDialog();
                    types_of_ProductsTableAdapter.Fill(computer_Hardware_DepartmentDataSet.Types_of_Products);
                    computer_Hardware_DepartmentDataSet.AcceptChanges();

                }
                else if (dataGridViewMain.DataSource == employeesBindingSource)
                {
                    var employeesDataTable = new Computer_Hardware_DepartmentDataSet.EmployeesDataTable();
                    employeesTableAdapter.Fill(employeesDataTable);
                    EditEmployeesForm editEmployees = new EditEmployeesForm(Convert.ToInt32(row[0].Value),
                                                                            row[1].Value.ToString(),
                                                                            row[2].Value.ToString(),
                                                                            row[3].Value.ToString(),
                                                                            row[4].Value.ToString(),
                                                                            row[5].Value.ToString());
                    editEmployees.ShowDialog();
                    employeesTableAdapter.Fill(computer_Hardware_DepartmentDataSet.Employees);
                    computer_Hardware_DepartmentDataSet.AcceptChanges();

                }
                else if (dataGridViewMain.DataSource == deliveryBindingSource)
                {
                    var deliveryDataTable = new Computer_Hardware_DepartmentDataSet.DeliveryDataTable();
                    deliveryTableAdapter.Fill(deliveryDataTable);
                    EditDeliveryForm editDelivery = new EditDeliveryForm(Convert.ToInt32(row[0].Value),
                                                                         row[1].Value.ToString(),
                                                                         Convert.ToInt32(row[2].Value),
                                                                         Convert.ToInt32(row[3].Value));
                    editDelivery.ShowDialog();
                    deliveryTableAdapter.Fill(computer_Hardware_DepartmentDataSet.Delivery);
                    computer_Hardware_DepartmentDataSet.AcceptChanges();

                }
                dataGridViewMain.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            var selected = dataGridViewMain.CurrentRow;
            var row = selected.Cells;
            try
            {
                if (dataGridViewMain.DataSource == issueBindingSource)
                {
                    if (MessageBox.Show("Ви підтверджуєте видалення рядку №" +
                        row[0].Value.ToString() + ": " + row[1].Value + " " + 
                        row[2].Value + " " + row[3].Value + "?", 
                        "УВАГА", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                    {
                        issueTableAdapter.DeleteQuery(Convert.ToInt32(row[0].Value));
                        issueTableAdapter.Fill(computer_Hardware_DepartmentDataSet.Issue);
                        computer_Hardware_DepartmentDataSet.AcceptChanges();
                    }
                }
                else if (dataGridViewMain.DataSource == modelsBindingSource1)
                {
                    if (MessageBox.Show("Ви підтверджуєте видалення моделі з ID " +
                        row[0].Value.ToString() + ": " + row[1].Value + "?",
                        "УВАГА", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                    {
                        modelsTableAdapter.DeleteQuery(Convert.ToInt32(row[0].Value));
                        modelsTableAdapter.Fill(computer_Hardware_DepartmentDataSet.Models);
                        computer_Hardware_DepartmentDataSet.AcceptChanges();
                    }
                }
                else if (dataGridViewMain.DataSource == supplyBindingSource)
                {
                    if (MessageBox.Show("Ви підтверджуєте видалення поставки №" +
                        row[0].Value.ToString() + "?", 
                        "УВАГА", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                    {
                        supplyTableAdapter.DeleteQuery(Convert.ToInt32(row[0].Value));
                        supplyTableAdapter.Fill(computer_Hardware_DepartmentDataSet.Supply);
                        computer_Hardware_DepartmentDataSet.AcceptChanges();
                    }
                }
                else if (dataGridViewMain.DataSource == suppliersBindingSource)
                {
                    if (MessageBox.Show("Ви підтверджуєте видалення постачальника №" +
                        row[0].Value.ToString() + ": " + row[1].Value.ToString() + "?",
                        "УВАГА", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                    {
                        suppliersTableAdapter.DeleteQuery(Convert.ToInt32(row[0].Value));
                        suppliersTableAdapter.Fill(computer_Hardware_DepartmentDataSet.Suppliers);
                        computer_Hardware_DepartmentDataSet.AcceptChanges();
                    }
                }
                else if (dataGridViewMain.DataSource == typesOfProductsBindingSource)
                {
                    if (MessageBox.Show("Ви підтверджуєте видалення виду товару №" +
                        row[0].Value.ToString() + ": " + row[1].Value.ToString() + "?",
                        "УВАГА", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                    {
                        types_of_ProductsTableAdapter.DeleteQuery(Convert.ToInt32(row[0].Value));
                        types_of_ProductsTableAdapter.Fill(computer_Hardware_DepartmentDataSet.Types_of_Products);
                        computer_Hardware_DepartmentDataSet.AcceptChanges();
                    }
                }
                else if (dataGridViewMain.DataSource == employeesBindingSource)
                {
                    if (MessageBox.Show("Ви підтверджуєте видалення співробітника №" +
                        row[0].Value.ToString() + ": " + row[1].Value.ToString() + " " + 
                        row[2].Value.ToString() + " " + row[3].Value.ToString() + "?",
                        "УВАГА", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                    {
                        employeesTableAdapter.DeleteQuery(Convert.ToInt32(row[0].Value));
                        employeesTableAdapter.Fill(computer_Hardware_DepartmentDataSet.Employees);
                        computer_Hardware_DepartmentDataSet.AcceptChanges();
                    }
                }
                else if (dataGridViewMain.DataSource == deliveryBindingSource)
                {
                    if (MessageBox.Show("Ви підтверджуєте видалення міста №" +
                        row[0].Value.ToString() + ": " + row[1].Value.ToString() + "?",
                        "УВАГА", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                    {
                        deliveryTableAdapter.DeleteQuery(Convert.ToInt32(row[0].Value));
                        deliveryTableAdapter.Fill(computer_Hardware_DepartmentDataSet.Delivery);
                        computer_Hardware_DepartmentDataSet.AcceptChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Обработка нажатий кнопок перехода на таблицы БД
        private void ButtonIssue_Click(object sender, EventArgs e)
        {
            ButtonIssue_ActiveCaption();
            ButtonsAddRedDel_Enable();
            EnableEmployeeFilters();
            dataGridViewMain.ClearSelection();
        }

        private void ButtonIssue_ActiveCaption()
        {
            dataGridViewMain.DataSource = issueBindingSource;
            buttonIssue.BackColor = SystemColors.ActiveCaption;
            buttonModels.BackColor = Color.WhiteSmoke;
            buttonSupplies.BackColor = Color.WhiteSmoke;
            buttonSuppliers.BackColor = Color.WhiteSmoke;
            buttonTypes.BackColor = Color.WhiteSmoke;
            buttonEmployees.BackColor = Color.WhiteSmoke;
            buttonDelivery.BackColor = Color.WhiteSmoke;
        }

        private void ButtonModels_Click(object sender, EventArgs e)
        {
            ButtonModels_ActiveCaption();
            ButtonsAddRedDel_Enable();
            DisableFilters();
            dataGridViewMain.ClearSelection();
        }
        private void DisableFilters()
        {
            comboBoxFilterEmployee.Enabled = false;
            textBoxFilterPrice1.Enabled = false;
            textBoxFilterPrice2.Enabled = false;
            labelEmployee.Enabled = false;
            labelModelPrice.Enabled = false;
            labelPriceFrom.Enabled = false;
            labelPriceTo.Enabled = false;
        }

        private void ButtonModels_ActiveCaption()
        {
            dataGridViewMain.DataSource = modelsBindingSource1;
            buttonIssue.BackColor = Color.WhiteSmoke;
            buttonModels.BackColor = SystemColors.ActiveCaption;
            buttonSupplies.BackColor = Color.WhiteSmoke;
            buttonSuppliers.BackColor = Color.WhiteSmoke;
            buttonTypes.BackColor = Color.WhiteSmoke;
            buttonEmployees.BackColor = Color.WhiteSmoke;
            buttonDelivery.BackColor = Color.WhiteSmoke;
        }

        private void ButtonSupplies_Click(object sender, EventArgs e)
        {
            ButtonSupplies_AcriveCaption();
            ButtonsAddRedDel_Enable();
            EnablePriceFilters();
            dataGridViewMain.ClearSelection();
        }

        private void ButtonSupplies_AcriveCaption()
        {
            dataGridViewMain.DataSource = supplyBindingSource;
            buttonIssue.BackColor = Color.WhiteSmoke;
            buttonModels.BackColor = Color.WhiteSmoke;
            buttonSupplies.BackColor = SystemColors.ActiveCaption;
            buttonSuppliers.BackColor = Color.WhiteSmoke;
            buttonTypes.BackColor = Color.WhiteSmoke;
            buttonEmployees.BackColor = Color.WhiteSmoke;
            buttonDelivery.BackColor = Color.WhiteSmoke;
        }

        private void ButtonSuppliers_Click(object sender, EventArgs e)
        {
            ButtonSuppliers_ActiveCaption();
            ButtonsAddRedDel_Enable();
            dataGridViewMain.ClearSelection();
        }

        private void ButtonSuppliers_ActiveCaption()
        {
            dataGridViewMain.DataSource = suppliersBindingSource;
            buttonIssue.BackColor = Color.WhiteSmoke;
            buttonModels.BackColor = Color.WhiteSmoke;
            buttonSupplies.BackColor = Color.WhiteSmoke;
            buttonSuppliers.BackColor = SystemColors.ActiveCaption;
            buttonTypes.BackColor = Color.WhiteSmoke;
            buttonEmployees.BackColor = Color.WhiteSmoke;
            buttonDelivery.BackColor = Color.WhiteSmoke;
        }

        private void ButtonTypes_Click(object sender, EventArgs e)
        {
            ButtonTypes_ActiveCaption();
            ButtonsAddRedDel_Enable();
            dataGridViewMain.ClearSelection();
        }

        private void ButtonTypes_ActiveCaption()
        {
            dataGridViewMain.DataSource = typesOfProductsBindingSource;
            buttonIssue.BackColor = Color.WhiteSmoke;
            buttonModels.BackColor = Color.WhiteSmoke;
            buttonSupplies.BackColor = Color.WhiteSmoke;
            buttonSuppliers.BackColor = Color.WhiteSmoke;
            buttonTypes.BackColor = SystemColors.ActiveCaption;
            buttonEmployees.BackColor = Color.WhiteSmoke;
            buttonDelivery.BackColor = Color.WhiteSmoke;
        }

        private void ButtonEmployees_Click(object sender, EventArgs e)
        {
            ButtonEmployees_ActiveCaption();
            ButtonsAddRedDel_Enable();
            dataGridViewMain.ClearSelection();
        }

        private void ButtonEmployees_ActiveCaption()
        {
            dataGridViewMain.DataSource = employeesBindingSource;
            buttonIssue.BackColor = Color.WhiteSmoke;
            buttonModels.BackColor = Color.WhiteSmoke;
            buttonSupplies.BackColor = Color.WhiteSmoke;
            buttonSuppliers.BackColor = Color.WhiteSmoke;
            buttonTypes.BackColor = Color.WhiteSmoke;
            buttonEmployees.BackColor = SystemColors.ActiveCaption;
            buttonDelivery.BackColor = Color.WhiteSmoke;
        }

        private void ButtonDelivery_Click(object sender, EventArgs e)
        {
            ButtonDelivery_ActiveCaption();
            ButtonsAddRedDel_Enable();
            dataGridViewMain.ClearSelection();
        }

        private void ButtonDelivery_ActiveCaption()
        {
            dataGridViewMain.DataSource = deliveryBindingSource;
            buttonIssue.BackColor = Color.WhiteSmoke;
            buttonModels.BackColor = Color.WhiteSmoke;
            buttonSupplies.BackColor = Color.WhiteSmoke;
            buttonSuppliers.BackColor = Color.WhiteSmoke;
            buttonTypes.BackColor = Color.WhiteSmoke;
            buttonEmployees.BackColor = Color.WhiteSmoke;
            buttonDelivery.BackColor = SystemColors.ActiveCaption;
        }


        private void ButtonsAddRedDel_Enable()
        {
            buttonAdd.Enabled = true;
            buttonRed.Enabled = true;
            buttonDel.Enabled = true;
        }
        #endregion
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            dataGridViewMain.ClearSelection();
            int count = 0;
            for (int i = 0; i < dataGridViewMain.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewMain.Columns.Count; j++)
                {
                    if (dataGridViewMain.Rows[i].Cells[j].Value.ToString().Contains(textBoxSearch.Text))
                    {
                        if (count == 0)
                        {
                            dataGridViewMain.CurrentCell = dataGridViewMain.Rows[i].Cells[j];
                            count++;
                        }
                        else
                        {
                            dataGridViewMain.Rows[i].Cells[j].Selected = true;
                            dataGridViewMain.Rows[i].Selected = true;
                        }
                    }
                }
            }
        }

        
        private void ButtonReqToCity_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(ConnectionString);
            sqlConn.Open();
            SqlDataAdapter oda = new SqlDataAdapter("SELECT * " +
                                                    "FROM Supply " +
                                                    "INNER JOIN Delivery ON Delivery.City LIKE N\'%" + textBoxReqToCity.Text + "%\' " +
                                                    "AND Delivery.Id = Supply.[To City]", sqlConn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridViewMain.DataSource = dt;
            sqlConn.Close();

            ButtonsAddRedDel_Disable();
            ButtonsIssueModelsSupplies_ClearCelection();

            EnablePriceFilters();

            dataGridViewMain.ClearSelection();
        }
        private void EnablePriceFilters()
        {
            comboBoxFilterEmployee.Enabled = false;
            textBoxFilterPrice1.Enabled = true;
            textBoxFilterPrice2.Enabled = true;
            labelEmployee.Enabled = false;
            labelModelPrice.Enabled = true;
            labelPriceFrom.Enabled = true;
            labelPriceTo.Enabled = true;
        }

        private void ButtonReqDelivery_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(ConnectionString);
            sqlConn.Open();
            SqlDataAdapter oda = new SqlDataAdapter("SELECT * " +
                                                    "FROM Issue " +
                                                    "WHERE City = '1'", sqlConn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridViewMain.DataSource = dt;
            sqlConn.Close();

            ButtonsAddRedDel_Disable();
            ButtonsIssueModelsSupplies_ClearCelection();

            EnableEmployeeFilters();

            dataGridViewMain.ClearSelection();
        }
        private void EnableEmployeeFilters()
        {
            comboBoxFilterEmployee.Enabled = true;
            textBoxFilterPrice1.Enabled = false;
            textBoxFilterPrice2.Enabled = false;
            labelEmployee.Enabled = true;
            labelModelPrice.Enabled = false;
            labelPriceFrom.Enabled = false;
            labelPriceTo.Enabled = false;
        }

        private void ButtonReqNVIDIA_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(ConnectionString);
            sqlConn.Open();
            SqlDataAdapter oda = new SqlDataAdapter("SELECT Issue.Id as [Issue Code], Surname, Name, [Middle Name], Models.Model as [Model's Name], Phone, [Issue Date], City, [Employee's Id] " +
                                                    "FROM Issue, Models " +
                                                    "WHERE Issue.Model = Models.Id " +
                                                    "AND Models.[Supplier's Id] = 3 ", sqlConn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridViewMain.DataSource = dt;
            sqlConn.Close();

            ButtonsAddRedDel_Disable();
            ButtonsIssueModelsSupplies_ClearCelection();

            EnableEmployeeFilters();

            dataGridViewMain.ClearSelection();
        }
        private void ButtonsAddRedDel_Disable()
        {
            buttonAdd.Enabled = false;
            buttonRed.Enabled = false;
            buttonDel.Enabled = false;
        }

        private void ButtonsIssueModelsSupplies_ClearCelection()
        {
            buttonIssue.BackColor = Color.WhiteSmoke;
            buttonModels.BackColor = Color.WhiteSmoke;
            buttonSupplies.BackColor = Color.WhiteSmoke;
        }

        private void ButtonRandReq_Click(object sender, EventArgs e)
        {
            var queryEdit = new QueryEdit();
            queryEdit.Show();
        }

        private void ButtonApplyFilters_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(ConnectionString);
            sqlConn.Open();
            if (dataGridViewMain.Columns[0].HeaderText == "Supply Code")
            {
                if (textBoxFilterPrice1.Text == "" && textBoxFilterPrice2.Text == "") { }
                else
                {
                    if (IsDigitsOnly(textBoxFilterPrice1.Text) && IsDigitsOnly(textBoxFilterPrice2.Text))
                    {
                        try
                        {
                            if (textBoxFilterPrice1.Text != "" && textBoxFilterPrice2.Text == "")
                            {
                                SqlDataAdapter oda = new SqlDataAdapter("SELECT * " +
                                                                        "FROM Supply " +
                                                                        "WHERE [Model's Price] >= " + textBoxFilterPrice1.Text, sqlConn);
                                DataTable dt = new DataTable();
                                oda.Fill(dt);
                                dataGridViewMain.DataSource = dt;
                            }
                            else if (textBoxFilterPrice1.Text == "" && textBoxFilterPrice2.Text != "")
                            {
                                SqlDataAdapter oda = new SqlDataAdapter("SELECT * " +
                                                                        "FROM Supply " +
                                                                        "WHERE [Model's Price] <= " + textBoxFilterPrice2.Text, sqlConn);
                                DataTable dt = new DataTable();
                                oda.Fill(dt);
                                dataGridViewMain.DataSource = dt;
                            }
                            else if (textBoxFilterPrice1.Text != "" && textBoxFilterPrice2.Text != "")
                            {
                                SqlDataAdapter oda = new SqlDataAdapter("SELECT * " +
                                                                        "FROM Supply " +
                                                                        "WHERE [Model's Price] " +
                                                                        "BETWEEN " + textBoxFilterPrice1.Text + " AND " + textBoxFilterPrice2.Text, sqlConn);
                                DataTable dt = new DataTable();
                                oda.Fill(dt);
                                dataGridViewMain.DataSource = dt;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(@"Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("У поля фільтрація можна вводити тільки цілі числа", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else if (dataGridViewMain.Columns[1].HeaderText == "Surname")
            {
                if (comboBoxFilterEmployee.Text == "") { }
                else
                {
                    try
                    {
                        SqlDataAdapter oda = new SqlDataAdapter("SELECT Issue.[Id], Issue.Surname, Issue.Name, Issue.[Middle Name], " +
                                                                       "[Good's Id], Model, Issue.Phone, [Issue Date], City, [Employee's Id] " +
                                                                "FROM Issue " +
                                                                "INNER JOIN Employees ON Issue.[Employee's Id] = Employees.Id " +
                                                                "WHERE Employees.Id = " + comboBoxFilterEmployee.SelectedValue, sqlConn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        dataGridViewMain.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(@"Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            sqlConn.Close();
            ButtonsAddRedDel_Disable();
            ButtonsIssueModelsSupplies_ClearCelection();
        }

        private void ButtonCancelFilters_Click(object sender, EventArgs e)
        {
            textBoxFilterPrice1.Text = "";
            textBoxFilterPrice2.Text = "";
            comboBoxFilterEmployee.Text = "";
            ButtonIssue_ActiveCaption();
            dataGridViewMain.ClearSelection();
        }

        private bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                {
                    return false;
                }
            }
            return true;
        }

        private void ReportSellsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportSellsForm reportSells = new ReportSellsForm();
            reportSells.ShowDialog();
        }

        private void QueriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticsQueries statisticsQueries = new StatisticsQueries();
            statisticsQueries.Show();
        }

        private void PriceAdjustmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminLogin login = new AdminLogin();
            login.ShowDialog();
            supplyTableAdapter.Fill(computer_Hardware_DepartmentDataSet.Supply);
            computer_Hardware_DepartmentDataSet.AcceptChanges();
        }

        private void ButtonSort_Click(object sender, EventArgs e)
        {
            if (dataGridViewMain.DataSource == issueBindingSource)
            {
                if (issueBindingSource.IsSorted)
                {
                    issueBindingSource.RemoveSort();
                }
                else issueBindingSource.Sort = "[Issue Date] ASC, City ASC";
            }
            else if (dataGridViewMain.DataSource == modelsBindingSource1)
            {
                if (modelsBindingSource1.IsSorted)
                {
                    modelsBindingSource1.RemoveSort();
                }
                else modelsBindingSource1.Sort = "Model ASC";
            }
            else if (dataGridViewMain.DataSource == supplyBindingSource)
            {
                if (supplyBindingSource.IsSorted)
                {
                    supplyBindingSource.RemoveSort(); ;
                }
                else supplyBindingSource.Sort = "Model ASC, [Model's Price] ASC";
            }
            else if (dataGridViewMain.DataSource == suppliersBindingSource)
            {
                if (suppliersBindingSource.IsSorted)
                {
                    suppliersBindingSource.RemoveSort(); ;
                }
                else suppliersBindingSource.Sort = "Name ASC";
            }
            else if (dataGridViewMain.DataSource == typesOfProductsBindingSource)
            {
                if (typesOfProductsBindingSource.IsSorted)
                {
                    typesOfProductsBindingSource.RemoveSort(); ;
                }
                else typesOfProductsBindingSource.Sort = "[Name of the Product] ASC";
            }
            else if (dataGridViewMain.DataSource == employeesBindingSource)
            {
                if (employeesBindingSource.IsSorted)
                {
                    employeesBindingSource.RemoveSort(); ;
                }
                else employeesBindingSource.Sort = "Surname ASC, Name ASC, [Middle Name] ASC";
            }
            else if (dataGridViewMain.DataSource == deliveryBindingSource)
            {
                if (deliveryBindingSource.IsSorted)
                {
                    deliveryBindingSource.RemoveSort(); ;
                }
                else deliveryBindingSource.Sort = "City ASC";
            }
        }

        private void ButtonFilter_Click(object sender, EventArgs e)
        {
            FilterForm filterForm = new FilterForm();
            filterForm.ShowDialog();
        }

        private void ComboBoxFilterEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ПоставкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportSuppliesForm reportSupplies = new ReportSuppliesForm();
            reportSupplies.ShowDialog();
        }
    }
}
