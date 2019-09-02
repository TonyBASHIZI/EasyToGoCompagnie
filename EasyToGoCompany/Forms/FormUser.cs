using EasyToGoCompany.Classes.Model;
using System;
using System.Windows.Forms;

namespace EasyToGoCompany.Forms
{
    public partial class FormUser : Form
    {
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
                    PnlEdit.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Une erreur s'est produite lors de l'opération", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Cette erreur s'est produite lors de l'opération : " + ex);
            }
        }

        private void ShowPassword_Click(object sender, EventArgs e)
        {
            string name = (((Control)sender).Name).Substring(3);

            switch (name)
            {
                case "LastPassword":
                    if (TxtLastPassword.UseSystemPasswordChar)
                        TxtLastPassword.UseSystemPasswordChar = false;
                    else
                        TxtLastPassword.UseSystemPasswordChar = true;
                    break;

                case "NewPassword1":
                    if (TxtNewPassword1.UseSystemPasswordChar)
                        TxtNewPassword1.UseSystemPasswordChar = false;
                    else
                        TxtNewPassword1.UseSystemPasswordChar = true;
                    break;

                case "NewPassword2":
                    if (TxtNewPassword2.UseSystemPasswordChar)
                        TxtNewPassword2.UseSystemPasswordChar = false;
                    else
                        TxtNewPassword2.UseSystemPasswordChar = true;
                    break;

                default:
                    break;
            }
        }

        private void Controles_Click(object sender, EventArgs e)
        {
            string name = (((Control)sender).Name).Substring(3);

            switch (name)
            {
                case "Edit":
                    /// TODO: Insert and update user here
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
    }
}
