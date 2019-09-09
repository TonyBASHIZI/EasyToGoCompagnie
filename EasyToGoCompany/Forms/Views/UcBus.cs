using System;
using System.Windows.Forms;
using EasyToGoCompany.Classes.Model;
using EasyToGoCompany.Classes;
using EasyToGoCompany.Classes.Config;

namespace EasyToGoCompany.Forms.Views
{
    public partial class UcBus : UserControl
    {
        private static UcBus _instance;

        private Form form = null;
        private Bus bus = null;
        private int id = 0;

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

            set
            {
                _instance = value;
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
            try
            {
                GridView.DataSource = Glossaire.Instance.LoadDatas(Constant.Table.Bus, " ", "ref_compagnie", User.Instance.DescriptionSession).Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue pendant l'opération ! \n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            id = 0;
            CmbEtatBus.Text = "ACTIF";
            TxtMarque.Text = "";
            TxtNumero.Text = "";
            TxtNumPos.Text = "";
            TxtAnneeFabrication.Text = "";
            DteMiseCirculation.Text = DateTime.Now.ToString();
            TxtPlace.Text = "0";
            TxtKilometrage.Text = "0";
            TxtPlaque.Text = "";
            TxtNumero.Focus();
            BtnDelete.Enabled = false;
            BtnSave.Enabled = true;
            ErrorProvider.Clear();
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
                    && !string.IsNullOrEmpty(TxtPlace.Text)
                    && !string.IsNullOrEmpty(TxtMarque.Text) && !string.IsNullOrEmpty(TxtPlaque.Text)
                    && !string.IsNullOrEmpty(TxtAnneeFabrication.Text) && !string.IsNullOrEmpty(TxtKilometrage.Text)
                    && IsNumeric(TxtPlace.Text) && IsNumeric(TxtAnneeFabrication.Text)
                    && IsNumeric(TxtKilometrage.Text) && !string.IsNullOrEmpty(CmbEtatBus.Text))
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
                    if (all == false && !IsNumeric(TxtPlace.Text))
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

                case "AnneeFabrication":
                    IsAuthentic(TxtAnneeFabrication);
                    break;

                case "Kilometrage":
                    IsAuthentic(TxtKilometrage);
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
                        RefCompagnie = User.Instance.DescriptionSession,
                        Place = Convert.ToInt32(TxtPlace.Text.Trim()),
                        Marque = TxtMarque.Text.Trim(),
                        Plaque = TxtPlaque.Text.Trim(),
                        AnneeFabrication = TxtAnneeFabrication.Text.Trim(),
                        Kilometrage = TxtKilometrage.Text.Trim(),
                        MiseEnCirculation = DteMiseCirculation.Value,
                        Etat = CmbEtatBus.Text
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
                    MessageBox.Show(this, "Certains champs ne sont pas conformes.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Enregistrement impossible, Veiller vérifier la conformité de données.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);              
            }
            finally
            {
                this.Cursor = Cursors.Default;
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
                        MiseEnCirculation = Convert.ToDateTime(GridView.SelectedRows[0].Cells["DgvMiseEnCirculation"].Value.ToString()),
                        Kilometrage = GridView.SelectedRows[0].Cells["DgvKilometrage"].Value.ToString(),
                        AnneeFabrication = GridView.SelectedRows[0].Cells["DgvAnneeFab"].Value.ToString(),
                        Etat = GridView.SelectedRows[0].Cells["GvcEtat"].Value.ToString()
                    };

                    if (bus !=  null)
                    {
                        this.Cursor = Cursors.WaitCursor;
                        form = new FormDetailBus(bus);                        
                        form.ShowDialog(this);

                        if (form.Visible)
                        {
                            this.Cursor = Cursors.Default;
                        }
                    }

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
                this.Cursor = Cursors.Default;
            }
        }

        private void GridView_Click(object sender, EventArgs e)
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
                        MiseEnCirculation = Convert.ToDateTime(GridView.SelectedRows[0].Cells["DgvMiseEnCirculation"].Value.ToString()),
                        Kilometrage = GridView.SelectedRows[0].Cells["DgvKilometrage"].Value.ToString(),
                        AnneeFabrication = GridView.SelectedRows[0].Cells["DgvAnneeFab"].Value.ToString(),
                        Etat = GridView.SelectedRows[0].Cells["GvcEtat"].Value.ToString()
                    };

                    id = bus.Id;
                    TxtMarque.Text = bus.Marque;
                    TxtNumero.Text = bus.Numero;
                    TxtNumPos.Text = bus.RefNumeroPos;
                    TxtPlace.Text = bus.Place.ToString();
                    TxtPlaque.Text = bus.Plaque;
                    TxtAnneeFabrication.Text = bus.AnneeFabrication;
                    TxtKilometrage.Text = bus.Kilometrage;
                    DteMiseCirculation.Text = bus.MiseEnCirculation.ToString();
                    CmbEtatBus.Text = bus.Etat;

                    LblMontant.Text = Glossaire.Instance.GetAmountByBus(bus.Plaque.ToString()).ToString();

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
                this.Cursor = Cursors.Default;
            }
        }

        /// TODO: Add ContextMenu strip

    }
}
