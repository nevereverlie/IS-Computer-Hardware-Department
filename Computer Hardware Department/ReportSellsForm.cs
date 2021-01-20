using Microsoft.Reporting.WinForms;
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

namespace Computer_Hardware_Department
{
    public partial class ReportSellsForm : Form
    {
        public ReportSellsForm()
        {
            InitializeComponent();
        }

        private void ReportSells_Load(object sender, EventArgs e)
        {
            
        }

        const string ConnectionString = MainForm.ConnectionString;
        private void ButtonMakeReport_Click(object sender, EventArgs e)
        {
            /*try
            {
                using (Computer_Hardware_DepartmentDataSet db = new Computer_Hardware_DepartmentDataSet())
                {
                    using (SqlConnection sqlConn = new SqlConnection(ConnectionString))
                    {
                        SqlCommand cmd = new SqlCommand("EXECUTE GetDataOrder @fromDate='" + dateTimePickerFrom.Value + "', @toDate='" + dateTimePickerTo.Value + "';", sqlConn);
                        SqlDataAdapter oda = new SqlDataAdapter("EXECUTE GetDataOrder @fromDate='" + dateTimePickerFrom.Value + "', @toDate='" + dateTimePickerTo.Value + "';", sqlConn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        this.IssueBindingSource.DataSource = dt;
                        ReportParameter[] parameters = new ReportParameter[]
                        {
                            new ReportParameter("fromDate", dateTimePickerFrom.Value.Date.ToShortDateString()),
                            new ReportParameter("toDate", dateTimePickerTo.Value.Date.ToShortTimeString())
                        };
                        reportViewer1.LocalReport.SetParameters(parameters);
                    }
                }
                //this.reportViewer1.LocalReport.SetParameters(reportParameters);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

            // TODO: данная строка кода позволяет загрузить данные в таблицу "Computer_Hardware_DepartmentDataSet.Issue". При необходимости она может быть перемещена или удалена.
            SqlConnection sqlConn = new SqlConnection(ConnectionString);
           
            sqlConn.Open();
            SqlDataAdapter oda = new SqlDataAdapter("SELECT * " +
                                                    "FROM Issue " +
                                                    "WHERE Issue.[Issue Date] >= '" + dateTimePickerFrom.Value.ToString("yyyy.MM.dd") + "' " +
                                                    "AND Issue.[Issue Date] <= '" + dateTimePickerTo.Value.ToString("yyyy.MM.dd") + "' ", sqlConn);
            DataSet dataSetIssue = new DataSet();
            dataSetIssue.DataSetName = "DataSetIssue";
            oda.Fill(dataSetIssue, "Issue");
            this.reportViewer1.ProcessingMode = ProcessingMode.Local;
            ReportDataSource reportDataSource1 = new ReportDataSource("DataSetIssue", dataSetIssue.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
   
        }
    }
}
