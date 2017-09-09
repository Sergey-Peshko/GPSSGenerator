namespace WinFromInterface
{
	partial class AddEntity
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
			this.distributionGroupBox = new System.Windows.Forms.GroupBox();
			this.distributionParam = new System.Windows.Forms.DataGridView();
			this.comboBoxTypeOfDistribution = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.add = new System.Windows.Forms.Button();
			this.cancel = new System.Windows.Forms.Button();
			this.entityParam = new System.Windows.Forms.DataGridView();
			this.nodeParamGroupBox = new System.Windows.Forms.GroupBox();
			this.comboBoxTypeOfEntity = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.valuesTabPage = new System.Windows.Forms.TabPage();
			this.distributionTabPage = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.distributionGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.distributionParam)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.entityParam)).BeginInit();
			this.nodeParamGroupBox.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.valuesTabPage.SuspendLayout();
			this.distributionTabPage.SuspendLayout();
			this.SuspendLayout();
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
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Type of distribution: ";
			// 
			// add
			// 
			this.add.Location = new System.Drawing.Point(493, 311);
			this.add.Name = "add";
			this.add.Size = new System.Drawing.Size(75, 23);
			this.add.TabIndex = 3;
			this.add.Text = "Add";
			this.add.UseVisualStyleBackColor = true;
			this.add.Click += new System.EventHandler(this.add_Click);
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
			// entityParam
			// 
			this.entityParam.AllowUserToAddRows = false;
			this.entityParam.AllowUserToDeleteRows = false;
			this.entityParam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.entityParam.Location = new System.Drawing.Point(6, 19);
			this.entityParam.Name = "entityParam";
			this.entityParam.Size = new System.Drawing.Size(496, 90);
			this.entityParam.TabIndex = 5;
			// 
			// nodeParamGroupBox
			// 
			this.nodeParamGroupBox.Controls.Add(this.entityParam);
			this.nodeParamGroupBox.Location = new System.Drawing.Point(6, 6);
			this.nodeParamGroupBox.Name = "nodeParamGroupBox";
			this.nodeParamGroupBox.Size = new System.Drawing.Size(508, 123);
			this.nodeParamGroupBox.TabIndex = 1;
			this.nodeParamGroupBox.TabStop = false;
			this.nodeParamGroupBox.Text = "Value Parameters for current entity";
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
			// tabControl
			// 
			this.tabControl.Controls.Add(this.valuesTabPage);
			this.tabControl.Controls.Add(this.distributionTabPage);
			this.tabControl.Location = new System.Drawing.Point(30, 102);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(528, 192);
			this.tabControl.TabIndex = 9;
			// 
			// valuesTabPage
			// 
			this.valuesTabPage.Controls.Add(this.nodeParamGroupBox);
			this.valuesTabPage.Location = new System.Drawing.Point(4, 22);
			this.valuesTabPage.Name = "valuesTabPage";
			this.valuesTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.valuesTabPage.Size = new System.Drawing.Size(520, 166);
			this.valuesTabPage.TabIndex = 0;
			this.valuesTabPage.Text = "Values";
			this.valuesTabPage.UseVisualStyleBackColor = true;
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
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(18, 74);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(550, 231);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Parameters according to entity type";
			// 
			// AddEntity
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
			this.Controls.Add(this.add);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "AddEntity";
			this.Text = "Add entity";
			this.Load += new System.EventHandler(this.AddNode_Load);
			this.distributionGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.distributionParam)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.entityParam)).EndInit();
			this.nodeParamGroupBox.ResumeLayout(false);
			this.tabControl.ResumeLayout(false);
			this.valuesTabPage.ResumeLayout(false);
			this.distributionTabPage.ResumeLayout(false);
			this.distributionTabPage.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.GroupBox distributionGroupBox;
		private System.Windows.Forms.DataGridView distributionParam;
		private System.Windows.Forms.ComboBox comboBoxTypeOfDistribution;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button add;
		private System.Windows.Forms.Button cancel;
		private System.Windows.Forms.DataGridView entityParam;
		private System.Windows.Forms.GroupBox nodeParamGroupBox;
		private System.Windows.Forms.ComboBox comboBoxTypeOfEntity;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage valuesTabPage;
		private System.Windows.Forms.TabPage distributionTabPage;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}