using EasyToGoCompany.Classes.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EasyToGoCompany.Forms.Views
{
    public partial class UcReport : UserControl
    {
        private Form form = null;
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
                    Cursor = Cursors.WaitCursor;
                    form = new FormReport(User.Instance.DescriptionSession)
                    {
                        ShowInTaskbar = false
                    };
                    form.ShowDialog(this);
                    Cursor = Cursors.Default;
                    break;

                case "PreviewBusHour":
                    Cursor = Cursors.WaitCursor;
                    form = new FormReport(User.Instance.DescriptionSession, DteByHour.Value.ToString(), TxtBegin.Text, TxtEnd.Text)
                    {
                        ShowInTaskbar = false
                    };
                    form.ShowDialog(this);
                    Cursor = Cursors.Default;
                    break;

                case "PreviewBusDate":
                    Cursor = Cursors.WaitCursor;
                    form = new FormReport(User.Instance.DescriptionSession, DteBegin.Value.ToString(), DteEnd.Value.ToString())
                    {
                        ShowInTaskbar = false
                    };
                    form.ShowDialog(this);
                    Cursor = Cursors.Default;
                    break;

                default:
                    Cursor = Cursors.Default;
                    break;
            }
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            switch (((Control)sender).Name.Substring(3))
            {
                case "PreviewBusAmount":
                    LblPreviewBusAmount.ForeColor = Color.FromArgb(85, 183, 20);
                    break;

                case "PreviewBusHour":
                    LblPreviewBusHour.ForeColor = Color.FromArgb(85, 183, 20);
                    break;

                case "PreviewBusDate":
                    LblPreviewBusDate.ForeColor = Color.FromArgb(85, 183, 20);
                    break;

                default:
                    break;
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            switch (((Control)sender).Name.Substring(3))
            {
                case "PreviewBusAmount":
                    LblPreviewBusAmount.ForeColor = Color.FromArgb(14, 23, 22);
                    break;

                case "PreviewBusHour":
                    LblPreviewBusHour.ForeColor = Color.FromArgb(14, 23, 22);
                    break;

                case "PreviewBusDate":
                    LblPreviewBusDate.ForeColor = Color.FromArgb(85, 183, 20);
                    break;

                default:
                    break;
            }
        }
    }
}
