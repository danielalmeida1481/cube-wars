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
    public partial class frm_help : Form
    {
        public frm_help()
        {
            InitializeComponent();
        }

        private void frm_help_Load(object sender, EventArgs e)
        {
            lbl_GName.Location = new Point(Width - ((Width / 2) + (lbl_GName.Width / 2)), 15);
        }
    }
}
