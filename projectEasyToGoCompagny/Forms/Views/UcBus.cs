using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyToGoCompany.Classes.Model;
using EasyToGoCompany.Classes;
using EasyToGoCompany.Classes.Config;

namespace projectEasyToGoCompagny.Forms.Views
{
    public partial class UcBus : UserControl
    {
        public static UcBus _instance;

        private int id = 0;
        private Bus bus = null;

        public UcBus()
        {
            InitializeComponent();
        }

        public static UcBus Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UcBus();
                return _instance;
            }
        }

        private void UcBus_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void ControleButtons_Click(object sender, EventArgs e)
        {
            string name = (((ToolStripButton)sender).Name).Substring(3);

            switch (name)
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

                case "Refresh":
                    this.Cursor = Cursors.WaitCursor;
                    LoadDataGridView();
                    this.Cursor = Cursors.Default;
                    break;
            }
        }

        private void LoadDataGridView()
        {
            GridView.DataSource = Glossaire.Instance.LoadGrid(Constant.Table.Bus, "id");
        }

        private void ClearFields()
        {
            id = 0;
            TxtMarque.Text = string.Empty;
            TxtNumero.Text = string.Empty;
            TxtNumPos.Text = string.Empty;
            TxtPlace.Text = string.Empty;
            TxtPlaque.Text = string.Empty;
            TxtNumero.Focus();
            BtnDelete.Enabled = false;
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

        private bool IsAuthentic(Control control = null, bool all = true)
        {
            if (control == null && all == true)
            {
                if (!string.IsNullOrEmpty(TxtNumero.Text) && !string.IsNullOrEmpty(TxtNumPos.Text)
                    && !string.IsNullOrEmpty(TxtCompagnie.Text) && !string.IsNullOrEmpty(TxtPlace.Text)
                    && !string.IsNullOrEmpty(TxtMarque.Text) && !string.IsNullOrEmpty(TxtPlaque.Text)
                    && IsNumeric(TxtPlace.Text))
                {
                    return true;
                }
                else
                    return false;
            }
            else if(control != null)
            {
                if (!string.IsNullOrEmpty(control.Text))
                {
                    if (all == false && !IsNumeric(TxtPlace.Text)) /// TODO: Test if TxtPlace is numerique
                    {
                        ErrorProvider.SetError(control, "Ce champ ne peut prendre que les fichres");
                        return false;
                    }
                    else
                    {
                        ErrorProvider.Clear();
                        return true;
                    }                  
                }
                else
                {
                    ErrorProvider.SetError(control, "Ce champ ne peut pas être vide");
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void TextControle_Leave(object sender, EventArgs e)
        {
            string name = (((Control)sender).Name).Substring(3);

            switch (name)
            {
                case "Numero":
                    IsAuthentic(TxtNumero);
                    break;

                case "Compagnie":
                    IsAuthentic(TxtCompagnie);
                    break;

                case "NumPos":
                    IsAuthentic(TxtNumPos);
                    break;

                case "Place":
                    IsAuthentic(TxtPlace, false);
                    break;

                case "Plaque":
                    IsAuthentic(TxtPlaque);
                    break;

                case "Marque":
                    IsAuthentic(TxtMarque);
                    break;
            }
        }

        private void CrudOperations(bool save = true)
        {
            try
            {
                if (IsAuthentic())
                {
                    this.Cursor = Cursors.WaitCursor;

                    bus = new Bus
                    {
                        Id = id,
                        Numero = TxtNumero.Text.Trim(),
                        RefNumeroPos = TxtNumPos.Text.Trim(),
                        RefCompagnie = TxtCompagnie.Text.Trim(),
                        Place = Convert.ToInt32(TxtPlace.Text.Trim()),
                        Marque = TxtMarque.Text.Trim(),
                        Plaque = TxtPlaque.Text.Trim()
                    };


                    if (save)
                    {
                        Glossaire.Instance.InsertUpdateBus(bus);
                    }
                    else
                    {
                        if (MessageBox.Show(this, "Voulez-vous vraiment supprimer ? ", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            Glossaire.Instance.Delete(Constant.Table.Bus, bus.Id);
                            ClearFields();
                        }
                    }

                    LoadDataGridView();

                    this.Cursor = Cursors.Default;
                }
                else
                {
                    MessageBox.Show(this, "Certains champs ne sont pas conformes.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Enregistrement impossible, Veiller vérifier la conformité de données.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);              
            }
        }

        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (GridView.SelectedRows.Count > 0)
                {
                    bus = new Bus()
                    {
                        Id = Convert.ToInt32(GridView.SelectedRows[0].Cells["DgvId"].Value.ToString()),
                        Place = Convert.ToInt32(GridView.SelectedRows[0].Cells["DgvPlace"].Value.ToString()),
                        Marque = GridView.SelectedRows[0].Cells["DgvMarque"].Value.ToString(),
                        Numero = GridView.SelectedRows[0].Cells["DgvNumero"].Value.ToString(),
                        Plaque = GridView.SelectedRows[0].Cells["DgvPlaque"].Value.ToString(),
                        RefCompagnie = GridView.SelectedRows[0].Cells["DgvCompagnie"].Value.ToString(),
                        RefNumeroPos = GridView.SelectedRows[0].Cells["DgvNumPos"].Value.ToString(),
                    };

                    id = bus.Id;
                    TxtCompagnie.Text = bus.RefCompagnie;
                    TxtMarque.Text = bus.Marque;
                    TxtNumero.Text = bus.Numero;
                    TxtNumPos.Text = bus.RefNumeroPos;
                    TxtPlace.Text = bus.Place.ToString();
                    TxtPlaque.Text = bus.Plaque;

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
                MessageBox.Show("Une erreur est survenue pendant l'opération ! \n" +ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        /// TODO: Add Binding navigator for datas

    }
}
