namespace WhatUnavailableAlbums
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LogBox = new System.Windows.Forms.TextBox();
            this.ScanButton = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.CopyListButton = new System.Windows.Forms.Button();
            this.ClearListButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AlbumSourceComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.albumBindingSource;
            this.listBox1.DisplayMember = "StringRepresentation";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(16, 73);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(356, 238);
            this.listBox1.TabIndex = 6;
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(WhatUnavailableAlbums.Album);
            // 
            // LogBox
            // 
            this.LogBox.Location = new System.Drawing.Point(15, 330);
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.Size = new System.Drawing.Size(479, 184);
            this.LogBox.TabIndex = 7;
            this.LogBox.TabStop = false;
            // 
            // ScanButton
            // 
            this.ScanButton.Location = new System.Drawing.Point(378, 31);
            this.ScanButton.Name = "ScanButton";
            this.ScanButton.Size = new System.Drawing.Size(116, 23);
            this.ScanButton.TabIndex = 5;
            this.ScanButton.Text = "Scan...";
            this.ScanButton.UseVisualStyleBackColor = true;
            this.ScanButton.Click += new System.EventHandler(this.ScanButton_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(37, 8);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(58, 13);
            this.labelUsername.TabIndex = 9;
            this.labelUsername.Text = "Username:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(207, 8);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 13);
            this.labelPassword.TabIndex = 10;
            this.labelPassword.Text = "Password:";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(101, 5);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(100, 20);
            this.Username.TabIndex = 3;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(272, 5);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(100, 20);
            this.Password.TabIndex = 4;
            // 
            // CopyListButton
            // 
            this.CopyListButton.Location = new System.Drawing.Point(378, 259);
            this.CopyListButton.Name = "CopyListButton";
            this.CopyListButton.Size = new System.Drawing.Size(116, 23);
            this.CopyListButton.TabIndex = 11;
            this.CopyListButton.Text = "Copy list to clipboard";
            this.CopyListButton.UseVisualStyleBackColor = true;
            this.CopyListButton.Click += new System.EventHandler(this.CopyListButton_Click);
            // 
            // ClearListButton
            // 
            this.ClearListButton.Location = new System.Drawing.Point(378, 288);
            this.ClearListButton.Name = "ClearListButton";
            this.ClearListButton.Size = new System.Drawing.Size(116, 23);
            this.ClearListButton.TabIndex = 12;
            this.ClearListButton.Text = "Clear list";
            this.ClearListButton.UseVisualStyleBackColor = true;
            this.ClearListButton.Click += new System.EventHandler(this.ClearListButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Album source:";
            // 
            // AlbumSourceComboBox
            // 
            this.AlbumSourceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AlbumSourceComboBox.FormattingEnabled = true;
            this.AlbumSourceComboBox.Items.AddRange(new object[] {
            "Directory structure",
            "Text file"});
            this.AlbumSourceComboBox.Location = new System.Drawing.Point(101, 31);
            this.AlbumSourceComboBox.Name = "AlbumSourceComboBox";
            this.AlbumSourceComboBox.Size = new System.Drawing.Size(271, 21);
            this.AlbumSourceComboBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Log:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Albums that aren\'t uploaded:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 531);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AlbumSourceComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearListButton);
            this.Controls.Add(this.CopyListButton);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.ScanButton);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.listBox1);
            this.Name = "MainForm";
            this.Text = "WhatUnavailableAlbums: What can I upload?";
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private System.Windows.Forms.TextBox LogBox;
        private System.Windows.Forms.Button ScanButton;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button CopyListButton;
        private System.Windows.Forms.Button ClearListButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox AlbumSourceComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;


    }
}

