using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AutoMouseClicker
{
    public partial class Form1 : Form
    {

        private int prevX = 0;
        private int prevY = 0;

        public Form1()
        {
            InitializeComponent();
            Text = Application.ProductName;
            updateState();
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                prevX = Cursor.Position.X;
                prevY = Cursor.Position.Y;
            }
            timer1.Enabled = !timer1.Enabled;
            updateState();
        }

        private void updateState()
        {
            lblStatus.Text = timer1.Enabled ? "Running." : "Ready.";
            btnStartStop.Text = timer1.Enabled ? "&Stop" : "&Start";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = Cursor.Position.X;
            int y = Cursor.Position.Y;
            bool moved = x != prevX || y != prevY;
            prevX = x;
            prevY = y;

            if (moved && chkPauseOnMotion.Checked)
            {
                lblStatus.Text = "Skipping due to motion.";
                return;
            }
            
            lblStatus.Text = "Clicking...";

            x = Cursor.Position.X;
            y = Cursor.Position.Y;

            if (rbLeftButton.Checked)
            {
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)x, (uint)y, 0, 0);
            }
            else if (rbRightButton.Checked)
            {
                mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, (uint)x, (uint)y, 0, 0);
            }
        }

        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

    }
}
