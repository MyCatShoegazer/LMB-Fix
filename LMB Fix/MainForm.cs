using LMB_Fix.GlobalHooks;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.Win32;

namespace LMB_Fix
{
    /// <summary>
    ///     A main application form.
    /// </summary>
    public partial class MainForm : Form
    {
        private MouseHook _mouseHook;       // An object providing low level global mouse hooks

        private bool _unsavedSettings;      // Flag for tracking unsaved settings

        /// <summary>
        ///     A constructor for <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Rises when user released right mouse button.
        /// </summary>
        /// <param name="mouseStruct">Low level event arguments from WinAPI.</param>
        private void _mouseHook_RightButtonUp(MouseHook.MSLLHOOKSTRUCT mouseStruct)
        {
            /*
             *  If user enabled right mouse button fix then
             *  doing following code.
             */
            if (rightButtonFixCheckBox.Checked)
            {
                /*
                 *  Here we printing second and millisecond
                 *  when user released right mouse button.
                 */
                historyRichTextBox.AppendText($"RMB Up: {DateTime.Now.Second}s:{DateTime.Now.Millisecond}ms\n");
            }
        }

        /// <summary>
        ///     Rises when user pressed right mouse button.
        /// </summary>
        /// <param name="mouseStruct">Low level event arguments from WinAPI.</param>
        private void _mouseHook_RightButtonDown(MouseHook.MSLLHOOKSTRUCT mouseStruct)
        {
            /*
             *  If user enabled right mouse button fix then
             *  doing following code.
             */
            if (rightButtonFixCheckBox.Checked)
            {
                /*
                 *  Printing second and millisecond when user pressed
                 *  right mouse button. Then blocking global system
                 *  input for delay given from trackbar.
                 */
                historyRichTextBox.AppendText($"RMB Down: {DateTime.Now.Second}s:{DateTime.Now.Millisecond}ms\n");
                NativeSupport.BlockInput(new TimeSpan(0, 0, 0, 0, rightButtonTrackBar.Value));
            }
        }

        /// <summary>
        ///     Rises when user released left mouse button.
        /// </summary>
        /// <param name="mouseStruct">Low level event arguments from WinAPI.</param>
        private void _mouseHook_LeftButtonUp(MouseHook.MSLLHOOKSTRUCT mouseStruct)
        {
            /*
             *  If user enabled left mouse button fix then
             *  doing following code.
             */
            if (leftButtonFixCheckBox.Checked)
            {
                /*
                 *  Printing second and millisecond when user released
                 *  left mouse button.
                 */
                historyRichTextBox.AppendText($"LMB Up: {DateTime.Now.Second}s:{DateTime.Now.Millisecond}ms\n");
            }
        }

        /// <summary>
        ///     Rises when user pressed left mouse button.
        /// </summary>
        /// <param name="mouseStruct">Low level event arguments from WinAPI.</param>
        private void _mouseHook_LeftButtonDown(MouseHook.MSLLHOOKSTRUCT mouseStruct)
        {
            /*
             *  If user enabled left mouse fix then
             *  doing following code.
             */
            if (leftButtonFixCheckBox.Checked)
            {
                /*
                 *  Printing second and millisecond when user pressed
                 *  left mouse button. Then blocking global system
                 *  input for delay given from trackbar.
                 */
                historyRichTextBox.AppendText($"LMB Down: {DateTime.Now.Second}s:{DateTime.Now.Millisecond}ms\n");
                NativeSupport.BlockInput(new TimeSpan(0, 0, 0, 0, leftButtonTrackBar.Value));
            }
        }

        /// <summary>
        ///     Rises when main form changed its size.
        /// </summary>
        /// <param name="sender"><see cref="MainForm"/> object.</param>
        /// <param name="e">General event arguments.</param>
        private void MainForm_Resize(object sender, EventArgs e)
        {
            /*
             *  If user pressed minimize button in window
             *  then after minimizing will hide it.
             */
            if (WindowState == FormWindowState.Minimized)
                Hide();
        }

