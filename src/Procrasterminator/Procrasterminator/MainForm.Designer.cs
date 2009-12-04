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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Facebook");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("YouTube");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Twitter");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Collegehumor");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Geekologie");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Freerice");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Pogo");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Bored");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("Postsecret");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxLinkChoice = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxTasks = new System.Windows.Forms.GroupBox();
            this.radioButtonAggressive = new System.Windows.Forms.RadioButton();
            this.radioButtonTolerant = new System.Windows.Forms.RadioButton();
            this.labelAgressiveDescription = new System.Windows.Forms.Label();
            this.groupBoxGeneral = new System.Windows.Forms.GroupBox();
            this.checkBoxLaunchOnStartUp = new System.Windows.Forms.CheckBox();
            this.labelListDescription = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.labelTolerantDescription = new System.Windows.Forms.Label();
            this.radioButtonOff = new System.Windows.Forms.RadioButton();
            this.textBoxAddKeyword = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAddKeyword = new System.Windows.Forms.Button();
            this.pictureBoxSapoTerminator = new System.Windows.Forms.PictureBox();
            this.buttonRemoveKeyword = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelMinutes = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSeconds = new System.Windows.Forms.Label();
            this.groupBoxLinkChoice.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxGeneral.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSapoTerminator)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(233, 34);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(358, 38);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Procrasterminator";
            // 
            // groupBoxLinkChoice
            // 
            this.groupBoxLinkChoice.Controls.Add(this.buttonRemoveKeyword);
            this.groupBoxLinkChoice.Controls.Add(this.textBoxAddKeyword);
            this.groupBoxLinkChoice.Controls.Add(this.buttonAddKeyword);
            this.groupBoxLinkChoice.Controls.Add(this.listView1);
            this.groupBoxLinkChoice.Controls.Add(this.labelListDescription);
            this.groupBoxLinkChoice.Location = new System.Drawing.Point(12, 92);
            this.groupBoxLinkChoice.Name = "groupBoxLinkChoice";
            this.groupBoxLinkChoice.Size = new System.Drawing.Size(189, 360);
            this.groupBoxLinkChoice.TabIndex = 2;
            this.groupBoxLinkChoice.TabStop = false;
            this.groupBoxLinkChoice.Text = "Procrastination List";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelSeconds);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.labelMinutes);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.radioButtonOff);
            this.groupBox2.Controls.Add(this.labelTolerantDescription);
            this.groupBox2.Controls.Add(this.labelAgressiveDescription);
            this.groupBox2.Controls.Add(this.radioButtonTolerant);
            this.groupBox2.Controls.Add(this.radioButtonAggressive);
            this.groupBox2.Location = new System.Drawing.Point(207, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 241);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Procrastination Limits:";
            // 
            // groupBoxTasks
            // 
            this.groupBoxTasks.Location = new System.Drawing.Point(442, 92);
            this.groupBoxTasks.Name = "groupBoxTasks";
            this.groupBoxTasks.Size = new System.Drawing.Size(226, 356);
            this.groupBoxTasks.TabIndex = 4;
            this.groupBoxTasks.TabStop = false;
            this.groupBoxTasks.Text = "Tasks";
            // 
            // radioButtonAggressive
            // 
            this.radioButtonAggressive.AutoSize = true;
            this.radioButtonAggressive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAggressive.Location = new System.Drawing.Point(15, 29);
            this.radioButtonAggressive.Name = "radioButtonAggressive";
            this.radioButtonAggressive.Size = new System.Drawing.Size(80, 17);
            this.radioButtonAggressive.TabIndex = 0;
            this.radioButtonAggressive.TabStop = true;
            this.radioButtonAggressive.Text = "Agressive";
            this.radioButtonAggressive.UseVisualStyleBackColor = true;
            // 
            // radioButtonTolerant
            // 
            this.radioButtonTolerant.AutoSize = true;
            this.radioButtonTolerant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTolerant.Location = new System.Drawing.Point(15, 90);
            this.radioButtonTolerant.Name = "radioButtonTolerant";
            this.radioButtonTolerant.Size = new System.Drawing.Size(72, 17);
            this.radioButtonTolerant.TabIndex = 1;
            this.radioButtonTolerant.TabStop = true;
            this.radioButtonTolerant.Text = "Tolerant";
            this.radioButtonTolerant.UseVisualStyleBackColor = true;
            // 
            // labelAgressiveDescription
            // 
            this.labelAgressiveDescription.Location = new System.Drawing.Point(32, 54);
            this.labelAgressiveDescription.Name = "labelAgressiveDescription";
            this.labelAgressiveDescription.Size = new System.Drawing.Size(186, 33);
            this.labelAgressiveDescription.TabIndex = 2;
            this.labelAgressiveDescription.Text = "Keeps you totally from procrastinating! Advisable when there\'s a lot of work to d" +
                "o!";
            // 
            // groupBoxGeneral
            // 
            this.groupBoxGeneral.Controls.Add(this.checkBoxLaunchOnStartUp);
            this.groupBoxGeneral.Location = new System.Drawing.Point(209, 390);
            this.groupBoxGeneral.Name = "groupBoxGeneral";
            this.groupBoxGeneral.Size = new System.Drawing.Size(227, 62);
            this.groupBoxGeneral.TabIndex = 5;
            this.groupBoxGeneral.TabStop = false;
            this.groupBoxGeneral.Text = "General";
            // 
            // checkBoxLaunchOnStartUp
            // 
            this.checkBoxLaunchOnStartUp.AutoSize = true;
            this.checkBoxLaunchOnStartUp.Location = new System.Drawing.Point(25, 31);
            this.checkBoxLaunchOnStartUp.Name = "checkBoxLaunchOnStartUp";
            this.checkBoxLaunchOnStartUp.Size = new System.Drawing.Size(199, 17);
            this.checkBoxLaunchOnStartUp.TabIndex = 0;
            this.checkBoxLaunchOnStartUp.Text = "Launch Procrasterminator on Startup";
            this.checkBoxLaunchOnStartUp.UseVisualStyleBackColor = true;
            // 
            // labelListDescription
            // 
            this.labelListDescription.Location = new System.Drawing.Point(6, 29);
            this.labelListDescription.Name = "labelListDescription";
            this.labelListDescription.Size = new System.Drawing.Size(172, 42);
            this.labelListDescription.TabIndex = 0;
            this.labelListDescription.Text = "Keywords that correspond to your sources of procrastination:";
            // 
            // listView1
            // 
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9});
            this.listView1.Location = new System.Drawing.Point(6, 62);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(169, 230);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // labelTolerantDescription
            // 
            this.labelTolerantDescription.Location = new System.Drawing.Point(32, 110);
            this.labelTolerantDescription.Name = "labelTolerantDescription";
            this.labelTolerantDescription.Size = new System.Drawing.Size(186, 29);
            this.labelTolerantDescription.TabIndex = 3;
            this.labelTolerantDescription.Text = "Okay...you are allowed to procrastinate! But only for ";
            // 
            // radioButtonOff
            // 
            this.radioButtonOff.AutoSize = true;
            this.radioButtonOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOff.Location = new System.Drawing.Point(15, 173);
            this.radioButtonOff.Name = "radioButtonOff";
            this.radioButtonOff.Size = new System.Drawing.Size(42, 17);
            this.radioButtonOff.TabIndex = 4;
            this.radioButtonOff.TabStop = true;
            this.radioButtonOff.Text = "Off";
            this.radioButtonOff.UseVisualStyleBackColor = true;
            // 
            // textBoxAddKeyword
            // 
            this.textBoxAddKeyword.Location = new System.Drawing.Point(6, 298);
            this.textBoxAddKeyword.Name = "textBoxAddKeyword";
            this.textBoxAddKeyword.Size = new System.Drawing.Size(169, 20);
            this.textBoxAddKeyword.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anoutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // anoutToolStripMenuItem
            // 
            this.anoutToolStripMenuItem.Name = "anoutToolStripMenuItem";
            this.anoutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.anoutToolStripMenuItem.Text = "About";
            // 
            // buttonAddKeyword
            // 
            this.buttonAddKeyword.Image = global::Procrasterminator.Properties.Resources.plus;
            this.buttonAddKeyword.Location = new System.Drawing.Point(6, 323);
            this.buttonAddKeyword.Name = "buttonAddKeyword";
            this.buttonAddKeyword.Size = new System.Drawing.Size(81, 30);
            this.buttonAddKeyword.TabIndex = 6;
            this.buttonAddKeyword.UseVisualStyleBackColor = true;
            // 
            // pictureBoxSapoTerminator
            // 
            this.pictureBoxSapoTerminator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxSapoTerminator.Image = global::Procrasterminator.Properties.Resources.sapoTerminator;
            this.pictureBoxSapoTerminator.Location = new System.Drawing.Point(148, 19);
            this.pictureBoxSapoTerminator.Name = "pictureBoxSapoTerminator";
            this.pictureBoxSapoTerminator.Size = new System.Drawing.Size(79, 62);
            this.pictureBoxSapoTerminator.TabIndex = 0;
            this.pictureBoxSapoTerminator.TabStop = false;
            // 
            // buttonRemoveKeyword
            // 
            this.buttonRemoveKeyword.Image = global::Procrasterminator.Properties.Resources.cross;
            this.buttonRemoveKeyword.Location = new System.Drawing.Point(93, 323);
            this.buttonRemoveKeyword.Name = "buttonRemoveKeyword";
            this.buttonRemoveKeyword.Size = new System.Drawing.Size(82, 31);
            this.buttonRemoveKeyword.TabIndex = 8;
            this.buttonRemoveKeyword.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 142);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(49, 20);
            this.textBox1.TabIndex = 5;
            // 
            // labelMinutes
            // 
            this.labelMinutes.AutoSize = true;
            this.labelMinutes.Location = new System.Drawing.Point(88, 148);
            this.labelMinutes.Name = "labelMinutes";
            this.labelMinutes.Size = new System.Drawing.Size(28, 13);
            this.labelMinutes.TabIndex = 6;
            this.labelMinutes.Text = "mins";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(122, 142);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(45, 20);
            this.textBox2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(33, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Well...if you want to to through the path of lazyness...it\'s your call.";
            // 
            // labelSeconds
            // 
            this.labelSeconds.AutoSize = true;
            this.labelSeconds.Location = new System.Drawing.Point(173, 148);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Size = new System.Drawing.Size(29, 13);
            this.labelSeconds.TabIndex = 9;
            this.labelSeconds.Text = "secs";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 464);
            this.Controls.Add(this.groupBoxGeneral);
            this.Controls.Add(this.groupBoxTasks);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxLinkChoice);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBoxSapoTerminator);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Procrasterminator";
            this.groupBoxLinkChoice.ResumeLayout(false);
            this.groupBoxLinkChoice.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxGeneral.ResumeLayout(false);
            this.groupBoxGeneral.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSapoTerminator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSapoTerminator;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBoxLinkChoice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBoxTasks;
        private System.Windows.Forms.RadioButton radioButtonTolerant;
        private System.Windows.Forms.RadioButton radioButtonAggressive;
        private System.Windows.Forms.Label labelAgressiveDescription;
        private System.Windows.Forms.GroupBox groupBoxGeneral;
        private System.Windows.Forms.CheckBox checkBoxLaunchOnStartUp;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label labelListDescription;
        private System.Windows.Forms.RadioButton radioButtonOff;
        private System.Windows.Forms.Label labelTolerantDescription;
        private System.Windows.Forms.TextBox textBoxAddKeyword;
        private System.Windows.Forms.Button buttonAddKeyword;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anoutToolStripMenuItem;
        private System.Windows.Forms.Button buttonRemoveKeyword;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelSeconds;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelMinutes;
        private System.Windows.Forms.TextBox textBox1;
    }
}

