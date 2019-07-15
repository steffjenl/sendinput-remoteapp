using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoteAppClient
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenPopupScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Popup popup = new Popup();
            if (popup.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(popup.inputMessage, "Message");
            }
        }
    }
}
