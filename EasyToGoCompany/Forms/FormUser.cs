using EasyToGoCompany.Classes;
using EasyToGoCompany.Classes.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EasyToGoCompany.Forms
{
    public partial class FormUser : Form
    {
        private string password = null;
        private User user = null;

        public FormUser()
        {
            InitializeComponent();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            try
            {
                if (User.Instance.IdSession == 0)
                    PnlEdit.Enabled = false;
                else
                {
                    PnlEdit.Enabled = true;
                    password = User.Instance.PasswordSession;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Une erreur s'est produite lors de l'opération", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Cette erreur s'est produite lors de l'opération : " + ex);
            }
        }

        private void ShowPassword_Click(object sender, EventArgs e)
        {
            switch ((((Control)sender).Name).Substring(3))
            {
                case "LastPassword":
                    TxtLastPassword.UseSystemPasswordChar = TxtLastPassword.UseSystemPasswordChar ? false : true;
                    break;

                case "NewPassword1":
                    TxtNewPassword1.UseSystemPasswordChar = TxtNewPassword1.UseSystemPasswordChar ? false : true;
                    break;

                case "NewPassword2":
                    TxtNewPassword2.UseSystemPasswordChar = TxtNewPassword2.UseSystemPasswordChar ? false : true;
                    break;

                default:
                    break;
            }
        }

        private void Controles_Click(object sender, EventArgs e)
        {
            switch ((((Control)sender).Name).Substring(3))
            {
                case "Edit":
                    UpdateUser();
                    break;

                case "Cancel":
                    ClearField();
                    break;

                default:
                    break;
            }
        }

        private void ClearField()
        {
            TxtLastPassword.Text = string.Empty;
            TxtNewPassword1.Text = string.Empty;
            TxtNewPassword2.Text = string.Empty;
            TxtUsername.Text = string.Empty;
            TxtUsername.Focus();
        }

        private void UpdateUser()
        {
            try
            {
                if (!string.IsNullOrEmpty(TxtLastPassword.Text) && !string.IsNullOrEmpty(TxtNewPassword1.Text)
                    && !string.IsNullOrEmpty(TxtNewPassword2.Text) && !string.IsNullOrEmpty(TxtUsername.Text))
                {
                    if (password.Equals(TxtLastPassword.Text))
                    {
                        if (! TxtNewPassword1.Text.Equals(TxtNewPassword2.Text))
                        {
                            MessageBox.Show(this, "Les deux mots de passe ne sont pas identiques !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            TxtNewPassword1.Focus();
                        }
                        else
                        {
                            user = new User
                            {
                                Username = TxtUsername.Text,
                                Password = TxtNewPassword2.Text
                            };

                            if (Glossaire.Instance.UpdateUser(user))
                            {
                                if (MessageBox.Show(this, "Information enregistrée avec succès !\n\nL'application doit rédemarrer pour appliquer les modifications.", "Rédemarrage requis", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                                {
                                    Application.Restart();
                                }
                                else
                                {
                                    //
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "Votre mot de passe est incorrect !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtLastPassword.Focus();
                    }
                }
                else
                {
                    MessageBox.Show(this, "Remplisser tous les champs svp !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtUsername.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Une erreur s'est produite lors de l'opération", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Cette erreur s'est produite lors de l'opération : " + ex);
            }
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            switch (((Control)sender).Name.Substring(3))
            {
                case "Edit":
                    LblEdit.ForeColor = Color.FromArgb(85, 183, 20);
                    break;

                case "Cancel":
                    LblCancel.ForeColor = Color.FromArgb(85, 183, 20);
                    break;

                default:
                    break;
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            switch (((Control)sender).Name.Substring(3))
            {
                case "Edit":
                    LblEdit.ForeColor = Color.FromArgb(14, 23, 22);
                    break;

                case "Cancel":
                    LblCancel.ForeColor = Color.FromArgb(14, 23, 22);
                    break;

                default:
                    break;
            }
        }
    }
}
