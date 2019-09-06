namespace EasyToGoCompany.Forms.Views
{
    partial class UcAccueil
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
            this.PnlMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PnlMain
            // 
            this.PnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlMain.BackColor = System.Drawing.Color.Transparent;
            this.PnlMain.BackgroundImage = global::EasyToGoCompany.Properties.Resources.Hatchback_Mockup_01__3_1;
            this.PnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlMain.Location = new System.Drawing.Point(3, 3);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(892, 492);
            this.PnlMain.TabIndex = 0;
            // 
            // UcAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlMain);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UcAccueil";
            this.Size = new System.Drawing.Size(898, 498);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMain;
    }
}
