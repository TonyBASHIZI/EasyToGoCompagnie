using EasyToGoCompany.Classes;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Windows.Forms;

namespace EasyToGoCompany.Forms.Views
{
    public partial class UcDashboard : UserControl
    {
        private int seconde = 0;

        private double axe1;
        private double axe2;
        private double axe3;
        private double axe4;
        private double axe5;

        public UcDashboard()
        {
            InitializeComponent();
            TimerDashboard.Start();
        }

        private void LoadDashboard()
        {
            try
            {
               

                //MessageBox.Show(Convert.ToDouble(axe1).ToString());

                //this.Cursor = Cursors.WaitCursor;

                LblAllBus.Text = Glossaire.Instance.GetBusCount().ToString();
                LblFakeBus.Text = Glossaire.Instance.GetInactiveBusCount().ToString();
                LblMontantVirtuel.Text = Glossaire.Instance.GetAmount().ToString();

                /// TODO: Call function to generate amount in bank
                //LblMontantBank.Text =

                DgvDashboard.DataSource = Glossaire.Instance.LoadDashboard().Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Une erreur s'est produite lors du chargement des données en temps réel. \n\nL'Application va automatiquement se rédemarrer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Une erreur s'est produite lors de l'opération : " + ex.Message);
                Application.Restart();
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void LoadCharts(string company = null)
        {

            #region Chart 2

            //string LabelPoint(ChartPoint chartPoint) =>
            //    string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            axe1 = Glossaire.Instance.GetAmountByAxes("AXE 1", DateTime.Now.ToString());
            axe2 = Glossaire.Instance.GetAmountByAxes("AXE 2", DateTime.Now.ToString());
            axe3 = Glossaire.Instance.GetAmountByAxes("AXE 3", DateTime.Now.ToString());
            axe4 = Glossaire.Instance.GetAmountByAxes("AXE 4", DateTime.Now.ToString());
            axe5 = Glossaire.Instance.GetAmountByAxes("AXE 5", DateTime.Now.ToString());

            PieChartBus.InnerRadius = 50;

            PieChartBus.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Axe 1",
                    Values = new ChartValues<double> {axe1},
                    //PushOut = 15,
                    DataLabels = true,
                    //LabelPoint = LabelPoint
                },
                new PieSeries
                {
                    Title = "Axe 2",
                    Values = new ChartValues<double> {axe2},
                    DataLabels = true,
                    //LabelPoint = LabelPoint
                },
                new PieSeries
                {
                    Title = "Axe 3",
                    Values = new ChartValues<double> {axe3},
                    DataLabels = true,
                    //LabelPoint = LabelPoint
                },
                new PieSeries
                {
                    Title = "Axe 4",
                    Values = new ChartValues<double> {axe4},
                    DataLabels = true,
                    //LabelPoint = LabelPoint
                },
                new PieSeries
                {
                    Title = "Axe 5",
                    Values = new ChartValues<double> {axe5},
                    DataLabels = true,
                    //LabelPoint = LabelPoint
                }
            };

            PieChartBus.LegendLocation = LegendLocation.Bottom;

            #endregion
        }

        private PieSeries LoadPieSeries() /// TODO: Add object inject to generate PieSeries
        {
            //string LabelPoint(ChartPoint chartPoint) =>
            //    string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            int nombre = Convert.ToInt32(LblAllBus.Text);
            PieSeries series = null;

            for (int i = 0; i <= nombre; i++)
            {
                series = new PieSeries
                {
                    Title = "Frederic",
                    Values = new ChartValues<double> { 2 },
                    DataLabels = true,
                    //LabelPoint = LabelPoint
                };
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
                LoadCharts();
                seconde = 0;
            }
        }
    }
}
