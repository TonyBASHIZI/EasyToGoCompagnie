using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyToGoCompany.Forms.Views
{
    public partial class UcReport : UserControl
    {
        private static UcReport _instance;

        public UcReport()
        {
            InitializeComponent();
        }

        public static UcReport Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UcReport();
                return _instance;
            }

            set
            {
                _instance = value;
            }
        }

        private void UcReport_Load(object sender, EventArgs e)
        {

        }

        private void ControleReport_Click(object sender, EventArgs e)
        {
            switch (((Control)sender).Name.Substring(3))
            {
                case "PreviewBusAmount":
                    break;

                case "PreviewBusHour":
                    break;

                case "PreviewBusDate":
                    break;

                default:
                    break;
            }
        }
    }
}
