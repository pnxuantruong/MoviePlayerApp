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
    public partial class frmInfo : Form
    {
        private string linkImage, linkVideo;
        private bool check = false;
        private int numberStar = 0;
        public DataTable dt;
        

        public frmInfo(string linkimage,string linkvideo )
        {
            InitializeComponent();
            linkImage = linkimage;
            linkVideo = linkvideo;
            pictureBox1.BackgroundImage = Image.FromFile(linkImage);
        }

        private void Play_Click(object sender, EventArgs e)
        {
            lb_viewnumber.Text = (Convert.ToInt32(lb_viewnumber.Text)+1).ToString();
            frmShow show = new frmShow(linkVideo);
            show.Text = this.Text;
            show.StartPosition = this.StartPosition;
            show.Size = this.Size;

            string ss = "TenTA='" + this.Text + "'";
            DataRow[] dr = dt.Select(ss);
            int stt = Convert.ToInt32(dr[0]["STT"]);
            dt.Rows[stt]["View"] = Convert.ToInt32(lb_viewnumber.Text);
            int ifviewed = Convert.ToInt32(dt.Rows[stt]["Viewed"]);
            if (ifviewed == 1)
            {
                show.db_time = Convert.ToDouble(dt.Rows[stt]["DB_Time"]);
                dt.Rows[stt]["Lanxem"] = Convert.ToInt32(dt.Rows[stt]["Lanxem"]) + 1;
            }
            else
            {
                dt.Rows[stt]["Viewed"] = 1;
                dt.Rows[stt]["Lanxem"] = 1;
            }

            show.ShowDialog();
    
            dt.Rows[stt]["Time"] = show.time;
            dt.Rows[stt]["DB_Time"] = show.db_time;
            dt.Rows[stt]["ThoiDiem"] = DateTime.Now.ToString();
        }

        private void pic_like_Click(object sender, EventArgs e)
        {
            int val = Convert.ToInt32(lb_likenumber.Text);
            if (!check)
            {
                val += 1;
                lb_likenumber.Text = (val).ToString();
                check = true;
            }
            else
            {
                val -= 1;
                lb_likenumber.Text = (val).ToString();
                check = false;
            }
            string ss = "TenTA='" + this.Text+ "'";
            DataRow[] dr = dt.Select(ss);
            int stt = Convert.ToInt32(dr[0]["STT"]);
            dt.Rows[stt]["Like"] = val;
        }

        

        public void updateStar(int number)
        {
            numberStar = number;
            switch (number)
             {
                case 0:
                    off_star1.BringToFront();
                    off_star2.BringToFront();
                    off_star3.BringToFront();
                    off_star4.BringToFront();
                    off_star5.BringToFront();
                    break;
                case 1:
                    on_star1.BringToFront();
                    off_star2.BringToFront();
                    off_star3.BringToFront();
                    off_star4.BringToFront();
                    off_star5.BringToFront();
                    break;
                case 2:
                    on_star1.BringToFront();
                    on_star2.BringToFront();
                    off_star3.BringToFront();
                    off_star4.BringToFront();
                    off_star5.BringToFront();
                    break;
                case 3:
                    on_star1.BringToFront();
                    on_star2.BringToFront();
                    on_star3.BringToFront();
                    off_star4.BringToFront();
                    off_star5.BringToFront();
                    break;
                case 4:
                    on_star1.BringToFront();
                    on_star2.BringToFront();
                    on_star3.BringToFront();
                    on_star4.BringToFront();
                    off_star5.BringToFront();
                    break;
                case 5:
                    on_star1.BringToFront();
                    on_star2.BringToFront();
                    on_star3.BringToFront();
                    on_star4.BringToFront();
                    on_star5.BringToFront();
                    break;
            }

        }

        private void on_star1_MouseClick(object sender, MouseEventArgs e)
        {
            updateStar(0);
        }

        private void on_star2_Click(object sender, EventArgs e)
        {
            updateStar(1);
        }

        private void on_star3_Click(object sender, EventArgs e)
        {
            updateStar(2);
        }

        private void on_star4_Click(object sender, EventArgs e)
        {
            updateStar(3);
        }

        private void on_star5_Click(object sender, EventArgs e)
        {
            updateStar(4);
        }

        private void off_star1_Click(object sender, EventArgs e)
        {
            updateStar(1);
        }

        private void off_star2_Click(object sender, EventArgs e)
        {
            updateStar(2);
        }

        private void off_star3_Click(object sender, EventArgs e)
        {
            updateStar(3);
        }

        private void off_star4_Click(object sender, EventArgs e)
        {
            updateStar(4);
        }

        private void off_star5_Click(object sender, EventArgs e)
        {
            updateStar(5);
        }

        private void Home_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string ss = "TenTA='" + this.Text + "'";
            DataRow[] dr = dt.Select(ss);
            int stt = Convert.ToInt32(dr[0]["STT"]);
            dt.Rows[stt]["Rate"] = numberStar;
            this.Close();
        }
        
    }
}
