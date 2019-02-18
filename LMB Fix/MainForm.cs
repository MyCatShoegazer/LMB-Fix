﻿using LMB_Fix.GlobalHooks;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace LMB_Fix
{
    public partial class MainForm : Form
    {
        private MouseHook _mouseHook;

        private bool _unsavedSettings;

        public MainForm()
        {
            InitializeComponent();
        }

        private void _mouseHook_RightButtonUp(MouseHook.MSLLHOOKSTRUCT mouseStruct)
        {
            if (rightButtonFixCheckBox.Checked)
            {
                historyRichTextBox.AppendText($"RMB Up: {DateTime.Now.Second}s:{DateTime.Now.Millisecond}ms\n");
            }
        }

        private void _mouseHook_RightButtonDown(MouseHook.MSLLHOOKSTRUCT mouseStruct)
        {
            if (rightButtonFixCheckBox.Checked)
            {
                historyRichTextBox.AppendText($"RMB Down: {DateTime.Now.Second}s:{DateTime.Now.Millisecond}ms\n");
                NativeSupport.BlockInput(new TimeSpan(0, 0, 0, 0, rightButtonTrackBar.Value));
            }
        }

        private void _mouseHook_LeftButtonUp(MouseHook.MSLLHOOKSTRUCT mouseStruct)
        {
            if (leftButtonFixCheckBox.Checked)
            {
                historyRichTextBox.AppendText($"LMB Up: {DateTime.Now.Second}s:{DateTime.Now.Millisecond}ms\n");
            }
        }

        private void _mouseHook_LeftButtonDown(MouseHook.MSLLHOOKSTRUCT mouseStruct)
        {
            if (leftButtonFixCheckBox.Checked)
            {
                historyRichTextBox.AppendText($"LMB Down: {DateTime.Now.Second}s:{DateTime.Now.Millisecond}ms\n");
                NativeSupport.BlockInput(new TimeSpan(0, 0, 0, 0, leftButtonTrackBar.Value));
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            new Ui.Dialogs.Etc.AboutDialog().ShowDialog(this);
        }

        private void leftButtonTrackBar_ValueChanged(object sender, EventArgs e)
        {
            TrackBar trackBar = sender as TrackBar;
            leftButtonLabel.Text = $"{trackBar.Value}ms";
        }

        private void rightButtonTrackBar_ValueChanged(object sender, EventArgs e)
        {
            TrackBar trackBar = sender as TrackBar;
            rightButtonLabel.Text = $"{trackBar.Value}ms";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.PropertyChanged += Default_PropertyChanged;

            _mouseHook = new MouseHook();
            _mouseHook.LeftButtonDown += _mouseHook_LeftButtonDown;
            _mouseHook.LeftButtonUp += _mouseHook_LeftButtonUp;
            _mouseHook.RightButtonDown += _mouseHook_RightButtonDown;
            _mouseHook.RightButtonUp += _mouseHook_RightButtonUp;
            _mouseHook.Install();

            leftButtonTrackBar.Value = Properties.Settings.Default.LeftButtonDelay;
            rightButtonTrackBar.Value = Properties.Settings.Default.RightButtonDelay;
        }

        private void Default_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            _unsavedSettings = true;
        }

        private void leftButtonFixCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            leftButtonTrackBar.Enabled = checkBox.Checked;
        }

        private void rightButtonFixCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            rightButtonTrackBar.Enabled = checkBox.Checked;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mouseHook.Uninstall();

            if (_unsavedSettings)
            {
                if (
                    MessageBox.Show(
                        "Application settings were changed after last time. Do you want to save theme before exit?",
                        "Unsaved settings",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                        ) == DialogResult.Yes)
                {
                    SaveSettings();
                }
            }
        }

        private void SaveSettings()
        {
            try
            {
                Properties.Settings.Default.LeftButtonFixEnabled = leftButtonFixCheckBox.Checked;
                Properties.Settings.Default.LeftButtonDelay = leftButtonTrackBar.Value;
                Properties.Settings.Default.RightButtonFixEnabled = rightButtonFixCheckBox.Checked;
                Properties.Settings.Default.RightButtonDelay = rightButtonTrackBar.Value;
                Properties.Settings.Default.Save();
            }
            catch(Exception)
            {
                MessageBox.Show(
                    "Please, contact to your system administrator or try again later.",
                    "Can't save application settings!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveSettings();
            _unsavedSettings = false;
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void leftButtonFixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.leftButtonFixCheckBox.Checked = !this.leftButtonFixCheckBox.Checked;
        }

        private void rightButtonFixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.rightButtonFixCheckBox.Checked = !this.rightButtonFixCheckBox.Checked;
        }
    }
}
