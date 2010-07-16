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

            AlbumSourceComboBox.SelectedIndex = 0;
        }

        private void Log(string message)
        {
            LogBox.Text += "[" + DateTime.Now.ToString() + "] " + message + Environment.NewLine;
            LogBox.SelectionStart = LogBox.Text.Length - 1;
            LogBox.ScrollToCaret();
        }

        private void ScanButton_Click(object sender, EventArgs e)
        {
            if (AlbumSourceComboBox.SelectedIndex == 0) // Directory structure
                ScanWithDirectoryStructure();
            else if (AlbumSourceComboBox.SelectedIndex == 1) // Text file
                ScanWithTextFile();    
        }

        private void ScanWithDirectoryStructure()
        {
            string music_directory;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                music_directory = fbd.SelectedPath;
            }
            else
            {
                return;
            }

            try
            {
                Log("Scanning");
                if (!WhatHelper.LoggedIn)
                {
                    Log("Logging in...");
                    WhatHelper.Login(Username.Text, Password.Text);
                }
                
                foreach (string artistPath in System.IO.Directory.GetDirectories(music_directory))
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
                
                Log("Finished");
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

        private void ScanWithTextFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Log("Reading file");
                    System.IO.StreamReader sr = new System.IO.StreamReader(ofd.FileName);
                    string[] data = sr.ReadToEnd().Split('\n');
                    sr.Close();

                    if (!WhatHelper.LoggedIn)
                    {
                        Log("Logging in...");
                        WhatHelper.Login(Username.Text, Password.Text);
                    }

                    foreach (string line in data)
                    {
                        Application.DoEvents();

                        string[] parts = line.Split('\\');
                        if (parts.Length != 2)
                        {
                            Log("Invalid format of line, skipping: \"" + line + "\"");
                            continue;
                        }

                        Album album = new Album(parts[0], parts[1]);

                        Log("Checking for " + album.ToString());
                        if (!WhatHelper.AlbumIsAvailable(album))
                            albumBindingSource.Add(album);
                    }
                    Log("Finished");
                }
                catch (Exception ex)
                {
                    Log(ex.GetType().ToString() + ": " + ex.Message);
                }
            }
        }
    }
}
