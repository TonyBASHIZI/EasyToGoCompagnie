using System.Windows.Forms;

namespace EasyToGoCompany.Forms.Views
{
    public partial class UcAccueil : UserControl
    {
        private static UcAccueil _instance;

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

            set
            {
                _instance = value;
            }
        }
    }
}
