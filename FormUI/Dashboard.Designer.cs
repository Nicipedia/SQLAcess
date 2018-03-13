namespace FormUI
{
    partial class Dashboard
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
            this.peopleFoundListbox = new System.Windows.Forms.ListBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.lastNameLable = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.firstNameInsText = new System.Windows.Forms.TextBox();
            this.lastNameInsText = new System.Windows.Forms.TextBox();
            this.emailAddressInsText = new System.Windows.Forms.TextBox();
            this.phoneNumberInsText = new System.Windows.Forms.TextBox();
            this.firstNameInsLable = new System.Windows.Forms.Label();
            this.lastNameInsLable = new System.Windows.Forms.Label();
            this.emailAddressInsLabel = new System.Windows.Forms.Label();
            this.phoneNumberInsLabel = new System.Windows.Forms.Label();
            this.insertRecordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // peopleFoundListbox
            // 
            this.peopleFoundListbox.FormattingEnabled = true;
            this.peopleFoundListbox.ItemHeight = 20;
            this.peopleFoundListbox.Location = new System.Drawing.Point(49, 99);
            this.peopleFoundListbox.Name = "peopleFoundListbox";
            this.peopleFoundListbox.Size = new System.Drawing.Size(421, 124);
            this.peopleFoundListbox.TabIndex = 0;
            this.peopleFoundListbox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(172, 27);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(151, 26);
            this.lastNameText.TabIndex = 1;
            // 
            // lastNameLable
            // 
            this.lastNameLable.AutoSize = true;
            this.lastNameLable.Location = new System.Drawing.Point(49, 27);
            this.lastNameLable.Name = "lastNameLable";
            this.lastNameLable.Size = new System.Drawing.Size(86, 20);
            this.lastNameLable.TabIndex = 2;
            this.lastNameLable.Text = "Last Name";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(172, 57);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(96, 36);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // firstNameInsText
            // 
            this.firstNameInsText.Location = new System.Drawing.Point(173, 269);
            this.firstNameInsText.Name = "firstNameInsText";
            this.firstNameInsText.Size = new System.Drawing.Size(150, 26);
            this.firstNameInsText.TabIndex = 4;
            // 
            // lastNameInsText
            // 
            this.lastNameInsText.Location = new System.Drawing.Point(173, 301);
            this.lastNameInsText.Name = "lastNameInsText";
            this.lastNameInsText.Size = new System.Drawing.Size(150, 26);
            this.lastNameInsText.TabIndex = 5;
            // 
            // emailAddressInsText
            // 
            this.emailAddressInsText.Location = new System.Drawing.Point(172, 330);
            this.emailAddressInsText.Name = "emailAddressInsText";
            this.emailAddressInsText.Size = new System.Drawing.Size(151, 26);
            this.emailAddressInsText.TabIndex = 6;
            // 
            // phoneNumberInsText
            // 
            this.phoneNumberInsText.Location = new System.Drawing.Point(173, 362);
            this.phoneNumberInsText.Name = "phoneNumberInsText";
            this.phoneNumberInsText.Size = new System.Drawing.Size(150, 26);
            this.phoneNumberInsText.TabIndex = 7;
            // 
            // firstNameInsLable
            // 
            this.firstNameInsLable.AutoSize = true;
            this.firstNameInsLable.Location = new System.Drawing.Point(49, 272);
            this.firstNameInsLable.Name = "firstNameInsLable";
            this.firstNameInsLable.Size = new System.Drawing.Size(90, 20);
            this.firstNameInsLable.TabIndex = 8;
            this.firstNameInsLable.Text = "First Name ";
            // 
            // lastNameInsLable
            // 
            this.lastNameInsLable.AutoSize = true;
            this.lastNameInsLable.Location = new System.Drawing.Point(49, 304);
            this.lastNameInsLable.Name = "lastNameInsLable";
            this.lastNameInsLable.Size = new System.Drawing.Size(86, 20);
            this.lastNameInsLable.TabIndex = 9;
            this.lastNameInsLable.Text = "Last Name";
            // 
            // emailAddressInsLabel
            // 
            this.emailAddressInsLabel.AutoSize = true;
            this.emailAddressInsLabel.Location = new System.Drawing.Point(49, 336);
            this.emailAddressInsLabel.Name = "emailAddressInsLabel";
            this.emailAddressInsLabel.Size = new System.Drawing.Size(111, 20);
            this.emailAddressInsLabel.TabIndex = 10;
            this.emailAddressInsLabel.Text = "Email Address";
            // 
            // phoneNumberInsLabel
            // 
            this.phoneNumberInsLabel.AutoSize = true;
            this.phoneNumberInsLabel.Location = new System.Drawing.Point(49, 368);
            this.phoneNumberInsLabel.Name = "phoneNumberInsLabel";
            this.phoneNumberInsLabel.Size = new System.Drawing.Size(115, 20);
            this.phoneNumberInsLabel.TabIndex = 11;
            this.phoneNumberInsLabel.Text = "Phone Number";
            // 
            // insertRecordButton
            // 
            this.insertRecordButton.Location = new System.Drawing.Point(172, 400);
            this.insertRecordButton.Name = "insertRecordButton";
            this.insertRecordButton.Size = new System.Drawing.Size(96, 36);
            this.insertRecordButton.TabIndex = 12;
            this.insertRecordButton.Text = "Insert";
            this.insertRecordButton.UseVisualStyleBackColor = true;
            this.insertRecordButton.Click += new System.EventHandler(this.insertRecordButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 448);
            this.Controls.Add(this.insertRecordButton);
            this.Controls.Add(this.phoneNumberInsLabel);
            this.Controls.Add(this.emailAddressInsLabel);
            this.Controls.Add(this.lastNameInsLable);
            this.Controls.Add(this.firstNameInsLable);
            this.Controls.Add(this.phoneNumberInsText);
            this.Controls.Add(this.emailAddressInsText);
            this.Controls.Add(this.lastNameInsText);
            this.Controls.Add(this.firstNameInsText);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.lastNameLable);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.peopleFoundListbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Dashboard";
            this.Text = "SQL Data Acess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox peopleFoundListbox;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label lastNameLable;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox firstNameInsText;
        private System.Windows.Forms.TextBox lastNameInsText;
        private System.Windows.Forms.TextBox emailAddressInsText;
        private System.Windows.Forms.TextBox phoneNumberInsText;
        private System.Windows.Forms.Label firstNameInsLable;
        private System.Windows.Forms.Label lastNameInsLable;
        private System.Windows.Forms.Label emailAddressInsLabel;
        private System.Windows.Forms.Label phoneNumberInsLabel;
        private System.Windows.Forms.Button insertRecordButton;
    }
}

