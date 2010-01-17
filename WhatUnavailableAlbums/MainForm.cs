using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WhatUnavailableAlbums
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Log(string message)
        {
            LogBox.Text += "[" + DateTime.Now.ToString() + "] " + message + Environment.NewLine;
            LogBox.SelectionStart = LogBox.Text.Length - 1;
            LogBox.ScrollToCaret();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                MusicDirectory.Text = fbd.SelectedPath;
            }
        }

        private void ScanButton_Click(object sender, EventArgs e)
        {
            try
            {
                Log("Logging in...");
                WhatHelper.Login(Username.Text, Password.Text);
                

                foreach (string artistPath in System.IO.Directory.GetDirectories(MusicDirectory.Text))
                {
                    foreach (string albumName in System.IO.Directory.GetDirectories(artistPath))
                    {
                        Application.DoEvents();

                        Album album = new Album(System.IO.Path.GetFileName(artistPath), System.IO.Path.GetFileName(albumName));
                        Log("Checking for " + album.ToString());
                        if (!WhatHelper.AlbumIsAvailable(album))
                            albumBindingSource.Add(album);
                    }
                }
            }
            catch (Exception ex)
            {
                Log(ex.GetType().ToString() + ": " + ex.Message);
            }
        }

        private void CopyListButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Album album in albumBindingSource)
            {
                sb.AppendLine(album.ToString());
            }
            Clipboard.SetText(sb.ToString());
            Log("Album list copied to clipboard");
        }

        private void ClearListButton_Click(object sender, EventArgs e)
        {
            albumBindingSource.Clear();
            Log("Album list cleared");
        }
    }
}
