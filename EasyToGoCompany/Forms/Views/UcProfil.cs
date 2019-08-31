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
    public partial class UcProfil : UserControl
    {
        public static UcProfil _instance;

        public UcProfil()
        {
            InitializeComponent();
        }

        public static UcProfil Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UcProfil();
                return _instance;
            }
        }

        private void PnlEdit_Click(object sender, EventArgs e)
        {
            if (LblEdit.Text == "Modifier")
            {
                GrbEdit.Visible = true;
                LblEdit.Text = "Enregistrer";
            }
            else if (LblEdit.Text == "Enregistrer")
            {
                GrbEdit.Visible = false;
                LblEdit.Text = "Modifier";
            }
        }

        private void PnlAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
