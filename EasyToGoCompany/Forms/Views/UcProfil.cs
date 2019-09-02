using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyToGoCompany.Classes;
using EasyToGoCompany.Classes.Model;
using System.IO;

namespace EasyToGoCompany.Forms.Views
{
    public partial class UcProfil : UserControl
    {
        public static UcProfil _instance;
        private Compagnie compagnie = null;
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
            byte[] bytes = (byte[])obj;
            MemoryStream ms = new MemoryStream(bytes);

            return Image.FromStream(ms);
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

                    TxtNom.Text = compagnie.Noms;
                    TxtAdresse.Text = compagnie.Adresse;
                    TxtRccm.Text = compagnie.Rccm;
                    TxtDescriptionEdit.Text = compagnie.Description;
                    PcbEdit.Image = compagnie.Photo == null ? Properties.Resources.user : SetImage(compagnie.Photo);
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
            if (LblEdit.Text == "Modifier")
            {
                GrbEdit.Visible = true;
                LblEdit.Text = "Enregistrer";
            }
            else if (LblEdit.Text == "Enregistrer")
            {
                GrbEdit.Visible = false;
                LblEdit.Text = "Modifier";

                compagnie = new Compagnie
                {
                    Id = id,
                    Noms = TxtNom.Text.Trim(),
                    Adresse = TxtAdresse.Text.Trim(),
                    Rccm = TxtRccm.Text.Trim(),
                    Description = TxtDescription.Text.Trim(),
                    Photo = GetImage(PcbEdit)
                };

                try
                {
                    Glossaire.Instance.InsertUpdateCompagnie(compagnie);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Le profile n'a pu être modifié", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine("Cette erreur s'est produite lors de la modification du profile : " + ex);
                }
                finally
                {
                    if (MessageBox.Show(this, "L'application doit rédemarrer pour appliqué toutes les modifications.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        Application.Restart();
                    }
                    else
                    {
                        //
                    }
                }
            }
            this.Cursor = Cursors.Default;
        }

        private void PnlAdd_Click(object sender, EventArgs e)
        {
            string path = null;
            OpenFileDialog.FileName = "profile_picture";

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
        }        
    }
}
