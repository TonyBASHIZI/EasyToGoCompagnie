using EasyToGoCompany.Classes;
using EasyToGoCompany.Classes.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EasyToGoCompany.Forms
{
    public partial class FormDetailBus : Form
    {
        private Bus bus = null;
        private int second = 0;

        public FormDetailBus(Bus bus)
        {
            InitializeComponent();
            DteByHour.Value = DateTime.Now;
            this.bus = bus;
        }

        private void FormDetailBus_Load(object sender, EventArgs e)
        {
            TimerDetailBus.Start();
            LoadBusDetail();
            TxtBegin.Focus();
        }

        private void LoadBusDetail()
        {
            try
            {
                Text = "Détail sur le bus : " + bus.Plaque;
                LblMontantNow.Text = Glossaire.Instance.GetAmountByBus(bus.Plaque, DateTime.Now.ToString()).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur de connexion est survenue pendant l'opération ! \n\n L'application va automatiquement se rédemarrer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.Write("Cette erreur est survenue lors de l'opération : " + ex.Message);
                Application.Restart();
            }
        }

        private void ResultByHours()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                LblResult.Text = Glossaire.Instance.GetAmountBusByHour(bus.Plaque, DteByHour.Value.ToString(), TxtBegin.Text, TxtEnd.Text).ToString();
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

        private void ResultByDates()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                LblResult.Text = Glossaire.Instance.GetAmountBusByDay(bus.Plaque, DteBegin.Value.ToString(), DteEnd.Value.ToString()).ToString();
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

        private void ControleFilter_Click(object sender, EventArgs e)
        {
            switch (((Control)sender).Name.Substring(3))
            {
                case "ValidateHour":
                    ResultByHours();
                    break;

                case "ValidateDate":
                    ResultByDates();
                    break;

                default:
                    break;
            }
        }

        private void TimerDetailBus_Tick(object sender, EventArgs e)
        {
            try
            {
                second++;

                if (second == 5)
                {
                    Cursor = Cursors.WaitCursor;
                    LoadBusDetail();
                    second = 0;
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

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            switch (((Control)sender).Name.Substring(3))
            {
                case "ValidateHour":
                    LblValidateHour.ForeColor = Color.FromArgb(85, 183, 20);
                    break;

                case "ValidateDate":
                    LblValidateDate.ForeColor = Color.FromArgb(85, 183, 20);
                    break;

                default:
                    break;
            }           
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            switch (((Control)sender).Name.Substring(3))
            {
                case "ValidateHour":
                    LblValidateHour.ForeColor = Color.FromArgb(14, 23, 22);
                    break;

                case "ValidateDate":
                    LblValidateDate.ForeColor = Color.FromArgb(14, 23, 22);
                    break;

                default:
                    break;
            }
        }
    }
}
