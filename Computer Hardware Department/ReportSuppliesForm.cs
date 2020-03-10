using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace Computer_Hardware_Department
{
    public partial class ReportSuppliesForm : Form
    {
        public ReportSuppliesForm()
        {
            InitializeComponent();
        }
        const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\БД\БД Лаба 3 - SQL Запросы\Computer Hardware Department\Computer Hardware Department\Computer Hardware Department.mdf;Integrated Security=True";
        private void ReportSuppliesForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Computer_Hardware_DepartmentDataSet.Supply". При необходимости она может быть перемещена или удалена.
            this.SupplyTableAdapter.Fill(this.Computer_Hardware_DepartmentDataSet.Supply);
            this.reportViewer1.RefreshReport();
        }

        private void ButtonMakeReport_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(ConnectionString);

            sqlConn.Open();
            SqlDataAdapter oda = new SqlDataAdapter("SELECT * " +
                                                    "FROM Supply " +
                                                    "WHERE Supply.[Model's Price] >= '" + Convert.ToInt32(textBoxFrom.Text) + "' " +
                                                    "AND Supply.[Model's Price] <= '" + Convert.ToInt32(textBoxTo.Text) + "' ", sqlConn);
            DataSet dataSetSupply = new DataSet();
            dataSetSupply.DataSetName = "DataSetSupply";
            oda.Fill(dataSetSupply, "Supply");
            this.reportViewer1.ProcessingMode = ProcessingMode.Local;
            ReportDataSource reportDataSource1 = new ReportDataSource("DataSetSupply", dataSetSupply.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
