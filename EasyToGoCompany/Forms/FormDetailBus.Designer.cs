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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblMontantNow = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblResult = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.PnlValidateDate = new System.Windows.Forms.Panel();
            this.LblValidateDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DteEnd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.DteBegin = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DteByHour = new System.Windows.Forms.DateTimePicker();
            this.TxtEnd = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtBegin = new System.Windows.Forms.MaskedTextBox();
            this.PnlValidateHour = new System.Windows.Forms.Panel();
            this.LblValidateHour = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TimerDetailBus = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.PnlValidateDate.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.PnlValidateHour.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LblMontantNow);
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Montant total en ce moment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "FC";
            // 
            // LblMontantNow
            // 
            this.LblMontantNow.AutoSize = true;
            this.LblMontantNow.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMontantNow.ForeColor = System.Drawing.Color.Blue;
            this.LblMontantNow.Location = new System.Drawing.Point(13, 22);
            this.LblMontantNow.Name = "LblMontantNow";
            this.LblMontantNow.Size = new System.Drawing.Size(19, 23);
            this.LblMontantNow.TabIndex = 0;
            this.LblMontantNow.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.LblResult);
            this.groupBox2.Location = new System.Drawing.Point(263, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 65);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Montant obtenu après filtrage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "FC";
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResult.ForeColor = System.Drawing.Color.Blue;
            this.LblResult.Location = new System.Drawing.Point(16, 23);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(19, 23);
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.PnlValidateDate);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.DteEnd);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.DteBegin);
            this.groupBox5.Location = new System.Drawing.Point(16, 126);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(461, 101);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Par interval de date";
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
            this.PnlValidateDate.TabIndex = 7;
            this.PnlValidateDate.Click += new System.EventHandler(this.ControleFilter_Click);
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
            this.LblValidateDate.Click += new System.EventHandler(this.ControleFilter_Click);
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
            // DteEnd
            // 
            this.DteEnd.Location = new System.Drawing.Point(81, 59);
            this.DteEnd.Name = "DteEnd";
            this.DteEnd.Size = new System.Drawing.Size(242, 23);
            this.DteEnd.TabIndex = 6;
            this.DteEnd.Value = new System.DateTime(2019, 9, 5, 12, 47, 54, 0);
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
            // DteBegin
            // 
            this.DteBegin.Location = new System.Drawing.Point(81, 25);
            this.DteBegin.Name = "DteBegin";
            this.DteBegin.Size = new System.Drawing.Size(242, 23);
            this.DteBegin.TabIndex = 5;
            this.DteBegin.Value = new System.DateTime(2019, 9, 5, 12, 47, 54, 0);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.DteByHour);
            this.groupBox4.Controls.Add(this.TxtEnd);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.TxtBegin);
            this.groupBox4.Controls.Add(this.PnlValidateHour);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(16, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(461, 98);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Par interval d\'heure";
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
            // DteByHour
            // 
            this.DteByHour.CustomFormat = "0000-00-00 00:00:00";
            this.DteByHour.Location = new System.Drawing.Point(81, 23);
            this.DteByHour.Name = "DteByHour";
            this.DteByHour.Size = new System.Drawing.Size(242, 23);
            this.DteByHour.TabIndex = 1;
            this.DteByHour.Value = new System.DateTime(2019, 9, 5, 13, 35, 35, 0);
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
            // PnlValidateHour
            // 
            this.PnlValidateHour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlValidateHour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.PnlValidateHour.Controls.Add(this.LblValidateHour);
            this.PnlValidateHour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PnlValidateHour.Location = new System.Drawing.Point(344, 32);
            this.PnlValidateHour.Name = "PnlValidateHour";
            this.PnlValidateHour.Size = new System.Drawing.Size(100, 38);
            this.PnlValidateHour.TabIndex = 4;
            this.PnlValidateHour.Click += new System.EventHandler(this.ControleFilter_Click);
            // 
            // LblValidateHour
            // 
            this.LblValidateHour.AutoSize = true;
            this.LblValidateHour.BackColor = System.Drawing.Color.Transparent;
            this.LblValidateHour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblValidateHour.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValidateHour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.LblValidateHour.Location = new System.Drawing.Point(20, 9);
            this.LblValidateHour.Name = "LblValidateHour";
            this.LblValidateHour.Size = new System.Drawing.Size(62, 18);
            this.LblValidateHour.TabIndex = 0;
            this.LblValidateHour.Text = "Valider";
            this.LblValidateHour.Click += new System.EventHandler(this.ControleFilter_Click);
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
            // TimerDetailBus
            // 
            this.TimerDetailBus.Interval = 1000;
            this.TimerDetailBus.Tick += new System.EventHandler(this.TimerDetailBus_Tick);
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
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.PnlValidateDate.ResumeLayout(false);
            this.PnlValidateDate.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.PnlValidateHour.ResumeLayout(false);
            this.PnlValidateHour.PerformLayout();
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
        private System.Windows.Forms.DateTimePicker DteEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DteBegin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DteByHour;
        private System.Windows.Forms.MaskedTextBox TxtEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox TxtBegin;
        private System.Windows.Forms.Panel PnlValidateHour;
        private System.Windows.Forms.Label LblValidateHour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer TimerDetailBus;
    }
}