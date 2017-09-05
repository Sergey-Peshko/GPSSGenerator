namespace UserInterface
{
	partial class AddNode
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
			this.label1 = new System.Windows.Forms.Label();
			this.comboBoxTypeOfDistribution = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.add = new System.Windows.Forms.Button();
			this.cancel = new System.Windows.Forms.Button();
			this.nodeParam = new System.Windows.Forms.DataGridView();
			this.nodeParamGroupBox = new System.Windows.Forms.GroupBox();
			this.comboBoxTypeOfNode = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.distributionGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.distributionParam)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nodeParam)).BeginInit();
			this.nodeParamGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// distributionGroupBox
			// 
			this.distributionGroupBox.Controls.Add(this.distributionParam);
			this.distributionGroupBox.Controls.Add(this.label1);
			this.distributionGroupBox.Controls.Add(this.comboBoxTypeOfDistribution);
			this.distributionGroupBox.Controls.Add(this.label2);
			this.distributionGroupBox.Location = new System.Drawing.Point(12, 193);
			this.distributionGroupBox.Name = "distributionGroupBox";
			this.distributionGroupBox.Size = new System.Drawing.Size(607, 151);
			this.distributionGroupBox.TabIndex = 2;
			this.distributionGroupBox.TabStop = false;
			this.distributionGroupBox.Text = "Распределение";
			this.distributionGroupBox.Visible = false;
			// 
			// distributionParam
			// 
			this.distributionParam.AllowUserToAddRows = false;
			this.distributionParam.AllowUserToDeleteRows = false;
			this.distributionParam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.distributionParam.Location = new System.Drawing.Point(9, 64);
			this.distributionParam.Name = "distributionParam";
			this.distributionParam.Size = new System.Drawing.Size(592, 75);
			this.distributionParam.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(157, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Параметры Распределения:  ";
			// 
			// comboBoxTypeOfDistribution
			// 
			this.comboBoxTypeOfDistribution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxTypeOfDistribution.FormattingEnabled = true;
			this.comboBoxTypeOfDistribution.Location = new System.Drawing.Point(126, 13);
			this.comboBoxTypeOfDistribution.Name = "comboBoxTypeOfDistribution";
			this.comboBoxTypeOfDistribution.Size = new System.Drawing.Size(121, 21);
			this.comboBoxTypeOfDistribution.TabIndex = 7;
			this.comboBoxTypeOfDistribution.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeOfDistribution_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Тип Распределения: ";
			// 
			// add
			// 
			this.add.Location = new System.Drawing.Point(544, 351);
			this.add.Name = "add";
			this.add.Size = new System.Drawing.Size(75, 23);
			this.add.TabIndex = 3;
			this.add.Text = "Добавить";
			this.add.UseVisualStyleBackColor = true;
			this.add.Click += new System.EventHandler(this.add_Click);
			// 
			// cancel
			// 
			this.cancel.Location = new System.Drawing.Point(463, 351);
			this.cancel.Name = "cancel";
			this.cancel.Size = new System.Drawing.Size(75, 23);
			this.cancel.TabIndex = 4;
			this.cancel.Text = "Отмена";
			this.cancel.UseVisualStyleBackColor = true;
			this.cancel.Click += new System.EventHandler(this.cancel_Click);
			// 
			// nodeParam
			// 
			this.nodeParam.AllowUserToAddRows = false;
			this.nodeParam.AllowUserToDeleteRows = false;
			this.nodeParam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.nodeParam.Location = new System.Drawing.Point(6, 19);
			this.nodeParam.Name = "nodeParam";
			this.nodeParam.Size = new System.Drawing.Size(591, 75);
			this.nodeParam.TabIndex = 5;
			// 
			// nodeParamGroupBox
			// 
			this.nodeParamGroupBox.Controls.Add(this.nodeParam);
			this.nodeParamGroupBox.Location = new System.Drawing.Point(12, 82);
			this.nodeParamGroupBox.Name = "nodeParamGroupBox";
			this.nodeParamGroupBox.Size = new System.Drawing.Size(607, 105);
			this.nodeParamGroupBox.TabIndex = 1;
			this.nodeParamGroupBox.TabStop = false;
			this.nodeParamGroupBox.Text = "Parameters of node";
			// 
			// comboBoxTypeOfNode
			// 
			this.comboBoxTypeOfNode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxTypeOfNode.FormattingEnabled = true;
			this.comboBoxTypeOfNode.Location = new System.Drawing.Point(79, 47);
			this.comboBoxTypeOfNode.Name = "comboBoxTypeOfNode";
			this.comboBoxTypeOfNode.Size = new System.Drawing.Size(225, 21);
			this.comboBoxTypeOfNode.TabIndex = 8;
			this.comboBoxTypeOfNode.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeOfNode_SelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(15, 50);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 13);
			this.label6.TabIndex = 7;
			this.label6.Text = "Тип узла: ";
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(79, 21);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(225, 20);
			this.nameTextBox.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(15, 24);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Имя узла: ";
			// 
			// AddNode
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(631, 386);
			this.Controls.Add(this.comboBoxTypeOfNode);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cancel);
			this.Controls.Add(this.add);
			this.Controls.Add(this.distributionGroupBox);
			this.Controls.Add(this.nodeParamGroupBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "AddNode";
			this.Text = "Добавление узла";
			this.Load += new System.EventHandler(this.AddNode_Load);
			this.distributionGroupBox.ResumeLayout(false);
			this.distributionGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.distributionParam)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nodeParam)).EndInit();
			this.nodeParamGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.GroupBox distributionGroupBox;
		private System.Windows.Forms.DataGridView distributionParam;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxTypeOfDistribution;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button add;
		private System.Windows.Forms.Button cancel;
		private System.Windows.Forms.DataGridView nodeParam;
		private System.Windows.Forms.GroupBox nodeParamGroupBox;
		private System.Windows.Forms.ComboBox comboBoxTypeOfNode;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.Label label5;
	}
}