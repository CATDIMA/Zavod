namespace Zavod
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
            this.MainTable = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.IDSortButton = new System.Windows.Forms.Button();
            this.NameSortButton = new System.Windows.Forms.Button();
            this.PostSortButton = new System.Windows.Forms.Button();
            this.SalaryPostButton = new System.Windows.Forms.Button();
            this.DateSortButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainTable)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.AllowUserToAddRows = false;
            this.MainTable.AllowUserToDeleteRows = false;
            this.MainTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MainTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this._Name,
            this.Post,
            this.Salary,
            this.Birthday});
            this.MainTable.Location = new System.Drawing.Point(5, 106);
            this.MainTable.Name = "MainTable";
            this.MainTable.ReadOnly = true;
            this.MainTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainTable.Size = new System.Drawing.Size(1013, 546);
            this.MainTable.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.Font = new System.Drawing.Font("Anime Ace v05", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(918, 658);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 50);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddButton.Font = new System.Drawing.Font("Anime Ace v05", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(5, 658);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 50);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveButton.Font = new System.Drawing.Font("Anime Ace v05", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveButton.Location = new System.Drawing.Point(111, 658);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(100, 50);
            this.RemoveButton.TabIndex = 6;
            this.RemoveButton.Text = "Удалить";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Anime Ace v05", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusLabel.ForeColor = System.Drawing.Color.Lime;
            this.StatusLabel.Location = new System.Drawing.Point(12, 34);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(77, 19);
            this.StatusLabel.TabIndex = 8;
            this.StatusLabel.Text = "ГОТОВ";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Anime Ace v05", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(354, 34);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(309, 19);
            this.NameLabel.TabIndex = 9;
            this.NameLabel.Text = "Наименование Организации";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // _Name
            // 
            this._Name.HeaderText = "ФИО";
            this._Name.Name = "_Name";
            this._Name.ReadOnly = true;
            // 
            // Post
            // 
            this.Post.HeaderText = "Должность";
            this.Post.Name = "Post";
            this.Post.ReadOnly = true;
            // 
            // Salary
            // 
            this.Salary.HeaderText = "Зарплата";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // Birthday
            // 
            this.Birthday.HeaderText = "Дата рождения";
            this.Birthday.Name = "Birthday";
            this.Birthday.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Anime Ace v05", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Сортировать по:";
            // 
            // IDSortButton
            // 
            this.IDSortButton.Font = new System.Drawing.Font("Anime Ace v05", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDSortButton.Location = new System.Drawing.Point(151, 72);
            this.IDSortButton.Name = "IDSortButton";
            this.IDSortButton.Size = new System.Drawing.Size(55, 26);
            this.IDSortButton.TabIndex = 12;
            this.IDSortButton.Text = "ID";
            this.IDSortButton.UseVisualStyleBackColor = true;
            this.IDSortButton.Click += new System.EventHandler(this.IDSortButton_Click);
            // 
            // NameSortButton
            // 
            this.NameSortButton.Font = new System.Drawing.Font("Anime Ace v05", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameSortButton.Location = new System.Drawing.Point(212, 72);
            this.NameSortButton.Name = "NameSortButton";
            this.NameSortButton.Size = new System.Drawing.Size(55, 26);
            this.NameSortButton.TabIndex = 13;
            this.NameSortButton.Text = "ФИО";
            this.NameSortButton.UseVisualStyleBackColor = true;
            this.NameSortButton.Click += new System.EventHandler(this.NameSortButton_Click);
            // 
            // PostSortButton
            // 
            this.PostSortButton.Font = new System.Drawing.Font("Anime Ace v05", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PostSortButton.Location = new System.Drawing.Point(273, 72);
            this.PostSortButton.Name = "PostSortButton";
            this.PostSortButton.Size = new System.Drawing.Size(106, 26);
            this.PostSortButton.TabIndex = 14;
            this.PostSortButton.Text = "Должности";
            this.PostSortButton.UseVisualStyleBackColor = true;
            this.PostSortButton.Click += new System.EventHandler(this.PostSortButton_Click);
            // 
            // SalaryPostButton
            // 
            this.SalaryPostButton.Font = new System.Drawing.Font("Anime Ace v05", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SalaryPostButton.Location = new System.Drawing.Point(385, 72);
            this.SalaryPostButton.Name = "SalaryPostButton";
            this.SalaryPostButton.Size = new System.Drawing.Size(106, 26);
            this.SalaryPostButton.TabIndex = 15;
            this.SalaryPostButton.Text = "Зарплате";
            this.SalaryPostButton.UseVisualStyleBackColor = true;
            this.SalaryPostButton.Click += new System.EventHandler(this.SalaryPostButton_Click);
            // 
            // DateSortButton
            // 
            this.DateSortButton.Font = new System.Drawing.Font("Anime Ace v05", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateSortButton.Location = new System.Drawing.Point(497, 72);
            this.DateSortButton.Name = "DateSortButton";
            this.DateSortButton.Size = new System.Drawing.Size(166, 26);
            this.DateSortButton.TabIndex = 16;
            this.DateSortButton.Text = "Дате рождения";
            this.DateSortButton.UseVisualStyleBackColor = true;
            this.DateSortButton.Click += new System.EventHandler(this.DateSortButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 720);
            this.Controls.Add(this.DateSortButton);
            this.Controls.Add(this.SalaryPostButton);
            this.Controls.Add(this.PostSortButton);
            this.Controls.Add(this.NameSortButton);
            this.Controls.Add(this.IDSortButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.MainTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1024, 720);
            this.Name = "MainForm";
            this.Text = "Zavod";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.MainTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MainTable;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Post;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button IDSortButton;
        private System.Windows.Forms.Button NameSortButton;
        private System.Windows.Forms.Button PostSortButton;
        private System.Windows.Forms.Button SalaryPostButton;
        private System.Windows.Forms.Button DateSortButton;
    }
}