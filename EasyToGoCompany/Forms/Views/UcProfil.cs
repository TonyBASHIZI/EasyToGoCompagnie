using System;
using System.Drawing;
using System.Windows.Forms;
using EasyToGoCompany.Classes;
using EasyToGoCompany.Classes.Model;
using System.IO;

namespace EasyToGoCompany.Forms.Views
{
    public partial class UcProfil : UserControl
    {
        private static UcProfil _instance;
        private Compagnie compagnie = null;
        private Form form = null;
        private int id = 0;

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

            set
            {
                _instance = value;
            }
        }

        private Image SetImage(object obj)
        {
            try
            {
                byte[] bytes = (byte[])obj;
                MemoryStream ms = new MemoryStream(bytes);

                return Image.FromStream(ms);
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void UcProfil_Load(object sender, EventArgs e)
        {
            LoadCompagnyProfile();
        }

        private void LoadCompagnyProfile()
        {
            try
            {
                compagnie = Glossaire.Instance.GetCompagnie(User.Instance.DescriptionSession);

                if (compagnie != null)
                {
                    id = compagnie.Id;
                    LblNom.Text = compagnie.Noms;
                    LblAdresse.Text = compagnie.Adresse;
                    LblRccm.Text = compagnie.Rccm;
                    TxtDescription.Text = compagnie.Description;
                    PcbProfile.Image = compagnie.Photo == null ? Properties.Resources.user : SetImage(compagnie.Photo);                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Le profile n'a pu être bien chargé", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Cette erreur s'est produite lors du chargement du profile : " + ex);
            }
        }

        private void PnlEdit_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if (compagnie != null)
            {
                form = new FormEditProfile(compagnie);
                form.ShowInTaskbar = false;
                form.ShowDialog(this);
            }

            this.Cursor = Cursors.Default;
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            LblEdit.ForeColor = Color.FromArgb(85, 183, 20);
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            LblEdit.ForeColor = Color.FromArgb(14, 23, 22);
        }
    }
}
