using EasyToGoCompany.Classes;
using EasyToGoCompany.Classes.Config;
using EasyToGoCompany.Classes.Model;
using System;
using System.Windows.Forms;

namespace EasyToGoCompany.Forms
{
    public partial class FormAxe : Form
    {
        private Axe axe = null;
        private int id = 0;

        public FormAxe()
        {
            InitializeComponent();
        }

        private void FormAxe_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            try
            {
                GridView.DataSource = Glossaire.Instance.LoadDatas(Constant.Table.Axe, " ", " ", null).Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue pendant l'opération ! \n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ControleButtons_Click(object sender, EventArgs e)
        {
            switch ((((ToolStripButton)sender).Name).Substring(3))
            {
                case "New":
                    ClearFields();
                    break;

                case "Save":
                    CrudOperations();
                    break;

                case "Delete":
                    CrudOperations(false);
                    break;

                default:
                    break;
            }
        }

        private void ClearFields()
        {
            id = 0;
            TxtDescription.Text = "";
            TxtDesignation.Text = "";
            TxtMontant.Text = "";
            TxtDesignation.Focus();
            BtnDelete.Enabled = false;
            BtnSave.Enabled = true;
        }

        private void CrudOperations(bool save = true)
        {
            try
            {
                if (IsAuthentic())
                {
                    Cursor = Cursors.WaitCursor;

                    axe = new Axe
                    {
                        Id = id,
                        Description = TxtDescription.Text.Trim(),
                        Designation = TxtDesignation.Text.Trim().ToUpper(),
                        Montant = Convert.ToInt32(TxtMontant.Text.Trim())
                    };


                    if (save)
                    {
                        Glossaire.Instance.InsertUpdateAxe(axe);
                        ClearFields();
                    }
                    else
                    {
                        if (MessageBox.Show(this, "Voulez-vous vraiment supprimer ? ", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            Glossaire.Instance.Delete(Constant.Table.Axe, axe.Id);
                            ClearFields();
                        }
                    }

                    LoadDataGridView();
                    Cursor = Cursors.Default;
                }
                else
                {
                    MessageBox.Show(this, "Certains champs ne sont pas conformes.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Enregistrement impossible, Veiller vérifier la conformité de données.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private bool IsAuthentic()
        {
            if (!string.IsNullOrEmpty(TxtDesignation.Text) && !string.IsNullOrEmpty(TxtDescription.Text)
                    && !string.IsNullOrEmpty(TxtMontant.Text) && IsNumeric(TxtMontant.Text))
            {
                return true;
            }
            else
                return false;
        }

        private bool IsNumeric(string nombre)
        {
            try
            {
                int.Parse(nombre);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (GridView.SelectedRows.Count > 0)
                {
                    axe = new Axe
                    {
                        Id = Convert.ToInt32(GridView.SelectedRows[0].Cells["DgvId"].Value.ToString()),
                        Description = GridView.SelectedRows[0].Cells["DgvDescription"].Value.ToString(),
                        Designation = GridView.SelectedRows[0].Cells["DgvDesignation"].Value.ToString(),
                        Montant = Convert.ToInt32(GridView.SelectedRows[0].Cells["DgvMontant"].Value.ToString())
                    };

                    id = axe.Id;
                    TxtDescription.Text = axe.Description;
                    TxtDesignation.Text = axe.Designation;
                    TxtMontant.Text = axe.Montant.ToString();

                    BtnSave.Enabled = true;
                    BtnDelete.Enabled = true;
                }
                else
                {
                    BtnSave.Enabled = false;
                    BtnDelete.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue pendant l'opération ! \n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }
}
