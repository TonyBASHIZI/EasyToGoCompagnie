using EasyToGoCompany.Classes.Config;
using EasyToGoCompany.Forms.Views;
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
    public partial class FormMain : Form
    {
        private Form form = null;
        private UserControl uc = null;

        public FormMain()
        {
            InitializeComponent();           
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            StatusLabel.Text = "";
            GenerateConfiguration();
            uc = new UcAccueil();
            LoadUserControles(uc);
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

                case "Profil":
                    uc = UcProfil.Instance;
                    LoadUserControles(uc);
                    break;
            }
        }

        private void BtnConnection_Click(object sender, EventArgs e)
        {
            form = new FormLogin
            {
                Icon = this.Icon
            };
            form.ShowDialog(this);
        }
    }
}
