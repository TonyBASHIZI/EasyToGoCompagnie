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
                    /// TODO: Add Refresh function
                    break;
            }
        }

        private void ClearFields()
        {
            id = 0;
            TxtCompagnie.Text = string.Empty;
            TxtMarque.Text = string.Empty;
            TxtNumero.Text = string.Empty;
            TxtNumPos.Text = string.Empty;
            TxtPlace.Text = string.Empty;
            TxtPlaque.Text = string.Empty;
        }

        private bool IsAuthentic(Control control = null, bool all = false)
        {
            if (control == null && all == false)
            {
                if (!string.IsNullOrWhiteSpace(TxtNumero.Text) && !string.IsNullOrWhiteSpace(TxtNumPos.Text)
                    && !string.IsNullOrWhiteSpace(TxtCompagnie.Text) && !string.IsNullOrWhiteSpace(TxtPlace.Text)
                    && !string.IsNullOrWhiteSpace(TxtMarque.Text) && !string.IsNullOrWhiteSpace(TxtPlaque.Text))
                {
                    return true;
                }
                else
                    return false;
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(control.Text))
                {
                    ErrorProvider.Clear();
                    return true;
                }
                else
                {
                    if (control.Name.Equals("TxtPlace")) /// TODO: Test if TxtPlace is numerique
                    {
                        ErrorProvider.SetError(control, "Ce champ ne peut prendre que les fichres");
                        return false;
                    }
                    else
                    {
                        ErrorProvider.SetError(control, "Ce champ ne peut pas être vide");
                        return false;
                    }
                }
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
                    IsAuthentic(TxtPlace);
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
            if (IsAuthentic())
            {
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
            }
            else
            {
                MessageBox.Show(this, "Certains champs ne sont pas conformes.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// TODO: Add Binding navigator for datas
        
        /// TODO: Add Selected Rows in DataGridView
        
    }
}
