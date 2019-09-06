﻿namespace EasyToGoCompany.Forms
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.PnlHeader = new System.Windows.Forms.Panel();
            this.PnlConnection = new System.Windows.Forms.Panel();
            this.LblConnection = new System.Windows.Forms.Label();
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.PnlParametreMain = new System.Windows.Forms.Panel();
            this.PcbUser = new System.Windows.Forms.PictureBox();
            this.LblUser = new System.Windows.Forms.Label();
            this.PcbReport = new System.Windows.Forms.PictureBox();
            this.LblReport = new System.Windows.Forms.Label();
            this.PnlParametre = new System.Windows.Forms.Panel();
            this.PcbParametre = new System.Windows.Forms.PictureBox();
            this.LblParametre = new System.Windows.Forms.Label();
            this.PnlWhite = new System.Windows.Forms.Panel();
            this.PnlBus = new System.Windows.Forms.Panel();
            this.PcbBus = new System.Windows.Forms.PictureBox();
            this.LblBus = new System.Windows.Forms.Label();
            this.PnlProfil = new System.Windows.Forms.Panel();
            this.PcbProfil = new System.Windows.Forms.PictureBox();
            this.LblProfil = new System.Windows.Forms.Label();
            this.PnlDashboard = new System.Windows.Forms.Panel();
            this.PcbDashboard = new System.Windows.Forms.PictureBox();
            this.LblDashboard = new System.Windows.Forms.Label();
            this.PnlWhite1 = new System.Windows.Forms.Panel();
            this.PnlMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StatusStrip.SuspendLayout();
            this.PnlHeader.SuspendLayout();
            this.PnlConnection.SuspendLayout();
            this.PnlMenu.SuspendLayout();
            this.PnlParametreMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbReport)).BeginInit();
            this.PnlParametre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbParametre)).BeginInit();
            this.PnlBus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBus)).BeginInit();
            this.PnlProfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbProfil)).BeginInit();
            this.PnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbDashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusStrip
            // 
            this.StatusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(64)))), ((int)(((byte)(2)))));
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 589);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.StatusStrip.Size = new System.Drawing.Size(1084, 22);
            this.StatusStrip.TabIndex = 0;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.ForeColor = System.Drawing.Color.White;
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(36, 17);
            this.StatusLabel.Text = "Invité";
            // 
            // PnlHeader
            // 
            this.PnlHeader.BackColor = System.Drawing.SystemColors.Control;
            this.PnlHeader.Controls.Add(this.label2);
            this.PnlHeader.Controls.Add(this.label1);
            this.PnlHeader.Controls.Add(this.PnlConnection);
            this.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHeader.Location = new System.Drawing.Point(0, 0);
            this.PnlHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Size = new System.Drawing.Size(1084, 90);
            this.PnlHeader.TabIndex = 1;
            // 
            // PnlConnection
            // 
            this.PnlConnection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(138)))), ((int)(((byte)(85)))));
            this.PnlConnection.Controls.Add(this.LblConnection);
            this.PnlConnection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PnlConnection.Location = new System.Drawing.Point(923, 50);
            this.PnlConnection.Name = "PnlConnection";
            this.PnlConnection.Size = new System.Drawing.Size(149, 29);
            this.PnlConnection.TabIndex = 2;
            this.PnlConnection.Click += new System.EventHandler(this.BtnConnection_Click);
            // 
            // LblConnection
            // 
            this.LblConnection.AutoSize = true;
            this.LblConnection.BackColor = System.Drawing.Color.Transparent;
            this.LblConnection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblConnection.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConnection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.LblConnection.Location = new System.Drawing.Point(19, 5);
            this.LblConnection.Name = "LblConnection";
            this.LblConnection.Size = new System.Drawing.Size(89, 18);
            this.LblConnection.TabIndex = 0;
            this.LblConnection.Text = "Connexion";
            this.LblConnection.Click += new System.EventHandler(this.BtnConnection_Click);
            // 
            // PnlMenu
            // 
            this.PnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(28)))), ((int)(((byte)(0)))));
            this.PnlMenu.Controls.Add(this.PnlParametreMain);
            this.PnlMenu.Controls.Add(this.PnlParametre);
            this.PnlMenu.Controls.Add(this.PnlWhite);
            this.PnlMenu.Controls.Add(this.PnlBus);
            this.PnlMenu.Controls.Add(this.PnlProfil);
            this.PnlMenu.Controls.Add(this.PnlDashboard);
            this.PnlMenu.Controls.Add(this.PnlWhite1);
            this.PnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlMenu.Location = new System.Drawing.Point(0, 90);
            this.PnlMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(185, 499);
            this.PnlMenu.TabIndex = 2;
            // 
            // PnlParametreMain
            // 
            this.PnlParametreMain.Controls.Add(this.PcbUser);
            this.PnlParametreMain.Controls.Add(this.LblUser);
            this.PnlParametreMain.Controls.Add(this.PcbReport);
            this.PnlParametreMain.Controls.Add(this.LblReport);
            this.PnlParametreMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.PnlParametreMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlParametreMain.Location = new System.Drawing.Point(0, 215);
            this.PnlParametreMain.Name = "PnlParametreMain";
            this.PnlParametreMain.Size = new System.Drawing.Size(185, 81);
            this.PnlParametreMain.TabIndex = 8;
            this.PnlParametreMain.Visible = false;
            // 
            // PcbUser
            // 
            this.PcbUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PcbUser.Image = global::EasyToGoCompany.Properties.Resources.user_credentials;
            this.PcbUser.Location = new System.Drawing.Point(47, 45);
            this.PcbUser.Name = "PcbUser";
            this.PcbUser.Size = new System.Drawing.Size(22, 22);
            this.PcbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbUser.TabIndex = 6;
            this.PcbUser.TabStop = false;
            this.PcbUser.Click += new System.EventHandler(this.NavigationControles_Click);
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUser.ForeColor = System.Drawing.Color.White;
            this.LblUser.Location = new System.Drawing.Point(77, 47);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(69, 17);
            this.LblUser.TabIndex = 5;
            this.LblUser.Text = "Utilisateur";
            this.LblUser.Click += new System.EventHandler(this.NavigationControles_Click);
            // 
            // PcbReport
            // 
            this.PcbReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PcbReport.Image = global::EasyToGoCompany.Properties.Resources.icons8_Print_48px;
            this.PcbReport.Location = new System.Drawing.Point(47, 14);
            this.PcbReport.Name = "PcbReport";
            this.PcbReport.Size = new System.Drawing.Size(22, 22);
            this.PcbReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbReport.TabIndex = 2;
            this.PcbReport.TabStop = false;
            this.PcbReport.Click += new System.EventHandler(this.NavigationControles_Click);
            // 
            // LblReport
            // 
            this.LblReport.AutoSize = true;
            this.LblReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblReport.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReport.ForeColor = System.Drawing.Color.White;
            this.LblReport.Location = new System.Drawing.Point(77, 16);
            this.LblReport.Name = "LblReport";
            this.LblReport.Size = new System.Drawing.Size(61, 17);
            this.LblReport.TabIndex = 1;
            this.LblReport.Text = "Rapport";
            this.LblReport.Click += new System.EventHandler(this.NavigationControles_Click);
            // 
            // PnlParametre
            // 
            this.PnlParametre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlParametre.Controls.Add(this.PcbParametre);
            this.PnlParametre.Controls.Add(this.LblParametre);
            this.PnlParametre.Cursor = System.Windows.Forms.Cursors.Default;
            this.PnlParametre.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlParametre.Location = new System.Drawing.Point(0, 162);
            this.PnlParametre.Name = "PnlParametre";
            this.PnlParametre.Size = new System.Drawing.Size(185, 53);
            this.PnlParametre.TabIndex = 7;
            // 
            // PcbParametre
            // 
            this.PcbParametre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PcbParametre.Image = global::EasyToGoCompany.Properties.Resources.settings;
            this.PcbParametre.Location = new System.Drawing.Point(17, 9);
            this.PcbParametre.Name = "PcbParametre";
            this.PcbParametre.Size = new System.Drawing.Size(30, 30);
            this.PcbParametre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbParametre.TabIndex = 2;
            this.PcbParametre.TabStop = false;
            // 
            // LblParametre
            // 
            this.LblParametre.AutoSize = true;
            this.LblParametre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblParametre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblParametre.ForeColor = System.Drawing.Color.White;
            this.LblParametre.Location = new System.Drawing.Point(56, 14);
            this.LblParametre.Name = "LblParametre";
            this.LblParametre.Size = new System.Drawing.Size(93, 21);
            this.LblParametre.TabIndex = 1;
            this.LblParametre.Text = "Paramètre";
            this.LblParametre.Click += new System.EventHandler(this.NavigationControles_Click);
            // 
            // PnlWhite
            // 
            this.PnlWhite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.PnlWhite.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlWhite.Location = new System.Drawing.Point(0, 496);
            this.PnlWhite.Name = "PnlWhite";
            this.PnlWhite.Size = new System.Drawing.Size(185, 3);
            this.PnlWhite.TabIndex = 5;
            // 
            // PnlBus
            // 
            this.PnlBus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlBus.Controls.Add(this.PcbBus);
            this.PnlBus.Controls.Add(this.LblBus);
            this.PnlBus.Cursor = System.Windows.Forms.Cursors.Default;
            this.PnlBus.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlBus.Location = new System.Drawing.Point(0, 109);
            this.PnlBus.Name = "PnlBus";
            this.PnlBus.Size = new System.Drawing.Size(185, 53);
            this.PnlBus.TabIndex = 2;
            this.PnlBus.Click += new System.EventHandler(this.NavigationControles_Click);
            // 
            // PcbBus
            // 
            this.PcbBus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PcbBus.Image = global::EasyToGoCompany.Properties.Resources.bus;
            this.PcbBus.Location = new System.Drawing.Point(17, 9);
            this.PcbBus.Name = "PcbBus";
            this.PcbBus.Size = new System.Drawing.Size(30, 30);
            this.PcbBus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbBus.TabIndex = 2;
            this.PcbBus.TabStop = false;
            this.PcbBus.Click += new System.EventHandler(this.NavigationControles_Click);
            // 
            // LblBus
            // 
            this.LblBus.AutoSize = true;
            this.LblBus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblBus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBus.ForeColor = System.Drawing.Color.White;
            this.LblBus.Location = new System.Drawing.Point(56, 14);
            this.LblBus.Name = "LblBus";
            this.LblBus.Size = new System.Drawing.Size(35, 21);
            this.LblBus.TabIndex = 1;
            this.LblBus.Text = "Bus";
            this.LblBus.Click += new System.EventHandler(this.NavigationControles_Click);
            // 
            // PnlProfil
            // 
            this.PnlProfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlProfil.Controls.Add(this.PcbProfil);
            this.PnlProfil.Controls.Add(this.LblProfil);
            this.PnlProfil.Cursor = System.Windows.Forms.Cursors.Default;
            this.PnlProfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlProfil.Location = new System.Drawing.Point(0, 56);
            this.PnlProfil.Name = "PnlProfil";
            this.PnlProfil.Size = new System.Drawing.Size(185, 53);
            this.PnlProfil.TabIndex = 1;
            this.PnlProfil.Click += new System.EventHandler(this.NavigationControles_Click);
            // 
            // PcbProfil
            // 
            this.PcbProfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PcbProfil.Image = global::EasyToGoCompany.Properties.Resources.user_account;
            this.PcbProfil.Location = new System.Drawing.Point(17, 9);
            this.PcbProfil.Name = "PcbProfil";
            this.PcbProfil.Size = new System.Drawing.Size(30, 30);
            this.PcbProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbProfil.TabIndex = 2;
            this.PcbProfil.TabStop = false;
            this.PcbProfil.Click += new System.EventHandler(this.NavigationControles_Click);
            // 
            // LblProfil
            // 
            this.LblProfil.AutoSize = true;
            this.LblProfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblProfil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProfil.ForeColor = System.Drawing.Color.White;
            this.LblProfil.Location = new System.Drawing.Point(56, 14);
            this.LblProfil.Name = "LblProfil";
            this.LblProfil.Size = new System.Drawing.Size(45, 21);
            this.LblProfil.TabIndex = 1;
            this.LblProfil.Text = "Profil";
            this.LblProfil.Click += new System.EventHandler(this.NavigationControles_Click);
            // 
            // PnlDashboard
            // 
            this.PnlDashboard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlDashboard.Controls.Add(this.PcbDashboard);
            this.PnlDashboard.Controls.Add(this.LblDashboard);
            this.PnlDashboard.Cursor = System.Windows.Forms.Cursors.Default;
            this.PnlDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlDashboard.Location = new System.Drawing.Point(0, 3);
            this.PnlDashboard.Name = "PnlDashboard";
            this.PnlDashboard.Size = new System.Drawing.Size(185, 53);
            this.PnlDashboard.TabIndex = 0;
            this.PnlDashboard.Click += new System.EventHandler(this.NavigationControles_Click);
            // 
            // PcbDashboard
            // 
            this.PcbDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PcbDashboard.Image = global::EasyToGoCompany.Properties.Resources.menu;
            this.PcbDashboard.Location = new System.Drawing.Point(17, 10);
            this.PcbDashboard.Name = "PcbDashboard";
            this.PcbDashboard.Size = new System.Drawing.Size(30, 30);
            this.PcbDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbDashboard.TabIndex = 1;
            this.PcbDashboard.TabStop = false;
            this.PcbDashboard.Click += new System.EventHandler(this.NavigationControles_Click);
            // 
            // LblDashboard
            // 
            this.LblDashboard.AutoSize = true;
            this.LblDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblDashboard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDashboard.ForeColor = System.Drawing.Color.White;
            this.LblDashboard.Location = new System.Drawing.Point(56, 14);
            this.LblDashboard.Name = "LblDashboard";
            this.LblDashboard.Size = new System.Drawing.Size(97, 21);
            this.LblDashboard.TabIndex = 0;
            this.LblDashboard.Text = "Dashboard";
            this.LblDashboard.Click += new System.EventHandler(this.NavigationControles_Click);
            // 
            // PnlWhite1
            // 
            this.PnlWhite1.BackColor = System.Drawing.Color.White;
            this.PnlWhite1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlWhite1.Location = new System.Drawing.Point(0, 0);
            this.PnlWhite1.Name = "PnlWhite1";
            this.PnlWhite1.Size = new System.Drawing.Size(185, 3);
            this.PnlWhite1.TabIndex = 6;
            // 
            // PnlMain
            // 
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMain.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlMain.Location = new System.Drawing.Point(185, 90);
            this.PnlMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(899, 499);
            this.PnlMain.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(183)))), ((int)(((byte)(20)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "Easy to go";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(80)))), ((int)(((byte)(1)))));
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Aloha Dynamics";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.PnlMain);
            this.Controls.Add(this.PnlMenu);
            this.Controls.Add(this.PnlHeader);
            this.Controls.Add(this.StatusStrip);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1100, 650);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy to go";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.PnlHeader.ResumeLayout(false);
            this.PnlHeader.PerformLayout();
            this.PnlConnection.ResumeLayout(false);
            this.PnlConnection.PerformLayout();
            this.PnlMenu.ResumeLayout(false);
            this.PnlParametreMain.ResumeLayout(false);
            this.PnlParametreMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbReport)).EndInit();
            this.PnlParametre.ResumeLayout(false);
            this.PnlParametre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbParametre)).EndInit();
            this.PnlBus.ResumeLayout(false);
            this.PnlBus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBus)).EndInit();
            this.PnlProfil.ResumeLayout(false);
            this.PnlProfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbProfil)).EndInit();
            this.PnlDashboard.ResumeLayout(false);
            this.PnlDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbDashboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.Panel PnlHeader;
        private System.Windows.Forms.Panel PnlMain;
        private System.Windows.Forms.Panel PnlDashboard;
        private System.Windows.Forms.Panel PnlBus;
        private System.Windows.Forms.Label LblBus;
        private System.Windows.Forms.Panel PnlProfil;
        private System.Windows.Forms.Label LblProfil;
        private System.Windows.Forms.Label LblDashboard;
        private System.Windows.Forms.PictureBox PcbDashboard;
        private System.Windows.Forms.PictureBox PcbBus;
        private System.Windows.Forms.PictureBox PcbProfil;
        private System.Windows.Forms.Panel PnlConnection;
        private System.Windows.Forms.Label LblConnection;
        private System.Windows.Forms.Panel PnlWhite;
        private System.Windows.Forms.Panel PnlWhite1;
        public System.Windows.Forms.Panel PnlMenu;
        public System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.Panel PnlParametre;
        private System.Windows.Forms.PictureBox PcbParametre;
        private System.Windows.Forms.Label LblParametre;
        private System.Windows.Forms.Panel PnlParametreMain;
        private System.Windows.Forms.PictureBox PcbReport;
        private System.Windows.Forms.Label LblReport;
        private System.Windows.Forms.PictureBox PcbUser;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}