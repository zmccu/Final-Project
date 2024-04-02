using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnUpdateReviews_Click(object sender, EventArgs e)
        {
            frmUpdates updates = new frmUpdates();
            updates.ShowDialog();
        }

        private void btnViewReviews_Click(object sender, EventArgs e)
        {
            frmReviews reviews = new frmReviews();
            reviews.ShowDialog();
        }
    }
}
