namespace EasyToGoCompany.Forms
{
    partial class FormLogin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.PnlConnection = new System.Windows.Forms.Panel();
            this.LblConnection = new System.Windows.Forms.Label();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblError = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.PnlConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtPassword);
            this.groupBox1.Controls.Add(this.PnlConnection);
            this.groupBox1.Controls.Add(this.TxtUsername);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(30, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(160, 55);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(195, 22);
            this.TxtPassword.TabIndex = 6;
            this.TxtPassword.UseSystemPasswordChar = true;
            this.TxtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormLogin_KeyDown);
            // 
            // PnlConnection
            // 
            this.PnlConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlConnection.BackColor = System.Drawing.Color.White;
            this.PnlConnection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlConnection.Controls.Add(this.LblConnection);
            this.PnlConnection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PnlConnection.Location = new System.Drawing.Point(93, 92);
            this.PnlConnection.Name = "PnlConnection";
            this.PnlConnection.Size = new System.Drawing.Size(200, 35);
            this.PnlConnection.TabIndex = 17;
            this.PnlConnection.Click += new System.EventHandler(this.LoginRequest_Click);
            this.PnlConnection.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.PnlConnection.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // LblConnection
            // 
            this.LblConnection.AutoSize = true;
            this.LblConnection.BackColor = System.Drawing.Color.Transparent;
            this.LblConnection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblConnection.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConnection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.LblConnection.Location = new System.Drawing.Point(55, 7);
            this.LblConnection.Name = "LblConnection";
            this.LblConnection.Size = new System.Drawing.Size(89, 18);
            this.LblConnection.TabIndex = 0;
            this.LblConnection.Text = "Connexion";
            this.LblConnection.Click += new System.EventHandler(this.LoginRequest_Click);
            this.LblConnection.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.LblConnection.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // TxtUsername
            // 
            this.TxtUsername.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsername.Location = new System.Drawing.Point(160, 25);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(195, 22);
            this.TxtUsername.TabIndex = 5;
            this.TxtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormLogin_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Mot de passe : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nom d\'utilisateur : ";
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblError.ForeColor = System.Drawing.Color.Red;
            this.LblError.Location = new System.Drawing.Point(69, 6);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(116, 17);
            this.LblError.TabIndex = 1;
            this.LblError.Text = "                                    ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EasyToGoCompany.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(106, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(446, 281);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblError);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(462, 320);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(462, 320);
            this.Name = "FormLogin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentification";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PnlConnection.ResumeLayout(false);
            this.PnlConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PnlConnection;
        private System.Windows.Forms.Label LblConnection;
        private System.Windows.Forms.Label LblError;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtUsername;
    }
}