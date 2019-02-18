﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using LMB_Fix.GlobalHooks;

namespace LMB_Fix
{
    public partial class MainForm : Form
    {
        private MouseHook _mouseHook;

        public MainForm()
        {
            InitializeComponent();

            this._mouseHook = new MouseHook();
            this._mouseHook.LeftButtonDown += _mouseHook_LeftButtonDown;
            this._mouseHook.LeftButtonUp += _mouseHook_LeftButtonUp;
            this._mouseHook.RightButtonDown += _mouseHook_RightButtonDown;
            this._mouseHook.RightButtonUp += _mouseHook_RightButtonUp;
            this._mouseHook.Install();
        }

        private void _mouseHook_RightButtonUp(MouseHook.MSLLHOOKSTRUCT mouseStruct)
        {
            this.historyRichTextBox.AppendText($"RMB Up: {DateTime.Now.Second}s:{DateTime.Now.Millisecond}ms\n");
        }

        private void _mouseHook_RightButtonDown(MouseHook.MSLLHOOKSTRUCT mouseStruct)
        {
            this.historyRichTextBox.AppendText($"RMB Down: {DateTime.Now.Second}s:{DateTime.Now.Millisecond}ms\n");
            NativeSupport.BlockInput(new TimeSpan(0, 0, 0, 0, this.rightButtonTrackBar.Value));
        }

        private void _mouseHook_LeftButtonUp(MouseHook.MSLLHOOKSTRUCT mouseStruct)
        {
            this.historyRichTextBox.AppendText($"LMB Up: {DateTime.Now.Second}s:{DateTime.Now.Millisecond}ms\n");
        }

        private void _mouseHook_LeftButtonDown(MouseHook.MSLLHOOKSTRUCT mouseStruct)
        {
            this.historyRichTextBox.AppendText($"LMB Down: {DateTime.Now.Second}s:{DateTime.Now.Millisecond}ms\n");
            NativeSupport.BlockInput(new TimeSpan(0, 0, 0, 0, this.leftButtonTrackBar.Value));
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.Hide();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            new Ui.Dialogs.Etc.AboutDialog().ShowDialog(this);
        }

        private void leftButtonTrackBar_ValueChanged(object sender, EventArgs e)
        {
            var trackBar = sender as TrackBar;
            this.leftButtonLabel.Text = $"{trackBar.Value}ms";
        }

        private void rightButtonTrackBar_ValueChanged(object sender, EventArgs e)
        {
            var trackBar = sender as TrackBar;
            this.rightButtonLabel.Text = $"{trackBar.Value}ms";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.leftButtonTrackBar.Value = Properties.Settings.Default.LeftButtonDelay;
            this.rightButtonTrackBar.Value = Properties.Settings.Default.RightButtonDelay;
        }

        private void leftButtonFixCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = sender as CheckBox;
            this.leftButtonTrackBar.Enabled = checkBox.Checked;
        }

        private void rightButtonFixCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = sender as CheckBox;
            this.rightButtonTrackBar.Enabled = checkBox.Checked;
        }
    }
}
