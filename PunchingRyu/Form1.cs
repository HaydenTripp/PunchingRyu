using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PunchingRyu
{
    public partial class frmRyu : Form
    {
        public frmRyu()
        {
            InitializeComponent();
        }

        private void punchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pictureRyu.Image = Properties.Resources.punch;
        }

        private void standToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pictureRyu.Image = Properties.Resources.stand;
        }
    }
}
