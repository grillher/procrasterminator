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
            System.Windows.Forms.ListViewItem listViewItem31 = new System.Windows.Forms.ListViewItem("Facebook");
            System.Windows.Forms.ListViewItem listViewItem32 = new System.Windows.Forms.ListViewItem("YouTube");
            System.Windows.Forms.ListViewItem listViewItem33 = new System.Windows.Forms.ListViewItem("Twitter");
            System.Windows.Forms.ListViewItem listViewItem34 = new System.Windows.Forms.ListViewItem("Collegehumor");
            System.Windows.Forms.ListViewItem listViewItem35 = new System.Windows.Forms.ListViewItem("Geekologie");
            System.Windows.Forms.ListViewItem listViewItem36 = new System.Windows.Forms.ListViewItem("Freerice");
            System.Windows.Forms.ListViewItem listViewItem37 = new System.Windows.Forms.ListViewItem("Pogo");
            System.Windows.Forms.ListViewItem listViewItem38 = new System.Windows.Forms.ListViewItem("Bored");
            System.Windows.Forms.ListViewItem listViewItem39 = new System.Windows.Forms.ListViewItem("Postsecret");
            System.Windows.Forms.ListViewItem listViewItem40 = new System.Windows.Forms.ListViewItem("Hi5");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxListKeywords = new System.Windows.Forms.GroupBox();
            this.buttonRemoveKeyword = new System.Windows.Forms.Button();
            this.textBoxAddKeyword = new System.Windows.Forms.TextBox();
            this.buttonAddKeyword = new System.Windows.Forms.Button();
            this.listViewKeyword = new System.Windows.Forms.ListView();
            this.labelListDescription = new System.Windows.Forms.Label();
            this.groupBoxMode = new System.Windows.Forms.GroupBox();
            this.labelTolerantSeconds = new System.Windows.Forms.Label();
            this.labelOffDescription = new System.Windows.Forms.Label();
            this.textBoxTolerantSeconds = new System.Windows.Forms.TextBox();
            this.labelTolerantMinutes = new System.Windows.Forms.Label();
            this.textBoxTolerantMinutes = new System.Windows.Forms.TextBox();
            this.radioButtonOff = new System.Windows.Forms.RadioButton();
            this.labelTolerantDescription = new System.Windows.Forms.Label();
            this.labelAgressiveDescription = new System.Windows.Forms.Label();
            this.radioButtonTolerant = new System.Windows.Forms.RadioButton();
            this.radioButtonAggressive = new System.Windows.Forms.RadioButton();
            this.groupBoxTasks = new System.Windows.Forms.GroupBox();
            this.groupBoxGeneral = new System.Windows.Forms.GroupBox();
            this.checkBoxLaunchOnStartUp = new System.Windows.Forms.CheckBox();
            this.menuStripTop = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxSapoTerminator = new System.Windows.Forms.PictureBox();
            this.timerController = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changeProcrastinationModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aggressiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tolerantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.comboBoxHost = new System.Windows.Forms.ComboBox();
            this.listViewTaskList = new System.Windows.Forms.ListView();
            this.labelHost = new System.Windows.Forms.Label();
            this.labelTaskList = new System.Windows.Forms.Label();
            this.buttonGetTasks = new System.Windows.Forms.Button();
            this.groupBoxListKeywords.SuspendLayout();
            this.groupBoxMode.SuspendLayout();
            this.groupBoxTasks.SuspendLayout();
            this.groupBoxGeneral.SuspendLayout();
            this.menuStripTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSapoTerminator)).BeginInit();
            this.contextMenuStripNotifyIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(233, 37);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(358, 38);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Procrasterminator";
            // 
            // groupBoxListKeywords
            // 
            this.groupBoxListKeywords.Controls.Add(this.buttonRemoveKeyword);
            this.groupBoxListKeywords.Controls.Add(this.textBoxAddKeyword);
            this.groupBoxListKeywords.Controls.Add(this.buttonAddKeyword);
            this.groupBoxListKeywords.Controls.Add(this.listViewKeyword);
            this.groupBoxListKeywords.Controls.Add(this.labelListDescription);
            this.groupBoxListKeywords.Location = new System.Drawing.Point(12, 96);
            this.groupBoxListKeywords.Name = "groupBoxListKeywords";
            this.groupBoxListKeywords.Size = new System.Drawing.Size(189, 360);
            this.groupBoxListKeywords.TabIndex = 2;
            this.groupBoxListKeywords.TabStop = false;
            this.groupBoxListKeywords.Text = "Procrastination List";
            // 
            // buttonRemoveKeyword
            // 
            this.buttonRemoveKeyword.Image = global::Procrasterminator.Properties.Resources.cross;
            this.buttonRemoveKeyword.Location = new System.Drawing.Point(93, 323);
            this.buttonRemoveKeyword.Name = "buttonRemoveKeyword";
            this.buttonRemoveKeyword.Size = new System.Drawing.Size(82, 31);
            this.buttonRemoveKeyword.TabIndex = 8;
            this.buttonRemoveKeyword.UseVisualStyleBackColor = true;
            this.buttonRemoveKeyword.Click += new System.EventHandler(this.buttonRemoveKeyword_Click);
            // 
            // textBoxAddKeyword
            // 
            this.textBoxAddKeyword.Location = new System.Drawing.Point(6, 298);
            this.textBoxAddKeyword.Name = "textBoxAddKeyword";
            this.textBoxAddKeyword.Size = new System.Drawing.Size(169, 20);
            this.textBoxAddKeyword.TabIndex = 7;
            // 
            // buttonAddKeyword
            // 
            this.buttonAddKeyword.Image = global::Procrasterminator.Properties.Resources.plus;
            this.buttonAddKeyword.Location = new System.Drawing.Point(6, 323);
            this.buttonAddKeyword.Name = "buttonAddKeyword";
            this.buttonAddKeyword.Size = new System.Drawing.Size(81, 30);
            this.buttonAddKeyword.TabIndex = 6;
            this.buttonAddKeyword.UseVisualStyleBackColor = true;
            this.buttonAddKeyword.Click += new System.EventHandler(this.buttonAddKeyword_Click);
            // 
            // listViewKeyword
            // 
            this.listViewKeyword.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem31,
            listViewItem32,
            listViewItem33,
            listViewItem34,
            listViewItem35,
            listViewItem36,
            listViewItem37,
            listViewItem38,
            listViewItem39,
            listViewItem40});
            this.listViewKeyword.Location = new System.Drawing.Point(6, 62);
            this.listViewKeyword.Name = "listViewKeyword";
            this.listViewKeyword.Size = new System.Drawing.Size(169, 230);
            this.listViewKeyword.TabIndex = 1;
            this.listViewKeyword.UseCompatibleStateImageBehavior = false;
            this.listViewKeyword.View = System.Windows.Forms.View.List;
            // 
            // labelListDescription
            // 
            this.labelListDescription.Location = new System.Drawing.Point(6, 29);
            this.labelListDescription.Name = "labelListDescription";
            this.labelListDescription.Size = new System.Drawing.Size(172, 30);
            this.labelListDescription.TabIndex = 0;
            this.labelListDescription.Text = "Keywords that correspond to your sources of procrastination:";
            // 
            // groupBoxMode
            // 
            this.groupBoxMode.Controls.Add(this.labelTolerantSeconds);
            this.groupBoxMode.Controls.Add(this.labelOffDescription);
            this.groupBoxMode.Controls.Add(this.textBoxTolerantSeconds);
            this.groupBoxMode.Controls.Add(this.labelTolerantMinutes);
            this.groupBoxMode.Controls.Add(this.textBoxTolerantMinutes);
            this.groupBoxMode.Controls.Add(this.radioButtonOff);
            this.groupBoxMode.Controls.Add(this.labelTolerantDescription);
            this.groupBoxMode.Controls.Add(this.labelAgressiveDescription);
            this.groupBoxMode.Controls.Add(this.radioButtonTolerant);
            this.groupBoxMode.Controls.Add(this.radioButtonAggressive);
            this.groupBoxMode.Location = new System.Drawing.Point(210, 96);
            this.groupBoxMode.Name = "groupBoxMode";
            this.groupBoxMode.Size = new System.Drawing.Size(224, 260);
            this.groupBoxMode.TabIndex = 3;
            this.groupBoxMode.TabStop = false;
            this.groupBoxMode.Text = "Procrastination Mode:";
            // 
            // labelTolerantSeconds
            // 
            this.labelTolerantSeconds.AutoSize = true;
            this.labelTolerantSeconds.Location = new System.Drawing.Point(173, 161);
            this.labelTolerantSeconds.Name = "labelTolerantSeconds";
            this.labelTolerantSeconds.Size = new System.Drawing.Size(29, 13);
            this.labelTolerantSeconds.TabIndex = 9;
            this.labelTolerantSeconds.Text = "secs";
            // 
            // labelOffDescription
            // 
            this.labelOffDescription.Location = new System.Drawing.Point(33, 211);
            this.labelOffDescription.Name = "labelOffDescription";
            this.labelOffDescription.Size = new System.Drawing.Size(185, 29);
            this.labelOffDescription.TabIndex = 8;
            this.labelOffDescription.Text = "Well...if you want to go through the path of lazyness...it\'s your call.";
            // 
            // textBoxTolerantSeconds
            // 
            this.textBoxTolerantSeconds.Location = new System.Drawing.Point(122, 158);
            this.textBoxTolerantSeconds.Name = "textBoxTolerantSeconds";
            this.textBoxTolerantSeconds.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxTolerantSeconds.Size = new System.Drawing.Size(45, 20);
            this.textBoxTolerantSeconds.TabIndex = 7;
            this.textBoxTolerantSeconds.Leave += new System.EventHandler(this.textBoxTolerantSeconds_Leave);
            this.textBoxTolerantSeconds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKeyPress);
            // 
            // labelTolerantMinutes
            // 
            this.labelTolerantMinutes.AutoSize = true;
            this.labelTolerantMinutes.Location = new System.Drawing.Point(88, 161);
            this.labelTolerantMinutes.Name = "labelTolerantMinutes";
            this.labelTolerantMinutes.Size = new System.Drawing.Size(28, 13);
            this.labelTolerantMinutes.TabIndex = 6;
            this.labelTolerantMinutes.Text = "mins";
            // 
            // textBoxTolerantMinutes
            // 
            this.textBoxTolerantMinutes.Location = new System.Drawing.Point(33, 155);
            this.textBoxTolerantMinutes.Name = "textBoxTolerantMinutes";
            this.textBoxTolerantMinutes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxTolerantMinutes.Size = new System.Drawing.Size(49, 20);
            this.textBoxTolerantMinutes.TabIndex = 5;
            this.textBoxTolerantMinutes.Leave += new System.EventHandler(this.textBoxTolerantMinutes_Leave);
            this.textBoxTolerantMinutes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKeyPress);
            // 
            // radioButtonOff
            // 
            this.radioButtonOff.AutoSize = true;
            this.radioButtonOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOff.Location = new System.Drawing.Point(15, 191);
            this.radioButtonOff.Name = "radioButtonOff";
            this.radioButtonOff.Size = new System.Drawing.Size(42, 17);
            this.radioButtonOff.TabIndex = 4;
            this.radioButtonOff.TabStop = true;
            this.radioButtonOff.Text = "Off";
            this.radioButtonOff.UseVisualStyleBackColor = true;
            this.radioButtonOff.Click += new System.EventHandler(this.ChangeToOffMode);
            // 
            // labelTolerantDescription
            // 
            this.labelTolerantDescription.Location = new System.Drawing.Point(32, 123);
            this.labelTolerantDescription.Name = "labelTolerantDescription";
            this.labelTolerantDescription.Size = new System.Drawing.Size(186, 29);
            this.labelTolerantDescription.TabIndex = 3;
            this.labelTolerantDescription.Text = "Okay...you are allowed to procrastinate! But only for ";
            // 
            // labelAgressiveDescription
            // 
            this.labelAgressiveDescription.Location = new System.Drawing.Point(32, 54);
            this.labelAgressiveDescription.Name = "labelAgressiveDescription";
            this.labelAgressiveDescription.Size = new System.Drawing.Size(186, 40);
            this.labelAgressiveDescription.TabIndex = 2;
            this.labelAgressiveDescription.Text = "Keeps you totally from procrastinating! Advisable when there\'s a lot of work to d" +
                "o!";
            // 
            // radioButtonTolerant
            // 
            this.radioButtonTolerant.AutoSize = true;
            this.radioButtonTolerant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTolerant.Location = new System.Drawing.Point(15, 103);
            this.radioButtonTolerant.Name = "radioButtonTolerant";
            this.radioButtonTolerant.Size = new System.Drawing.Size(72, 17);
            this.radioButtonTolerant.TabIndex = 1;
            this.radioButtonTolerant.TabStop = true;
            this.radioButtonTolerant.Text = "Tolerant";
            this.radioButtonTolerant.UseVisualStyleBackColor = true;
            this.radioButtonTolerant.Click += new System.EventHandler(this.ChangeToTolerantMode);
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
            this.radioButtonAggressive.Click += new System.EventHandler(this.ChangeToAgressiveMode);
            // 
            // groupBoxTasks
            // 
            this.groupBoxTasks.Controls.Add(this.buttonGetTasks);
            this.groupBoxTasks.Controls.Add(this.labelTaskList);
            this.groupBoxTasks.Controls.Add(this.labelHost);
            this.groupBoxTasks.Controls.Add(this.listViewTaskList);
            this.groupBoxTasks.Controls.Add(this.comboBoxHost);
            this.groupBoxTasks.Controls.Add(this.textBoxPassword);
            this.groupBoxTasks.Controls.Add(this.label1);
            this.groupBoxTasks.Controls.Add(this.textBoxEmail);
            this.groupBoxTasks.Controls.Add(this.labelEmail);
            this.groupBoxTasks.Location = new System.Drawing.Point(443, 96);
            this.groupBoxTasks.Name = "groupBoxTasks";
            this.groupBoxTasks.Size = new System.Drawing.Size(229, 356);
            this.groupBoxTasks.TabIndex = 4;
            this.groupBoxTasks.TabStop = false;
            this.groupBoxTasks.Text = "Tasks";
            // 
            // groupBoxGeneral
            // 
            this.groupBoxGeneral.Controls.Add(this.checkBoxLaunchOnStartUp);
            this.groupBoxGeneral.Location = new System.Drawing.Point(212, 362);
            this.groupBoxGeneral.Name = "groupBoxGeneral";
            this.groupBoxGeneral.Size = new System.Drawing.Size(222, 94);
            this.groupBoxGeneral.TabIndex = 5;
            this.groupBoxGeneral.TabStop = false;
            this.groupBoxGeneral.Text = "General";
            // 
            // checkBoxLaunchOnStartUp
            // 
            this.checkBoxLaunchOnStartUp.AutoSize = true;
            this.checkBoxLaunchOnStartUp.Checked = true;
            this.checkBoxLaunchOnStartUp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLaunchOnStartUp.Location = new System.Drawing.Point(13, 44);
            this.checkBoxLaunchOnStartUp.Name = "checkBoxLaunchOnStartUp";
            this.checkBoxLaunchOnStartUp.Size = new System.Drawing.Size(199, 17);
            this.checkBoxLaunchOnStartUp.TabIndex = 0;
            this.checkBoxLaunchOnStartUp.Text = "Launch Procrasterminator on Startup";
            this.checkBoxLaunchOnStartUp.UseVisualStyleBackColor = true;
            // 
            // menuStripTop
            // 
            this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripTop.Location = new System.Drawing.Point(0, 0);
            this.menuStripTop.Name = "menuStripTop";
            this.menuStripTop.Size = new System.Drawing.Size(684, 24);
            this.menuStripTop.TabIndex = 6;
            this.menuStripTop.Text = "menuStrip1";
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
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            // pictureBoxSapoTerminator
            // 
            this.pictureBoxSapoTerminator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxSapoTerminator.Image = global::Procrasterminator.Properties.Resources.sapoTerminator;
            this.pictureBoxSapoTerminator.Location = new System.Drawing.Point(148, 26);
            this.pictureBoxSapoTerminator.Name = "pictureBoxSapoTerminator";
            this.pictureBoxSapoTerminator.Size = new System.Drawing.Size(79, 62);
            this.pictureBoxSapoTerminator.TabIndex = 0;
            this.pictureBoxSapoTerminator.TabStop = false;
            // 
            // timerController
            // 
            this.timerController.Enabled = true;
            this.timerController.Interval = 1000;
            this.timerController.Tick += new System.EventHandler(this.timerController_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStripNotifyIcon;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Procrasterminator";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuStripNotifyIcon
            // 
            this.contextMenuStripNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeProcrastinationModeToolStripMenuItem,
            this.toolStripMenuItemExit});
            this.contextMenuStripNotifyIcon.Name = "contextMenuStripNotifyIcon";
            this.contextMenuStripNotifyIcon.Size = new System.Drawing.Size(233, 48);
            // 
            // changeProcrastinationModeToolStripMenuItem
            // 
            this.changeProcrastinationModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aggressiveToolStripMenuItem,
            this.tolerantToolStripMenuItem,
            this.offToolStripMenuItem});
            this.changeProcrastinationModeToolStripMenuItem.Name = "changeProcrastinationModeToolStripMenuItem";
            this.changeProcrastinationModeToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.changeProcrastinationModeToolStripMenuItem.Text = "Change Procrastination Mode";
            // 
            // aggressiveToolStripMenuItem
            // 
            this.aggressiveToolStripMenuItem.Name = "aggressiveToolStripMenuItem";
            this.aggressiveToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.aggressiveToolStripMenuItem.Text = "Agressive";
            this.aggressiveToolStripMenuItem.Click += new System.EventHandler(this.ChangeToAgressiveMode);
            // 
            // tolerantToolStripMenuItem
            // 
            this.tolerantToolStripMenuItem.Name = "tolerantToolStripMenuItem";
            this.tolerantToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.tolerantToolStripMenuItem.Text = "Tolerant";
            this.tolerantToolStripMenuItem.Click += new System.EventHandler(this.ChangeToTolerantMode);
            // 
            // offToolStripMenuItem
            // 
            this.offToolStripMenuItem.Name = "offToolStripMenuItem";
            this.offToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.offToolStripMenuItem.Text = "Off";
            this.offToolStripMenuItem.Click += new System.EventHandler(this.ChangeToOffMode);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(232, 22);
            this.toolStripMenuItemExit.Text = "Exit";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(5, 70);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(38, 13);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "E-mail:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(9, 90);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(208, 20);
            this.textBoxEmail.TabIndex = 1;
            this.textBoxEmail.Text = "grillher@gmail.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(9, 129);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(209, 20);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.Text = "coiso";
            // 
            // comboBoxHost
            // 
            this.comboBoxHost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHost.FormattingEnabled = true;
            this.comboBoxHost.Items.AddRange(new object[] {
            "Todoist.com"});
            this.comboBoxHost.Location = new System.Drawing.Point(9, 42);
            this.comboBoxHost.Name = "comboBoxHost";
            this.comboBoxHost.Size = new System.Drawing.Size(211, 21);
            this.comboBoxHost.TabIndex = 4;
            // 
            // listViewTaskList
            // 
            this.listViewTaskList.Location = new System.Drawing.Point(9, 191);
            this.listViewTaskList.Name = "listViewTaskList";
            this.listViewTaskList.Size = new System.Drawing.Size(211, 159);
            this.listViewTaskList.TabIndex = 5;
            this.listViewTaskList.UseCompatibleStateImageBehavior = false;
            this.listViewTaskList.View = System.Windows.Forms.View.List;
            // 
            // labelHost
            // 
            this.labelHost.AutoSize = true;
            this.labelHost.Location = new System.Drawing.Point(6, 26);
            this.labelHost.Name = "labelHost";
            this.labelHost.Size = new System.Drawing.Size(32, 13);
            this.labelHost.TabIndex = 6;
            this.labelHost.Text = "Host:";
            // 
            // labelTaskList
            // 
            this.labelTaskList.AutoSize = true;
            this.labelTaskList.Location = new System.Drawing.Point(8, 175);
            this.labelTaskList.Name = "labelTaskList";
            this.labelTaskList.Size = new System.Drawing.Size(53, 13);
            this.labelTaskList.TabIndex = 7;
            this.labelTaskList.Text = "Task List:";
            // 
            // buttonGetTasks
            // 
            this.buttonGetTasks.Location = new System.Drawing.Point(138, 155);
            this.buttonGetTasks.Name = "buttonGetTasks";
            this.buttonGetTasks.Size = new System.Drawing.Size(82, 22);
            this.buttonGetTasks.TabIndex = 8;
            this.buttonGetTasks.Text = "Get Tasks!";
            this.buttonGetTasks.UseVisualStyleBackColor = true;
            this.buttonGetTasks.Click += new System.EventHandler(this.buttonGetTasks_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 464);
            this.Controls.Add(this.groupBoxGeneral);
            this.Controls.Add(this.groupBoxMode);
            this.Controls.Add(this.groupBoxListKeywords);
            this.Controls.Add(this.groupBoxTasks);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBoxSapoTerminator);
            this.Controls.Add(this.menuStripTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripTop;
            this.Name = "MainForm";
            this.Text = "Procrasterminator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.groupBoxListKeywords.ResumeLayout(false);
            this.groupBoxListKeywords.PerformLayout();
            this.groupBoxMode.ResumeLayout(false);
            this.groupBoxMode.PerformLayout();
            this.groupBoxTasks.ResumeLayout(false);
            this.groupBoxTasks.PerformLayout();
            this.groupBoxGeneral.ResumeLayout(false);
            this.groupBoxGeneral.PerformLayout();
            this.menuStripTop.ResumeLayout(false);
            this.menuStripTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSapoTerminator)).EndInit();
            this.contextMenuStripNotifyIcon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSapoTerminator;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBoxListKeywords;
        private System.Windows.Forms.GroupBox groupBoxMode;
        private System.Windows.Forms.GroupBox groupBoxTasks;
        private System.Windows.Forms.RadioButton radioButtonTolerant;
        private System.Windows.Forms.RadioButton radioButtonAggressive;
        private System.Windows.Forms.Label labelAgressiveDescription;
        private System.Windows.Forms.GroupBox groupBoxGeneral;
        private System.Windows.Forms.CheckBox checkBoxLaunchOnStartUp;
        private System.Windows.Forms.ListView listViewKeyword;
        private System.Windows.Forms.Label labelListDescription;
        private System.Windows.Forms.RadioButton radioButtonOff;
        private System.Windows.Forms.Label labelTolerantDescription;
        private System.Windows.Forms.TextBox textBoxAddKeyword;
        private System.Windows.Forms.Button buttonAddKeyword;
        private System.Windows.Forms.MenuStrip menuStripTop;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anoutToolStripMenuItem;
        private System.Windows.Forms.Button buttonRemoveKeyword;
        private System.Windows.Forms.Timer timerController;
        private System.Windows.Forms.Label labelTolerantSeconds;
        private System.Windows.Forms.Label labelOffDescription;
        private System.Windows.Forms.TextBox textBoxTolerantSeconds;
        private System.Windows.Forms.Label labelTolerantMinutes;
        private System.Windows.Forms.TextBox textBoxTolerantMinutes;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem changeProcrastinationModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aggressiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tolerantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelTaskList;
        private System.Windows.Forms.Label labelHost;
        private System.Windows.Forms.ListView listViewTaskList;
        private System.Windows.Forms.ComboBox comboBoxHost;
        private System.Windows.Forms.Button buttonGetTasks;
    }
}

