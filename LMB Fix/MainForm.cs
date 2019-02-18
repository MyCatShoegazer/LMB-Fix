using System;
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
            this._mouseHook.Install();
        }

        private void _mouseHook_LeftButtonUp(MouseHook.MSLLHOOKSTRUCT mouseStruct)
        {
#if DEBUG
            Debug.WriteLine($"LMB Up: {DateTime.Now.Second}:{DateTime.Now.Millisecond}");
#endif
        }

        private void _mouseHook_LeftButtonDown(MouseHook.MSLLHOOKSTRUCT mouseStruct)
        {
#if DEBUG
            Debug.WriteLine($"LMB Down: {DateTime.Now.Second}:{DateTime.Now.Millisecond}");
#endif
            NativeSupport.BlockInput(new TimeSpan(0, 0, 0, 0, 20));
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
    }
}
