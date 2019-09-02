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

namespace EasyToGoCompany.Forms.Views
{
    public partial class UcBus : UserControl
    {
        public static UcBus _instance;

        private Bus bus = null;
        private BindingSource bindSource = null;

        public UcBus()
        {
            InitializeComponent();
            bindSource = new BindingSource();
            TxtCompagnie.Text = User.Instance.DescriptionSession;
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
            GridView.DataSource = Glossaire.Instance.LoadDatas(Constant.Table.Bus, "id").Tables[0].DefaultView;
            bindSource.DataSource = Glossaire.Instance.LoadDatas(Constant.Table.Bus, "id").Tables[0].DefaultView;
            BindNavig.BindingSource = bindSource;
            bindSource.CurrentChanged += BindingBus_CurrentChanged;
        }

        private void ClearFields()
        {
            TxtId.Text = "0";
            TxtMarque.Text = "";
            TxtNumero.Text = "";
            TxtNumPos.Text = "";
            TxtPlace.Text = "0";
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

        private void BindingBus_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                SetBinding(TxtId, "Text", "id");
                SetBinding(TxtNumero, "Text", "numero");
                SetBinding(TxtCompagnie, "Text", "ref_compagnie");
                SetBinding(TxtMarque, "Text", "marque");
                SetBinding(TxtNumPos, "Text", "ref_pos");
                SetBinding(TxtPlace, "Text", "place");
                SetBinding(TxtPlaque, "Text", "plaque");

                BtnSave.Enabled = false;
                BtnDelete.Enabled = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void SetBinding(Control control, string properties, string accessor)
        {
            try
            {                
                Binding binding = new Binding(properties, bindSource.Current, accessor, true, DataSourceUpdateMode.OnPropertyChanged);
                binding.BindingComplete += BindingBus_BindingComplete;

                control.DataBindings.Clear();
                control.DataBindings.Add(binding);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void BindingBus_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            try
            {
                if (e.Cancel)
                {
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
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
                        Id = Convert.ToInt32(TxtId.Text.Trim()),
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

                    TxtId.Text = bus.Id.ToString();
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

        /// TODO: Add ContextMenu strip

    }
}
