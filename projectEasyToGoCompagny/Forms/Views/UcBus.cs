using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyToGoCompany.Classes.Model;

namespace projectEasyToGoCompagny.Forms.Views
{
    public partial class UcBus : UserControl
    {
        public static UcBus _instance;

        public UcBus()
        {
            InitializeComponent();
        }

        public static UcBus Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UcBus();
                return _instance;
            }
        }

        private void ControleButtons_Click(object sender, EventArgs e)
        {
            string name = (((Control)sender).Name).Substring(3);

            switch (name)
            {
                case "Save":

                    break;

            }
        }

        private bool IsNotEmpty()
        {
            if (!string.IsNullOrWhiteSpace(TxtCompagnie.Text))
            {

            }

            return false;
        }

        private void CrudBus(Bus bus)
        {

        }
    }
}
