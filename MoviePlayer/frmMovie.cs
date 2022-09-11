using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelApp = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace MoviePlayer
{
    public partial class frmMovie : Form
    {
        ExcelApp.Application excelApp = new ExcelApp.Application();
        public DataTable dt;
        public DataRow dr;

        public frmMovie(bool flag = true)
        {
            InitializeComponent();

            if (flag)
            {
                initialData();
            }
        }

        private void initialData()
        {
            dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("TenTA", typeof(string));
            dt.Columns.Add("TheLoai", typeof(string));
            dt.Columns.Add("Thoiluong", typeof(string));
            dt.Columns.Add("DVChinh", typeof(string));
            dt.Columns.Add("TomTat", typeof(string));
            dt.Columns.Add("Like", typeof(int));
            dt.Columns.Add("View", typeof(int));
            dt.Columns.Add("LinkImage", typeof(string));
            dt.Columns.Add("LinkVideo", typeof(string));

            //for history part
            dt.Columns.Add("Viewed", typeof(int));
            dt.Columns.Add("Rate", typeof(int));
            dt.Columns.Add("Time", typeof(string));
            dt.Columns.Add("DB_Time", typeof(double));
            dt.Columns.Add("ThoiDiem", typeof(string));
            dt.Columns.Add("Lanxem", typeof(int));
            //

            ExcelApp.Workbook excelBook = excelApp.Workbooks.Open(@"C:\Users\HP\Desktop\C#\MoviePlayer\moviedata1.xlsx");
            ExcelApp._Worksheet excelSheet = excelBook.Sheets[1];
            ExcelApp.Range excelRange = excelSheet.UsedRange;

            int rows = excelRange.Rows.Count;
            int cols = excelRange.Columns.Count;
            // import data
            for (int i = 2; i <= rows; i++)
            {
                dr = dt.NewRow();
                dr["STT"] = Convert.ToInt32(excelRange.Cells[i, 1].Value2.ToString());
                dr["TenTA"] = excelRange.Cells[i, 2].Value2.ToString();
                dr["TheLoai"] = excelRange.Cells[i, 3].Value2.ToString();
                dr["Thoiluong"] = excelRange.Cells[i, 4].Value2.ToString();
                dr["DVChinh"] = excelRange.Cells[i, 5].Value2.ToString();
                dr["TomTat"] = excelRange.Cells[i, 6].Value2.ToString();
                dr["Like"] = Convert.ToInt32(excelRange.Cells[i, 7].Value2.ToString());
                dr["View"] = Convert.ToInt32(excelRange.Cells[i, 8].Value2.ToString());
                dr["LinkImage"] = excelRange.Cells[i, 9].Value2.ToString();
                dr["LinkVideo"] = excelRange.Cells[i, 10].Value2.ToString();
                dr["Viewed"] = 0;
                dr["Rate"] = 0;
                dt.Rows.Add(dr);
            }

            excelApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
        }

        private void frmMovie_Load(object sender, EventArgs e)
        {
            DisplayMovie();
        }

        private void DisplayMovie(int stt = -1)
        {
           
            int rows = dt.Rows.Count;
            for (int i = 0; i < rows; i++)
            {
                MovieList.Items.Add(dt.Rows[i]["TenTA"].ToString(), Convert.ToInt32(dt.Rows[i]["STT"]));
            }
            MovieList.LargeImageList = imageList1;
            MovieList.View = View.LargeIcon;
        }

        private void MovieList_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            
            ListViewItem item = MovieList.GetItemAt(e.X, e.Y);
            int stt = item.Index;
            Show_Movie_InFo(stt);
            this.Show();
        }

        private void Show_Movie_InFo(int stt)
        {
            string ten = dt.Rows[stt]["TenTA"].ToString();
            string thoiluong = dt.Rows[stt]["ThoiLuong"].ToString();
            string theloai = dt.Rows[stt]["TheLoai"].ToString();
            string dv = dt.Rows[stt]["DVChinh"].ToString();
            string likenumber = dt.Rows[stt]["Like"].ToString();
            string viewnumber = dt.Rows[stt]["View"].ToString();
            string tomtat = dt.Rows[stt]["TomTat"].ToString();
            string linkimage = dt.Rows[stt]["LinkImage"].ToString();
            string linkVideo = dt.Rows[stt]["LinkVideo"].ToString();


            frmInfo inFo = new frmInfo(linkimage, linkVideo);
            inFo.Text = ten;
            inFo.lb_moviename.Text = ten;
            inFo.lb_thoiluong_value.Text = thoiluong;
            inFo.lb_theloai_value.Text = theloai;
            inFo.lb_dv_value.Text = dv;
            inFo.lb_likenumber.Text = likenumber;
            inFo.lb_viewnumber.Text = viewnumber;
            inFo.lb_tomtat.Text = tomtat;
            inFo.Size = this.Size;
            inFo.dt = this.dt;
            inFo.updateStar(Convert.ToInt32(dt.Rows[stt]["Rate"].ToString()));

            inFo.ShowDialog();
        }

        private void MovieList_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            string ss = "TenTA='" + e.Item.Text + "'";
            DataRow[] dr = dt.Select(ss);
            int stt = Convert.ToInt32(dr[0]["STT"]); pic_mvimage.BackgroundImage = Image.FromFile(dt.Rows[stt]["LinkImage"].ToString());
            lb_moviename.Text = dt.Rows[stt]["TenTA"].ToString();
            lb_Thoiluong.Text = "Thời Lượng:";
            tb_thoiluong_value.Text = dt.Rows[stt]["Thoiluong"].ToString();
            lb_theloai.Text = "Thể Loại:";
            tb_theloai_value.Text = dt.Rows[stt]["TheLoai"].ToString();
            lb_dienvien.Text = "Diễn Viên";
            tb_dv_value.Text = dt.Rows[stt]["DVChinh"].ToString();

        }

        private void History_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            frmHistory h = new frmHistory();
            h.dt = this.dt;
            h.Size = this.Size;
            h.StartPosition = this.StartPosition;
            h.updateStar(-1);
            h.ShowDialog();
            int num = h.stt;
            h.Close();
            if(num != -1)
            {
                Show_Movie_InFo(num);
            }
            this.Show();
        }

        
        private void search(string text, string col)
        {
            MovieList.Items.Clear();
            string ss = col + "='" + text + "'";
            List<int> stt = new List<int>();
            foreach(DataRow dr in dt.Rows)
            {
                if (dr[col].ToString().Contains(text)) 
                { 
                    stt.Add(Convert.ToInt32(dr["STT"].ToString())); 
                }
            }
            //DataRow[] dr = dt.Rows.Cast<DataRow>().Any(r => r.ItemArray.Any(c => c.ToString().Contains(text)));
            foreach( int s in stt)
            {
                MovieList.Items.Add(dt.Rows[s]["TenTA"].ToString(), Convert.ToInt32(dt.Rows[s]["STT"]));
            }
            if (stt.Count() == 0)
            {
                MovieList.Items.Add("Không có kết quả tìm kiếm", 10);
            }
            MovieList.LargeImageList = imageList1;
            MovieList.View = View.LargeIcon;
        }

        private void comb_theloai_SelectedValueChanged(object sender, EventArgs e)
        {
            string theloai = comb_theloai.SelectedItem.ToString();
            search(theloai, "TheLoai");
        }

        private void tb_finder_TextChanged(object sender, EventArgs e)
        {
            search(tb_finder.Text, "TenTA");
        }
    }

}
