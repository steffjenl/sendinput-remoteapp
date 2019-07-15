using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;

namespace RemoteDesktopClient
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<IntPtr, string> window in OpenWindowGetter.GetOpenWindows())
            {
                IntPtr handle = window.Key;
                string title = window.Value;
                if (title.ToLower().Contains("remoteappclient"))
                {
                    WindowsAPI.SetForegroundWindow(handle);
                    WindowsAPI.SwitchWindow(handle);
                    Thread.Sleep(1000);
                    var sim = new InputSimulator();
                    sim.Keyboard
                        .ModifiedKeyStroke(new[] { VirtualKeyCode.LCONTROL, VirtualKeyCode.LSHIFT }, VirtualKeyCode.VK_O)
                        .Sleep(1000)
                        .TextEntry("test input")
                        .Sleep(1000)
                        .KeyPress(VirtualKeyCode.TAB)
                        .Sleep(1000)
                        .KeyPress(VirtualKeyCode.RETURN);
                }
            }
        }
    }
}
