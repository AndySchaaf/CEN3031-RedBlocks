namespace VideoGameRentalSystem
{
    partial class RentalMainScreen
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SignOutLink = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.consoleComboBox = new System.Windows.Forms.ComboBox();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.videoGamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.redBlocksDataSet = new VideoGameRentalSystem.RedBlocksDataSet();
            this.video_GamesTableAdapter = new VideoGameRentalSystem.RedBlocksDataSetTableAdapters.Video_GamesTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consoleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoGamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redBlocksDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(377, 16);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(139, 22);
            this.searchBox.TabIndex = 2;
            this.searchBox.Text = "Search";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(243, 19);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(59, 17);
            this.linkLabel2.TabIndex = 4;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Account";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // SignOutLink
            // 
            this.SignOutLink.AutoSize = true;
            this.SignOutLink.Location = new System.Drawing.Point(308, 19);
            this.SignOutLink.Name = "SignOutLink";
            this.SignOutLink.Size = new System.Drawing.Size(63, 17);
            this.SignOutLink.TabIndex = 5;
            this.SignOutLink.TabStop = true;
            this.SignOutLink.Text = "Sign Out";
            this.SignOutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignOutLink_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Filters";
            // 
            // consoleComboBox
            // 
            this.consoleComboBox.FormattingEnabled = true;
            this.consoleComboBox.Location = new System.Drawing.Point(66, 54);
            this.consoleComboBox.Name = "consoleComboBox";
            this.consoleComboBox.Size = new System.Drawing.Size(121, 24);
            this.consoleComboBox.TabIndex = 7;
            this.consoleComboBox.Text = "Console";
            this.consoleComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // genreComboBox
            // 
            this.genreComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Location = new System.Drawing.Point(193, 54);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(139, 24);
            this.genreComboBox.TabIndex = 8;
            this.genreComboBox.Text = "Genre";
            this.genreComboBox.SelectedIndexChanged += new System.EventHandler(this.genreComboBox_SelectedIndexChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(104, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 25);
            this.nameLabel.TabIndex = 11;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(104, 13);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(0, 25);
            this.userNameLabel.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.consoleDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.videoGamesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(570, 359);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // videoGamesBindingSource
            // 
            this.videoGamesBindingSource.DataMember = "Video_Games";
            this.videoGamesBindingSource.DataSource = this.redBlocksDataSet;
            // 
            // redBlocksDataSet
            // 
            this.redBlocksDataSet.DataSetName = "RedBlocksDataSet";
            this.redBlocksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // video_GamesTableAdapter
            // 
            this.video_GamesTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(522, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 31);
            this.button1.TabIndex = 14;
            this.button1.Text = "Go!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // consoleDataGridViewTextBoxColumn
            // 
            this.consoleDataGridViewTextBoxColumn.DataPropertyName = "console";
            this.consoleDataGridViewTextBoxColumn.HeaderText = "console";
            this.consoleDataGridViewTextBoxColumn.Name = "consoleDataGridViewTextBoxColumn";
            this.consoleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            this.genreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // RentalMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 455);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.genreComboBox);
            this.Controls.Add(this.consoleComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SignOutLink);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label1);
            this.Name = "RentalMainScreen";
            this.Text = "Redblocks";
            this.Activated += new System.EventHandler(this.RentalMainScreen_Activated);
            this.Load += new System.EventHandler(this.RentalMainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoGamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redBlocksDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel SignOutLink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox consoleComboBox;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RedBlocksDataSet redBlocksDataSet;
        private System.Windows.Forms.BindingSource videoGamesBindingSource;
        private RedBlocksDataSetTableAdapters.Video_GamesTableAdapter video_GamesTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consoleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
    }
}