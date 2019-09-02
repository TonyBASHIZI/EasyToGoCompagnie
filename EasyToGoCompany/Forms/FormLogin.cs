using EasyToGoCompany.Classes;
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
    public partial class FormLogin : Form
    {
        private FormMain main = new FormMain();

        public FormLogin()
        {
            InitializeComponent();
        }

        public FormLogin(FormMain parent)
        {
            InitializeComponent();
            main = parent;
        }

        private void LoginRequest_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (IsAuthentic())
                {
                    User.Instance = Glossaire.Instance.LoginRequest(TxtUsername.Text, TxtPassword.Text);

                    if (User.Instance.DescriptionSession != null && User.Instance.UsernameSession != null && User.Instance.NiveauSession != 0)
                    {
                        User.Instance.UpdateFormMain();
                        this.main.RefreshOnlineStatus();
                        this.Close();
                    }
                    else
                    {
                        LblError.Text = "Le nom d'utilisateur ou le mot de passe est incorrect !";
                        TxtUsername.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Une erreur de connexion s'est produite !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Cette erreur s'est produit lors du chargement du profile : " + ex);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private bool IsAuthentic()
        {
            if (!string.IsNullOrEmpty(TxtPassword.Text) && !string.IsNullOrEmpty(TxtUsername.Text))
            {
                return true;
            }
            else
                return false;
        }       
    }
}
