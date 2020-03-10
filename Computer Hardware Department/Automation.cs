using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Computer_Hardware_Department
{
    public partial class Automation : Form
    {
        public Automation()
        {
            InitializeComponent();
        }
        const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\БД\БД Лаба 3 - SQL Запросы\Computer Hardware Department\Computer Hardware Department\Computer Hardware Department.mdf;Integrated Security=True";

        private void Automation_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computer_Hardware_DepartmentDataSet.Supply". При необходимости она может быть перемещена или удалена.
            this.supplyTableAdapter.Fill(this.computer_Hardware_DepartmentDataSet.Supply);
            SqlConnection sqlConn = new SqlConnection(ConnectionString);
            sqlConn.Open();
            var year = DateTime.Now.Year;
            var month = DateTime.Now.Month;
            var day = DateTime.Now.Day;
            var LastMonth = new DateTime(year, month - 1, day);
            SqlDataAdapter oda = new SqlDataAdapter("SELECT Supply.[Supply Code], Models.Model, Supply.[Model's Price], " +
                                                            "Delivery.City, Delivery.[Delivery Price], " +
                                                            "COUNT(Issue.Model) AS [Sold Models] " +
                                                    "FROM Supply, Delivery, Models, Issue " +
                                                    "WHERE Supply.[To City] = Delivery.Id " +
                                                            "AND Supply.Model = Models.Id " +
                                                            "AND Issue.Model = Models.Id " +
                                                            "AND Issue.[Issue Date] >= '" + LastMonth.ToString("yyyy.MM.dd") + "' " +
                                                    "GROUP BY Supply.[Supply Code], Models.Model, Supply.[Model's Price], Delivery.City, Delivery.[Delivery Price] " +
                                                    "ORDER BY Supply.[Model's Price] ASC ", sqlConn);
            DataTable dt = new DataTable();
            oda.Fill(dt);

            SetPricesBonusesColumn(dt);
            CreateButtonColumn();
        }

        private void SetPricesBonusesColumn(DataTable dt)
        {
            DataColumn DepartmentPrice = new DataColumn();
            DepartmentPrice.DataType = System.Type.GetType("System.Decimal");
            DepartmentPrice.ColumnName = "Department Price";
            DepartmentPrice.Expression = "[Model's Price] + (0.15 * ([Model's Price] + [Delivery Price]))";
            dt.Columns.Add(DepartmentPrice);

            DataColumn BonusPercentage = new DataColumn();
            BonusPercentage.DataType = System.Type.GetType("System.Decimal");
            BonusPercentage.ColumnName = "Bonus Percentage";
            BonusPercentage.Expression = "[Sold Models] / 100";
            dt.Columns.Add(BonusPercentage);
            dataGridView1.DataSource = dt;
            dataGridView1.ClearSelection();
        }

        private void CreateButtonColumn()
        {
            DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                Visible = true,
                Text = "Approve",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Popup,
                HeaderText = "Estimated Increase",
                Name = "ApproveButtonColumn"
            };
            dataGridView1.Columns.Add(dataGridViewButtonColumn);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                int supplyCode = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                double bonus = Convert.ToDouble(dataGridView1.CurrentRow.Cells[7].Value);
                double totalPrice = Convert.ToDouble(dataGridView1.CurrentRow.Cells[6].Value);
                double increasedPrice = totalPrice + (bonus * totalPrice);
                
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("UPDATE Supply SET [Model's Price] = '" + Math.Round(increasedPrice, 0) + "' WHERE [Supply Code] = " + supplyCode, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                supplyBindingSource.EndEdit();
                supplyTableAdapter.Update(computer_Hardware_DepartmentDataSet.Supply);
                supplyTableAdapter.Fill(computer_Hardware_DepartmentDataSet.Supply);
                computer_Hardware_DepartmentDataSet.AcceptChanges();

                dataGridView1.CurrentRow.Cells[8].Style.BackColor = Color.Blue;
                dataGridView1.CurrentRow.Cells[8].Style.ForeColor = Color.WhiteSmoke;
                dataGridView1.CurrentRow.Cells[8].Value = "APPROVED!";

                MessageBox.Show("Changes Applied!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonSelectFromDates_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(ConnectionString);
            sqlConn.Open();
            SqlDataAdapter oda = new SqlDataAdapter("SELECT Supply.[Supply Code], Models.Model, Supply.[Model's Price], " +
                                                            "Delivery.City, Delivery.[Delivery Price], " +
                                                            "COUNT(Issue.Model) AS [Sold Models] " +
                                                    "FROM Supply, Delivery, Models, Issue " +
                                                    "WHERE Supply.[To City] = Delivery.Id " +
                                                            "AND Supply.Model = Models.Id " +
                                                            "AND Issue.Model = Models.Id " +
                                                            "AND Issue.[Issue Date] >= '" + dateTimePickerFrom.Value.ToString("yyyy.MM.dd") + "' " +
                                                            "AND Issue.[Issue Date] <= '" + dateTimePickerTo.Value.ToString("yyyy.MM.dd") + "' " +
                                                    "GROUP BY Supply.[Supply Code], Models.Model, Supply.[Model's Price], Delivery.City, Delivery.[Delivery Price] " +
                                                    "ORDER BY Supply.[Model's Price] ASC ", sqlConn);
            DataTable dt = new DataTable();
            oda.Fill(dt);

            SetPricesBonusesColumn(dt);
            dataGridView1.Columns.Remove("ApproveButtonColumn");
            CreateButtonColumn();
        }

        private void buttonSelectFromDates_MouseEnter(object sender, EventArgs e)
        {
            buttonSelectFromDates.BackColor = SystemColors.ActiveCaption;
        }

        private void buttonSelectFromDates_MouseUp(object sender, MouseEventArgs e)
        {
            buttonSelectFromDates.BackColor = SystemColors.ActiveCaption;
        }
    }
}