        /// <summary>
        ///     Rises when user double clicking on
        ///     notify icon in system tray.
        /// </summary>
        /// <param name="sender"><see cref="NotifyIcon"/> object.</param>
        /// <param name="e">This event arguments.</param>
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            /*
             *  Show current window and
             *  set window state to normal.
             */
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        /// <summary>
        ///     Rises when user pressing exit
        ///     button on main form.
        /// </summary>
        /// <param name="sender"><see cref="Button"/> object.</param>
        /// <param name="e">General event arguments.</param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        ///     Rises when user pressing close
        ///     button on main form.
        /// </summary>
        /// <param name="sender"><see cref="Button"/> object.</param>
        /// <param name="e">General event arguments.</param>
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        ///     Rises when user pressed about
        ///     button on main form.
        /// </summary>
        /// <param name="sender"><see cref="Button"/> object.</param>
        /// <param name="e">General event arguments.</param>
        private void aboutButton_Click(object sender, EventArgs e)
        {
            new Ui.Dialogs.Etc.AboutDialog().ShowDialog(this);
        }

        /// <summary>
        ///     Rises when user drags and changes
        ///     delay trackbar on main form.
        /// </summary>
        /// <param name="sender"><see cref="TrackBar"/> object.</param>
        /// <param name="e">General event arguments.</param>
        private void leftButtonTrackBar_ValueChanged(object sender, EventArgs e)
        {
            /*
             *  Taking value from trackbar and printing
             *  it to label on main form. Then passing its
             *  value to settings storage.
             */
            TrackBar trackBar = sender as TrackBar;
            leftButtonLabel.Text = $"{trackBar.Value}ms";
            Properties.Settings.Default.LeftButtonDelay = trackBar.Value;
        }
        /// <summary>
        ///     Rises when user drags and changes
        ///     delay tackbar on main form.
        /// </summary>
        /// <param name="sender"><see cref="TrackBar"/> object.</param>
        /// <param name="e">General event arguments.</param>
        private void rightButtonTrackBar_ValueChanged(object sender, EventArgs e)
        {
            /*
             *  Taking value from trackbar and printing
             *  it to label on main form. Then passing its
             *  value to settings storage.
             */
            TrackBar trackBar = sender as TrackBar;
            rightButtonLabel.Text = $"{trackBar.Value}ms";
            Properties.Settings.Default.RightButtonDelay = trackBar.Value;
        }

        /// <summary>
        ///     Rises when <see cref="MainForm"/> loads.
        /// </summary>
        /// <param name="sender"><see cref="MainForm"/> object.</param>
        /// <param name="e">General event arguments.</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            /*
             *  Registering low level mouse hooks with
             *  passing event handlers for it.
             */
            _mouseHook = new MouseHook();
            _mouseHook.LeftButtonDown += _mouseHook_LeftButtonDown;
            _mouseHook.LeftButtonUp += _mouseHook_LeftButtonUp;
            _mouseHook.RightButtonDown += _mouseHook_RightButtonDown;
            _mouseHook.RightButtonUp += _mouseHook_RightButtonUp;
            _mouseHook.Install();

            /*
             *  Registering events for left mouse button fix controls.
             */
            leftButtonFixCheckBox.Checked = Properties.Settings.Default.LeftButtonFixEnabled;
            leftButtonTrackBar.Value = Properties.Settings.Default.LeftButtonDelay;

            /*
             *  Registering events for right mouse button fix controls.
             */
            rightButtonFixCheckBox.Checked = Properties.Settings.Default.RightButtonFixEnabled;
            rightButtonTrackBar.Value = Properties.Settings.Default.RightButtonDelay;

            /*
             *  Checking in Windows registry if application execution path
             *  used in system startup.
             */
            var run = Registry.CurrentUser.OpenSubKey(Properties.Settings.Default.StartupRegistryPath, false).GetValue(Application.ProductName);
            if (run != null)
                runAtStartCheckBox.Checked = true;

            /*
             *  Registering event for changing start up checkbox.
             */
            runAtStartCheckBox.CheckedChanged += runAtStartCheckBox_CheckedChanged;

            /*
             *  Registering event for changed application settings.
             */
            Properties.Settings.Default.PropertyChanged += Default_PropertyChanged;
        }

