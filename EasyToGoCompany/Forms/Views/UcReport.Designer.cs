namespace EasyToGoCompany.Forms.Views
{
    partial class UcReport
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.PnlPreviewBusHour = new System.Windows.Forms.Panel();
            this.LblPreviewBusHour = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DteByHour = new System.Windows.Forms.DateTimePicker();
            this.TxtEnd = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBegin = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.PnlPreviewBusDate = new System.Windows.Forms.Panel();
            this.LblPreviewBusDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DteEnd = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.DteBegin = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PnlPreviewBusAmount = new System.Windows.Forms.Panel();
            this.LblPreviewBusAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.PnlPreviewBusHour.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.PnlPreviewBusDate.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.PnlPreviewBusAmount.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(898, 498);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(30, 127);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(840, 147);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Visualisation par interval d\'heure selon une date";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.PnlPreviewBusHour);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.DteByHour);
            this.groupBox5.Controls.Add(this.TxtEnd);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.TxtBegin);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(25, 24);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(792, 104);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Filtre par heure : ";
            // 
            // PnlPreviewBusHour
            // 
            this.PnlPreviewBusHour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlPreviewBusHour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(138)))), ((int)(((byte)(85)))));
            this.PnlPreviewBusHour.Controls.Add(this.LblPreviewBusHour);
            this.PnlPreviewBusHour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PnlPreviewBusHour.Location = new System.Drawing.Point(600, 37);
            this.PnlPreviewBusHour.Margin = new System.Windows.Forms.Padding(4);
            this.PnlPreviewBusHour.Name = "PnlPreviewBusHour";
            this.PnlPreviewBusHour.Size = new System.Drawing.Size(167, 32);
            this.PnlPreviewBusHour.TabIndex = 24;
            this.PnlPreviewBusHour.Click += new System.EventHandler(this.ControleReport_Click);
            // 
            // LblPreviewBusHour
            // 
            this.LblPreviewBusHour.AutoSize = true;
            this.LblPreviewBusHour.BackColor = System.Drawing.Color.Transparent;
            this.LblPreviewBusHour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblPreviewBusHour.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPreviewBusHour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.LblPreviewBusHour.Location = new System.Drawing.Point(47, 7);
            this.LblPreviewBusHour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPreviewBusHour.Name = "LblPreviewBusHour";
            this.LblPreviewBusHour.Size = new System.Drawing.Size(77, 18);
            this.LblPreviewBusHour.TabIndex = 0;
            this.LblPreviewBusHour.Text = "Visualiser";
            this.LblPreviewBusHour.Click += new System.EventHandler(this.ControleReport_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Date : ";
            // 
            // DteByHour
            // 
            this.DteByHour.CustomFormat = "0000-00-00 00:00:00";
            this.DteByHour.Location = new System.Drawing.Point(108, 26);
            this.DteByHour.Margin = new System.Windows.Forms.Padding(4);
            this.DteByHour.Name = "DteByHour";
            this.DteByHour.Size = new System.Drawing.Size(321, 23);
            this.DteByHour.TabIndex = 1;
            this.DteByHour.Value = new System.DateTime(2019, 9, 5, 13, 35, 35, 0);
            // 
            // TxtEnd
            // 
            this.TxtEnd.Location = new System.Drawing.Point(311, 61);
            this.TxtEnd.Margin = new System.Windows.Forms.Padding(4);
            this.TxtEnd.Mask = "00:00";
            this.TxtEnd.Name = "TxtEnd";
            this.TxtEnd.Size = new System.Drawing.Size(119, 23);
            this.TxtEnd.TabIndex = 21;
            this.TxtEnd.Text = "2000";
            this.TxtEnd.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Fin : ";
            // 
            // TxtBegin
            // 
            this.TxtBegin.Location = new System.Drawing.Point(108, 61);
            this.TxtBegin.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBegin.Mask = "00:00";
            this.TxtBegin.Name = "TxtBegin";
            this.TxtBegin.Size = new System.Drawing.Size(119, 23);
            this.TxtBegin.TabIndex = 19;
            this.TxtBegin.Text = "0700";
            this.TxtBegin.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 65);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Début : ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Location = new System.Drawing.Point(30, 282);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(840, 148);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Visualisation par interval de date ";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.PnlPreviewBusDate);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.DteEnd);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.DteBegin);
            this.groupBox6.Location = new System.Drawing.Point(25, 24);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(792, 106);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Filtre par date";
            // 
            // PnlPreviewBusDate
            // 
            this.PnlPreviewBusDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlPreviewBusDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(138)))), ((int)(((byte)(85)))));
            this.PnlPreviewBusDate.Controls.Add(this.LblPreviewBusDate);
            this.PnlPreviewBusDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PnlPreviewBusDate.Location = new System.Drawing.Point(600, 40);
            this.PnlPreviewBusDate.Margin = new System.Windows.Forms.Padding(4);
            this.PnlPreviewBusDate.Name = "PnlPreviewBusDate";
            this.PnlPreviewBusDate.Size = new System.Drawing.Size(167, 32);
            this.PnlPreviewBusDate.TabIndex = 28;
            this.PnlPreviewBusDate.Click += new System.EventHandler(this.ControleReport_Click);
            // 
            // LblPreviewBusDate
            // 
            this.LblPreviewBusDate.AutoSize = true;
            this.LblPreviewBusDate.BackColor = System.Drawing.Color.Transparent;
            this.LblPreviewBusDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblPreviewBusDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPreviewBusDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.LblPreviewBusDate.Location = new System.Drawing.Point(47, 6);
            this.LblPreviewBusDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPreviewBusDate.Name = "LblPreviewBusDate";
            this.LblPreviewBusDate.Size = new System.Drawing.Size(77, 18);
            this.LblPreviewBusDate.TabIndex = 0;
            this.LblPreviewBusDate.Text = "Visualiser";
            this.LblPreviewBusDate.Click += new System.EventHandler(this.ControleReport_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Fin : ";
            // 
            // DteEnd
            // 
            this.DteEnd.Location = new System.Drawing.Point(108, 62);
            this.DteEnd.Margin = new System.Windows.Forms.Padding(4);
            this.DteEnd.Name = "DteEnd";
            this.DteEnd.Size = new System.Drawing.Size(321, 23);
            this.DteEnd.TabIndex = 6;
            this.DteEnd.Value = new System.DateTime(2019, 9, 5, 12, 47, 54, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 34);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Début : ";
            // 
            // DteBegin
            // 
            this.DteBegin.Location = new System.Drawing.Point(108, 28);
            this.DteBegin.Margin = new System.Windows.Forms.Padding(4);
            this.DteBegin.Name = "DteBegin";
            this.DteBegin.Size = new System.Drawing.Size(321, 23);
            this.DteBegin.TabIndex = 5;
            this.DteBegin.Value = new System.DateTime(2019, 9, 5, 12, 47, 54, 0);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PnlPreviewBusAmount);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(30, 36);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(840, 83);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Visualisation";
            // 
            // PnlPreviewBusAmount
            // 
            this.PnlPreviewBusAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlPreviewBusAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(138)))), ((int)(((byte)(85)))));
            this.PnlPreviewBusAmount.Controls.Add(this.LblPreviewBusAmount);
            this.PnlPreviewBusAmount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PnlPreviewBusAmount.Location = new System.Drawing.Point(625, 25);
            this.PnlPreviewBusAmount.Margin = new System.Windows.Forms.Padding(4);
            this.PnlPreviewBusAmount.Name = "PnlPreviewBusAmount";
            this.PnlPreviewBusAmount.Size = new System.Drawing.Size(167, 32);
            this.PnlPreviewBusAmount.TabIndex = 5;
            this.PnlPreviewBusAmount.Click += new System.EventHandler(this.ControleReport_Click);
            // 
            // LblPreviewBusAmount
            // 
            this.LblPreviewBusAmount.AutoSize = true;
            this.LblPreviewBusAmount.BackColor = System.Drawing.Color.Transparent;
            this.LblPreviewBusAmount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblPreviewBusAmount.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPreviewBusAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.LblPreviewBusAmount.Location = new System.Drawing.Point(47, 7);
            this.LblPreviewBusAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPreviewBusAmount.Name = "LblPreviewBusAmount";
            this.LblPreviewBusAmount.Size = new System.Drawing.Size(77, 18);
            this.LblPreviewBusAmount.TabIndex = 0;
            this.LblPreviewBusAmount.Text = "Visualiser";
            this.LblPreviewBusAmount.Click += new System.EventHandler(this.ControleReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Le rapport de transaction pour tous les bus : ";
            // 
            // UcReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(898, 498);
            this.Name = "UcReport";
            this.Size = new System.Drawing.Size(898, 498);
            this.Load += new System.EventHandler(this.UcReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.PnlPreviewBusHour.ResumeLayout(false);
            this.PnlPreviewBusHour.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.PnlPreviewBusDate.ResumeLayout(false);
            this.PnlPreviewBusDate.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.PnlPreviewBusAmount.ResumeLayout(false);
            this.PnlPreviewBusAmount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel PnlPreviewBusAmount;
        private System.Windows.Forms.Label LblPreviewBusAmount;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Panel PnlPreviewBusHour;
        private System.Windows.Forms.Label LblPreviewBusHour;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DteByHour;
        private System.Windows.Forms.MaskedTextBox TxtEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox TxtBegin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Panel PnlPreviewBusDate;
        private System.Windows.Forms.Label LblPreviewBusDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DteEnd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DteBegin;
    }
}
