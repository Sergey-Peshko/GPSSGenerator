namespace UserInterface
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
			this.groupBoxCommonParam = new System.Windows.Forms.GroupBox();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonApply = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.numericNumberOfTransactions = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBoxTypeOfNet = new System.Windows.Forms.ComboBox();
			this.groupBoxStreams = new System.Windows.Forms.GroupBox();
			this.groupBoxNodes = new System.Windows.Forms.GroupBox();
			this.buttonShowFullDescription = new System.Windows.Forms.Button();
			this.buttonEditNode = new System.Windows.Forms.Button();
			this.buttonDeleteNode = new System.Windows.Forms.Button();
			this.buttonAddNode = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.buttonGenerate = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.buttonEditStream = new System.Windows.Forms.Button();
			this.buttonDeleteStream = new System.Windows.Forms.Button();
			this.buttonAddStream = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.groupBoxCommonParam.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericNumberOfTransactions)).BeginInit();
			this.groupBoxStreams.SuspendLayout();
			this.groupBoxNodes.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(656, 24);
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
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.openToolStripMenuItem.Text = "Open";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.saveToolStripMenuItem.Text = "Save";
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
			// 
			// groupBoxCommonParam
			// 
			this.groupBoxCommonParam.Controls.Add(this.buttonEdit);
			this.groupBoxCommonParam.Controls.Add(this.buttonApply);
			this.groupBoxCommonParam.Controls.Add(this.label3);
			this.groupBoxCommonParam.Controls.Add(this.numericNumberOfTransactions);
			this.groupBoxCommonParam.Controls.Add(this.label1);
			this.groupBoxCommonParam.Controls.Add(this.comboBoxTypeOfNet);
			this.groupBoxCommonParam.Location = new System.Drawing.Point(12, 47);
			this.groupBoxCommonParam.Name = "groupBoxCommonParam";
			this.groupBoxCommonParam.Size = new System.Drawing.Size(277, 109);
			this.groupBoxCommonParam.TabIndex = 1;
			this.groupBoxCommonParam.TabStop = false;
			this.groupBoxCommonParam.Text = "Общие Параметры";
			// 
			// buttonEdit
			// 
			this.buttonEdit.Location = new System.Drawing.Point(6, 77);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(93, 23);
			this.buttonEdit.TabIndex = 7;
			this.buttonEdit.Text = "редактировать";
			this.buttonEdit.UseVisualStyleBackColor = true;
			// 
			// buttonApply
			// 
			this.buttonApply.Location = new System.Drawing.Point(196, 77);
			this.buttonApply.Name = "buttonApply";
			this.buttonApply.Size = new System.Drawing.Size(75, 23);
			this.buttonApply.TabIndex = 6;
			this.buttonApply.Text = "применить";
			this.buttonApply.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(108, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Кол-во транзактов: ";
			// 
			// numericNumberOfTransactions
			// 
			this.numericNumberOfTransactions.Location = new System.Drawing.Point(122, 46);
			this.numericNumberOfTransactions.Name = "numericNumberOfTransactions";
			this.numericNumberOfTransactions.Size = new System.Drawing.Size(121, 20);
			this.numericNumberOfTransactions.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Выберите тип сети: ";
			// 
			// comboBoxTypeOfNet
			// 
			this.comboBoxTypeOfNet.FormattingEnabled = true;
			this.comboBoxTypeOfNet.Location = new System.Drawing.Point(122, 19);
			this.comboBoxTypeOfNet.Name = "comboBoxTypeOfNet";
			this.comboBoxTypeOfNet.Size = new System.Drawing.Size(121, 21);
			this.comboBoxTypeOfNet.TabIndex = 0;
			// 
			// groupBoxStreams
			// 
			this.groupBoxStreams.Controls.Add(this.buttonEditStream);
			this.groupBoxStreams.Controls.Add(this.buttonDeleteStream);
			this.groupBoxStreams.Controls.Add(this.buttonAddStream);
			this.groupBoxStreams.Controls.Add(this.listBox1);
			this.groupBoxStreams.Location = new System.Drawing.Point(12, 162);
			this.groupBoxStreams.Name = "groupBoxStreams";
			this.groupBoxStreams.Size = new System.Drawing.Size(277, 121);
			this.groupBoxStreams.TabIndex = 2;
			this.groupBoxStreams.TabStop = false;
			this.groupBoxStreams.Text = "Описание Потоков";
			// 
			// groupBoxNodes
			// 
			this.groupBoxNodes.Controls.Add(this.buttonShowFullDescription);
			this.groupBoxNodes.Controls.Add(this.buttonEditNode);
			this.groupBoxNodes.Controls.Add(this.buttonDeleteNode);
			this.groupBoxNodes.Controls.Add(this.buttonAddNode);
			this.groupBoxNodes.Controls.Add(this.dataGridView1);
			this.groupBoxNodes.Location = new System.Drawing.Point(295, 47);
			this.groupBoxNodes.Name = "groupBoxNodes";
			this.groupBoxNodes.Size = new System.Drawing.Size(358, 236);
			this.groupBoxNodes.TabIndex = 3;
			this.groupBoxNodes.TabStop = false;
			this.groupBoxNodes.Text = "Описание Узлов Системы";
			// 
			// buttonShowFullDescription
			// 
			this.buttonShowFullDescription.Location = new System.Drawing.Point(252, 181);
			this.buttonShowFullDescription.Name = "buttonShowFullDescription";
			this.buttonShowFullDescription.Size = new System.Drawing.Size(101, 49);
			this.buttonShowFullDescription.TabIndex = 4;
			this.buttonShowFullDescription.Text = "Показать Полное Описание";
			this.buttonShowFullDescription.UseVisualStyleBackColor = true;
			// 
			// buttonEditNode
			// 
			this.buttonEditNode.Location = new System.Drawing.Point(252, 48);
			this.buttonEditNode.Name = "buttonEditNode";
			this.buttonEditNode.Size = new System.Drawing.Size(102, 23);
			this.buttonEditNode.TabIndex = 3;
			this.buttonEditNode.Text = "Редактировать";
			this.buttonEditNode.UseVisualStyleBackColor = true;
			// 
			// buttonDeleteNode
			// 
			this.buttonDeleteNode.Location = new System.Drawing.Point(252, 77);
			this.buttonDeleteNode.Name = "buttonDeleteNode";
			this.buttonDeleteNode.Size = new System.Drawing.Size(102, 23);
			this.buttonDeleteNode.TabIndex = 2;
			this.buttonDeleteNode.Text = "Удалить";
			this.buttonDeleteNode.UseVisualStyleBackColor = true;
			// 
			// buttonAddNode
			// 
			this.buttonAddNode.Location = new System.Drawing.Point(252, 19);
			this.buttonAddNode.Name = "buttonAddNode";
			this.buttonAddNode.Size = new System.Drawing.Size(102, 23);
			this.buttonAddNode.TabIndex = 1;
			this.buttonAddNode.Text = "Добавить";
			this.buttonAddNode.UseVisualStyleBackColor = true;
			this.buttonAddNode.Click += new System.EventHandler(this.addButton_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(6, 19);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(240, 211);
			this.dataGridView1.TabIndex = 0;
			// 
			// buttonGenerate
			// 
			this.buttonGenerate.Location = new System.Drawing.Point(262, 296);
			this.buttonGenerate.Name = "buttonGenerate";
			this.buttonGenerate.Size = new System.Drawing.Size(131, 23);
			this.buttonGenerate.TabIndex = 4;
			this.buttonGenerate.Text = "Сгенерировать код";
			this.buttonGenerate.UseVisualStyleBackColor = true;
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(6, 19);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(163, 95);
			this.listBox1.TabIndex = 0;
			// 
			// buttonEditStream
			// 
			this.buttonEditStream.Location = new System.Drawing.Point(175, 55);
			this.buttonEditStream.Name = "buttonEditStream";
			this.buttonEditStream.Size = new System.Drawing.Size(102, 23);
			this.buttonEditStream.TabIndex = 6;
			this.buttonEditStream.Text = "Редактировать";
			this.buttonEditStream.UseVisualStyleBackColor = true;
			// 
			// buttonDeleteStream
			// 
			this.buttonDeleteStream.Location = new System.Drawing.Point(175, 84);
			this.buttonDeleteStream.Name = "buttonDeleteStream";
			this.buttonDeleteStream.Size = new System.Drawing.Size(102, 23);
			this.buttonDeleteStream.TabIndex = 5;
			this.buttonDeleteStream.Text = "Удалить";
			this.buttonDeleteStream.UseVisualStyleBackColor = true;
			// 
			// buttonAddStream
			// 
			this.buttonAddStream.Location = new System.Drawing.Point(175, 26);
			this.buttonAddStream.Name = "buttonAddStream";
			this.buttonAddStream.Size = new System.Drawing.Size(102, 23);
			this.buttonAddStream.TabIndex = 4;
			this.buttonAddStream.Text = "Добавить";
			this.buttonAddStream.UseVisualStyleBackColor = true;
			// 
			// MainFrame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(656, 331);
			this.Controls.Add(this.buttonGenerate);
			this.Controls.Add(this.groupBoxNodes);
			this.Controls.Add(this.groupBoxStreams);
			this.Controls.Add(this.groupBoxCommonParam);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainFrame";
			this.Text = "GPSSHelper";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBoxCommonParam.ResumeLayout(false);
			this.groupBoxCommonParam.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericNumberOfTransactions)).EndInit();
			this.groupBoxStreams.ResumeLayout(false);
			this.groupBoxNodes.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
		private System.Windows.Forms.GroupBox groupBoxCommonParam;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxTypeOfNet;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numericNumberOfTransactions;
		private System.Windows.Forms.GroupBox groupBoxStreams;
		private System.Windows.Forms.GroupBox groupBoxNodes;
		private System.Windows.Forms.Button buttonEditNode;
		private System.Windows.Forms.Button buttonDeleteNode;
		private System.Windows.Forms.Button buttonAddNode;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button buttonShowFullDescription;
		private System.Windows.Forms.Button buttonGenerate;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.Button buttonApply;
		private System.Windows.Forms.Button buttonEditStream;
		private System.Windows.Forms.Button buttonDeleteStream;
		private System.Windows.Forms.Button buttonAddStream;
		private System.Windows.Forms.ListBox listBox1;
	}
}

