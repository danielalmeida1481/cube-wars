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
    public partial class frm_mainmenu : Form
    {
        public frm_mainmenu()
        {
            InitializeComponent();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            frm_main frm_main = new frm_main();
            frm_main.Show();
            Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            frm_help frm_help = new frm_help();
            frm_help.Show();
        }

        private void frm_mainmenu_Load(object sender, EventArgs e)
        {
            lbl_gname.Location = new Point(Width - ((Width / 2) + (lbl_gname.Width / 2)), 15);
        }
    }
}
