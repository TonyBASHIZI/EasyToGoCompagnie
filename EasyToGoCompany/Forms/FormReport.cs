using EasyToGoCompany.Classes.Connection;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace EasyToGoCompany.Forms
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        public FormReport(string reportName)
        {
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            this.RptViewer.RefreshReport();
            LoadReport("AllBus");
        }

        private void LoadReport(string name)
        {
            name = name.Substring(3);
            try
            {
                if (Connection.Instance.Con.State == ConnectionState.Closed)
                    Connection.Instance.Con.Open();

                using (IDbCommand cmd = Connection.Instance.Con.CreateCommand())
                {
                    cmd.CommandText = "SELECT ref_compagnie, ref_pos, numero, marque, place " +
                        " FROM easy_to_go.bus WHERE `bus`.`ref_compagnie` = 'ALOHA COMMISSION'; ";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter((MySqlCommand)cmd))
                    {
                        using (DataSet ds = new DataSet("DsAllBus"))
                        {
                            adapter.Fill(ds, "DsAllBus");

                            RptViewer.LocalReport.DataSources.Clear();
                            RptViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DsAllBus", ds.Tables[0]));
                            RptViewer.LocalReport.ReportEmbeddedResource = "EasyToGoCompany.Reports.RptAllBus.rdlc";
                            RptViewer.PrinterSettings.DefaultPageSettings.Landscape = false;
                            RptViewer.RefreshReport();
                        }                       
                    }                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Une erreur s'est produite lors du chargement du rapport. \n ERROR : " +ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
