namespace EasyToGoCompany.Forms
{
    partial class FormUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUser));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PcbNewPassword2 = new System.Windows.Forms.PictureBox();
            this.PcbNewPassword1 = new System.Windows.Forms.PictureBox();
            this.PcbLastPassword = new System.Windows.Forms.PictureBox();
            this.PnlCancel = new System.Windows.Forms.Panel();
            this.LblCancel = new System.Windows.Forms.Label();
            this.PnlEdit = new System.Windows.Forms.Panel();
            this.LblEdit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNewPassword2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtNewPassword1 = new System.Windows.Forms.TextBox();
            this.TxtLastPassword = new System.Windows.Forms.TextBox();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbNewPassword2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbNewPassword1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLastPassword)).BeginInit();
            this.PnlCancel.SuspendLayout();
            this.PnlEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PcbNewPassword2);
            this.groupBox1.Controls.Add(this.PcbNewPassword1);
            this.groupBox1.Controls.Add(this.PcbLastPassword);
            this.groupBox1.Controls.Add(this.PnlCancel);
            this.groupBox1.Controls.Add(this.PnlEdit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtNewPassword2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.TxtNewPassword1);
            this.groupBox1.Controls.Add(this.TxtLastPassword);
            this.groupBox1.Controls.Add(this.TxtUsername);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(374, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // PcbNewPassword2
            // 
            this.PcbNewPassword2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PcbNewPassword2.Image = global::EasyToGoCompany.Properties.Resources.hint;
            this.PcbNewPassword2.Location = new System.Drawing.Point(336, 141);
            this.PcbNewPassword2.Name = "PcbNewPassword2";
            this.PcbNewPassword2.Size = new System.Drawing.Size(22, 22);
            this.PcbNewPassword2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbNewPassword2.TabIndex = 26;
            this.PcbNewPassword2.TabStop = false;
            this.PcbNewPassword2.Click += new System.EventHandler(this.ShowPassword_Click);
            // 
            // PcbNewPassword1
            // 
            this.PcbNewPassword1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PcbNewPassword1.Image = global::EasyToGoCompany.Properties.Resources.hint;
            this.PcbNewPassword1.Location = new System.Drawing.Point(336, 111);
            this.PcbNewPassword1.Name = "PcbNewPassword1";
            this.PcbNewPassword1.Size = new System.Drawing.Size(22, 22);
            this.PcbNewPassword1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbNewPassword1.TabIndex = 25;
            this.PcbNewPassword1.TabStop = false;
            this.PcbNewPassword1.Click += new System.EventHandler(this.ShowPassword_Click);
            // 
            // PcbLastPassword
            // 
            this.PcbLastPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PcbLastPassword.Image = global::EasyToGoCompany.Properties.Resources.hint;
            this.PcbLastPassword.Location = new System.Drawing.Point(336, 54);
            this.PcbLastPassword.Name = "PcbLastPassword";
            this.PcbLastPassword.Size = new System.Drawing.Size(22, 22);
            this.PcbLastPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbLastPassword.TabIndex = 24;
            this.PcbLastPassword.TabStop = false;
            this.PcbLastPassword.Click += new System.EventHandler(this.ShowPassword_Click);
            // 
            // PnlCancel
            // 
            this.PnlCancel.BackColor = System.Drawing.Color.White;
            this.PnlCancel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlCancel.Controls.Add(this.LblCancel);
            this.PnlCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PnlCancel.Location = new System.Drawing.Point(196, 194);
            this.PnlCancel.Name = "PnlCancel";
            this.PnlCancel.Size = new System.Drawing.Size(136, 32);
            this.PnlCancel.TabIndex = 23;
            this.PnlCancel.Click += new System.EventHandler(this.Controles_Click);
            this.PnlCancel.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.PnlCancel.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // LblCancel
            // 
            this.LblCancel.AutoSize = true;
            this.LblCancel.BackColor = System.Drawing.Color.Transparent;
            this.LblCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblCancel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.LblCancel.Location = new System.Drawing.Point(35, 5);
            this.LblCancel.Name = "LblCancel";
            this.LblCancel.Size = new System.Drawing.Size(65, 18);
            this.LblCancel.TabIndex = 0;
            this.LblCancel.Text = "Annuler";
            this.LblCancel.Click += new System.EventHandler(this.Controles_Click);
            this.LblCancel.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.LblCancel.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // PnlEdit
            // 
            this.PnlEdit.BackColor = System.Drawing.Color.White;
            this.PnlEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlEdit.Controls.Add(this.LblEdit);
            this.PnlEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PnlEdit.Location = new System.Drawing.Point(38, 194);
            this.PnlEdit.Name = "PnlEdit";
            this.PnlEdit.Size = new System.Drawing.Size(136, 32);
            this.PnlEdit.TabIndex = 22;
            this.PnlEdit.Click += new System.EventHandler(this.Controles_Click);
            this.PnlEdit.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.PnlEdit.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // LblEdit
            // 
            this.LblEdit.AutoSize = true;
            this.LblEdit.BackColor = System.Drawing.Color.Transparent;
            this.LblEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblEdit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.LblEdit.Location = new System.Drawing.Point(32, 5);
            this.LblEdit.Name = "LblEdit";
            this.LblEdit.Size = new System.Drawing.Size(69, 18);
            this.LblEdit.TabIndex = 0;
            this.LblEdit.Text = "Modifier";
            this.LblEdit.Click += new System.EventHandler(this.Controles_Click);
            this.LblEdit.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.LblEdit.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Répéter le mot de passe : ";
            // 
            // TxtNewPassword2
            // 
            this.TxtNewPassword2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNewPassword2.Location = new System.Drawing.Point(178, 141);
            this.TxtNewPassword2.Name = "TxtNewPassword2";
            this.TxtNewPassword2.Size = new System.Drawing.Size(154, 22);
            this.TxtNewPassword2.TabIndex = 20;
            this.TxtNewPassword2.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nouveau mot de passe : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 12);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // TxtNewPassword1
            // 
            this.TxtNewPassword1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNewPassword1.Location = new System.Drawing.Point(178, 111);
            this.TxtNewPassword1.Name = "TxtNewPassword1";
            this.TxtNewPassword1.Size = new System.Drawing.Size(154, 22);
            this.TxtNewPassword1.TabIndex = 15;
            this.TxtNewPassword1.UseSystemPasswordChar = true;
            // 
            // TxtLastPassword
            // 
            this.TxtLastPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLastPassword.Location = new System.Drawing.Point(178, 54);
            this.TxtLastPassword.Name = "TxtLastPassword";
            this.TxtLastPassword.Size = new System.Drawing.Size(154, 22);
            this.TxtLastPassword.TabIndex = 14;
            this.TxtLastPassword.UseSystemPasswordChar = true;
            // 
            // TxtUsername
            // 
            this.TxtUsername.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsername.Location = new System.Drawing.Point(178, 24);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(180, 22);
            this.TxtUsername.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ancien mot de passe : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nom d\'utilisateur : ";
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(402, 284);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(418, 323);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(418, 323);
            this.Name = "FormUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Changer le mot de passe";
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbNewPassword2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbNewPassword1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLastPassword)).EndInit();
            this.PnlCancel.ResumeLayout(false);
            this.PnlCancel.PerformLayout();
            this.PnlEdit.ResumeLayout(false);
            this.PnlEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNewPassword2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtNewPassword1;
        private System.Windows.Forms.TextBox TxtLastPassword;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PnlCancel;
        private System.Windows.Forms.Label LblCancel;
        private System.Windows.Forms.Panel PnlEdit;
        private System.Windows.Forms.Label LblEdit;
        private System.Windows.Forms.PictureBox PcbLastPassword;
        private System.Windows.Forms.PictureBox PcbNewPassword2;
        private System.Windows.Forms.PictureBox PcbNewPassword1;
    }
}