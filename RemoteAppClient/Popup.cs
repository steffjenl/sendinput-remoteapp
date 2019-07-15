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
    public partial class Popup : Form
    {
        public string inputMessage = null;

        public Popup()
        {
            InitializeComponent();
        }

        private void Popup_Shown(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            inputMessage = textBox1.Text;
        }
    }
}
