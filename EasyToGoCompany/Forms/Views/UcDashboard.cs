using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using EasyToGoCompany.Classes;
using EasyToGoCompany.Classes.Model;

namespace EasyToGoCompany.Forms.Views
{
    public partial class UcDashboard : UserControl
    {
        public UcDashboard()
        {
            InitializeComponent();
        }

        private void LoadDashboard()
        {
            try
            {
                LblAllBus.Text = Glossaire.Instance.GetBusCount(User.Instance.DescriptionSession).ToString();
                LblMontantVirtuel.Text = Glossaire.Instance.GetAmount(User.Instance.DescriptionSession).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Une erreur s'est produite lors de l'opération", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.WriteLine("Une erreur s'est produite lors de l'opération : " + ex);
            }
        }

        private void LoadCharts(string company = null)
        {
            #region Chart 1

            ChartOperation.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = DateTime.Now.Year.ToString(),
                    Values = new ChartValues<double> { 10, 50, 39, 50, 10, 44, 22}

                    /// TODO: Add all transaction per mounths
                }
            };

            //adding series will update and animate the chart automatically
            //ChartOperation.Series.Add(new ColumnSeries
            //{
            //    Title = "2016",
            //    Values = new ChartValues<double> { 11, 56, 42, 33, 43, 22, 20 }
            //});

            //also adding values updates and animates the chart automatically
            //ChartOperation.Series[1].Values.Add(48d);

            ChartOperation.AxisX.Add(new Axis
            {
                Title = "Mois",
                Labels = new[] { "J", "F", "M", "A", "M", "J", "J", "A", "O", "S", "N", "D" }
            });

            ChartOperation.AxisY.Add(new Axis
            {
                Title = "Montant",
                LabelFormatter = value => value.ToString("N")
            });

            #endregion

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
    }
}
