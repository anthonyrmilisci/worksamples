namespace Chptr5_Case3_ComicCharacterConvention
{
    partial class frmComicCharacterConvention
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
            this.picComic = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblGroupSize = new System.Windows.Forms.Label();
            this.grpBadgeSelection = new System.Windows.Forms.GroupBox();
            this.radConvention = new System.Windows.Forms.RadioButton();
            this.radAutographs = new System.Windows.Forms.RadioButton();
            this.radSuperheroExperience = new System.Windows.Forms.RadioButton();
            this.chkPreview = new System.Windows.Forms.CheckBox();
            this.pnlPreviewNight = new System.Windows.Forms.Panel();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtGroupSize = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picComic)).BeginInit();
            this.grpBadgeSelection.SuspendLayout();
            this.pnlPreviewNight.SuspendLayout();
            this.SuspendLayout();
            // 
            // picComic
            // 
            this.picComic.Image = global::Chptr5_Case3_ComicCharacterConvention.Properties.Resources.Comic1;
            this.picComic.Location = new System.Drawing.Point(0, 0);
            this.picComic.Name = "picComic";
            this.picComic.Size = new System.Drawing.Size(434, 213);
            this.picComic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picComic.TabIndex = 0;
            this.picComic.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(2, 216);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(430, 31);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Comic Character Convention Registration";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGroupSize
            // 
            this.lblGroupSize.AutoSize = true;
            this.lblGroupSize.BackColor = System.Drawing.SystemColors.Control;
            this.lblGroupSize.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupSize.ForeColor = System.Drawing.Color.Red;
            this.lblGroupSize.Location = new System.Drawing.Point(121, 282);
            this.lblGroupSize.Name = "lblGroupSize";
            this.lblGroupSize.Size = new System.Drawing.Size(101, 23);
            this.lblGroupSize.TabIndex = 2;
            this.lblGroupSize.Text = "Group Size:";
            // 
            // grpBadgeSelection
            // 
            this.grpBadgeSelection.Controls.Add(this.radConvention);
            this.grpBadgeSelection.Controls.Add(this.radAutographs);
            this.grpBadgeSelection.Controls.Add(this.radSuperheroExperience);
            this.grpBadgeSelection.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBadgeSelection.ForeColor = System.Drawing.Color.Red;
            this.grpBadgeSelection.Location = new System.Drawing.Point(51, 346);
            this.grpBadgeSelection.Name = "grpBadgeSelection";
            this.grpBadgeSelection.Size = new System.Drawing.Size(332, 131);
            this.grpBadgeSelection.TabIndex = 3;
            this.grpBadgeSelection.TabStop = false;
            this.grpBadgeSelection.Text = "Select Badge Type:";
            // 
            // radConvention
            // 
            this.radConvention.AutoSize = true;
            this.radConvention.Checked = true;
            this.radConvention.Location = new System.Drawing.Point(7, 97);
            this.radConvention.Name = "radConvention";
            this.radConvention.Size = new System.Drawing.Size(107, 27);
            this.radConvention.TabIndex = 2;
            this.radConvention.TabStop = true;
            this.radConvention.Text = "Convention";
            this.radConvention.UseVisualStyleBackColor = true;
            // 
            // radAutographs
            // 
            this.radAutographs.AutoSize = true;
            this.radAutographs.Location = new System.Drawing.Point(7, 64);
            this.radAutographs.Name = "radAutographs";
            this.radAutographs.Size = new System.Drawing.Size(228, 27);
            this.radAutographs.TabIndex = 1;
            this.radAutographs.Text = "Convention + Authographs";
            this.radAutographs.UseVisualStyleBackColor = true;
            // 
            // radSuperheroExperience
            // 
            this.radSuperheroExperience.AutoSize = true;
            this.radSuperheroExperience.Location = new System.Drawing.Point(7, 30);
            this.radSuperheroExperience.Name = "radSuperheroExperience";
            this.radSuperheroExperience.Size = new System.Drawing.Size(300, 27);
            this.radSuperheroExperience.TabIndex = 0;
            this.radSuperheroExperience.Text = "Convention + Superhero Experience";
            this.radSuperheroExperience.UseVisualStyleBackColor = true;
            // 
            // chkPreview
            // 
            this.chkPreview.AutoSize = true;
            this.chkPreview.Location = new System.Drawing.Point(17, 13);
            this.chkPreview.Name = "chkPreview";
            this.chkPreview.Size = new System.Drawing.Size(207, 27);
            this.chkPreview.TabIndex = 0;
            this.chkPreview.Text = "Optional Preview Night";
            this.chkPreview.UseVisualStyleBackColor = true;
            // 
            // pnlPreviewNight
            // 
            this.pnlPreviewNight.BackColor = System.Drawing.Color.Gold;
            this.pnlPreviewNight.Controls.Add(this.chkPreview);
            this.pnlPreviewNight.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPreviewNight.ForeColor = System.Drawing.Color.Black;
            this.pnlPreviewNight.Location = new System.Drawing.Point(100, 483);
            this.pnlPreviewNight.Name = "pnlPreviewNight";
            this.pnlPreviewNight.Size = new System.Drawing.Size(235, 54);
            this.pnlPreviewNight.TabIndex = 5;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(12, 556);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(410, 23);
            this.lblTotalCost.TabIndex = 6;
            this.lblTotalCost.Text = "Registration Cost: ";
            this.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Gold;
            this.btnCalculate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.Black;
            this.btnCalculate.Location = new System.Drawing.Point(51, 607);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(90, 35);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.BackColor = System.Drawing.Color.Gold;
            this.btnClear.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(293, 607);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 35);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtGroupSize
            // 
            this.txtGroupSize.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupSize.Location = new System.Drawing.Point(256, 282);
            this.txtGroupSize.Name = "txtGroupSize";
            this.txtGroupSize.Size = new System.Drawing.Size(58, 30);
            this.txtGroupSize.TabIndex = 9;
            // 
            // frmComicCharacterConvention
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 654);
            this.Controls.Add(this.txtGroupSize);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.pnlPreviewNight);
            this.Controls.Add(this.grpBadgeSelection);
            this.Controls.Add(this.lblGroupSize);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picComic);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "frmComicCharacterConvention";
            this.Text = "Comic Character Convention";
            ((System.ComponentModel.ISupportInitialize)(this.picComic)).EndInit();
            this.grpBadgeSelection.ResumeLayout(false);
            this.grpBadgeSelection.PerformLayout();
            this.pnlPreviewNight.ResumeLayout(false);
            this.pnlPreviewNight.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picComic;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblGroupSize;
        private System.Windows.Forms.GroupBox grpBadgeSelection;
        private System.Windows.Forms.RadioButton radConvention;
        private System.Windows.Forms.RadioButton radAutographs;
        private System.Windows.Forms.RadioButton radSuperheroExperience;
        private System.Windows.Forms.CheckBox chkPreview;
        private System.Windows.Forms.Panel pnlPreviewNight;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtGroupSize;
    }
}

