namespace PersonalInformationApp
{
    partial class personalInfoUI
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
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.fatherNameTextBox = new System.Windows.Forms.TextBox();
            this.motherNameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.fatherNameLabel = new System.Windows.Forms.Label();
            this.motherNameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.allInfoButton = new System.Windows.Forms.Button();
            this.nameButton = new System.Windows.Forms.Button();
            this.parentsNameButton = new System.Windows.Forms.Button();
            this.addressButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(284, 32);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(296, 20);
            this.firstNameTextBox.TabIndex = 0;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(284, 59);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(296, 20);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // fatherNameTextBox
            // 
            this.fatherNameTextBox.Location = new System.Drawing.Point(284, 88);
            this.fatherNameTextBox.Name = "fatherNameTextBox";
            this.fatherNameTextBox.Size = new System.Drawing.Size(296, 20);
            this.fatherNameTextBox.TabIndex = 2;
            // 
            // motherNameTextBox
            // 
            this.motherNameTextBox.Location = new System.Drawing.Point(284, 118);
            this.motherNameTextBox.Name = "motherNameTextBox";
            this.motherNameTextBox.Size = new System.Drawing.Size(296, 20);
            this.motherNameTextBox.TabIndex = 3;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(284, 149);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(296, 62);
            this.addressTextBox.TabIndex = 4;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(195, 35);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 3;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(195, 62);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 4;
            this.lastNameLabel.Text = "Last Name";
            // 
            // fatherNameLabel
            // 
            this.fatherNameLabel.AutoSize = true;
            this.fatherNameLabel.Location = new System.Drawing.Point(195, 91);
            this.fatherNameLabel.Name = "fatherNameLabel";
            this.fatherNameLabel.Size = new System.Drawing.Size(75, 13);
            this.fatherNameLabel.TabIndex = 5;
            this.fatherNameLabel.Text = "Father\'s Name";
            // 
            // motherNameLabel
            // 
            this.motherNameLabel.AutoSize = true;
            this.motherNameLabel.Location = new System.Drawing.Point(195, 121);
            this.motherNameLabel.Name = "motherNameLabel";
            this.motherNameLabel.Size = new System.Drawing.Size(78, 13);
            this.motherNameLabel.TabIndex = 6;
            this.motherNameLabel.Text = "Mother\'s Name";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(195, 152);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 7;
            this.addressLabel.Text = "Address";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(284, 226);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // allInfoButton
            // 
            this.allInfoButton.Location = new System.Drawing.Point(375, 226);
            this.allInfoButton.Name = "allInfoButton";
            this.allInfoButton.Size = new System.Drawing.Size(115, 23);
            this.allInfoButton.TabIndex = 6;
            this.allInfoButton.Text = "Show All Information";
            this.allInfoButton.UseVisualStyleBackColor = true;
            this.allInfoButton.Click += new System.EventHandler(this.allInfoButton_Click);
            // 
            // nameButton
            // 
            this.nameButton.Location = new System.Drawing.Point(505, 226);
            this.nameButton.Name = "nameButton";
            this.nameButton.Size = new System.Drawing.Size(75, 23);
            this.nameButton.TabIndex = 7;
            this.nameButton.Text = "Name";
            this.nameButton.UseVisualStyleBackColor = true;
            this.nameButton.Click += new System.EventHandler(this.nameButton_Click);
            // 
            // parentsNameButton
            // 
            this.parentsNameButton.Location = new System.Drawing.Point(375, 266);
            this.parentsNameButton.Name = "parentsNameButton";
            this.parentsNameButton.Size = new System.Drawing.Size(115, 23);
            this.parentsNameButton.TabIndex = 9;
            this.parentsNameButton.Text = "Parent\'s Name";
            this.parentsNameButton.UseVisualStyleBackColor = true;
            this.parentsNameButton.Click += new System.EventHandler(this.parentsNameButton_Click);
            // 
            // addressButton
            // 
            this.addressButton.Location = new System.Drawing.Point(284, 266);
            this.addressButton.Name = "addressButton";
            this.addressButton.Size = new System.Drawing.Size(75, 23);
            this.addressButton.TabIndex = 8;
            this.addressButton.Text = "Address";
            this.addressButton.UseVisualStyleBackColor = true;
            this.addressButton.Click += new System.EventHandler(this.addressButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(505, 266);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // personalInfoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 318);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addressButton);
            this.Controls.Add(this.parentsNameButton);
            this.Controls.Add(this.nameButton);
            this.Controls.Add(this.allInfoButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.motherNameLabel);
            this.Controls.Add(this.fatherNameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.motherNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.fatherNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Name = "personalInfoUI";
            this.Text = "Personal Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox fatherNameTextBox;
        private System.Windows.Forms.TextBox motherNameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label fatherNameLabel;
        private System.Windows.Forms.Label motherNameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button allInfoButton;
        private System.Windows.Forms.Button nameButton;
        private System.Windows.Forms.Button parentsNameButton;
        private System.Windows.Forms.Button addressButton;
        private System.Windows.Forms.Button exitButton;
    }
}

