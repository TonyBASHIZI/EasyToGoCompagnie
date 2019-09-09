using EasyToGoCompany.Classes;
using EasyToGoCompany.Classes.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EasyToGoCompany.Forms
{
    public partial class FormLogin : Form
    {
        private FormMain main = new FormMain();

        public FormLogin(FormMain parent)
        {
            InitializeComponent();
            main = parent;
        }

        private void LoginRequest_Click(object sender, EventArgs e)
        {
            LoginProcess();
        }

        private bool IsAuthentic()
        {
            return !string.IsNullOrEmpty(TxtPassword.Text) && !string.IsNullOrEmpty(TxtUsername.Text) ? true : false;
        } 
        
        private void LoginProcess()
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                if (IsAuthentic())
                {
                    User.Instance = Glossaire.Instance.LoginRequest(TxtUsername.Text, TxtPassword.Text);

                    if (User.Instance.DescriptionSession != null && User.Instance.UsernameSession != null
                        && User.Instance.NiveauSession != 0 && User.Instance.PasswordSession != null)
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
                MessageBox.Show(this, "Une erreur de connexion s'est produite. \nVeillez contacter l'administrateur système !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Cette erreur s'est produit lors du chargement du profile : " + ex);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginProcess();
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
    }
}
