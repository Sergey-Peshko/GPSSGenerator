namespace WinFromInterface
{
	partial class StatisticForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.comboBoxTypeOfStatistic = new System.Windows.Forms.ComboBox();
			this.parametersGroupBox = new System.Windows.Forms.GroupBox();
			this.tableParamTabPage = new System.Windows.Forms.TabPage();
			this.tableParamGroupBox = new System.Windows.Forms.GroupBox();
			this.tableParamDataGridView = new System.Windows.Forms.DataGridView();
			this.upperBoundOfLowerFrequencyIntervalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.intervalWidthColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.numberOfIntervalsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.addButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.tableParamTabPage.SuspendLayout();
			this.tableParamGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tableParamDataGridView)).BeginInit();
			this.tabControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name of Statistic:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Type of Statistic:";
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(109, 13);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(157, 20);
			this.nameTextBox.TabIndex = 2;
			// 
			// comboBoxTypeOfStatistic
			// 
			this.comboBoxTypeOfStatistic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxTypeOfStatistic.FormattingEnabled = true;
			this.comboBoxTypeOfStatistic.Location = new System.Drawing.Point(109, 44);
			this.comboBoxTypeOfStatistic.Name = "comboBoxTypeOfStatistic";
			this.comboBoxTypeOfStatistic.Size = new System.Drawing.Size(157, 21);
			this.comboBoxTypeOfStatistic.TabIndex = 3;
			this.comboBoxTypeOfStatistic.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeOfStatistic_SelectedIndexChanged);
			// 
			// parametersGroupBox
			// 
			this.parametersGroupBox.Location = new System.Drawing.Point(12, 71);
			this.parametersGroupBox.Name = "parametersGroupBox";
			this.parametersGroupBox.Size = new System.Drawing.Size(510, 197);
			this.parametersGroupBox.TabIndex = 5;
			this.parametersGroupBox.TabStop = false;
			this.parametersGroupBox.Text = "Parameters according to statistic type";
			// 
			// tableParamTabPage
			// 
			this.tableParamTabPage.Controls.Add(this.tableParamGroupBox);
			this.tableParamTabPage.Location = new System.Drawing.Point(4, 22);
			this.tableParamTabPage.Name = "tableParamTabPage";
			this.tableParamTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.tableParamTabPage.Size = new System.Drawing.Size(489, 146);
			this.tableParamTabPage.TabIndex = 0;
			this.tableParamTabPage.Text = "Table Parameters";
			this.tableParamTabPage.UseVisualStyleBackColor = true;
			// 
			// tableParamGroupBox
			// 
			this.tableParamGroupBox.Controls.Add(this.tableParamDataGridView);
			this.tableParamGroupBox.Location = new System.Drawing.Point(6, 6);
			this.tableParamGroupBox.Name = "tableParamGroupBox";
			this.tableParamGroupBox.Size = new System.Drawing.Size(477, 134);
			this.tableParamGroupBox.TabIndex = 0;
			this.tableParamGroupBox.TabStop = false;
			this.tableParamGroupBox.Text = "Table parameters";
			// 
			// tableParamDataGridView
			// 
			this.tableParamDataGridView.AllowUserToAddRows = false;
			this.tableParamDataGridView.AllowUserToDeleteRows = false;
			this.tableParamDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tableParamDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.upperBoundOfLowerFrequencyIntervalColumn,
            this.intervalWidthColumn,
            this.numberOfIntervalsColumn});
			this.tableParamDataGridView.Location = new System.Drawing.Point(6, 19);
			this.tableParamDataGridView.Name = "tableParamDataGridView";
			this.tableParamDataGridView.Size = new System.Drawing.Size(471, 109);
			this.tableParamDataGridView.TabIndex = 0;
			// 
			// upperBoundOfLowerFrequencyIntervalColumn
			// 
			this.upperBoundOfLowerFrequencyIntervalColumn.FillWeight = 200F;
			this.upperBoundOfLowerFrequencyIntervalColumn.Frozen = true;
			this.upperBoundOfLowerFrequencyIntervalColumn.HeaderText = "Upper Bound Of Lower Frequency Interval";
			this.upperBoundOfLowerFrequencyIntervalColumn.Name = "upperBoundOfLowerFrequencyIntervalColumn";
			this.upperBoundOfLowerFrequencyIntervalColumn.ReadOnly = true;
			this.upperBoundOfLowerFrequencyIntervalColumn.Width = 200;
			// 
			// intervalWidthColumn
			// 
			this.intervalWidthColumn.Frozen = true;
			this.intervalWidthColumn.HeaderText = "Interval Width";
			this.intervalWidthColumn.Name = "intervalWidthColumn";
			this.intervalWidthColumn.ReadOnly = true;
			// 
			// numberOfIntervalsColumn
			// 
			this.numberOfIntervalsColumn.Frozen = true;
			this.numberOfIntervalsColumn.HeaderText = "Number Of Intervals";
			this.numberOfIntervalsColumn.Name = "numberOfIntervalsColumn";
			this.numberOfIntervalsColumn.ReadOnly = true;
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tableParamTabPage);
			this.tabControl.Location = new System.Drawing.Point(19, 90);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(497, 172);
			this.tabControl.TabIndex = 4;
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(446, 274);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(75, 23);
			this.addButton.TabIndex = 6;
			this.addButton.Text = "Save";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point(365, 274);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 7;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// StatisticForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(534, 309);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.comboBoxTypeOfStatistic);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.parametersGroupBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "StatisticForm";
			this.Text = "Statistic Form";
			this.tableParamTabPage.ResumeLayout(false);
			this.tableParamGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.tableParamDataGridView)).EndInit();
			this.tabControl.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.ComboBox comboBoxTypeOfStatistic;
		private System.Windows.Forms.GroupBox parametersGroupBox;
		private System.Windows.Forms.TabPage tableParamTabPage;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.GroupBox tableParamGroupBox;
		private System.Windows.Forms.DataGridView tableParamDataGridView;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn upperBoundOfLowerFrequencyIntervalColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn intervalWidthColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn numberOfIntervalsColumn;
	}
}