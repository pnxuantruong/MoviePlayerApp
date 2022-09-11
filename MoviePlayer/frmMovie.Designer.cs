
namespace MoviePlayer
{
    partial class frmMovie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovie));
            this.MovieList = new System.Windows.Forms.ListView();
            this.History = new System.Windows.Forms.PictureBox();
            this.Home = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.grpb_thongtinphim = new System.Windows.Forms.GroupBox();
            this.tb_dv_value = new System.Windows.Forms.TextBox();
            this.tb_theloai_value = new System.Windows.Forms.TextBox();
            this.tb_thoiluong_value = new System.Windows.Forms.TextBox();
            this.lb_dienvien = new System.Windows.Forms.Label();
            this.lb_moviename = new System.Windows.Forms.Label();
            this.lb_Thoiluong = new System.Windows.Forms.Label();
            this.lb_theloai = new System.Windows.Forms.Label();
            this.pic_mvimage = new System.Windows.Forms.PictureBox();
            this.thongtinphim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comb_theloai = new System.Windows.Forms.ComboBox();
            this.lb_theloaicombobox = new System.Windows.Forms.Label();
            this.tb_finder = new System.Windows.Forms.TextBox();
            this.pic_finder = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.History)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).BeginInit();
            this.grpb_thongtinphim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mvimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_finder)).BeginInit();
            this.SuspendLayout();
            // 
            // MovieList
            // 
            this.MovieList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieList.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.MovieList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MovieList.ForeColor = System.Drawing.Color.Aqua;
            this.MovieList.HideSelection = false;
            this.MovieList.Location = new System.Drawing.Point(49, 116);
            this.MovieList.Name = "MovieList";
            this.MovieList.Size = new System.Drawing.Size(723, 437);
            this.MovieList.TabIndex = 0;
            this.MovieList.UseCompatibleStateImageBehavior = false;
            this.MovieList.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.MovieList_ItemMouseHover);
            this.MovieList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MovieList_MouseClick);
            // 
            // History
            // 
            this.History.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.History.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("History.BackgroundImage")));
            this.History.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.History.Location = new System.Drawing.Point(983, 12);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(45, 43);
            this.History.TabIndex = 1;
            this.History.TabStop = false;
            this.History.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.History_MouseDoubleClick);
            // 
            // Home
            // 
            this.Home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Home.BackgroundImage")));
            this.Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Home.Location = new System.Drawing.Point(12, 12);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(57, 52);
            this.Home.TabIndex = 2;
            this.Home.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "30chuatet.jpg");
            this.imageList1.Images.SetKeyName(1, "NhungKeHetThoi.jpg");
            this.imageList1.Images.SetKeyName(2, "2020_Godmothered.jpg");
            this.imageList1.Images.SetKeyName(3, "BoGia.jpg");
            this.imageList1.Images.SetKeyName(4, "Breach.jpg");
            this.imageList1.Images.SetKeyName(5, "NguoiCaBaoThu.jpg");
            this.imageList1.Images.SetKeyName(6, "cualaivobau.jpg");
            this.imageList1.Images.SetKeyName(7, "doimatAmDuong.jpg");
            this.imageList1.Images.SetKeyName(8, "Stream_2022.jpg");
            this.imageList1.Images.SetKeyName(9, "TrangTi.jpg");
            this.imageList1.Images.SetKeyName(10, "436171_trash_remove_logout_close_icon.png");
            // 
            // grpb_thongtinphim
            // 
            this.grpb_thongtinphim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpb_thongtinphim.Controls.Add(this.tb_dv_value);
            this.grpb_thongtinphim.Controls.Add(this.tb_theloai_value);
            this.grpb_thongtinphim.Controls.Add(this.tb_thoiluong_value);
            this.grpb_thongtinphim.Controls.Add(this.lb_dienvien);
            this.grpb_thongtinphim.Controls.Add(this.lb_moviename);
            this.grpb_thongtinphim.Controls.Add(this.lb_Thoiluong);
            this.grpb_thongtinphim.Controls.Add(this.lb_theloai);
            this.grpb_thongtinphim.Controls.Add(this.pic_mvimage);
            this.grpb_thongtinphim.Location = new System.Drawing.Point(789, 133);
            this.grpb_thongtinphim.Name = "grpb_thongtinphim";
            this.grpb_thongtinphim.Size = new System.Drawing.Size(224, 420);
            this.grpb_thongtinphim.TabIndex = 3;
            this.grpb_thongtinphim.TabStop = false;
            // 
            // tb_dv_value
            // 
            this.tb_dv_value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_dv_value.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_dv_value.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_dv_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dv_value.ForeColor = System.Drawing.Color.White;
            this.tb_dv_value.Location = new System.Drawing.Point(85, 352);
            this.tb_dv_value.Multiline = true;
            this.tb_dv_value.Name = "tb_dv_value";
            this.tb_dv_value.ReadOnly = true;
            this.tb_dv_value.Size = new System.Drawing.Size(133, 62);
            this.tb_dv_value.TabIndex = 7;
            // 
            // tb_theloai_value
            // 
            this.tb_theloai_value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_theloai_value.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_theloai_value.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_theloai_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_theloai_value.ForeColor = System.Drawing.Color.White;
            this.tb_theloai_value.Location = new System.Drawing.Point(75, 296);
            this.tb_theloai_value.Multiline = true;
            this.tb_theloai_value.Name = "tb_theloai_value";
            this.tb_theloai_value.ReadOnly = true;
            this.tb_theloai_value.Size = new System.Drawing.Size(123, 53);
            this.tb_theloai_value.TabIndex = 7;
            // 
            // tb_thoiluong_value
            // 
            this.tb_thoiluong_value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_thoiluong_value.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_thoiluong_value.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_thoiluong_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_thoiluong_value.ForeColor = System.Drawing.Color.White;
            this.tb_thoiluong_value.Location = new System.Drawing.Point(96, 260);
            this.tb_thoiluong_value.Name = "tb_thoiluong_value";
            this.tb_thoiluong_value.ReadOnly = true;
            this.tb_thoiluong_value.Size = new System.Drawing.Size(100, 16);
            this.tb_thoiluong_value.TabIndex = 7;
            // 
            // lb_dienvien
            // 
            this.lb_dienvien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_dienvien.AutoSize = true;
            this.lb_dienvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dienvien.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lb_dienvien.Location = new System.Drawing.Point(6, 352);
            this.lb_dienvien.Name = "lb_dienvien";
            this.lb_dienvien.Size = new System.Drawing.Size(0, 17);
            this.lb_dienvien.TabIndex = 6;
            // 
            // lb_moviename
            // 
            this.lb_moviename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_moviename.AutoEllipsis = true;
            this.lb_moviename.AutoSize = true;
            this.lb_moviename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_moviename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lb_moviename.Location = new System.Drawing.Point(82, 221);
            this.lb_moviename.Name = "lb_moviename";
            this.lb_moviename.Size = new System.Drawing.Size(0, 15);
            this.lb_moviename.TabIndex = 5;
            // 
            // lb_Thoiluong
            // 
            this.lb_Thoiluong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_Thoiluong.AutoSize = true;
            this.lb_Thoiluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Thoiluong.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lb_Thoiluong.Location = new System.Drawing.Point(6, 259);
            this.lb_Thoiluong.Name = "lb_Thoiluong";
            this.lb_Thoiluong.Size = new System.Drawing.Size(0, 17);
            this.lb_Thoiluong.TabIndex = 4;
            this.lb_Thoiluong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_theloai
            // 
            this.lb_theloai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_theloai.AutoSize = true;
            this.lb_theloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_theloai.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lb_theloai.Location = new System.Drawing.Point(6, 295);
            this.lb_theloai.Name = "lb_theloai";
            this.lb_theloai.Size = new System.Drawing.Size(0, 17);
            this.lb_theloai.TabIndex = 2;
            // 
            // pic_mvimage
            // 
            this.pic_mvimage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pic_mvimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_mvimage.Location = new System.Drawing.Point(30, 19);
            this.pic_mvimage.Name = "pic_mvimage";
            this.pic_mvimage.Size = new System.Drawing.Size(168, 199);
            this.pic_mvimage.TabIndex = 0;
            this.pic_mvimage.TabStop = false;
            // 
            // thongtinphim
            // 
            this.thongtinphim.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.thongtinphim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.thongtinphim.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.thongtinphim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thongtinphim.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongtinphim.ForeColor = System.Drawing.Color.Yellow;
            this.thongtinphim.Location = new System.Drawing.Point(789, 116);
            this.thongtinphim.Name = "thongtinphim";
            this.thongtinphim.Size = new System.Drawing.Size(224, 28);
            this.thongtinphim.TabIndex = 4;
            this.thongtinphim.Text = "Thông tin phim";
            this.thongtinphim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Forte", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(383, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 58);
            this.label1.TabIndex = 5;
            this.label1.Text = "HOME";
            // 
            // comb_theloai
            // 
            this.comb_theloai.BackColor = System.Drawing.Color.Gray;
            this.comb_theloai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_theloai.DropDownWidth = 100;
            this.comb_theloai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comb_theloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comb_theloai.ForeColor = System.Drawing.SystemColors.Info;
            this.comb_theloai.FormattingEnabled = true;
            this.comb_theloai.Items.AddRange(new object[] {
            "Hài",
            "Tâm lý",
            "Gia đình",
            "Kinh dị",
            "Kỳ ảo",
            "Hành động"});
            this.comb_theloai.Location = new System.Drawing.Point(180, 27);
            this.comb_theloai.Name = "comb_theloai";
            this.comb_theloai.Size = new System.Drawing.Size(16, 26);
            this.comb_theloai.TabIndex = 6;
            this.comb_theloai.SelectedValueChanged += new System.EventHandler(this.comb_theloai_SelectedValueChanged);
            // 
            // lb_theloaicombobox
            // 
            this.lb_theloaicombobox.AutoSize = true;
            this.lb_theloaicombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_theloaicombobox.ForeColor = System.Drawing.Color.Yellow;
            this.lb_theloaicombobox.Location = new System.Drawing.Point(93, 30);
            this.lb_theloaicombobox.Name = "lb_theloaicombobox";
            this.lb_theloaicombobox.Size = new System.Drawing.Size(81, 22);
            this.lb_theloaicombobox.TabIndex = 7;
            this.lb_theloaicombobox.Text = "Thể Loại";
            // 
            // tb_finder
            // 
            this.tb_finder.BackColor = System.Drawing.Color.Silver;
            this.tb_finder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_finder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_finder.ForeColor = System.Drawing.Color.Teal;
            this.tb_finder.Location = new System.Drawing.Point(672, 91);
            this.tb_finder.Name = "tb_finder";
            this.tb_finder.Size = new System.Drawing.Size(100, 19);
            this.tb_finder.TabIndex = 8;
            this.tb_finder.Text = "Tìm kiếm";
            this.tb_finder.TextChanged += new System.EventHandler(this.tb_finder_TextChanged);
            // 
            // pic_finder
            // 
            this.pic_finder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_finder.BackgroundImage")));
            this.pic_finder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_finder.Location = new System.Drawing.Point(639, 85);
            this.pic_finder.Name = "pic_finder";
            this.pic_finder.Size = new System.Drawing.Size(27, 27);
            this.pic_finder.TabIndex = 9;
            this.pic_finder.TabStop = false;
            this.pic_finder.Click += new System.EventHandler(this.tb_finder_TextChanged);
            // 
            // frmMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1040, 555);
            this.Controls.Add(this.pic_finder);
            this.Controls.Add(this.tb_finder);
            this.Controls.Add(this.lb_theloaicombobox);
            this.Controls.Add(this.comb_theloai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thongtinphim);
            this.Controls.Add(this.grpb_thongtinphim);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.History);
            this.Controls.Add(this.MovieList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1056, 594);
            this.Name = "frmMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoviePlayer";
            this.Load += new System.EventHandler(this.frmMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.History)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).EndInit();
            this.grpb_thongtinphim.ResumeLayout(false);
            this.grpb_thongtinphim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mvimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_finder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView MovieList;
        private System.Windows.Forms.PictureBox History;
        private System.Windows.Forms.PictureBox Home;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox grpb_thongtinphim;
        private System.Windows.Forms.PictureBox pic_mvimage;
        private System.Windows.Forms.TextBox thongtinphim;
        private System.Windows.Forms.Label lb_theloai;
        private System.Windows.Forms.Label lb_Thoiluong;
        private System.Windows.Forms.Label lb_moviename;
        private System.Windows.Forms.Label lb_dienvien;
        private System.Windows.Forms.TextBox tb_thoiluong_value;
        private System.Windows.Forms.TextBox tb_dv_value;
        private System.Windows.Forms.TextBox tb_theloai_value;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comb_theloai;
        private System.Windows.Forms.Label lb_theloaicombobox;
        private System.Windows.Forms.TextBox tb_finder;
        private System.Windows.Forms.PictureBox pic_finder;
    }
}