        /// <summary>
        ///     Rises when one of the applicaiton
        ///     settings were changed.
        /// </summary>
        /// <param name="sender">Settings provider.</param>
        /// <param name="e">Changed property arguments.</param>
        private void Default_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            /*
             *  If we have one of the application settings
             *  changed then enabling unsaved settings flag.
             */
            _unsavedSettings = true;
        }

        /// <summary>
        ///     Rises when user enables left mouse button fix.
        /// </summary>
        /// <param name="sender"><see cref="CheckBox"/> object.</param>
        /// <param name="e">General event arguments.</param>
        private void leftButtonFixCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            /*
             *  Here we notifying user that state
             *  of left mouse button fix changed and saving
             *  it to application settings storage.
             */
            CheckBox checkBox = sender as CheckBox;
            leftButtonTrackBar.Enabled = checkBox.Checked;
            var tip = checkBox.Checked ? "enabled" : "disabled";
            this.notifyIcon.ShowBalloonTip(3000, "LMB Status", $"Left mouse button fix {tip}.", ToolTipIcon.Info);
            Properties.Settings.Default.LeftButtonFixEnabled = checkBox.Checked;
        }

        /// <summary>
        ///     Rises when user enables right mouse button fix.
        /// </summary>
        /// <param name="sender"><see cref="CheckBox"/> object.</param>
        /// <param name="e">General event arguments.</param>
        private void rightButtonFixCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            /*
             *  Here we notifying user that state
             *  of right mouse button fix changed and saving
             *  it to application settings storage.
             */
            CheckBox checkBox = sender as CheckBox;
            rightButtonTrackBar.Enabled = checkBox.Checked;
            var tip = checkBox.Checked ? "enabled" : "disabled";
            this.notifyIcon.ShowBalloonTip(3000, "LMB Status", $"Right mouse button fix {checkBox.Checked}.", ToolTipIcon.Info);
            Properties.Settings.Default.RightButtonFixEnabled = checkBox.Checked;
        }

        /// <summary>
        ///     Rises when <see cref="MainForm"/> closing.
        /// </summary>
        /// <param name="sender"><see cref="MainForm"/> object.</param>
        /// <param name="e">Form closing arguments.</param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
             *  We need to uninstall low level
             *  mouse hooks.
             */
            _mouseHook.Uninstall();

            /*
             *  If we have unsaved settings we will
             *  promt it to user.
             */
            if (_unsavedSettings)
            {
                if (
                    MessageBox.Show(
                        "Application settings were changed after last time. Do you want to save them before exit?",
                        "Unsaved settings",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                        ) == DialogResult.Yes)
                {
                    SaveSettings();
                }
            }
        }

        /*
         *  Saves application settings to settings storage.
         */
        private void SaveSettings()
        {
            /*
             *  Here we try save application settings
             *  and if we can't then showing error message.
             */
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

        /// <summary>
        ///     Rises when save button was pressed.
        /// </summary>
        /// <param name="sender"><see cref="Button"/> object.</param>
        /// <param name="e">General event arguments.</param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            /*
             *  Saving application settings and
             *  setting flag to false.
             */
            SaveSettings();
            _unsavedSettings = false;
        }

        /// <summary>
        ///     Rises when user pressed show button
        ///     in tool strip menu of notify icon.
        /// </summary>
        /// <param name="sender"><see cref="MenuItem"/> object.</param>
        /// <param name="e">General event arguments.</param>
        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             *  Showing application main form and setting
             *  its window state property to normal.
             */
            Show();
            WindowState = FormWindowState.Normal;
        }

        /// <summary>
        ///     Rises when user enables left mouse button fix
        ///     from tool strip menu of notify icon.
        /// </summary>
        /// <param name="sender"><see cref="MenuItem"/> object.</param>
        /// <param name="e">General event arguments.</param>
        private void leftButtonFixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.leftButtonFixCheckBox.Checked = !this.leftButtonFixCheckBox.Checked;
        }

        /// <summary>
        ///     Rises when user enables right mouse button fix
        ///     from tool strip menu of notify icon.
        /// </summary>
        /// <param name="sender"><see cref="MenuItem"/> object.</param>
        /// <param name="e">General event argumetns.</param>
        private void rightButtonFixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.rightButtonFixCheckBox.Checked = !this.rightButtonFixCheckBox.Checked;
        }

        /// <summary>
        ///     Rises when user checks run at startup
        ///     checkbox form main application form.
        /// </summary>
        /// <param name="sender"><see cref="CheckBox"/> object.</param>
        /// <param name="e">General event arguments.</param>
        private void runAtStartCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = sender as CheckBox;
            var regKey = Registry.CurrentUser.OpenSubKey(Properties.Settings.Default.StartupRegistryPath, true);

            if (checkbox.Checked)
                regKey.SetValue(Application.ProductName, Application.ExecutablePath);
            else
                regKey.DeleteValue(Application.ProductName, false);
        }
    }
}
