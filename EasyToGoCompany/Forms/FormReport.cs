using EasyToGoCompany.Classes.Connection;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace EasyToGoCompany.Forms
{
    public partial class FormReport : Form
    {
        private string company = null;

        public FormReport()
        {
            InitializeComponent();
        }

        public FormReport(string company)
        {
            InitializeComponent();
            this.company = company;
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            this.RptViewer.RefreshReport();
            LoadBusAmount(company);
        }

        private void LoadBusAmount(string comapgny)
        {
            try
            {
                if (Connection.Instance.Con.State == ConnectionState.Closed)
                    Connection.Instance.Con.Open();

                using (IDbCommand cmd = Connection.Instance.Con.CreateCommand())
                {
                    cmd.CommandText = "SELECT bus.ref_compagnie, bus.numero, ref_bus, bus.etat as etat_bus, " + 
                        "sum(montant - (commission + fraisTransact)) as montant from transaction " + 
                        "inner join bus on transaction.ref_bus = bus.plaque where bus.ref_compagnie = '"+ comapgny +"' group by ref_bus ";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter((MySqlCommand)cmd))
                    {
                        using (DataSet ds = new DataSet("DsBusAmount"))
                        {
                            adapter.Fill(ds, "DsBusAmount");

                            RptViewer.LocalReport.DataSources.Clear();
                            RptViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DsBusAmount", ds.Tables[0]));
                            RptViewer.LocalReport.ReportEmbeddedResource = "EasyToGoCompany.Reports.RptBusAmount.rdlc";
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
