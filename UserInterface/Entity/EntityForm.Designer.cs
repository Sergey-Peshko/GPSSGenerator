namespace WinFromInterface
{
	partial class EntityForm
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
			this.saveButton = new System.Windows.Forms.Button();
			this.cancel = new System.Windows.Forms.Button();
			this.comboBoxTypeOfEntity = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.numberOfTransactionsToBeDeletedTabPage = new System.Windows.Forms.TabPage();
			this.numberOfTransactionsToBeDeletedNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.numberOfTransactionsTabPage = new System.Windows.Forms.TabPage();
			this.numberOfTransactionsNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.capasityTabPage = new System.Windows.Forms.TabPage();
			this.capacityNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.distributionTabPage = new System.Windows.Forms.TabPage();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBoxTypeOfDistribution = new System.Windows.Forms.ComboBox();
			this.distributionGroupBox = new System.Windows.Forms.GroupBox();
			this.distributionParam = new System.Windows.Forms.DataGridView();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.numberOfTransactionsToBeDeletedTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numberOfTransactionsToBeDeletedNumericUpDown)).BeginInit();
			this.numberOfTransactionsTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numberOfTransactionsNumericUpDown)).BeginInit();
			this.capasityTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.capacityNumericUpDown)).BeginInit();
			this.distributionTabPage.SuspendLayout();
			this.distributionGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.distributionParam)).BeginInit();
			this.tabControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(493, 311);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 23);
			this.saveButton.TabIndex = 3;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// cancel
			// 
			this.cancel.Location = new System.Drawing.Point(406, 311);
			this.cancel.Name = "cancel";
			this.cancel.Size = new System.Drawing.Size(75, 23);
			this.cancel.TabIndex = 4;
			this.cancel.Text = "Cancel";
			this.cancel.UseVisualStyleBackColor = true;
			this.cancel.Click += new System.EventHandler(this.cancel_Click);
			// 
			// comboBoxTypeOfEntity
			// 
			this.comboBoxTypeOfEntity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxTypeOfEntity.FormattingEnabled = true;
			this.comboBoxTypeOfEntity.Location = new System.Drawing.Point(96, 47);
			this.comboBoxTypeOfEntity.Name = "comboBoxTypeOfEntity";
			this.comboBoxTypeOfEntity.Size = new System.Drawing.Size(225, 21);
			this.comboBoxTypeOfEntity.TabIndex = 8;
			this.comboBoxTypeOfEntity.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeOfNode_SelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(15, 50);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(74, 13);
			this.label6.TabIndex = 7;
			this.label6.Text = "Type of entity:";
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(96, 21);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(225, 20);
			this.nameTextBox.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(15, 24);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(78, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Name of entity:";
			// 
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(18, 74);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(550, 231);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Parameters according to entity type";
			// 
			// numberOfTransactionsToBeDeletedTabPage
			// 
			this.numberOfTransactionsToBeDeletedTabPage.Controls.Add(this.label4);
			this.numberOfTransactionsToBeDeletedTabPage.Controls.Add(this.numberOfTransactionsToBeDeletedNumericUpDown);
			this.numberOfTransactionsToBeDeletedTabPage.Location = new System.Drawing.Point(4, 22);
			this.numberOfTransactionsToBeDeletedTabPage.Name = "numberOfTransactionsToBeDeletedTabPage";
			this.numberOfTransactionsToBeDeletedTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.numberOfTransactionsToBeDeletedTabPage.Size = new System.Drawing.Size(520, 166);
			this.numberOfTransactionsToBeDeletedTabPage.TabIndex = 4;
			this.numberOfTransactionsToBeDeletedTabPage.Text = "Number Of Transactions To Be Deleted";
			this.numberOfTransactionsToBeDeletedTabPage.UseVisualStyleBackColor = true;
			// 
			// numberOfTransactionsToBeDeletedNumericUpDown
			// 
			this.numberOfTransactionsToBeDeletedNumericUpDown.Location = new System.Drawing.Point(299, 17);
			this.numberOfTransactionsToBeDeletedNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numberOfTransactionsToBeDeletedNumericUpDown.Name = "numberOfTransactionsToBeDeletedNumericUpDown";
			this.numberOfTransactionsToBeDeletedNumericUpDown.Size = new System.Drawing.Size(120, 20);
			this.numberOfTransactionsToBeDeletedNumericUpDown.TabIndex = 2;
			this.numberOfTransactionsToBeDeletedNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 19);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(287, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Number Of Transactions To Be Deleted after resiver block: ";
			// 
			// numberOfTransactionsTabPage
			// 
			this.numberOfTransactionsTabPage.Controls.Add(this.label3);
			this.numberOfTransactionsTabPage.Controls.Add(this.numberOfTransactionsNumericUpDown);
			this.numberOfTransactionsTabPage.Location = new System.Drawing.Point(4, 22);
			this.numberOfTransactionsTabPage.Name = "numberOfTransactionsTabPage";
			this.numberOfTransactionsTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.numberOfTransactionsTabPage.Size = new System.Drawing.Size(520, 166);
			this.numberOfTransactionsTabPage.TabIndex = 3;
			this.numberOfTransactionsTabPage.Text = "Number Of Transactions";
			this.numberOfTransactionsTabPage.UseVisualStyleBackColor = true;
			// 
			// numberOfTransactionsNumericUpDown
			// 
			this.numberOfTransactionsNumericUpDown.Location = new System.Drawing.Point(292, 16);
			this.numberOfTransactionsNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numberOfTransactionsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numberOfTransactionsNumericUpDown.Name = "numberOfTransactionsNumericUpDown";
			this.numberOfTransactionsNumericUpDown.Size = new System.Drawing.Size(120, 20);
			this.numberOfTransactionsNumericUpDown.TabIndex = 2;
			this.numberOfTransactionsNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(5, 18);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(281, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Number Of Transactions will be generated at one moment:";
			// 
			// capasityTabPage
			// 
			this.capasityTabPage.Controls.Add(this.label1);
			this.capasityTabPage.Controls.Add(this.capacityNumericUpDown);
			this.capasityTabPage.Location = new System.Drawing.Point(4, 22);
			this.capasityTabPage.Name = "capasityTabPage";
			this.capasityTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.capasityTabPage.Size = new System.Drawing.Size(520, 166);
			this.capasityTabPage.TabIndex = 2;
			this.capasityTabPage.Text = "Capacity";
			this.capasityTabPage.UseVisualStyleBackColor = true;
			// 
			// capacityNumericUpDown
			// 
			this.capacityNumericUpDown.Location = new System.Drawing.Point(106, 12);
			this.capacityNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.capacityNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.capacityNumericUpDown.Name = "capacityNumericUpDown";
			this.capacityNumericUpDown.Size = new System.Drawing.Size(120, 20);
			this.capacityNumericUpDown.TabIndex = 0;
			this.capacityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Capasity of facility:";
			// 
			// distributionTabPage
			// 
			this.distributionTabPage.Controls.Add(this.distributionGroupBox);
			this.distributionTabPage.Controls.Add(this.comboBoxTypeOfDistribution);
			this.distributionTabPage.Controls.Add(this.label2);
			this.distributionTabPage.Location = new System.Drawing.Point(4, 22);
			this.distributionTabPage.Name = "distributionTabPage";
			this.distributionTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.distributionTabPage.Size = new System.Drawing.Size(520, 166);
			this.distributionTabPage.TabIndex = 1;
			this.distributionTabPage.Text = "Distribution";
			this.distributionTabPage.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Type of distribution: ";
			// 
			// comboBoxTypeOfDistribution
			// 
			this.comboBoxTypeOfDistribution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxTypeOfDistribution.FormattingEnabled = true;
			this.comboBoxTypeOfDistribution.Location = new System.Drawing.Point(128, 6);
			this.comboBoxTypeOfDistribution.Name = "comboBoxTypeOfDistribution";
			this.comboBoxTypeOfDistribution.Size = new System.Drawing.Size(121, 21);
			this.comboBoxTypeOfDistribution.TabIndex = 7;
			this.comboBoxTypeOfDistribution.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeOfDistribution_SelectedIndexChanged);
			// 
			// distributionGroupBox
			// 
			this.distributionGroupBox.Controls.Add(this.distributionParam);
			this.distributionGroupBox.Location = new System.Drawing.Point(11, 33);
			this.distributionGroupBox.Name = "distributionGroupBox";
			this.distributionGroupBox.Size = new System.Drawing.Size(472, 124);
			this.distributionGroupBox.TabIndex = 2;
			this.distributionGroupBox.TabStop = false;
			this.distributionGroupBox.Text = "Parameters of distribution";
			// 
			// distributionParam
			// 
			this.distributionParam.AllowUserToAddRows = false;
			this.distributionParam.AllowUserToDeleteRows = false;
			this.distributionParam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.distributionParam.Location = new System.Drawing.Point(6, 19);
			this.distributionParam.Name = "distributionParam";
			this.distributionParam.Size = new System.Drawing.Size(460, 99);
			this.distributionParam.TabIndex = 9;
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.distributionTabPage);
			this.tabControl.Controls.Add(this.capasityTabPage);
			this.tabControl.Controls.Add(this.numberOfTransactionsTabPage);
			this.tabControl.Controls.Add(this.numberOfTransactionsToBeDeletedTabPage);
			this.tabControl.Location = new System.Drawing.Point(30, 102);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(528, 192);
			this.tabControl.TabIndex = 9;
			// 
			// EntityForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(581, 346);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.comboBoxTypeOfEntity);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cancel);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "EntityForm";
			this.Text = "Entity From";
			this.numberOfTransactionsToBeDeletedTabPage.ResumeLayout(false);
			this.numberOfTransactionsToBeDeletedTabPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numberOfTransactionsToBeDeletedNumericUpDown)).EndInit();
			this.numberOfTransactionsTabPage.ResumeLayout(false);
			this.numberOfTransactionsTabPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numberOfTransactionsNumericUpDown)).EndInit();
			this.capasityTabPage.ResumeLayout(false);
			this.capasityTabPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.capacityNumericUpDown)).EndInit();
			this.distributionTabPage.ResumeLayout(false);
			this.distributionTabPage.PerformLayout();
			this.distributionGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.distributionParam)).EndInit();
			this.tabControl.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Button cancel;
		private System.Windows.Forms.ComboBox comboBoxTypeOfEntity;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TabPage numberOfTransactionsToBeDeletedTabPage;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown numberOfTransactionsToBeDeletedNumericUpDown;
		private System.Windows.Forms.TabPage numberOfTransactionsTabPage;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numberOfTransactionsNumericUpDown;
		private System.Windows.Forms.TabPage capasityTabPage;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown capacityNumericUpDown;
		private System.Windows.Forms.TabPage distributionTabPage;
		private System.Windows.Forms.GroupBox distributionGroupBox;
		private System.Windows.Forms.DataGridView distributionParam;
		private System.Windows.Forms.ComboBox comboBoxTypeOfDistribution;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TabControl tabControl;
	}
}