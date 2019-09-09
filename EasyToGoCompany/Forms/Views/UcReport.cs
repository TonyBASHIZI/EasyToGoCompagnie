using System;
using System.Windows.Forms;
using EasyToGoCompany.Classes.Model;
using System.Drawing;

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
                    this.Cursor = Cursors.WaitCursor;
                    form = new FormReport(User.Instance.DescriptionSession);
                    form.ShowInTaskbar = false;
                    form.ShowDialog(this);
                    this.Cursor = Cursors.Default;
                    break;

                case "PreviewBusHour":
                    this.Cursor = Cursors.WaitCursor;
                    form = new FormReport(User.Instance.DescriptionSession, DteByHour.Value.ToString(), TxtBegin.Text, TxtEnd.Text);
                    form.ShowInTaskbar = false;
                    form.ShowDialog(this);
                    this.Cursor = Cursors.Default;
                    break;

                case "PreviewBusDate":
                    this.Cursor = Cursors.WaitCursor;
                    form = new FormReport(User.Instance.DescriptionSession, DteBegin.Value.ToString(), DteEnd.Value.ToString());
                    form.ShowInTaskbar = false;
                    form.ShowDialog(this);
                    this.Cursor = Cursors.Default;
                    break;

                default:
                    this.Cursor = Cursors.Default;
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
