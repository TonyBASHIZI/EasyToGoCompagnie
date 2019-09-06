﻿using EasyToGoCompany.Classes;
using EasyToGoCompany.Classes.Model;
using System;
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
                this.Text = "Détail sur le bus : " + bus.Plaque;
                LblMontantNow.Text = Glossaire.Instance.GetAmountByBus(bus.Plaque, DateTime.Now.ToString()).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue pendant l'opération ! \n" + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResultByHours()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                LblResult.Text = Glossaire.Instance.GetAmountBusByHour(bus.Plaque, DteByHour.Value.ToString(), TxtBegin.Text, TxtEnd.Text).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue pendant l'opération ! \n" + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void ResultByDates()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                LblResult.Text = Glossaire.Instance.GetAmountBusByDay(bus.Plaque, DteBegin.Value.ToString(), DteEnd.Value.ToString()).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue pendant l'opération ! \n" + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
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

                if (second == 3)
                {
                    this.Cursor = Cursors.WaitCursor;
                    LoadBusDetail();
                    second = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue pendant l'opération ! \n" + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
    }
}
