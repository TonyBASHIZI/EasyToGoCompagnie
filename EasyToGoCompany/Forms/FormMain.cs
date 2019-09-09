using EasyToGoCompany.Classes.Config;
using EasyToGoCompany.Classes.Model;
using EasyToGoCompany.Forms.Views;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EasyToGoCompany.Forms
{
    public partial class FormMain : Form
    {
        private static FormMain main;
        private Form form = null;
        private UserControl uc = null;

        public static FormMain Instance
        {
            get
            {
                if (main == null)
                {
                    main = new FormMain();
                }
                return main;
            } 
        }

        public FormMain()
        {
            InitializeComponent();           
        }

        public void RefreshOnlineStatus()
        {
            if (User.Instance.IsAuthenticate())
            {
                PnlMenu.Enabled = true;
                LblConnection.Text = "Déconnexion";
                LblStatus.Text = User.Instance.DescriptionSession;               
            }
            else
            {
                uc = UcAccueil.Instance;
                LoadUserControles(uc);
                PnlMenu.Enabled = false;
                LblStatus.Text = "Invité";
                LblConnection.Text = "Connexion";
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            GenerateConfiguration();
            RefreshOnlineStatus();
            uc = new UcAccueil();
            LoadUserControles(uc);
        }

        public void LoadUserControles(UserControl uc)
        {
            this.Cursor = Cursors.WaitCursor;
            this.PnlMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            //this.uc.MouseEnter += new System.EventHandler(this.ColorChanges_MouseEnter);

            /// On mouse enter change color of controle
  
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
                case "Dashboard":
                    uc = new UcDashboard();
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

                case "Parametre":
                    if (PnlParametreMain.Visible)
                    {
                        PnlParametreMain.Visible = false;
                    }
                    else
                    {
                        PnlParametreMain.Visible = true;
                    }
                    break;

                case "Report":
                    uc = UcReport.Instance;
                    LoadUserControles(uc);
                    break;

                case "User":
                    form = new FormUser
                    {
                        Icon = this.Icon
                    };
                    form.ShowDialog();
                    break;

                default:
                    uc = UcAccueil.Instance;
                    LoadUserControles(uc);
                    break;
            }
        }

        private void BtnConnection_Click(object sender, EventArgs e)
        {
            if (LblConnection.Text == "Connexion")
            {
                form = new FormLogin(this)
                {
                    Icon = this.Icon
                };
                form.ShowDialog(this);
            }
            else
            {
                User.Instance = null;
                UcAccueil.Instance = null;
                UcBus.Instance = null;
                UcProfil.Instance = null;
                this.RefreshOnlineStatus();
            }
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            LblConnection.ForeColor = Color.FromArgb(85, 183, 20);
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            LblConnection.ForeColor = Color.FromArgb(14, 23, 22);
        }

        private void Menu_MouseEnter(object sender, EventArgs e)
        {
            switch (((Control)sender).Name.Substring(3))
            {
                case "Dashboard":
                    LblDashboard.ForeColor = Color.FromArgb(85, 183, 20);
                    break;

                case "Profil":
                    LblProfil.ForeColor = Color.FromArgb(85, 183, 20);
                    break;

                case "Bus":
                    LblBus.ForeColor = Color.FromArgb(85, 183, 20);
                    break;

                case "Parametre":
                    LblParametre.ForeColor = Color.FromArgb(85, 183, 20);
                    break;

                case "Report":
                    LblReport.ForeColor = Color.FromArgb(85, 183, 20);
                    break;

                case "User":
                    LblUser.ForeColor = Color.FromArgb(85, 183, 20);
                    break;

                default:
                    break;
            }
        }

        private void Menu_MouseLeave(object sender, EventArgs e)
        {
            switch (((Control)sender).Name.Substring(3))
            {
                case "Dashboard":
                    LblDashboard.ForeColor = Color.FromArgb(14, 23, 22);
                    break;

                case "Profil":
                    LblProfil.ForeColor = Color.FromArgb(14, 23, 22);
                    break;

                case "Bus":
                    LblBus.ForeColor = Color.FromArgb(14, 23, 22);
                    break;

                case "Parametre":
                    LblParametre.ForeColor = Color.FromArgb(14, 23, 22);
                    break;

                case "Report":
                    LblReport.ForeColor = Color.FromArgb(14, 23, 22);
                    break;

                case "User":
                    LblUser.ForeColor = Color.FromArgb(14, 23, 22);
                    break;

                default:
                    break;
            }
        }
    }
}
