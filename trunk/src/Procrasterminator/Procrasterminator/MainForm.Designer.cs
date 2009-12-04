namespace Procrasterminator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBoxSapoTerminator = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxLinkChoice = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSapoTerminator)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSapoTerminator
            // 
            this.pictureBoxSapoTerminator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxSapoTerminator.Image = global::Procrasterminator.Properties.Resources.sapoTerminator;
            this.pictureBoxSapoTerminator.Location = new System.Drawing.Point(138, 9);
            this.pictureBoxSapoTerminator.Name = "pictureBoxSapoTerminator";
            this.pictureBoxSapoTerminator.Size = new System.Drawing.Size(79, 62);
            this.pictureBoxSapoTerminator.TabIndex = 0;
            this.pictureBoxSapoTerminator.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(217, 18);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(358, 38);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Procrasterminator";
            // 
            // groupBoxLinkChoice
            // 
            this.groupBoxLinkChoice.Location = new System.Drawing.Point(17, 103);
            this.groupBoxLinkChoice.Name = "groupBoxLinkChoice";
            this.groupBoxLinkChoice.Size = new System.Drawing.Size(243, 349);
            this.groupBoxLinkChoice.TabIndex = 2;
            this.groupBoxLinkChoice.TabStop = false;
            this.groupBoxLinkChoice.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(291, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 148);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(291, 276);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(358, 176);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 464);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxLinkChoice);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBoxSapoTerminator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Procrasterminator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSapoTerminator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSapoTerminator;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBoxLinkChoice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

