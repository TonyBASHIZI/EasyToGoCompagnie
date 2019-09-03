using EasyToGoCompany.Classes.Config;
using EasyToGoCompany.Classes.Model;
using EasyToGoCompany.Forms.Views;
using System;
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
                LblConnection.Text = "Déconnection";
                StatusLabel.Text = User.Instance.DescriptionSession;
            }
            else
            {
                uc = UcAccueil.Instance;
                LoadUserControles(uc);
                PnlMenu.Enabled = false;
                StatusLabel.Text = "Invité";
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

                case "AllBus":
                    //
                    break;

                case "BusInactifs":
                    //
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
                UcDashboard.Instance = null;
                UcProfil.Instance = null;
                this.RefreshOnlineStatus();
            }
        }
    }
}
