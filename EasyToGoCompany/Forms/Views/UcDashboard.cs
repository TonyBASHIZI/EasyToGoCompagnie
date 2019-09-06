using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using EasyToGoCompany.Classes;
using EasyToGoCompany.Classes.Model;

namespace EasyToGoCompany.Forms.Views
{
    public partial class UcDashboard : UserControl
    {
        private int seconde = 0;

        public UcDashboard()
        {
            InitializeComponent();
            TimerDashboard.Start();
        }

        private void LoadDashboard()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                LblAllBus.Text = Glossaire.Instance.GetBusCount().ToString();
                LblFakeBus.Text = Glossaire.Instance.GetInactiveBusCount().ToString();

                /// TODO: Call function to generate amount in bank
                //LblMontantBank.Text =

                LblMontantVirtuel.Text = Glossaire.Instance.GetAmount().ToString();

                DgvDashboard.DataSource = Glossaire.Instance.LoadDashboard().Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Une erreur s'est produite lors du chargement", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Une erreur s'est produite lors de l'opération : " + ex);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void LoadCharts(string company = null)
        {

            #region Chart 2

            //string LabelPoint(ChartPoint chartPoint) =>
            //    string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            PieChartBus.InnerRadius = 50;
            PieChartBus.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Alpha",
                    Values = new ChartValues<double> {3},
                    PushOut = 15,
                    DataLabels = true,
                    //LabelPoint = LabelPoint
                },
                new PieSeries
                {
                    Title = "Beta",
                    Values = new ChartValues<double> {4},
                    DataLabels = true,
                    //LabelPoint = LabelPoint
                },
                new PieSeries
                {
                    Title = "Charli",
                    Values = new ChartValues<double> {6},
                    DataLabels = true,
                    //LabelPoint = LabelPoint
                },
                new PieSeries
                {
                    Title = "Delta",
                    Values = new ChartValues<double> {2},
                    DataLabels = true,
                    //LabelPoint = LabelPoint
                }
            };

            PieChartBus.LegendLocation = LegendLocation.Bottom;

            #endregion
        }

        private List<PieSeries> LoadPieSeries() /// TODO: Add object inject to generate PieSeries
        {
            //string LabelPoint(ChartPoint chartPoint) =>
            //    string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            int nombre = Convert.ToInt32(LblAllBus.Text);
            List<PieSeries> series = null;

            for (int i = 0; i <= nombre; i++)
            {
                series.Add(new PieSeries
                {
                    Title = "Frederic",
                    Values = new ChartValues<double> { 2 },
                    DataLabels = true,
                    //LabelPoint = LabelPoint
                }
                );
            }

            return series;

        }

        private void UcDashboard_Load(object sender, EventArgs e)
        {
            LoadCharts();
            LoadDashboard();
        }

        private void TimerDashboard_Tick(object sender, EventArgs e)
        {
            seconde++;

            if (seconde == 5)
            {
                LoadDashboard();
                seconde = 0;
            }
        }
    }
}
