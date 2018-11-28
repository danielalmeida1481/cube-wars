using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M11_ProjectGame
{
    public partial class frm_winner : Form
    {
        string str_Message;

        public frm_winner(string str_MessageINC)
        {
            InitializeComponent();

            str_Message = str_MessageINC;
        }

        private void frm_winner_Load(object sender, EventArgs e)
        {
            lbl_message.Text = str_Message;
            lbl_message.Location = new Point(pnl_Screen.Width / 2 - lbl_message.Width / 2, pnl_Screen.Height / 2 - lbl_message.Height);

            if (str_Message.Contains("Player 1"))
            {
                pic_Body.BackColor = Color.Orange;
                pic_Head.Image = Properties.Resources.p1;
            }else if (str_Message.Contains("Player 2"))
            {
                pic_Body.BackColor = Color.Silver;
                pic_Head.Image = Properties.Resources.p2;
            }
        }

        private void btn_retry_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Retry;
        }

        private void btn_mainmenu_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
