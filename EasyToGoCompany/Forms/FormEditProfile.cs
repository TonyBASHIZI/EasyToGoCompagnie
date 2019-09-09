using EasyToGoCompany.Classes;
using EasyToGoCompany.Classes.Model;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EasyToGoCompany.Forms
{
    public partial class FormEditProfile : Form
    {
        private Compagnie compagnie = null;
        private int id = 0;

        public FormEditProfile()
        {
            InitializeComponent();
        }

        public FormEditProfile(Compagnie compagnie)
        {
            InitializeComponent();
            this.compagnie = compagnie;
        }

        private byte[] GetImage(PictureBox picture)
        {
            MemoryStream ms = new MemoryStream();
            Bitmap bitmap = new Bitmap(picture.Image);
            byte[] byteImage;
            bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            byteImage = ms.ToArray();
            ms.Close();

            return byteImage;
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

        private void Controles_Click(object sender, EventArgs e)
        {
            switch (((Control)sender).Name.Substring(3))
            {
                case "Add":

                    string path = null;
                    OpenFileDialog.FileName = "photo";

                    /// TODO: Add open file dialog file filter 

                    if (OpenFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        if (OpenFileDialog.FileName != string.Empty)
                        {
                            PcbEdit.Image = Image.FromFile(OpenFileDialog.FileName);
                            PcbEdit.Tag = OpenFileDialog.FileName;
                            path = OpenFileDialog.FileName;
                        }
                    }
                    else
                    {
                        path = string.Empty;
                        PcbEdit.Tag = "";
                    }

                    break;

                case "Edit":
                    UpdateProfile();
                    break;

                default:
                    break;
            }
        }

        private void FormEditProfile_Load(object sender, EventArgs e)
        {
            if (compagnie != null)
            {
                id = compagnie.Id;
                TxtNom.Text = compagnie.Noms;
                TxtAdresse.Text = compagnie.Adresse;
                TxtRccm.Text = compagnie.Rccm;
                TxtDescriptionEdit.Text = compagnie.Description;
                PcbEdit.Image = compagnie.Photo == null ? Properties.Resources.user : SetImage(compagnie.Photo);

                this.Text = compagnie.Noms;
            }
        }

        private void UpdateProfile()
        {
            try
            {
                compagnie = new Compagnie
                {
                    Id = id,
                    Noms = TxtNom.Text.Trim(),
                    Adresse = TxtAdresse.Text.Trim(),
                    Rccm = TxtRccm.Text.Trim(),
                    Description = TxtDescriptionEdit.Text.Trim(),
                    Photo = GetImage(PcbEdit)
                };

                Glossaire.Instance.InsertUpdateCompagnie(compagnie);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Le profile n'a pu être modifié", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Cette erreur s'est produite lors de la modification du profile : " + ex);
            }
            finally
            {
                if (MessageBox.Show(this, "Modification enregistrée avec succès !\n\nL'application doit rédemarrer pour appliqué toutes les modifications.", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    Application.Restart();
                }
                else
                {
                    //
                }
            }
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            switch (((Control)sender).Name.Substring(3))
            {
                case "Edit":
                    LblEdit.ForeColor = Color.FromArgb(85, 183, 20);
                    break;

                case "Add":
                    LblAdd.ForeColor = Color.FromArgb(85, 183, 20);
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

                case "Add":
                    LblAdd.ForeColor = Color.FromArgb(14, 23, 22);
                    break;

                default:
                    break;
            }
        }
    }
}

