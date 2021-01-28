using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WalletLesster.Models;

namespace WalletLesster.Views
{
    public partial class TransactionReport : Form
    {
        string ConnectionString = "";
        WalletLessterTempData tempData = new WalletLessterTempData();
        static int userId = 1;
        public TransactionReport()
        {
            InitializeComponent();
            if (File.Exists(@"D:\WL_LoggedInUserTempData.xml") == true)
            {
                tempData.ReadXml(@"D:\WL_LoggedInUserTempData.xml");
                userId = tempData.User[0].Id;
            }
            ConnectionString = "Data Source=LAPTOP-OEO6CLPO;Initial Catalog=WalletLessterDatabase;Integrated Security=True";
            reportViewer1.SetDisplayMode(DisplayMode.Normal);
            reportViewer1.ZoomMode = ZoomMode.PageWidth;
            cmbTransType.Text = "Income & Expense";
        }

        private void TransactionReport_Load(object sender, EventArgs e)
        {
            btnReset_Click(sender, e);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string userQuery, dateQuery, typeQuery;
            SqlCommand cmd;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                userQuery = "select distinct * from [WalletLessterDatabase].[dbo].[Transactions] where UserId = '" + userId + "'";
                dateQuery = " and Date between '" + this.dtFromDate.Value.Date.ToShortDateString() + "' and'" + this.dtToDate.Value.Date.ToShortDateString() + "'";
                if (!this.cmbTransType.Text.Equals("Income & Expense"))
                {
                    typeQuery = " and Type = '" + cmbTransType.Text + "'";
                    cmd = new SqlCommand(userQuery + dateQuery + typeQuery, conn);
                    cmd.CommandType = CommandType.Text;
                }
                else
                {
                    cmd = new SqlCommand(userQuery + dateQuery, conn);
                    cmd.CommandType = CommandType.Text;
                }
                conn.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                ReportDataSource reportDataSource = new ReportDataSource("WL_TransactionDataSet", dt);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
                conn.Close();
            }
            updateDateRange();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbTransType.Text = "Income & Expense";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM [WalletLessterDatabase].[dbo].[Transactions] where UserId = '" + userId + "'", conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                ReportDataSource reportDataSource = new ReportDataSource("WL_TransactionDataSet", dt);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
                conn.Close();
            }
            ReportParameter[] reportParameters = new ReportParameter[]
            {
                new ReportParameter("fromDate", ""),
                new ReportParameter("toDate", ""),
                new ReportParameter("transactionType", cmbTransType.Text),
            };
            reportViewer1.LocalReport.SetParameters(reportParameters);
            reportViewer1.RefreshReport();
        }

        private void updateDateRange()
        {
            ReportParameter[] reportParameters = new ReportParameter[]
            {
                new ReportParameter("fromDate", "From: " + dtFromDate.Value.Date.ToShortDateString() + "    To: "),
                new ReportParameter("toDate", dtToDate.Value.Date.ToShortDateString()),
                new ReportParameter("transactionType", cmbTransType.Text),
            };
            reportViewer1.LocalReport.SetParameters(reportParameters);
            reportViewer1.RefreshReport();
        }

        private void btnDateFilter_MouseHover(object sender, EventArgs e)
        {
            btnFilter.BackgroundImage = Properties.Resources.green_btn;
        }

        private void btnDateFilter_MouseLeave(object sender, EventArgs e)
        {
            btnFilter.BackgroundImage = Properties.Resources.blue_btn;
        }

        private void btnReset_MouseLeave(object sender, EventArgs e)
        {
            btnReset.BackgroundImage = Properties.Resources.orange_btn;

        }

        private void btnReset_MouseHover(object sender, EventArgs e)
        {
            btnReset.BackgroundImage = Properties.Resources.yellow_btn;

        }
    }
}
