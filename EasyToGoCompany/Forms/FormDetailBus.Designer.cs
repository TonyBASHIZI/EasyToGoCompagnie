namespace EasyToGoCompany.Forms
{
    partial class FormDetailBus
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
            this.LblMontantNow = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblResult = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.PnlValidateHoure = new System.Windows.Forms.Panel();
            this.LblValidateHoure = new System.Windows.Forms.Label();
            this.TxtBegin = new System.Windows.Forms.MaskedTextBox();
            this.TxtEnd = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DteByHour = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.PnlValidateDate = new System.Windows.Forms.Panel();
            this.LblValidateDate = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.PnlValidateHoure.SuspendLayout();
            this.PnlValidateDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblMontantNow);
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Montant total en ce moment";
            // 
            // LblMontantNow
            // 
            this.LblMontantNow.AutoSize = true;
            this.LblMontantNow.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMontantNow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LblMontantNow.Location = new System.Drawing.Point(17, 22);
            this.LblMontantNow.Name = "LblMontantNow";
            this.LblMontantNow.Size = new System.Drawing.Size(22, 25);
            this.LblMontantNow.TabIndex = 0;
            this.LblMontantNow.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblResult);
            this.groupBox2.Location = new System.Drawing.Point(263, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 65);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Montant obtenu apres filtrage";
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LblResult.Location = new System.Drawing.Point(17, 23);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(22, 25);
            this.LblResult.TabIndex = 0;
            this.LblResult.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(12, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(494, 244);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Début : ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.DteByHour);
            this.groupBox4.Controls.Add(this.TxtEnd);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.TxtBegin);
            this.groupBox4.Controls.Add(this.PnlValidateHoure);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(16, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(461, 98);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Par interval d\'heure";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.PnlValidateDate);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.dateTimePicker3);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.dateTimePicker2);
            this.groupBox5.Location = new System.Drawing.Point(16, 126);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(461, 101);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Par interval de date";
            // 
            // PnlValidateHoure
            // 
            this.PnlValidateHoure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlValidateHoure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.PnlValidateHoure.Controls.Add(this.LblValidateHoure);
            this.PnlValidateHoure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PnlValidateHoure.Location = new System.Drawing.Point(344, 32);
            this.PnlValidateHoure.Name = "PnlValidateHoure";
            this.PnlValidateHoure.Size = new System.Drawing.Size(100, 38);
            this.PnlValidateHoure.TabIndex = 18;
            // 
            // LblValidateHoure
            // 
            this.LblValidateHoure.AutoSize = true;
            this.LblValidateHoure.BackColor = System.Drawing.Color.Transparent;
            this.LblValidateHoure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblValidateHoure.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValidateHoure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.LblValidateHoure.Location = new System.Drawing.Point(20, 9);
            this.LblValidateHoure.Name = "LblValidateHoure";
            this.LblValidateHoure.Size = new System.Drawing.Size(62, 18);
            this.LblValidateHoure.TabIndex = 0;
            this.LblValidateHoure.Text = "Valider";
            // 
            // TxtBegin
            // 
            this.TxtBegin.Location = new System.Drawing.Point(81, 58);
            this.TxtBegin.Mask = "00:00";
            this.TxtBegin.Name = "TxtBegin";
            this.TxtBegin.Size = new System.Drawing.Size(90, 23);
            this.TxtBegin.TabIndex = 19;
            this.TxtBegin.Text = "0700";
            this.TxtBegin.ValidatingType = typeof(System.DateTime);
            // 
            // TxtEnd
            // 
            this.TxtEnd.Location = new System.Drawing.Point(233, 58);
            this.TxtEnd.Mask = "00:00";
            this.TxtEnd.Name = "TxtEnd";
            this.TxtEnd.Size = new System.Drawing.Size(90, 23);
            this.TxtEnd.TabIndex = 21;
            this.TxtEnd.Text = "2000";
            this.TxtEnd.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Fin : ";
            // 
            // DteByHour
            // 
            this.DteByHour.Location = new System.Drawing.Point(81, 23);
            this.DteByHour.Name = "DteByHour";
            this.DteByHour.Size = new System.Drawing.Size(242, 23);
            this.DteByHour.TabIndex = 22;
            this.DteByHour.Value = new System.DateTime(2019, 9, 5, 12, 47, 54, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Date : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Début : ";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(81, 25);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(242, 23);
            this.dateTimePicker2.TabIndex = 24;
            this.dateTimePicker2.Value = new System.DateTime(2019, 9, 5, 12, 47, 54, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Fin : ";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(81, 59);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(242, 23);
            this.dateTimePicker3.TabIndex = 26;
            this.dateTimePicker3.Value = new System.DateTime(2019, 9, 5, 12, 47, 54, 0);
            // 
            // PnlValidateDate
            // 
            this.PnlValidateDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlValidateDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.PnlValidateDate.Controls.Add(this.LblValidateDate);
            this.PnlValidateDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PnlValidateDate.Location = new System.Drawing.Point(344, 34);
            this.PnlValidateDate.Name = "PnlValidateDate";
            this.PnlValidateDate.Size = new System.Drawing.Size(100, 38);
            this.PnlValidateDate.TabIndex = 28;
            // 
            // LblValidateDate
            // 
            this.LblValidateDate.AutoSize = true;
            this.LblValidateDate.BackColor = System.Drawing.Color.Transparent;
            this.LblValidateDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblValidateDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValidateDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.LblValidateDate.Location = new System.Drawing.Point(20, 9);
            this.LblValidateDate.Name = "LblValidateDate";
            this.LblValidateDate.Size = new System.Drawing.Size(62, 18);
            this.LblValidateDate.TabIndex = 0;
            this.LblValidateDate.Text = "Valider";
            // 
            // FormDetailBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 341);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(536, 380);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(536, 380);
            this.Name = "FormDetailBus";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Détail sur le bus";
            this.Load += new System.EventHandler(this.FormDetailBus_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.PnlValidateHoure.ResumeLayout(false);
            this.PnlValidateHoure.PerformLayout();
            this.PnlValidateDate.ResumeLayout(false);
            this.PnlValidateDate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblMontantNow;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel PnlValidateDate;
        private System.Windows.Forms.Label LblValidateDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DteByHour;
        private System.Windows.Forms.MaskedTextBox TxtEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox TxtBegin;
        private System.Windows.Forms.Panel PnlValidateHoure;
        private System.Windows.Forms.Label LblValidateHoure;
    }
}