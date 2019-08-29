using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectEasyToGoCompagny.Forms.Views
{
    public partial class UcAccueil : UserControl
    {
        public static UcAccueil _instance;

        public UcAccueil()
        {
            InitializeComponent();
        }

        public static UcAccueil Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UcAccueil();
                return _instance;
            }
        }
    }
}
