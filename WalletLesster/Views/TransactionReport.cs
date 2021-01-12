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
        public TransactionReport()
        {
            InitializeComponent();
            ConnectionString = "Data Source=LAPTOP-OEO6CLPO;Initial Catalog=WalletLessterDatabase;Integrated Security=True";
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.PageWidth;
        }

        private void TransactionReport_Load(object sender, EventArgs e)
        {
            btnReset_Click(sender, e);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("select distinct * from [WalletLessterDatabase].[dbo].[Transactions] where Date between '" + this.dtFromDate.Value.Date.ToShortDateString() + "' and'" + this.dtToDate.Value.Date.ToShortDateString() + "'", conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                ReportDataSource reportDataSource = new ReportDataSource("DataSet1", dt);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
                conn.Close();
            }
        }

        private void Normal()
        {
            /*
            SqlCommand cmd = new SqlCommand("SELECT * FROM [WalletLessterDatabase].[dbo].[Transactions]", conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            ReportDataSource reportDataSource = new ReportDataSource("DataSet1", dt);
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM [WalletLessterDatabase].[dbo].[Transactions]", conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                ReportDataSource reportDataSource = new ReportDataSource("DataSet1", dt);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
                conn.Close();
            }
        }
    }
}
