using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Final_Project
{
    public partial class frmUpdates : Form
    {
        public frmUpdates()
        {
            InitializeComponent();
            webJS.Navigate(Path.Combine(Application.StartupPath, "index.php"));
        }

        private void frmUpdates_Load(object sender, EventArgs e)
        {

        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
        }
    }
}
