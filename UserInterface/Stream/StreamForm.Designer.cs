namespace WinFromInterface
{
	partial class StreamForm
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.fromComboBox = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.addMovementButton = new System.Windows.Forms.Button();
			this.toComboBox = new System.Windows.Forms.ComboBox();
			this.probabilityNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.removeMovementButton = new System.Windows.Forms.Button();
			this.movementsDataGridView = new System.Windows.Forms.DataGridView();
			this.fromColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.toColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.probabilityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.movementsTabPage = new System.Windows.Forms.TabPage();
			this.statisticsTabPage = new System.Windows.Forms.TabPage();
			this.statisticTabControl = new System.Windows.Forms.TabControl();
			this.beforeTabPage = new System.Windows.Forms.TabPage();
			this.removeStatisticBeforeButton = new System.Windows.Forms.Button();
			this.statisticBeforeDataGridView = new System.Windows.Forms.DataGridView();
			this.statisticPointIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statisticNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.beforeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statisticBeforePointInfoGroupBox = new System.Windows.Forms.GroupBox();
			this.statisticNameComboBox = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.addStatisticButton = new System.Windows.Forms.Button();
			this.statisticIdTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.beforeComboBox = new System.Windows.Forms.ComboBox();
			this.afterTabPage = new System.Windows.Forms.TabPage();
			this.removeStatisticAfterButton = new System.Windows.Forms.Button();
			this.statisticAfterDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.afterComboBox = new System.Windows.Forms.ComboBox();
			this.betweenTabPage = new System.Windows.Forms.TabPage();
			this.removeStatisticBetweenButton = new System.Windows.Forms.Button();
			this.statisticBetweenDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.betweenComboBox = new System.Windows.Forms.ComboBox();
			this.streamIdTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.putSstatisticPointBeforeRadioButton = new System.Windows.Forms.RadioButton();
			this.putStatisticPointAfterRadioButton = new System.Windows.Forms.RadioButton();
			this.putStatisticPointBetweenRadioButton = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.probabilityNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.movementsDataGridView)).BeginInit();
			this.tabControl.SuspendLayout();
			this.movementsTabPage.SuspendLayout();
			this.statisticsTabPage.SuspendLayout();
			this.statisticTabControl.SuspendLayout();
			this.beforeTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.statisticBeforeDataGridView)).BeginInit();
			this.statisticBeforePointInfoGroupBox.SuspendLayout();
			this.afterTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.statisticAfterDataGridView)).BeginInit();
			this.betweenTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.statisticBetweenDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.removeMovementButton);
			this.groupBox1.Controls.Add(this.movementsDataGridView);
			this.groupBox1.Location = new System.Drawing.Point(6, 7);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(670, 354);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Define movements";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.fromComboBox);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.addMovementButton);
			this.groupBox2.Controls.Add(this.toComboBox);
			this.groupBox2.Controls.Add(this.probabilityNumericUpDown);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Location = new System.Drawing.Point(6, 19);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(223, 187);
			this.groupBox2.TabIndex = 20;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Movement info";
			// 
			// fromComboBox
			// 
			this.fromComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.fromComboBox.FormattingEnabled = true;
			this.fromComboBox.Location = new System.Drawing.Point(84, 23);
			this.fromComboBox.Name = "fromComboBox";
			this.fromComboBox.Size = new System.Drawing.Size(121, 21);
			this.fromComboBox.TabIndex = 14;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(7, 98);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 13);
			this.label5.TabIndex = 19;
			this.label5.Text = "Probability(%):";
			// 
			// addMovementButton
			// 
			this.addMovementButton.Location = new System.Drawing.Point(130, 136);
			this.addMovementButton.Name = "addMovementButton";
			this.addMovementButton.Size = new System.Drawing.Size(75, 25);
			this.addMovementButton.TabIndex = 1;
			this.addMovementButton.Text = "Add";
			this.addMovementButton.UseVisualStyleBackColor = true;
			this.addMovementButton.Click += new System.EventHandler(this.addMovementButton_Click);
			// 
			// toComboBox
			// 
			this.toComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.toComboBox.FormattingEnabled = true;
			this.toComboBox.Location = new System.Drawing.Point(84, 52);
			this.toComboBox.Name = "toComboBox";
			this.toComboBox.Size = new System.Drawing.Size(121, 21);
			this.toComboBox.TabIndex = 15;
			// 
			// probabilityNumericUpDown
			// 
			this.probabilityNumericUpDown.Location = new System.Drawing.Point(85, 95);
			this.probabilityNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.probabilityNumericUpDown.Name = "probabilityNumericUpDown";
			this.probabilityNumericUpDown.Size = new System.Drawing.Size(120, 20);
			this.probabilityNumericUpDown.TabIndex = 18;
			this.probabilityNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(45, 26);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(33, 13);
			this.label7.TabIndex = 16;
			this.label7.Text = "From:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(55, 55);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(23, 13);
			this.label6.TabIndex = 17;
			this.label6.Text = "To:";
			// 
			// removeMovementButton
			// 
			this.removeMovementButton.Location = new System.Drawing.Point(586, 19);
			this.removeMovementButton.Name = "removeMovementButton";
			this.removeMovementButton.Size = new System.Drawing.Size(75, 25);
			this.removeMovementButton.TabIndex = 2;
			this.removeMovementButton.Text = "Remove";
			this.removeMovementButton.UseVisualStyleBackColor = true;
			this.removeMovementButton.Click += new System.EventHandler(this.removeMovementButton_Click);
			// 
			// movementsDataGridView
			// 
			this.movementsDataGridView.AllowUserToAddRows = false;
			this.movementsDataGridView.AllowUserToDeleteRows = false;
			this.movementsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.movementsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fromColumn,
            this.toColumn,
            this.probabilityColumn});
			this.movementsDataGridView.Location = new System.Drawing.Point(235, 19);
			this.movementsDataGridView.Name = "movementsDataGridView";
			this.movementsDataGridView.ReadOnly = true;
			this.movementsDataGridView.Size = new System.Drawing.Size(345, 329);
			this.movementsDataGridView.TabIndex = 0;
			// 
			// fromColumn
			// 
			this.fromColumn.Frozen = true;
			this.fromColumn.HeaderText = "From";
			this.fromColumn.Name = "fromColumn";
			this.fromColumn.ReadOnly = true;
			// 
			// toColumn
			// 
			this.toColumn.Frozen = true;
			this.toColumn.HeaderText = "To";
			this.toColumn.Name = "toColumn";
			this.toColumn.ReadOnly = true;
			// 
			// probabilityColumn
			// 
			this.probabilityColumn.Frozen = true;
			this.probabilityColumn.HeaderText = "Probability";
			this.probabilityColumn.Name = "probabilityColumn";
			this.probabilityColumn.ReadOnly = true;
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(631, 444);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(75, 23);
			this.addButton.TabIndex = 3;
			this.addButton.Text = "Save";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point(550, 444);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 4;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.movementsTabPage);
			this.tabControl.Controls.Add(this.statisticsTabPage);
			this.tabControl.Location = new System.Drawing.Point(12, 49);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(698, 393);
			this.tabControl.TabIndex = 5;
			// 
			// movementsTabPage
			// 
			this.movementsTabPage.Controls.Add(this.groupBox1);
			this.movementsTabPage.Location = new System.Drawing.Point(4, 22);
			this.movementsTabPage.Name = "movementsTabPage";
			this.movementsTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.movementsTabPage.Size = new System.Drawing.Size(682, 367);
			this.movementsTabPage.TabIndex = 0;
			this.movementsTabPage.Text = "Movements";
			this.movementsTabPage.UseVisualStyleBackColor = true;
			// 
			// statisticsTabPage
			// 
			this.statisticsTabPage.Controls.Add(this.statisticBeforePointInfoGroupBox);
			this.statisticsTabPage.Controls.Add(this.statisticTabControl);
			this.statisticsTabPage.Location = new System.Drawing.Point(4, 22);
			this.statisticsTabPage.Name = "statisticsTabPage";
			this.statisticsTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.statisticsTabPage.Size = new System.Drawing.Size(690, 367);
			this.statisticsTabPage.TabIndex = 1;
			this.statisticsTabPage.Text = "Statistics";
			this.statisticsTabPage.UseVisualStyleBackColor = true;
			// 
			// statisticTabControl
			// 
			this.statisticTabControl.Controls.Add(this.beforeTabPage);
			this.statisticTabControl.Controls.Add(this.afterTabPage);
			this.statisticTabControl.Controls.Add(this.betweenTabPage);
			this.statisticTabControl.Location = new System.Drawing.Point(6, 6);
			this.statisticTabControl.Name = "statisticTabControl";
			this.statisticTabControl.SelectedIndex = 0;
			this.statisticTabControl.Size = new System.Drawing.Size(371, 355);
			this.statisticTabControl.TabIndex = 2;
			// 
			// beforeTabPage
			// 
			this.beforeTabPage.Controls.Add(this.removeStatisticBeforeButton);
			this.beforeTabPage.Controls.Add(this.statisticBeforeDataGridView);
			this.beforeTabPage.Location = new System.Drawing.Point(4, 22);
			this.beforeTabPage.Name = "beforeTabPage";
			this.beforeTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.beforeTabPage.Size = new System.Drawing.Size(363, 329);
			this.beforeTabPage.TabIndex = 0;
			this.beforeTabPage.Text = "Before";
			this.beforeTabPage.UseVisualStyleBackColor = true;
			// 
			// removeStatisticBeforeButton
			// 
			this.removeStatisticBeforeButton.Location = new System.Drawing.Point(278, 300);
			this.removeStatisticBeforeButton.Name = "removeStatisticBeforeButton";
			this.removeStatisticBeforeButton.Size = new System.Drawing.Size(75, 23);
			this.removeStatisticBeforeButton.TabIndex = 4;
			this.removeStatisticBeforeButton.Text = "Remove";
			this.removeStatisticBeforeButton.UseVisualStyleBackColor = true;
			this.removeStatisticBeforeButton.Click += new System.EventHandler(this.removeStatisticBeforeButton_Click);
			// 
			// statisticBeforeDataGridView
			// 
			this.statisticBeforeDataGridView.AllowUserToAddRows = false;
			this.statisticBeforeDataGridView.AllowUserToDeleteRows = false;
			this.statisticBeforeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.statisticBeforeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.statisticPointIdColumn,
            this.statisticNameColumn,
            this.beforeColumn});
			this.statisticBeforeDataGridView.Location = new System.Drawing.Point(6, 6);
			this.statisticBeforeDataGridView.Name = "statisticBeforeDataGridView";
			this.statisticBeforeDataGridView.ReadOnly = true;
			this.statisticBeforeDataGridView.Size = new System.Drawing.Size(347, 288);
			this.statisticBeforeDataGridView.TabIndex = 3;
			// 
			// statisticPointIdColumn
			// 
			this.statisticPointIdColumn.Frozen = true;
			this.statisticPointIdColumn.HeaderText = "id";
			this.statisticPointIdColumn.Name = "statisticPointIdColumn";
			this.statisticPointIdColumn.ReadOnly = true;
			// 
			// statisticNameColumn
			// 
			this.statisticNameColumn.Frozen = true;
			this.statisticNameColumn.HeaderText = "Statistic Name";
			this.statisticNameColumn.Name = "statisticNameColumn";
			this.statisticNameColumn.ReadOnly = true;
			// 
			// beforeColumn
			// 
			this.beforeColumn.Frozen = true;
			this.beforeColumn.HeaderText = "Before";
			this.beforeColumn.Name = "beforeColumn";
			this.beforeColumn.ReadOnly = true;
			// 
			// statisticBeforePointInfoGroupBox
			// 
			this.statisticBeforePointInfoGroupBox.Controls.Add(this.putStatisticPointBetweenRadioButton);
			this.statisticBeforePointInfoGroupBox.Controls.Add(this.putStatisticPointAfterRadioButton);
			this.statisticBeforePointInfoGroupBox.Controls.Add(this.putSstatisticPointBeforeRadioButton);
			this.statisticBeforePointInfoGroupBox.Controls.Add(this.statisticNameComboBox);
			this.statisticBeforePointInfoGroupBox.Controls.Add(this.betweenComboBox);
			this.statisticBeforePointInfoGroupBox.Controls.Add(this.label4);
			this.statisticBeforePointInfoGroupBox.Controls.Add(this.afterComboBox);
			this.statisticBeforePointInfoGroupBox.Controls.Add(this.addStatisticButton);
			this.statisticBeforePointInfoGroupBox.Controls.Add(this.statisticIdTextBox);
			this.statisticBeforePointInfoGroupBox.Controls.Add(this.beforeComboBox);
			this.statisticBeforePointInfoGroupBox.Controls.Add(this.label3);
			this.statisticBeforePointInfoGroupBox.Location = new System.Drawing.Point(382, 28);
			this.statisticBeforePointInfoGroupBox.Name = "statisticBeforePointInfoGroupBox";
			this.statisticBeforePointInfoGroupBox.Size = new System.Drawing.Size(297, 231);
			this.statisticBeforePointInfoGroupBox.TabIndex = 2;
			this.statisticBeforePointInfoGroupBox.TabStop = false;
			this.statisticBeforePointInfoGroupBox.Text = "Statistic Point Info";
			// 
			// statisticNameComboBox
			// 
			this.statisticNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.statisticNameComboBox.FormattingEnabled = true;
			this.statisticNameComboBox.Location = new System.Drawing.Point(143, 60);
			this.statisticNameComboBox.Name = "statisticNameComboBox";
			this.statisticNameComboBox.Size = new System.Drawing.Size(148, 21);
			this.statisticNameComboBox.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(59, 63);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Statistic Name:";
			// 
			// addStatisticButton
			// 
			this.addStatisticButton.Location = new System.Drawing.Point(216, 202);
			this.addStatisticButton.Name = "addStatisticButton";
			this.addStatisticButton.Size = new System.Drawing.Size(75, 23);
			this.addStatisticButton.TabIndex = 4;
			this.addStatisticButton.Text = "Add";
			this.addStatisticButton.UseVisualStyleBackColor = true;
			this.addStatisticButton.Click += new System.EventHandler(this.addStatisticButton_Click);
			// 
			// statisticIdTextBox
			// 
			this.statisticIdTextBox.Location = new System.Drawing.Point(143, 34);
			this.statisticIdTextBox.Name = "statisticIdTextBox";
			this.statisticIdTextBox.Size = new System.Drawing.Size(148, 20);
			this.statisticIdTextBox.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(52, 37);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Statistic point Id:";
			// 
			// beforeComboBox
			// 
			this.beforeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.beforeComboBox.Enabled = false;
			this.beforeComboBox.FormattingEnabled = true;
			this.beforeComboBox.Location = new System.Drawing.Point(169, 102);
			this.beforeComboBox.Name = "beforeComboBox";
			this.beforeComboBox.Size = new System.Drawing.Size(122, 21);
			this.beforeComboBox.TabIndex = 0;
			// 
			// afterTabPage
			// 
			this.afterTabPage.Controls.Add(this.removeStatisticAfterButton);
			this.afterTabPage.Controls.Add(this.statisticAfterDataGridView);
			this.afterTabPage.Location = new System.Drawing.Point(4, 22);
			this.afterTabPage.Name = "afterTabPage";
			this.afterTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.afterTabPage.Size = new System.Drawing.Size(363, 329);
			this.afterTabPage.TabIndex = 1;
			this.afterTabPage.Text = "After";
			this.afterTabPage.UseVisualStyleBackColor = true;
			// 
			// removeStatisticAfterButton
			// 
			this.removeStatisticAfterButton.Location = new System.Drawing.Point(278, 300);
			this.removeStatisticAfterButton.Name = "removeStatisticAfterButton";
			this.removeStatisticAfterButton.Size = new System.Drawing.Size(75, 23);
			this.removeStatisticAfterButton.TabIndex = 7;
			this.removeStatisticAfterButton.Text = "Remove";
			this.removeStatisticAfterButton.UseVisualStyleBackColor = true;
			this.removeStatisticAfterButton.Click += new System.EventHandler(this.removeStatisticAfterButton_Click);
			// 
			// statisticAfterDataGridView
			// 
			this.statisticAfterDataGridView.AllowUserToAddRows = false;
			this.statisticAfterDataGridView.AllowUserToDeleteRows = false;
			this.statisticAfterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.statisticAfterDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
			this.statisticAfterDataGridView.Location = new System.Drawing.Point(6, 6);
			this.statisticAfterDataGridView.Name = "statisticAfterDataGridView";
			this.statisticAfterDataGridView.ReadOnly = true;
			this.statisticAfterDataGridView.Size = new System.Drawing.Size(347, 288);
			this.statisticAfterDataGridView.TabIndex = 6;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.Frozen = true;
			this.dataGridViewTextBoxColumn1.HeaderText = "id";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.Frozen = true;
			this.dataGridViewTextBoxColumn2.HeaderText = "Statistic Name";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.Frozen = true;
			this.dataGridViewTextBoxColumn3.HeaderText = "After";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// afterComboBox
			// 
			this.afterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.afterComboBox.Enabled = false;
			this.afterComboBox.FormattingEnabled = true;
			this.afterComboBox.Location = new System.Drawing.Point(169, 129);
			this.afterComboBox.Name = "afterComboBox";
			this.afterComboBox.Size = new System.Drawing.Size(122, 21);
			this.afterComboBox.TabIndex = 0;
			// 
			// betweenTabPage
			// 
			this.betweenTabPage.Controls.Add(this.removeStatisticBetweenButton);
			this.betweenTabPage.Controls.Add(this.statisticBetweenDataGridView);
			this.betweenTabPage.Location = new System.Drawing.Point(4, 22);
			this.betweenTabPage.Name = "betweenTabPage";
			this.betweenTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.betweenTabPage.Size = new System.Drawing.Size(363, 329);
			this.betweenTabPage.TabIndex = 2;
			this.betweenTabPage.Text = "Between";
			this.betweenTabPage.UseVisualStyleBackColor = true;
			// 
			// removeStatisticBetweenButton
			// 
			this.removeStatisticBetweenButton.Location = new System.Drawing.Point(278, 300);
			this.removeStatisticBetweenButton.Name = "removeStatisticBetweenButton";
			this.removeStatisticBetweenButton.Size = new System.Drawing.Size(75, 23);
			this.removeStatisticBetweenButton.TabIndex = 7;
			this.removeStatisticBetweenButton.Text = "Remove";
			this.removeStatisticBetweenButton.UseVisualStyleBackColor = true;
			this.removeStatisticBetweenButton.Click += new System.EventHandler(this.removeStatisticBetweenButton_Click);
			// 
			// statisticBetweenDataGridView
			// 
			this.statisticBetweenDataGridView.AllowUserToAddRows = false;
			this.statisticBetweenDataGridView.AllowUserToDeleteRows = false;
			this.statisticBetweenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.statisticBetweenDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
			this.statisticBetweenDataGridView.Location = new System.Drawing.Point(6, 6);
			this.statisticBetweenDataGridView.Name = "statisticBetweenDataGridView";
			this.statisticBetweenDataGridView.ReadOnly = true;
			this.statisticBetweenDataGridView.Size = new System.Drawing.Size(347, 288);
			this.statisticBetweenDataGridView.TabIndex = 6;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.Frozen = true;
			this.dataGridViewTextBoxColumn4.HeaderText = "id";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.Frozen = true;
			this.dataGridViewTextBoxColumn5.HeaderText = "Statistic Name";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.Frozen = true;
			this.dataGridViewTextBoxColumn6.HeaderText = "Between";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			// 
			// betweenComboBox
			// 
			this.betweenComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.betweenComboBox.Enabled = false;
			this.betweenComboBox.FormattingEnabled = true;
			this.betweenComboBox.Location = new System.Drawing.Point(169, 156);
			this.betweenComboBox.Name = "betweenComboBox";
			this.betweenComboBox.Size = new System.Drawing.Size(122, 21);
			this.betweenComboBox.TabIndex = 0;
			// 
			// streamIdTextBox
			// 
			this.streamIdTextBox.Location = new System.Drawing.Point(77, 16);
			this.streamIdTextBox.Name = "streamIdTextBox";
			this.streamIdTextBox.Size = new System.Drawing.Size(100, 20);
			this.streamIdTextBox.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Stream Id:";
			// 
			// putSstatisticPointBeforeRadioButton
			// 
			this.putSstatisticPointBeforeRadioButton.AutoSize = true;
			this.putSstatisticPointBeforeRadioButton.Location = new System.Drawing.Point(11, 103);
			this.putSstatisticPointBeforeRadioButton.Name = "putSstatisticPointBeforeRadioButton";
			this.putSstatisticPointBeforeRadioButton.Size = new System.Drawing.Size(141, 17);
			this.putSstatisticPointBeforeRadioButton.TabIndex = 7;
			this.putSstatisticPointBeforeRadioButton.Text = "Put statistic point before:";
			this.putSstatisticPointBeforeRadioButton.UseVisualStyleBackColor = true;
			this.putSstatisticPointBeforeRadioButton.CheckedChanged += new System.EventHandler(this.putSstatisticPointBeforeRadioButton_CheckedChanged);
			// 
			// putStatisticPointAfterRadioButton
			// 
			this.putStatisticPointAfterRadioButton.AutoSize = true;
			this.putStatisticPointAfterRadioButton.Location = new System.Drawing.Point(11, 130);
			this.putStatisticPointAfterRadioButton.Name = "putStatisticPointAfterRadioButton";
			this.putStatisticPointAfterRadioButton.Size = new System.Drawing.Size(132, 17);
			this.putStatisticPointAfterRadioButton.TabIndex = 8;
			this.putStatisticPointAfterRadioButton.Text = "Put statistic point after:";
			this.putStatisticPointAfterRadioButton.UseVisualStyleBackColor = true;
			this.putStatisticPointAfterRadioButton.CheckedChanged += new System.EventHandler(this.putStatisticPointAfterRadioButton_CheckedChanged);
			// 
			// putStatisticPointBetweenRadioButton
			// 
			this.putStatisticPointBetweenRadioButton.AutoSize = true;
			this.putStatisticPointBetweenRadioButton.Location = new System.Drawing.Point(11, 157);
			this.putStatisticPointBetweenRadioButton.Name = "putStatisticPointBetweenRadioButton";
			this.putStatisticPointBetweenRadioButton.Size = new System.Drawing.Size(152, 17);
			this.putStatisticPointBetweenRadioButton.TabIndex = 9;
			this.putStatisticPointBetweenRadioButton.Text = "Put statistic point between:";
			this.putStatisticPointBetweenRadioButton.UseVisualStyleBackColor = true;
			this.putStatisticPointBetweenRadioButton.CheckedChanged += new System.EventHandler(this.putStatisticPointBetweenRadioButton_CheckedChanged);
			// 
			// StreamForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(722, 483);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.streamIdTextBox);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.addButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "StreamForm";
			this.Text = "Stream Form";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.probabilityNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.movementsDataGridView)).EndInit();
			this.tabControl.ResumeLayout(false);
			this.movementsTabPage.ResumeLayout(false);
			this.statisticsTabPage.ResumeLayout(false);
			this.statisticTabControl.ResumeLayout(false);
			this.beforeTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.statisticBeforeDataGridView)).EndInit();
			this.statisticBeforePointInfoGroupBox.ResumeLayout(false);
			this.statisticBeforePointInfoGroupBox.PerformLayout();
			this.afterTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.statisticAfterDataGridView)).EndInit();
			this.betweenTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.statisticBetweenDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button removeMovementButton;
		private System.Windows.Forms.Button addMovementButton;
		private System.Windows.Forms.DataGridView movementsDataGridView;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage movementsTabPage;
		private System.Windows.Forms.TabPage statisticsTabPage;
		private System.Windows.Forms.TextBox streamIdTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabControl statisticTabControl;
		private System.Windows.Forms.TabPage beforeTabPage;
		private System.Windows.Forms.TabPage afterTabPage;
		private System.Windows.Forms.DataGridViewTextBoxColumn fromColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn toColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn probabilityColumn;
		private System.Windows.Forms.TabPage betweenTabPage;
		private System.Windows.Forms.GroupBox statisticBeforePointInfoGroupBox;
		private System.Windows.Forms.TextBox statisticIdTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button removeStatisticBeforeButton;
		private System.Windows.Forms.DataGridView statisticBeforeDataGridView;
		private System.Windows.Forms.ComboBox statisticNameComboBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox fromComboBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox toComboBox;
		private System.Windows.Forms.NumericUpDown probabilityNumericUpDown;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGridViewTextBoxColumn statisticPointIdColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn statisticNameColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn beforeColumn;
		private System.Windows.Forms.Button addStatisticButton;
		private System.Windows.Forms.ComboBox beforeComboBox;
		private System.Windows.Forms.Button removeStatisticAfterButton;
		private System.Windows.Forms.DataGridView statisticAfterDataGridView;
		private System.Windows.Forms.ComboBox afterComboBox;
		private System.Windows.Forms.Button removeStatisticBetweenButton;
		private System.Windows.Forms.DataGridView statisticBetweenDataGridView;
		private System.Windows.Forms.ComboBox betweenComboBox;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.RadioButton putStatisticPointBetweenRadioButton;
		private System.Windows.Forms.RadioButton putStatisticPointAfterRadioButton;
		private System.Windows.Forms.RadioButton putSstatisticPointBeforeRadioButton;
	}
}