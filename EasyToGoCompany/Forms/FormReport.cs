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

        public FormReport(string company)
        {
            InitializeComponent();

            LoadBusAmount(company);
        }

        public FormReport(string company, string begin, string end)
        {
            InitializeComponent();

            LoadBusAmountDate(company, begin, end);
        }

        public FormReport(string company, string date, string begin, string end)
        {
            InitializeComponent();

            LoadBusAmountHour(company, date, begin, end);
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            this.RptViewer.RefreshReport();
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

        private void LoadBusAmountHour(string comapgny, string date, string begin, string end)
        {
            date = Convert.ToDateTime(ConvertToOwerDateTimeFormat(date)).ToString("yyyy-MM-dd ");
            begin = date + begin.Insert(begin.LastIndexOf(":"), ":00");
            end = date + end.Insert(end.LastIndexOf(":"), ":00");

            try
            {
                if (Connection.Instance.Con.State == ConnectionState.Closed)
                    Connection.Instance.Con.Open();

                using (IDbCommand cmd = Connection.Instance.Con.CreateCommand())
                {
                    cmd.CommandText = "SELECT bus.ref_compagnie, bus.numero, ref_bus, bus.etat as etat_bus, " +
                        "sum(montant - (commission + fraisTransact)) as montant from transaction " +
                        "inner join bus on transaction.ref_bus = bus.plaque where (bus.ref_compagnie = '" + comapgny + "') " +
                        " AND (dateTransact BETWEEN '" + begin + "' AND '" + end + "') group by ref_bus ";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter((MySqlCommand)cmd))
                    {
                        using (DataSet ds = new DataSet("DsBusAmountHour"))
                        {
                            adapter.Fill(ds, "DsBusAmountHour");

                            RptViewer.LocalReport.DataSources.Clear();
                            RptViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DsBusAmountHour", ds.Tables[0]));
                            RptViewer.LocalReport.ReportEmbeddedResource = "EasyToGoCompany.Reports.RptBusAmountHour.rdlc";
                            RptViewer.PrinterSettings.DefaultPageSettings.Landscape = false;
                            RptViewer.RefreshReport();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Une erreur s'est produite lors du chargement du rapport. \n ERROR : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBusAmountDate(string comapgny, string begin, string end)
        {
            begin = Convert.ToDateTime(ConvertToOwerDateTimeFormat(begin)).ToString("yyyy-MM-dd 00:00:00");
            end = Convert.ToDateTime(ConvertToOwerDateTimeFormat(end)).ToString("yyyy-MM-dd 00:00:00");

            try
            {
                if (Connection.Instance.Con.State == ConnectionState.Closed)
                    Connection.Instance.Con.Open();

                using (IDbCommand cmd = Connection.Instance.Con.CreateCommand())
                {
                    cmd.CommandText = "SELECT bus.ref_compagnie, bus.numero, ref_bus, bus.etat as etat_bus, " +
                        "sum(montant - (commission + fraisTransact)) as montant from transaction " +
                        "inner join bus on transaction.ref_bus = bus.plaque where (bus.ref_compagnie = '" + comapgny + "') " +
                        " AND (dateTransact BETWEEN '" + begin + "' AND '" + end + "') group by ref_bus ";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter((MySqlCommand)cmd))
                    {
                        using (DataSet ds = new DataSet("DsBusAmountDate"))
                        {
                            adapter.Fill(ds, "DsBusAmountDate");

                            RptViewer.LocalReport.DataSources.Clear();
                            RptViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DsBusAmountDate", ds.Tables[0]));
                            RptViewer.LocalReport.ReportEmbeddedResource = "EasyToGoCompany.Reports.RptBusAmountDate.rdlc";
                            RptViewer.PrinterSettings.DefaultPageSettings.Landscape = false;
                            RptViewer.RefreshReport();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Une erreur s'est produite lors du chargement du rapport. \n ERROR : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string ConvertToOwerDateTimeFormat(string field)
        {
            string date = null;

            if (field.Contains("Jan") || field.Contains("Feb") || field.Contains("Mar") ||
                field.Contains("Apr") || field.Contains("Jun") || field.Contains("Jul") ||
                field.Contains("Aug") || field.Contains("Sep") || field.Contains("Oct") ||
                field.Contains("Nov") || field.Contains("Dec"))
            {
                if (field.Contains("Jan"))
                {
                    int index = field.IndexOf("Jan");
                    field = field.Remove(index, 3);
                    date = field.Insert(index, "01");
                    date = Convert.ToDateTime(date).ToString("yyyy-MM-dd HH:mm:ss");
                }

                if (field.Contains("Feb"))
                {
                    int index = field.IndexOf("Feb");
                    field = field.Remove(index, 3);
                    date = field.Insert(index, "02");
                    date = Convert.ToDateTime(date).ToString("yyyy-MM-dd HH:mm:ss");
                }

                if (field.Contains("Mar"))
                {
                    int index = field.IndexOf("Mar");
                    field = field.Remove(index, 3);
                    date = field.Insert(index, "03");
                    date = Convert.ToDateTime(date).ToString("yyyy-MM-dd HH:mm:ss");
                }

                if (field.Contains("Apr"))
                {
                    int index = field.IndexOf("Apr");
                    field = field.Remove(index, 3);
                    date = field.Insert(index, "04");
                    date = Convert.ToDateTime(date).ToString("yyyy-MM-dd HH:mm:ss");
                }

                if (field.Contains("May"))
                {
                    int index = field.IndexOf("May");
                    field = field.Remove(index, 3);
                    date = field.Insert(index, "05");
                    date = Convert.ToDateTime(date).ToString("yyyy-MM-dd HH:mm:ss");
                }

                if (field.Contains("Jun"))
                {
                    int index = field.IndexOf("Jun");
                    field = field.Remove(index, 3);
                    date = field.Insert(index, "06");
                }

                if (field.Contains("Jul"))
                {
                    int index = field.IndexOf("Jul");
                    field = field.Remove(index, 3);
                    date = field.Insert(index, "07");
                    date = Convert.ToDateTime(date).ToString("yyyy-MM-dd HH:mm:ss");
                }

                if (field.Contains("Aug"))
                {
                    int index = field.IndexOf("Aug");
                    field = field.Remove(index, 3);
                    date = field.Insert(index, "08");
                    date = Convert.ToDateTime(date).ToString("yyyy-MM-dd HH:mm:ss");
                }

                if (field.Contains("Sep"))
                {
                    int index = field.IndexOf("Sep");
                    field = field.Remove(index, 3);
                    date = field.Insert(index, "09");
                    date = Convert.ToDateTime(date).ToString("yyyy-MM-dd HH:mm:ss");
                }

                if (field.Contains("Oct"))
                {
                    int index = field.IndexOf("Oct");
                    field = field.Remove(index, 3);
                    date = field.Insert(index, "10");
                    date = Convert.ToDateTime(date).ToString("yyyy-MM-dd HH:mm:ss");
                }

                if (field.Contains("Nov"))
                {
                    int index = field.IndexOf("Nov");
                    field = field.Remove(index, 3);
                    date = field.Insert(index, "11");
                    date = Convert.ToDateTime(date).ToString("yyyy-MM-dd HH:mm:ss");
                }

                if (field.Contains("Dec"))
                {
                    int index = field.IndexOf("Dec");
                    field = field.Remove(index, 3);
                    date = field.Insert(index, "12");
                    date = Convert.ToDateTime(date).ToString("yyyy-MM-dd HH:mm:ss");
                }
            }
            else
            {
                date = field;
            }

            return date;
        }
    }
}
