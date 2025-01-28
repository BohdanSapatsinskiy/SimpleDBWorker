namespace usingbd
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBoxTables = new System.Windows.Forms.ListBox();
            this.dataGridViewTable = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonShowTables = new System.Windows.Forms.Button();
            this.buttonShowStatistic = new System.Windows.Forms.Button();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.tbDB = new System.Windows.Forms.TextBox();
            this.buttonConnection = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxTables
            // 
            this.listBoxTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxTables.FormattingEnabled = true;
            this.listBoxTables.ItemHeight = 20;
            this.listBoxTables.Location = new System.Drawing.Point(12, 124);
            this.listBoxTables.Name = "listBoxTables";
            this.listBoxTables.Size = new System.Drawing.Size(292, 244);
            this.listBoxTables.TabIndex = 0;
            this.listBoxTables.SelectedIndexChanged += new System.EventHandler(this.listBoxTables_SelectedIndexChanged_1);
            // 
            // dataGridViewTable
            // 
            this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable.Location = new System.Drawing.Point(310, 124);
            this.dataGridViewTable.Name = "dataGridViewTable";
            this.dataGridViewTable.RowHeadersWidth = 51;
            this.dataGridViewTable.RowTemplate.Height = 24;
            this.dataGridViewTable.Size = new System.Drawing.Size(1137, 314);
            this.dataGridViewTable.TabIndex = 2;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(1198, 444);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(249, 57);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Зберегти зміни";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.Location = new System.Drawing.Point(642, 23);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(98, 25);
            this.labelInfo.TabIndex = 9;
            this.labelInfo.Text = "Таблиця";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonShowTables
            // 
            this.buttonShowTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowTables.Location = new System.Drawing.Point(12, 61);
            this.buttonShowTables.Name = "buttonShowTables";
            this.buttonShowTables.Size = new System.Drawing.Size(292, 57);
            this.buttonShowTables.TabIndex = 10;
            this.buttonShowTables.Text = "Таблиці";
            this.buttonShowTables.UseVisualStyleBackColor = true;
            this.buttonShowTables.Click += new System.EventHandler(this.buttonShowTables_Click);
            // 
            // buttonShowStatistic
            // 
            this.buttonShowStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowStatistic.Location = new System.Drawing.Point(12, 374);
            this.buttonShowStatistic.Name = "buttonShowStatistic";
            this.buttonShowStatistic.Size = new System.Drawing.Size(292, 57);
            this.buttonShowStatistic.TabIndex = 11;
            this.buttonShowStatistic.Text = "Процедури";
            this.buttonShowStatistic.UseVisualStyleBackColor = true;
            this.buttonShowStatistic.Click += new System.EventHandler(this.buttonShowStatistic_Click);
            // 
            // textBoxFind
            // 
            this.textBoxFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFind.Location = new System.Drawing.Point(647, 69);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(491, 34);
            this.textBoxFind.TabIndex = 13;
            // 
            // buttonFind
            // 
            this.buttonFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFind.Location = new System.Drawing.Point(1144, 61);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(111, 57);
            this.buttonFind.TabIndex = 14;
            this.buttonFind.Text = "Знайти";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(546, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Пошук:";
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(12, 479);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(146, 22);
            this.tbServer.TabIndex = 16;
            // 
            // tbDB
            // 
            this.tbDB.Location = new System.Drawing.Point(13, 520);
            this.tbDB.Name = "tbDB";
            this.tbDB.Size = new System.Drawing.Size(145, 22);
            this.tbDB.TabIndex = 17;
            // 
            // buttonConnection
            // 
            this.buttonConnection.Location = new System.Drawing.Point(175, 479);
            this.buttonConnection.Name = "buttonConnection";
            this.buttonConnection.Size = new System.Drawing.Size(115, 63);
            this.buttonConnection.TabIndex = 18;
            this.buttonConnection.Text = "Підключення";
            this.buttonConnection.UseVisualStyleBackColor = true;
            this.buttonConnection.Click += new System.EventHandler(this.buttonConnection_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Назва сервера";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 504);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Назва бази даних";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 563);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonConnection);
            this.Controls.Add(this.tbDB);
            this.Controls.Add(this.tbServer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.buttonShowStatistic);
            this.Controls.Add(this.buttonShowTables);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridViewTable);
            this.Controls.Add(this.listBoxTables);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SimpleDB";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTables;
        private System.Windows.Forms.DataGridView dataGridViewTable;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonShowTables;
        private System.Windows.Forms.Button buttonShowStatistic;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.TextBox tbDB;
        private System.Windows.Forms.Button buttonConnection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

