namespace VideoGameRentalSystem
{
    partial class EditProfileScreen
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
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zipTextBox
            // 
            this.zipTextBox.Location = new System.Drawing.Point(17, 186);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(138, 22);
            this.zipTextBox.TabIndex = 32;
            this.zipTextBox.Text = "Zip Code";
            // 
            // stateComboBox
            // 
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.stateComboBox.Items.AddRange(new object[] {
            "AK",
            "AL",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.stateComboBox.Location = new System.Drawing.Point(161, 158);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(157, 24);
            this.stateComboBox.TabIndex = 31;
            this.stateComboBox.Text = "State";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(17, 158);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(138, 22);
            this.cityTextBox.TabIndex = 30;
            this.cityTextBox.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Shipping Info";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(17, 129);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(301, 22);
            this.addressTextBox.TabIndex = 28;
            this.addressTextBox.Text = "Street address";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(17, 84);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(301, 22);
            this.emailTextBox.TabIndex = 24;
            this.emailTextBox.Text = "E-mail address";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(161, 56);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(157, 22);
            this.lastNameTextBox.TabIndex = 23;
            this.lastNameTextBox.Text = "Last name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(17, 56);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(138, 22);
            this.firstNameTextBox.TabIndex = 22;
            this.firstNameTextBox.Text = "First name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Edit Profile";
            // 
            // passwordButton
            // 
            this.passwordButton.Location = new System.Drawing.Point(17, 229);
            this.passwordButton.Name = "passwordButton";
            this.passwordButton.Size = new System.Drawing.Size(138, 31);
            this.passwordButton.TabIndex = 33;
            this.passwordButton.Text = "Change password";
            this.passwordButton.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(161, 229);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(157, 31);
            this.submitButton.TabIndex = 34;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // EditProfileScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 277);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.passwordButton);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.label4);
            this.Name = "EditProfileScreen";
            this.Text = "EditProfileScreen";
            this.AutoSizeChanged += new System.EventHandler(this.EditProfileScreen_AutoSizeChanged);
            this.Activated += new System.EventHandler(this.EditProfileScreen_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button passwordButton;
        private System.Windows.Forms.Button submitButton;
    }
}