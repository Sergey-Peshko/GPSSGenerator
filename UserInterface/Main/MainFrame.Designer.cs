namespace WinFromInterface
{
	partial class MainFrame
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBoxSettings = new System.Windows.Forms.GroupBox();
			this.isTime = new System.Windows.Forms.RadioButton();
			this.isTransactions = new System.Windows.Forms.RadioButton();
			this.numericValue = new System.Windows.Forms.NumericUpDown();
			this.groupBoxStreams = new System.Windows.Forms.GroupBox();
			this.buttonEditStream = new System.Windows.Forms.Button();
			this.buttonDeleteStream = new System.Windows.Forms.Button();
			this.buttonAddStream = new System.Windows.Forms.Button();
			this.streamListBox = new System.Windows.Forms.ListBox();
			this.groupBoxEntities = new System.Windows.Forms.GroupBox();
			this.buttonEditNode = new System.Windows.Forms.Button();
			this.buttonDeleteNode = new System.Windows.Forms.Button();
			this.buttonAddNode = new System.Windows.Forms.Button();
			this.entitiesDataGridView = new System.Windows.Forms.DataGridView();
			this.nameOfEntityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.entityTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonGenerate = new System.Windows.Forms.Button();
			this.mainTabControl = new System.Windows.Forms.TabControl();
			this.generalTabPage = new System.Windows.Forms.TabPage();
			this.entitiesTabPage = new System.Windows.Forms.TabPage();
			this.statisticsTabPage = new System.Windows.Forms.TabPage();
			this.statisticsGroupBox = new System.Windows.Forms.GroupBox();
			this.removeButton = new System.Windows.Forms.Button();
			this.editButton = new System.Windows.Forms.Button();
			this.addButton = new System.Windows.Forms.Button();
			this.statisticsDataGridView = new System.Windows.Forms.DataGridView();
			this.nameOfStatisticColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statisticTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.StreamsTabPage = new System.Windows.Forms.TabPage();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.menuStrip1.SuspendLayout();
			this.groupBoxSettings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericValue)).BeginInit();
			this.groupBoxStreams.SuspendLayout();
			this.groupBoxEntities.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.entitiesDataGridView)).BeginInit();
			this.mainTabControl.SuspendLayout();
			this.generalTabPage.SuspendLayout();
			this.entitiesTabPage.SuspendLayout();
			this.statisticsTabPage.SuspendLayout();
			this.statisticsGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.statisticsDataGridView)).BeginInit();
			this.StreamsTabPage.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(484, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.newToolStripMenuItem.Text = "New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// groupBoxSettings
			// 
			this.groupBoxSettings.Controls.Add(this.isTime);
			this.groupBoxSettings.Controls.Add(this.isTransactions);
			this.groupBoxSettings.Controls.Add(this.numericValue);
			this.groupBoxSettings.Location = new System.Drawing.Point(6, 6);
			this.groupBoxSettings.Name = "groupBoxSettings";
			this.groupBoxSettings.Size = new System.Drawing.Size(436, 277);
			this.groupBoxSettings.TabIndex = 1;
			this.groupBoxSettings.TabStop = false;
			this.groupBoxSettings.Text = "Measure life cycle by";
			// 
			// isTime
			// 
			this.isTime.AutoSize = true;
			this.isTime.Location = new System.Drawing.Point(6, 19);
			this.isTime.Name = "isTime";
			this.isTime.Size = new System.Drawing.Size(80, 17);
			this.isTime.TabIndex = 11;
			this.isTime.Text = "Time (sec.):";
			this.isTime.UseVisualStyleBackColor = true;
			// 
			// isTransactions
			// 
			this.isTransactions.AutoSize = true;
			this.isTransactions.Checked = true;
			this.isTransactions.Location = new System.Drawing.Point(107, 19);
			this.isTransactions.Name = "isTransactions";
			this.isTransactions.Size = new System.Drawing.Size(122, 17);
			this.isTransactions.TabIndex = 10;
			this.isTransactions.TabStop = true;
			this.isTransactions.Text = "Num. of transactions";
			this.isTransactions.UseVisualStyleBackColor = true;
			// 
			// numericValue
			// 
			this.numericValue.Location = new System.Drawing.Point(30, 53);
			this.numericValue.Maximum = new decimal(new int[] {
            1241513984,
            370409800,
            542101,
            0});
			this.numericValue.Name = "numericValue";
			this.numericValue.Size = new System.Drawing.Size(121, 20);
			this.numericValue.TabIndex = 4;
			this.numericValue.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			// 
			// groupBoxStreams
			// 
			this.groupBoxStreams.Controls.Add(this.buttonEditStream);
			this.groupBoxStreams.Controls.Add(this.buttonDeleteStream);
			this.groupBoxStreams.Controls.Add(this.buttonAddStream);
			this.groupBoxStreams.Controls.Add(this.streamListBox);
			this.groupBoxStreams.Location = new System.Drawing.Point(6, 6);
			this.groupBoxStreams.Name = "groupBoxStreams";
			this.groupBoxStreams.Size = new System.Drawing.Size(290, 277);
			this.groupBoxStreams.TabIndex = 2;
			this.groupBoxStreams.TabStop = false;
			this.groupBoxStreams.Text = "Streams descriptions";
			// 
			// buttonEditStream
			// 
			this.buttonEditStream.Location = new System.Drawing.Point(175, 48);
			this.buttonEditStream.Name = "buttonEditStream";
			this.buttonEditStream.Size = new System.Drawing.Size(102, 23);
			this.buttonEditStream.TabIndex = 6;
			this.buttonEditStream.Text = "edit";
			this.buttonEditStream.UseVisualStyleBackColor = true;
			this.buttonEditStream.Click += new System.EventHandler(this.buttonEditStream_Click);
			// 
			// buttonDeleteStream
			// 
			this.buttonDeleteStream.Location = new System.Drawing.Point(175, 77);
			this.buttonDeleteStream.Name = "buttonDeleteStream";
			this.buttonDeleteStream.Size = new System.Drawing.Size(102, 23);
			this.buttonDeleteStream.TabIndex = 5;
			this.buttonDeleteStream.Text = "remove";
			this.buttonDeleteStream.UseVisualStyleBackColor = true;
			this.buttonDeleteStream.Click += new System.EventHandler(this.buttonDeleteStream_Click);
			// 
			// buttonAddStream
			// 
			this.buttonAddStream.Location = new System.Drawing.Point(175, 19);
			this.buttonAddStream.Name = "buttonAddStream";
			this.buttonAddStream.Size = new System.Drawing.Size(102, 23);
			this.buttonAddStream.TabIndex = 4;
			this.buttonAddStream.Text = "add";
			this.buttonAddStream.UseVisualStyleBackColor = true;
			this.buttonAddStream.Click += new System.EventHandler(this.buttonAddStream_Click);
			// 
			// streamListBox
			// 
			this.streamListBox.FormattingEnabled = true;
			this.streamListBox.Location = new System.Drawing.Point(6, 19);
			this.streamListBox.Name = "streamListBox";
			this.streamListBox.Size = new System.Drawing.Size(161, 251);
			this.streamListBox.TabIndex = 0;
			// 
			// groupBoxEntities
			// 
			this.groupBoxEntities.Controls.Add(this.buttonEditNode);
			this.groupBoxEntities.Controls.Add(this.buttonDeleteNode);
			this.groupBoxEntities.Controls.Add(this.buttonAddNode);
			this.groupBoxEntities.Controls.Add(this.entitiesDataGridView);
			this.groupBoxEntities.Location = new System.Drawing.Point(3, 6);
			this.groupBoxEntities.Name = "groupBoxEntities";
			this.groupBoxEntities.Size = new System.Drawing.Size(439, 277);
			this.groupBoxEntities.TabIndex = 3;
			this.groupBoxEntities.TabStop = false;
			this.groupBoxEntities.Text = "Entities descriptions";
			// 
			// buttonEditNode
			// 
			this.buttonEditNode.Location = new System.Drawing.Point(328, 48);
			this.buttonEditNode.Name = "buttonEditNode";
			this.buttonEditNode.Size = new System.Drawing.Size(102, 23);
			this.buttonEditNode.TabIndex = 3;
			this.buttonEditNode.Text = "edit";
			this.buttonEditNode.UseVisualStyleBackColor = true;
			this.buttonEditNode.Click += new System.EventHandler(this.editEntityButton_Click);
			// 
			// buttonDeleteNode
			// 
			this.buttonDeleteNode.Location = new System.Drawing.Point(328, 77);
			this.buttonDeleteNode.Name = "buttonDeleteNode";
			this.buttonDeleteNode.Size = new System.Drawing.Size(102, 23);
			this.buttonDeleteNode.TabIndex = 2;
			this.buttonDeleteNode.Text = "remove";
			this.buttonDeleteNode.UseVisualStyleBackColor = true;
			this.buttonDeleteNode.Click += new System.EventHandler(this.removeEntityButton_Click);
			// 
			// buttonAddNode
			// 
			this.buttonAddNode.Location = new System.Drawing.Point(328, 19);
			this.buttonAddNode.Name = "buttonAddNode";
			this.buttonAddNode.Size = new System.Drawing.Size(102, 23);
			this.buttonAddNode.TabIndex = 1;
			this.buttonAddNode.Text = "add";
			this.buttonAddNode.UseVisualStyleBackColor = true;
			this.buttonAddNode.Click += new System.EventHandler(this.addEntityButton_Click);
			// 
			// entitiesDataGridView
			// 
			this.entitiesDataGridView.AllowUserToAddRows = false;
			this.entitiesDataGridView.AllowUserToDeleteRows = false;
			this.entitiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.entitiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameOfEntityColumn,
            this.entityTypeColumn});
			this.entitiesDataGridView.Location = new System.Drawing.Point(6, 19);
			this.entitiesDataGridView.Name = "entitiesDataGridView";
			this.entitiesDataGridView.ReadOnly = true;
			this.entitiesDataGridView.Size = new System.Drawing.Size(316, 252);
			this.entitiesDataGridView.TabIndex = 0;
			// 
			// nameOfEntityColumn
			// 
			this.nameOfEntityColumn.Frozen = true;
			this.nameOfEntityColumn.HeaderText = "Name of Entity";
			this.nameOfEntityColumn.Name = "nameOfEntityColumn";
			this.nameOfEntityColumn.ReadOnly = true;
			// 
			// entityTypeColumn
			// 
			this.entityTypeColumn.FillWeight = 170F;
			this.entityTypeColumn.Frozen = true;
			this.entityTypeColumn.HeaderText = "Type";
			this.entityTypeColumn.Name = "entityTypeColumn";
			this.entityTypeColumn.ReadOnly = true;
			this.entityTypeColumn.Width = 170;
			// 
			// buttonGenerate
			// 
			this.buttonGenerate.Location = new System.Drawing.Point(168, 348);
			this.buttonGenerate.Name = "buttonGenerate";
			this.buttonGenerate.Size = new System.Drawing.Size(131, 23);
			this.buttonGenerate.TabIndex = 4;
			this.buttonGenerate.Text = "Generate Code";
			this.buttonGenerate.UseVisualStyleBackColor = true;
			this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
			// 
			// mainTabControl
			// 
			this.mainTabControl.Controls.Add(this.generalTabPage);
			this.mainTabControl.Controls.Add(this.entitiesTabPage);
			this.mainTabControl.Controls.Add(this.statisticsTabPage);
			this.mainTabControl.Controls.Add(this.StreamsTabPage);
			this.mainTabControl.Location = new System.Drawing.Point(12, 27);
			this.mainTabControl.Name = "mainTabControl";
			this.mainTabControl.SelectedIndex = 0;
			this.mainTabControl.Size = new System.Drawing.Size(456, 315);
			this.mainTabControl.TabIndex = 5;
			// 
			// generalTabPage
			// 
			this.generalTabPage.Controls.Add(this.groupBoxSettings);
			this.generalTabPage.Location = new System.Drawing.Point(4, 22);
			this.generalTabPage.Name = "generalTabPage";
			this.generalTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.generalTabPage.Size = new System.Drawing.Size(448, 289);
			this.generalTabPage.TabIndex = 0;
			this.generalTabPage.Text = "General";
			this.generalTabPage.UseVisualStyleBackColor = true;
			// 
			// entitiesTabPage
			// 
			this.entitiesTabPage.Controls.Add(this.groupBoxEntities);
			this.entitiesTabPage.Location = new System.Drawing.Point(4, 22);
			this.entitiesTabPage.Name = "entitiesTabPage";
			this.entitiesTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.entitiesTabPage.Size = new System.Drawing.Size(448, 289);
			this.entitiesTabPage.TabIndex = 1;
			this.entitiesTabPage.Text = "Entities";
			this.entitiesTabPage.UseVisualStyleBackColor = true;
			// 
			// statisticsTabPage
			// 
			this.statisticsTabPage.Controls.Add(this.statisticsGroupBox);
			this.statisticsTabPage.Location = new System.Drawing.Point(4, 22);
			this.statisticsTabPage.Name = "statisticsTabPage";
			this.statisticsTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.statisticsTabPage.Size = new System.Drawing.Size(448, 289);
			this.statisticsTabPage.TabIndex = 2;
			this.statisticsTabPage.Text = "Statistics";
			this.statisticsTabPage.UseVisualStyleBackColor = true;
			// 
			// statisticsGroupBox
			// 
			this.statisticsGroupBox.Controls.Add(this.removeButton);
			this.statisticsGroupBox.Controls.Add(this.editButton);
			this.statisticsGroupBox.Controls.Add(this.addButton);
			this.statisticsGroupBox.Controls.Add(this.statisticsDataGridView);
			this.statisticsGroupBox.Location = new System.Drawing.Point(6, 6);
			this.statisticsGroupBox.Name = "statisticsGroupBox";
			this.statisticsGroupBox.Size = new System.Drawing.Size(436, 280);
			this.statisticsGroupBox.TabIndex = 0;
			this.statisticsGroupBox.TabStop = false;
			this.statisticsGroupBox.Text = "Statistics descriptions";
			// 
			// removeButton
			// 
			this.removeButton.Location = new System.Drawing.Point(331, 77);
			this.removeButton.Name = "removeButton";
			this.removeButton.Size = new System.Drawing.Size(99, 23);
			this.removeButton.TabIndex = 3;
			this.removeButton.Text = "remove";
			this.removeButton.UseVisualStyleBackColor = true;
			this.removeButton.Click += new System.EventHandler(this.removeStatisticButton_Click);
			// 
			// editButton
			// 
			this.editButton.Location = new System.Drawing.Point(331, 48);
			this.editButton.Name = "editButton";
			this.editButton.Size = new System.Drawing.Size(99, 23);
			this.editButton.TabIndex = 2;
			this.editButton.Text = "edit";
			this.editButton.UseVisualStyleBackColor = true;
			this.editButton.Click += new System.EventHandler(this.editStatisticButton_Click);
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(331, 19);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(99, 23);
			this.addButton.TabIndex = 1;
			this.addButton.Text = "add";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addStatisticButton_Click);
			// 
			// statisticsDataGridView
			// 
			this.statisticsDataGridView.AllowUserToAddRows = false;
			this.statisticsDataGridView.AllowUserToDeleteRows = false;
			this.statisticsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.statisticsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameOfStatisticColumn,
            this.statisticTypeColumn});
			this.statisticsDataGridView.Location = new System.Drawing.Point(6, 19);
			this.statisticsDataGridView.Name = "statisticsDataGridView";
			this.statisticsDataGridView.ReadOnly = true;
			this.statisticsDataGridView.Size = new System.Drawing.Size(319, 255);
			this.statisticsDataGridView.TabIndex = 0;
			// 
			// nameOfStatisticColumn
			// 
			this.nameOfStatisticColumn.Frozen = true;
			this.nameOfStatisticColumn.HeaderText = "Name of Statistic";
			this.nameOfStatisticColumn.Name = "nameOfStatisticColumn";
			this.nameOfStatisticColumn.ReadOnly = true;
			// 
			// statisticTypeColumn
			// 
			this.statisticTypeColumn.FillWeight = 170F;
			this.statisticTypeColumn.Frozen = true;
			this.statisticTypeColumn.HeaderText = "Type";
			this.statisticTypeColumn.Name = "statisticTypeColumn";
			this.statisticTypeColumn.ReadOnly = true;
			this.statisticTypeColumn.Width = 170;
			// 
			// StreamsTabPage
			// 
			this.StreamsTabPage.Controls.Add(this.groupBoxStreams);
			this.StreamsTabPage.Location = new System.Drawing.Point(4, 22);
			this.StreamsTabPage.Name = "StreamsTabPage";
			this.StreamsTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.StreamsTabPage.Size = new System.Drawing.Size(448, 289);
			this.StreamsTabPage.TabIndex = 3;
			this.StreamsTabPage.Text = "Streams";
			this.StreamsTabPage.UseVisualStyleBackColor = true;
			// 
			// openFileDialog
			// 
			this.openFileDialog.DefaultExt = "xml";
			this.openFileDialog.FileName = "openFileDialog";
			this.openFileDialog.Filter = "XML files|*.xml";
			// 
			// saveFileDialog
			// 
			this.saveFileDialog.DefaultExt = "xml";
			this.saveFileDialog.Filter = "XML files|*.xml";
			// 
			// MainFrame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 383);
			this.Controls.Add(this.buttonGenerate);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.mainTabControl);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainFrame";
			this.Text = "GPSSHelper";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBoxSettings.ResumeLayout(false);
			this.groupBoxSettings.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericValue)).EndInit();
			this.groupBoxStreams.ResumeLayout(false);
			this.groupBoxEntities.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.entitiesDataGridView)).EndInit();
			this.mainTabControl.ResumeLayout(false);
			this.generalTabPage.ResumeLayout(false);
			this.entitiesTabPage.ResumeLayout(false);
			this.statisticsTabPage.ResumeLayout(false);
			this.statisticsGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.statisticsDataGridView)).EndInit();
			this.StreamsTabPage.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.GroupBox groupBoxSettings;
		private System.Windows.Forms.NumericUpDown numericValue;
		private System.Windows.Forms.GroupBox groupBoxStreams;
		private System.Windows.Forms.GroupBox groupBoxEntities;
		private System.Windows.Forms.Button buttonEditNode;
		private System.Windows.Forms.Button buttonDeleteNode;
		private System.Windows.Forms.Button buttonAddNode;
		private System.Windows.Forms.DataGridView entitiesDataGridView;
		private System.Windows.Forms.Button buttonGenerate;
		private System.Windows.Forms.Button buttonEditStream;
		private System.Windows.Forms.Button buttonDeleteStream;
		private System.Windows.Forms.Button buttonAddStream;
		private System.Windows.Forms.ListBox streamListBox;
		private System.Windows.Forms.RadioButton isTime;
		private System.Windows.Forms.RadioButton isTransactions;
		private System.Windows.Forms.TabControl mainTabControl;
		private System.Windows.Forms.TabPage generalTabPage;
		private System.Windows.Forms.TabPage entitiesTabPage;
		private System.Windows.Forms.TabPage statisticsTabPage;
		private System.Windows.Forms.TabPage StreamsTabPage;
		private System.Windows.Forms.GroupBox statisticsGroupBox;
		private System.Windows.Forms.Button removeButton;
		private System.Windows.Forms.Button editButton;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.DataGridView statisticsDataGridView;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameOfEntityColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn entityTypeColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameOfStatisticColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn statisticTypeColumn;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
	}
}

