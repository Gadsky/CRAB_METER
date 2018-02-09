using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ELO {
    public partial class MainForm : Form {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        EVELogManager logManager = new EVELogManager();

        public MainForm() {
            InitializeComponent();
        }

        private void OnCloseLClick(object sender, EventArgs e) {
            Close();
        }

        private void OnFormMouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        bool empty = true;

        private void OnTimerTick(object sender, EventArgs e) {
            var chars = logManager.Characters;

            if (chars.Count == 0) return;

            if (chars.Count != flowLayoutPanel1.Controls.Count || empty) {
                flowLayoutPanel1.Controls.Clear();

                foreach (var c in chars) {
                    if (c.Value.Control == null) {
                        c.Value.Control = new StatsControl(c.Value);
                    }
                    flowLayoutPanel1.Controls.Add(c.Value.Control);
                }

                empty = false;

            }
        }


    }
}


