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
    public partial class frmHistory : Form
    {
        public int stt = -1;
        public DataTable dt;
        public frmHistory()
        {
            InitializeComponent();
        }

        private void Home_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void frmHistory_Load(object sender, EventArgs e)
        {
            DisplayMovie();
        }

        private void DisplayMovie()
        {
            int rows = dt.Rows.Count;
            for (int i = 0; i < rows; i++)
            {
                int ifviewed = Convert.ToInt32(dt.Rows[i]["Viewed"]);
                if (ifviewed == 1)
                {
                    MovieList.Items.Add(dt.Rows[i]["TenTA"].ToString(), Convert.ToInt32(dt.Rows[i]["STT"]));
                }
            }
            MovieList.LargeImageList = imageList1;
            MovieList.View = View.LargeIcon;
        }

        private void MovieList_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        { 
            string ss = "TenTA='" + e.Item.Text + "'";
            DataRow[] dr = dt.Select(ss);
            int stt = Convert.ToInt32(dr[0]["STT"]);
            pic_mvimage.BackgroundImage = Image.FromFile(dt.Rows[stt]["LinkImage"].ToString());
            lb_moviename.Text = dt.Rows[stt]["TenTA"].ToString();
            lb_thoiluong.Text = "Thời gian xem:";
            lb_rate.Text = "Your Rate:";
            lb_thoidiem.Text = "Xem gần nhất:";
            lb_lanxem.Text = "Lần xem:";
            string time = dt.Rows[stt]["Time"].ToString();
            tb_time_value.Text = dt.Rows[stt]["Time"].ToString();
            tb_thoidiem_value.Text = dt.Rows[stt]["ThoiDiem"].ToString();
            tb_lanxem_value.Text = dt.Rows[stt]["Lanxem"].ToString();
            updateStar(Convert.ToInt32(dt.Rows[stt]["Rate"].ToString()));
        }


        private void MovieList_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = MovieList.GetItemAt(e.X, e.Y);
            string ss = "TenTA='" + item.Text + "'";
            DataRow[] dr = dt.Select(ss);
            stt = Convert.ToInt32(dr[0]["STT"]);
            this.Close();
        }

        public void updateStar(int number)
        {
            if(number == -1)
            {
                off_star1.Hide();
                off_star2.Hide();
                off_star3.Hide();
                off_star4.Hide();
                off_star5.Hide();
                on_star1.Hide();
                on_star2.Hide();
                on_star3.Hide();
                on_star4.Hide();
                on_star5.Hide();
            }
            else
            {
                off_star1.Show();
                off_star2.Show();
                off_star3.Show();
                off_star4.Show();
                off_star5.Show();
                on_star1.Show();
                on_star2.Show();
                on_star3.Show();
                on_star4.Show();
                on_star5.Show();
            }
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
    }
}
