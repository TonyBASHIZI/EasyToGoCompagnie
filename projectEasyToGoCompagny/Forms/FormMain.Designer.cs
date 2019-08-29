namespace projectEasyToGoCompagny.Forms
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
            this.PnlHeader = new System.Windows.Forms.Panel();
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PnlBus = new System.Windows.Forms.Panel();
            this.LblBus = new System.Windows.Forms.Label();
            this.PnlProfil = new System.Windows.Forms.Panel();
            this.LblProfil = new System.Windows.Forms.Label();
            this.PnlDashboard = new System.Windows.Forms.Panel();
            this.LblDashboard = new System.Windows.Forms.Label();
            this.PnlMain = new System.Windows.Forms.Panel();
            this.PnlMenu.SuspendLayout();
            this.PnlBus.SuspendLayout();
            this.PnlProfil.SuspendLayout();
            this.PnlDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusStrip
            // 
            this.StatusStrip.Location = new System.Drawing.Point(0, 589);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.StatusStrip.Size = new System.Drawing.Size(1084, 22);
            this.StatusStrip.TabIndex = 0;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // PnlHeader
            // 
            this.PnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(98)))), ((int)(((byte)(97)))));
            this.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHeader.Location = new System.Drawing.Point(0, 0);
            this.PnlHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Size = new System.Drawing.Size(1084, 90);
            this.PnlHeader.TabIndex = 1;
            // 
            // PnlMenu
            // 
            this.PnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.PnlMenu.Controls.Add(this.panel5);
            this.PnlMenu.Controls.Add(this.panel4);
            this.PnlMenu.Controls.Add(this.PnlBus);
            this.PnlMenu.Controls.Add(this.PnlProfil);
            this.PnlMenu.Controls.Add(this.PnlDashboard);
            this.PnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlMenu.Location = new System.Drawing.Point(0, 90);
            this.PnlMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(185, 499);
            this.PnlMenu.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 212);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(185, 53);
            this.panel5.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 159);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(185, 53);
            this.panel4.TabIndex = 3;
            // 
            // PnlBus
            // 
            this.PnlBus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlBus.Controls.Add(this.LblBus);
            this.PnlBus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PnlBus.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlBus.Location = new System.Drawing.Point(0, 106);
            this.PnlBus.Name = "PnlBus";
            this.PnlBus.Size = new System.Drawing.Size(185, 53);
            this.PnlBus.TabIndex = 2;
            this.PnlBus.Click += new System.EventHandler(this.NavigationControles_Click);
            // 
            // LblBus
            // 
            this.LblBus.AutoSize = true;
            this.LblBus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBus.ForeColor = System.Drawing.Color.White;
            this.LblBus.Location = new System.Drawing.Point(56, 15);
            this.LblBus.Name = "LblBus";
            this.LblBus.Size = new System.Drawing.Size(35, 21);
            this.LblBus.TabIndex = 1;
            this.LblBus.Text = "Bus";
            this.LblBus.Click += new System.EventHandler(this.NavigationControles_Click);
            // 
            // PnlProfil
            // 
            this.PnlProfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlProfil.Controls.Add(this.LblProfil);
            this.PnlProfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PnlProfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlProfil.Location = new System.Drawing.Point(0, 53);
            this.PnlProfil.Name = "PnlProfil";
            this.PnlProfil.Size = new System.Drawing.Size(185, 53);
            this.PnlProfil.TabIndex = 1;
            this.PnlProfil.Click += new System.EventHandler(this.NavigationControles_Click);
            // 
            // LblProfil
            // 
            this.LblProfil.AutoSize = true;
            this.LblProfil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProfil.ForeColor = System.Drawing.Color.White;
            this.LblProfil.Location = new System.Drawing.Point(56, 15);
            this.LblProfil.Name = "LblProfil";
            this.LblProfil.Size = new System.Drawing.Size(45, 21);
            this.LblProfil.TabIndex = 1;
            this.LblProfil.Text = "Profil";
            this.LblProfil.Click += new System.EventHandler(this.NavigationControles_Click);
            // 
            // PnlDashboard
            // 
            this.PnlDashboard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlDashboard.Controls.Add(this.LblDashboard);
            this.PnlDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PnlDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlDashboard.Location = new System.Drawing.Point(0, 0);
            this.PnlDashboard.Name = "PnlDashboard";
            this.PnlDashboard.Size = new System.Drawing.Size(185, 53);
            this.PnlDashboard.TabIndex = 0;
            this.PnlDashboard.Click += new System.EventHandler(this.NavigationControles_Click);
            // 
            // LblDashboard
            // 
            this.LblDashboard.AutoSize = true;
            this.LblDashboard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDashboard.ForeColor = System.Drawing.Color.White;
            this.LblDashboard.Location = new System.Drawing.Point(56, 15);
            this.LblDashboard.Name = "LblDashboard";
            this.LblDashboard.Size = new System.Drawing.Size(97, 21);
            this.LblDashboard.TabIndex = 0;
            this.LblDashboard.Text = "Dashboard";
            this.LblDashboard.Click += new System.EventHandler(this.NavigationControles_Click);
            // 
            // PnlMain
            // 
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMain.Location = new System.Drawing.Point(185, 90);
            this.PnlMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(899, 499);
            this.PnlMain.TabIndex = 3;
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
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.PnlMenu.ResumeLayout(false);
            this.PnlBus.ResumeLayout(false);
            this.PnlBus.PerformLayout();
            this.PnlProfil.ResumeLayout(false);
            this.PnlProfil.PerformLayout();
            this.PnlDashboard.ResumeLayout(false);
            this.PnlDashboard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.Panel PnlHeader;
        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.Panel PnlMain;
        private System.Windows.Forms.Panel PnlDashboard;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel PnlBus;
        private System.Windows.Forms.Label LblBus;
        private System.Windows.Forms.Panel PnlProfil;
        private System.Windows.Forms.Label LblProfil;
        private System.Windows.Forms.Label LblDashboard;
    }
}