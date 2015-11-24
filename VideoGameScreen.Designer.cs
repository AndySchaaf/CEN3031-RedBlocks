namespace VideoGameRentalSystem
{
    partial class VideoGameScreen
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
            this.rentButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.consoleLabel = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rentButton
            // 
            this.rentButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rentButton.Location = new System.Drawing.Point(12, 137);
            this.rentButton.Name = "rentButton";
            this.rentButton.Size = new System.Drawing.Size(121, 37);
            this.rentButton.TabIndex = 0;
            this.rentButton.Text = "Rent";
            this.rentButton.UseVisualStyleBackColor = true;
            this.rentButton.Click += new System.EventHandler(this.rentButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(90, 18);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Madden 15";
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Genre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLabel.Location = new System.Drawing.Point(94, 36);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(52, 18);
            this.genreLabel.TabIndex = 3;
            this.genreLabel.Text = "Sports";
            this.genreLabel.Click += new System.EventHandler(this.genreLabel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Console";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // consoleLabel
            // 
            this.consoleLabel.AutoSize = true;
            this.consoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleLabel.Location = new System.Drawing.Point(94, 67);
            this.consoleLabel.Name = "consoleLabel";
            this.consoleLabel.Size = new System.Drawing.Size(36, 18);
            this.consoleLabel.TabIndex = 5;
            this.consoleLabel.Text = "PS4";
            this.consoleLabel.Click += new System.EventHandler(this.consoleLabel_Click);
            // 
            // returnButton
            // 
            this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.returnButton.Location = new System.Drawing.Point(139, 137);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(117, 37);
            this.returnButton.TabIndex = 6;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Inventory";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryLabel.Location = new System.Drawing.Point(94, 99);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(16, 18);
            this.inventoryLabel.TabIndex = 8;
            this.inventoryLabel.Text = "3";
            // 
            // VideoGameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 186);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.consoleLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.rentButton);
            this.Name = "VideoGameScreen";
            this.Text = "VideoGameScreen";
            this.Load += new System.EventHandler(this.VideoGameScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rentButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label consoleLabel;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label inventoryLabel;
    }
}