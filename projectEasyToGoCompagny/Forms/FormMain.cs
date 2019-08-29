using EasyToGoCompany.Classes.Config;
using projectEasyToGoCompagny.Forms.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectEasyToGoCompagny.Forms
{
    public partial class FormMain : Form
    {
        private Form frm = null;
        private UserControl uc = null;

        public FormMain()
        {
            InitializeComponent();
            uc = new UcAccueil();
            LoadUserControles(uc);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            GenerateConfiguration();
        }

        public void LoadUserControles(UserControl uc)
        {
            this.Cursor = Cursors.WaitCursor;
            this.PnlMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            //this.uc.MouseEnter += new System.EventHandler(this.ColorChanges_MouseEnter);
            this.PnlMain.Controls.Add(uc);
            uc.Show();

            if (uc.Visible == true)
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void GenerateConfiguration()
        {
            if (!AppConfig.InitialDirectoryExist())
            {
                AppConfig.CreateInitialDirectory();

                if (!AppConfig.ConnectionStringExist())
                {
                    AppConfig.CreateConnectionDirectory();
                    AppConfig.CreateConnectionString();
                }
            }
            else
            {
                if (!AppConfig.ConnectionStringExist())
                {
                    AppConfig.CreateConnectionDirectory();
                    AppConfig.CreateConnectionString();
                }

                ///  TODO: Add this section to login form for connection string vérification
                if (AppConfig.ConnectionStringEmpty())
                {
                    MessageBox.Show(this, "Veuillez contacter l'administrateur système pour la configuration.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }          
        }

        private void NavigationControles_Click(object sender, EventArgs e)
        {
            string controlName = ((Control)sender).Name.Substring(3);
            switch (controlName)
            {
                case "Accueil":
                    uc = UcAccueil.Instance;
                    LoadUserControles(uc);
                    break;

                case "Dashboard":
                    uc = UcDashboard.Instance;
                    LoadUserControles(uc);
                    break;

                case "Bus":
                    uc = UcBus.Instance;
                    LoadUserControles(uc);
                    break;
            }
        }
    }
}
