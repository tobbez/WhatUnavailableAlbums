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
            this.labelMusicDirectory = new System.Windows.Forms.Label();
            this.MusicDirectory = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
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
            this.CheckTextFileAlbumListButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMusicDirectory
            // 
            this.labelMusicDirectory.AutoSize = true;
            this.labelMusicDirectory.Location = new System.Drawing.Point(12, 9);
            this.labelMusicDirectory.Name = "labelMusicDirectory";
            this.labelMusicDirectory.Size = new System.Drawing.Size(83, 13);
            this.labelMusicDirectory.TabIndex = 2;
            this.labelMusicDirectory.Text = "Music Directory:";
            // 
            // MusicDirectory
            // 
            this.MusicDirectory.Location = new System.Drawing.Point(101, 6);
            this.MusicDirectory.Name = "MusicDirectory";
            this.MusicDirectory.Size = new System.Drawing.Size(271, 20);
            this.MusicDirectory.TabIndex = 1;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(378, 4);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(116, 23);
            this.BrowseButton.TabIndex = 2;
            this.BrowseButton.Text = "Browse...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.albumBindingSource;
            this.listBox1.DisplayMember = "StringRepresentation";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(16, 58);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(356, 251);
            this.listBox1.TabIndex = 6;
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(WhatUnavailableAlbums.Album);
            // 
            // LogBox
            // 
            this.LogBox.Location = new System.Drawing.Point(15, 315);
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.Size = new System.Drawing.Size(479, 199);
            this.LogBox.TabIndex = 7;
            this.LogBox.TabStop = false;
            // 
            // ScanButton
            // 
            this.ScanButton.Location = new System.Drawing.Point(378, 30);
            this.ScanButton.Name = "ScanButton";
            this.ScanButton.Size = new System.Drawing.Size(116, 23);
            this.ScanButton.TabIndex = 5;
            this.ScanButton.Text = "Scan";
            this.ScanButton.UseVisualStyleBackColor = true;
            this.ScanButton.Click += new System.EventHandler(this.ScanButton_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(37, 35);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(58, 13);
            this.labelUsername.TabIndex = 9;
            this.labelUsername.Text = "Username:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(207, 35);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 13);
            this.labelPassword.TabIndex = 10;
            this.labelPassword.Text = "Password:";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(101, 32);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(100, 20);
            this.Username.TabIndex = 3;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(272, 32);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(100, 20);
            this.Password.TabIndex = 4;
            // 
            // CopyListButton
            // 
            this.CopyListButton.Location = new System.Drawing.Point(378, 59);
            this.CopyListButton.Name = "CopyListButton";
            this.CopyListButton.Size = new System.Drawing.Size(116, 23);
            this.CopyListButton.TabIndex = 11;
            this.CopyListButton.Text = "Copy list to clipboard";
            this.CopyListButton.UseVisualStyleBackColor = true;
            this.CopyListButton.Click += new System.EventHandler(this.CopyListButton_Click);
            // 
            // ClearListButton
            // 
            this.ClearListButton.Location = new System.Drawing.Point(378, 88);
            this.ClearListButton.Name = "ClearListButton";
            this.ClearListButton.Size = new System.Drawing.Size(116, 23);
            this.ClearListButton.TabIndex = 12;
            this.ClearListButton.Text = "Clear list";
            this.ClearListButton.UseVisualStyleBackColor = true;
            this.ClearListButton.Click += new System.EventHandler(this.ClearListButton_Click);
            // 
            // CheckTextFileAlbumListButton
            // 
            this.CheckTextFileAlbumListButton.Location = new System.Drawing.Point(378, 274);
            this.CheckTextFileAlbumListButton.Name = "CheckTextFileAlbumListButton";
            this.CheckTextFileAlbumListButton.Size = new System.Drawing.Size(116, 35);
            this.CheckTextFileAlbumListButton.TabIndex = 13;
            this.CheckTextFileAlbumListButton.Text = "Album list from text file...";
            this.CheckTextFileAlbumListButton.UseVisualStyleBackColor = true;
            this.CheckTextFileAlbumListButton.Click += new System.EventHandler(this.CheckTextFileAlbumListButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 531);
            this.Controls.Add(this.CheckTextFileAlbumListButton);
            this.Controls.Add(this.ClearListButton);
            this.Controls.Add(this.CopyListButton);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.ScanButton);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.MusicDirectory);
            this.Controls.Add(this.labelMusicDirectory);
            this.Name = "MainForm";
            this.Text = "WhatUnavailableAlbums: What can I upload?";
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMusicDirectory;
        private System.Windows.Forms.TextBox MusicDirectory;
        private System.Windows.Forms.Button BrowseButton;
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
        private System.Windows.Forms.Button CheckTextFileAlbumListButton;


    }
}

