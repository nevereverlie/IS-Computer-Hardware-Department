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
    public partial class StatisticsQueries : Form
    {
        const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\БД\БД Лаба 3 - SQL Запросы\Computer Hardware Department\Computer Hardware Department\Computer Hardware Department.mdf;Integrated Security=True";

        public StatisticsQueries()
        {
            InitializeComponent();
        }

        private void ButtonModelSalesQuery_Click(object sender, EventArgs e) ///wTf
        {
            SqlConnection sqlConn = new SqlConnection(ConnectionString);
            sqlConn.Open();
            SqlDataAdapter oda = new SqlDataAdapter("SELECT Models.[Id] AS ID, Models.[Model] AS Model, COUNT(Issue.[Model]) AS Sells " +
                                                    "FROM Models, Issue " +
                                                    "WHERE Issue.[Model] = Models.[Id] " +
                                                    "AND Issue.[Issue Date] >= '" + dateTimePickerFrom.Value.ToString("yyyy.MM.dd") + "' " +
                                                    "AND Issue.[Issue Date] <= '" + dateTimePickerTo.Value.ToString("yyyy.MM.dd") + "' " +
                                                    "GROUP BY Models.[Id], Models.[Model] " +
                                                    "ORDER BY Models.[Id] ASC ", sqlConn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ClearSelection();
            sqlConn.Close();
        }

        private void ButtonEmpProductivityQuery_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(ConnectionString);
            sqlConn.Open();
            SqlDataAdapter oda = new SqlDataAdapter("SELECT Issue.[Employee's Id], Employees.Surname, Employees.Name, " +
                                                        "Employees.[Middle Name], COUNT(Issue.Model) AS Sold " + 
                                                    "FROM Issue, Employees " + 
                                                    "WHERE Issue.[Employee's Id] = Employees.Id " +
                                                    "AND Issue.[Issue Date] >= '" + dateTimePickerFrom.Value.ToString("yyyy.MM.dd") + "' " +
                                                    "AND Issue.[Issue Date] <= '" + dateTimePickerTo.Value.ToString("yyyy.MM.dd") + "' " +
                                                    "GROUP BY Issue.[Employee's Id], Employees.Surname, Employees.Name, Employees.[Middle Name] ", sqlConn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ClearSelection();
            sqlConn.Close();
        }

        private void ButtonPricesQuery_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(ConnectionString);
            sqlConn.Open();
            SqlDataAdapter oda = new SqlDataAdapter("SELECT Supply.[Supply Code], Models.Model, Supply.[Model's Price], Delivery.City, Delivery.[Delivery Price], (SUM(Supply.[Model's Price]) + SUM(Delivery.[Delivery Price])) AS [Total Price] " +
                                                    "FROM Supply, Delivery, Models " +
                                                    "WHERE Supply.[To City] = Delivery.Id AND Supply.Model = Models.Id " +
                                                    "GROUP BY Supply.[Supply Code], Models.Model, Supply.[Model's Price], Delivery.City, Delivery.[Delivery Price] " + 
                                                    "ORDER BY [Total Price] ASC", sqlConn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ClearSelection();
            sqlConn.Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(ConnectionString);
            sqlConn.Open();
            SqlDataAdapter oda = new SqlDataAdapter("SELECT CAST(Suppliers.Name AS NVARCHAR(MAX)) AS Supplier, CAST(Models.[Product's Id] AS NVARCHAR(MAX)) AS [Product's Id], COUNT(Issue.[Good's Id]) AS [Sold Total] " +
                                                    "FROM Suppliers, Issue, Models " +
                                                    "WHERE Issue.Model = Models.Id AND Models.[Supplier's Id] = Suppliers.Id " +
                                                    "AND Issue.[Issue Date] >= '" + dateTimePickerFrom.Value.ToString("yyyy.MM.dd") + "' " +
                                                    "AND Issue.[Issue Date] <= '" + dateTimePickerTo.Value.ToString("yyyy.MM.dd") + "' " +
                                                    "GROUP BY CAST(Suppliers.Name AS NVARCHAR(MAX)), CAST(Models.[Product's Id] AS NVARCHAR(MAX)) " +
                                                    "ORDER BY CAST(Models.[Product's Id] AS NVARCHAR(MAX)) ASC", sqlConn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ClearSelection();
            sqlConn.Close();
        }
    }
}
