using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviePlayer
{
    public partial class frmShow : Form
    {
        public string time;
        public double db_time;
        public frmShow(string Link)
        {
            InitializeComponent();
            WMP_Show.URL = Link;
        }


        private void frmShow_FormClosed(object sender, FormClosedEventArgs e)
        {
            WMP_Show.close();
        }

        private void frmShow_FormClosing(object sender, FormClosingEventArgs e)
        {
            time = WMP_Show.Ctlcontrols.currentPositionString;
            db_time = WMP_Show.Ctlcontrols.currentPosition;
        }

        private void frmShow_Load(object sender, EventArgs e)
        {
            WMP_Show.Ctlcontrols.currentPosition = db_time;
        }
    }
}
