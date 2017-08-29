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
			this.groupBoxSettings = new System.Windows.Forms.GroupBox();
			this.isTime = new System.Windows.Forms.RadioButton();
			this.isTransactions = new System.Windows.Forms.RadioButton();
			this.numericValue = new System.Windows.Forms.NumericUpDown();
			this.groupBoxStreams = new System.Windows.Forms.GroupBox();
			this.buttonEditStream = new System.Windows.Forms.Button();
			this.buttonDeleteStream = new System.Windows.Forms.Button();
			this.buttonAddStream = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.groupBoxNodes = new System.Windows.Forms.GroupBox();
			this.buttonShowFullDescription = new System.Windows.Forms.Button();
			this.buttonEditNode = new System.Windows.Forms.Button();
			this.buttonDeleteNode = new System.Windows.Forms.Button();
			this.buttonAddNode = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.buttonGenerate = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.groupBoxSettings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericValue)).BeginInit();
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
			this.menuStrip1.Size = new System.Drawing.Size(667, 24);
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
			// groupBoxSettings
			// 
			this.groupBoxSettings.Controls.Add(this.isTime);
			this.groupBoxSettings.Controls.Add(this.isTransactions);
			this.groupBoxSettings.Controls.Add(this.numericValue);
			this.groupBoxSettings.Location = new System.Drawing.Point(12, 47);
			this.groupBoxSettings.Name = "groupBoxSettings";
			this.groupBoxSettings.Size = new System.Drawing.Size(277, 83);
			this.groupBoxSettings.TabIndex = 1;
			this.groupBoxSettings.TabStop = false;
			this.groupBoxSettings.Text = "Измерять жизненный цикл модели по:";
			// 
			// isTime
			// 
			this.isTime.AutoSize = true;
			this.isTime.Location = new System.Drawing.Point(6, 19);
			this.isTime.Name = "isTime";
			this.isTime.Size = new System.Drawing.Size(73, 17);
			this.isTime.TabIndex = 11;
			this.isTime.Text = "Времени:";
			this.isTime.UseVisualStyleBackColor = true;
			// 
			// isTransactions
			// 
			this.isTransactions.AutoSize = true;
			this.isTransactions.Checked = true;
			this.isTransactions.Location = new System.Drawing.Point(107, 19);
			this.isTransactions.Name = "isTransactions";
			this.isTransactions.Size = new System.Drawing.Size(125, 17);
			this.isTransactions.TabIndex = 10;
			this.isTransactions.TabStop = true;
			this.isTransactions.Text = "Кол-ву транзактов: ";
			this.isTransactions.UseVisualStyleBackColor = true;
			// 
			// numericValue
			// 
			this.numericValue.Location = new System.Drawing.Point(6, 48);
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
			this.groupBoxStreams.Controls.Add(this.listBox1);
			this.groupBoxStreams.Location = new System.Drawing.Point(12, 162);
			this.groupBoxStreams.Name = "groupBoxStreams";
			this.groupBoxStreams.Size = new System.Drawing.Size(277, 121);
			this.groupBoxStreams.TabIndex = 2;
			this.groupBoxStreams.TabStop = false;
			this.groupBoxStreams.Text = "Описание Потоков";
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
			this.buttonAddStream.Click += new System.EventHandler(this.buttonAddStream_Click);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(6, 19);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(163, 95);
			this.listBox1.TabIndex = 0;
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
			this.buttonGenerate.Location = new System.Drawing.Point(258, 289);
			this.buttonGenerate.Name = "buttonGenerate";
			this.buttonGenerate.Size = new System.Drawing.Size(131, 23);
			this.buttonGenerate.TabIndex = 4;
			this.buttonGenerate.Text = "Сгенерировать код";
			this.buttonGenerate.UseVisualStyleBackColor = true;
			// 
			// MainFrame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(667, 330);
			this.Controls.Add(this.buttonGenerate);
			this.Controls.Add(this.groupBoxNodes);
			this.Controls.Add(this.groupBoxStreams);
			this.Controls.Add(this.groupBoxSettings);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainFrame";
			this.Text = "GPSSHelper";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBoxSettings.ResumeLayout(false);
			this.groupBoxSettings.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericValue)).EndInit();
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
		private System.Windows.Forms.GroupBox groupBoxSettings;
		private System.Windows.Forms.NumericUpDown numericValue;
		private System.Windows.Forms.GroupBox groupBoxStreams;
		private System.Windows.Forms.GroupBox groupBoxNodes;
		private System.Windows.Forms.Button buttonEditNode;
		private System.Windows.Forms.Button buttonDeleteNode;
		private System.Windows.Forms.Button buttonAddNode;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button buttonShowFullDescription;
		private System.Windows.Forms.Button buttonGenerate;
		private System.Windows.Forms.Button buttonEditStream;
		private System.Windows.Forms.Button buttonDeleteStream;
		private System.Windows.Forms.Button buttonAddStream;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.RadioButton isTime;
		private System.Windows.Forms.RadioButton isTransactions;
	}
}

