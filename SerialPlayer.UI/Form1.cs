using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialPlayer.UI
{
    public partial class Form1 : Form
    {

        public IPlayer Player { get; set; }
        public Form1()
        {
            InitializeComponent();
            Player = new SerialPlayer(SerialPlayer.Ports.FirstOrDefault());
            Player.Response += Player_Response;
        }

        private void Player_Response(object sender, PlayerResponseEventArgs e)
        {
            Debug.WriteLine(e.Text);
            SetTextBox(e.Text);
        }

        public void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }
            txtResp.Text += value+"\r\n";
        }

        public void SetTextBox(string value)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action<string>(SetTextBox), new object[] { value });
                return;
            }
            txtResp.Text = value + "\r\n";
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Player.Play();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            Player.Pause();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Player.Stop();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            Player.Prev();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            Player.Skip();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResp.Text = "";
        }
    }
}
