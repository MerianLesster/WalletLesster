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
        string transactionType = "Income";
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
        }

        private void TransactionReport_Load(object sender, EventArgs e)
        {
            btnReset_Click(sender, e);
        }

        private void btnDateFilter_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("select distinct * from [WalletLessterDatabase].[dbo].[Transactions] where UserId = '" + userId + "' and Date between '" + this.dtFromDate.Value.Date.ToShortDateString() + "' and'" + this.dtToDate.Value.Date.ToShortDateString() + "'", conn);
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
            updateDateRange();
        }

        private void Normal()
        {
            /*
            SqlCommand cmd = new SqlCommand("SELECT * FROM [WalletLessterDatabase].[dbo].[Transactions]", conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            ReportDataSource reportDataSource = new ReportDataSource("WL_TransactionDataSet", dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.PageWidth;
            reportViewer1.RefreshReport();
            conn.Close();*/
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
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
            updateDateRange();
        }

        private void btnTypeFilter_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("select distinct * from [WalletLessterDatabase].[dbo].[Transactions] where UserId = '" + userId + "' and Type = '" + this.transactionType + "'", conn);
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
            updateDateRange();
        }

        private void rbIncome_CheckedChanged(object sender, EventArgs e)
        {
            string value;
            bool isChecked = rbIncome.Checked;
            if (isChecked)
                value = rbIncome.Text;
            else
                value = rbExpense.Text;
            transactionType = value;
        }

        private void updateDateRange()
        {
            ReportParameter[] reportParameters = new ReportParameter[]
            {
                new ReportParameter("fromDate", dtFromDate.Value.Date.ToShortDateString()),
                new ReportParameter("toDate", dtToDate.Value.Date.ToShortDateString()),
                new ReportParameter("transactionType", transactionType),
            };
            reportViewer1.LocalReport.SetParameters(reportParameters);
            reportViewer1.RefreshReport();
        }

        private void btnDateFilter_MouseHover(object sender, EventArgs e)
        {
            btnDateFilter.BackgroundImage = Properties.Resources.green_btn;
        }

        private void btnDateFilter_MouseLeave(object sender, EventArgs e)
        {
            btnDateFilter.BackgroundImage = Properties.Resources.blue_btn;
        }

        private void btnTypeFilter_MouseHover(object sender, EventArgs e)
        {
            btnTypeFilter.BackgroundImage = Properties.Resources.purple_btn;
        }

        private void btnTypeFilter_MouseLeave(object sender, EventArgs e)
        {
            btnTypeFilter.BackgroundImage = Properties.Resources.pink_btn;

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
