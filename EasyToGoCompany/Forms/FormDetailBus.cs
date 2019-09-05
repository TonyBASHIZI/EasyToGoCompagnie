using EasyToGoCompany.Classes.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyToGoCompany.Forms
{
    public partial class FormDetailBus : Form
    {
        public FormDetailBus()
        {
            InitializeComponent();
        }

        public FormDetailBus(Bus bus)
        {
            InitializeComponent();
        }

        private void FormDetailBus_Load(object sender, EventArgs e)
        {
            try
            {
                DteByHour.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue pendant l'opération ! \n" + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBusDetail()
        {

        }
    }
}
