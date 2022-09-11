
namespace MoviePlayer
{
    partial class frmHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistory));
            this.Home = new System.Windows.Forms.PictureBox();
            this.thongtinphim = new System.Windows.Forms.TextBox();
            this.pic_mvimage = new System.Windows.Forms.PictureBox();
            this.lb_moviename = new System.Windows.Forms.Label();
            this.tb_time_value = new System.Windows.Forms.TextBox();
            this.grpb_thongtinphim = new System.Windows.Forms.GroupBox();
            this.off_star5 = new System.Windows.Forms.PictureBox();
            this.lb_rate = new System.Windows.Forms.Label();
            this.lb_thoidiem = new System.Windows.Forms.Label();
            this.lb_thoiluong = new System.Windows.Forms.Label();
            this.on_star5 = new System.Windows.Forms.PictureBox();
            this.tb_thoidiem_value = new System.Windows.Forms.TextBox();
            this.off_star4 = new System.Windows.Forms.PictureBox();
            this.on_star4 = new System.Windows.Forms.PictureBox();
            this.off_star3 = new System.Windows.Forms.PictureBox();
            this.off_star2 = new System.Windows.Forms.PictureBox();
            this.on_star3 = new System.Windows.Forms.PictureBox();
            this.off_star1 = new System.Windows.Forms.PictureBox();
            this.on_star1 = new System.Windows.Forms.PictureBox();
            this.on_star2 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.MovieList = new System.Windows.Forms.ListView();
            this.lbHistory = new System.Windows.Forms.Label();
            this.tb_lanxem_value = new System.Windows.Forms.TextBox();
            this.lb_lanxem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mvimage)).BeginInit();
            this.grpb_thongtinphim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.off_star5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.on_star5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.off_star4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.on_star4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.off_star3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.off_star2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.on_star3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.off_star1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.on_star1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.on_star2)).BeginInit();
            this.SuspendLayout();
            // 
            // Home
            // 
            this.Home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Home.BackgroundImage")));
            this.Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Home.Location = new System.Drawing.Point(12, 12);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(57, 52);
            this.Home.TabIndex = 5;
            this.Home.TabStop = false;
            this.Home.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Home_MouseDoubleClick);
            // 
            // thongtinphim
            // 
            this.thongtinphim.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.thongtinphim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.thongtinphim.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.thongtinphim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thongtinphim.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongtinphim.ForeColor = System.Drawing.Color.Yellow;
            this.thongtinphim.Location = new System.Drawing.Point(789, 111);
            this.thongtinphim.Name = "thongtinphim";
            this.thongtinphim.Size = new System.Drawing.Size(224, 28);
            this.thongtinphim.TabIndex = 10;
            this.thongtinphim.Text = "Thông tin phim đã xem";
            this.thongtinphim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // lb_moviename
            // 
            this.lb_moviename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_moviename.AutoSize = true;
            this.lb_moviename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_moviename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lb_moviename.Location = new System.Drawing.Point(72, 221);
            this.lb_moviename.Name = "lb_moviename";
            this.lb_moviename.Size = new System.Drawing.Size(0, 15);
            this.lb_moviename.TabIndex = 5;
            // 
            // tb_time_value
            // 
            this.tb_time_value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_time_value.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_time_value.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_time_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_time_value.ForeColor = System.Drawing.Color.White;
            this.tb_time_value.Location = new System.Drawing.Point(106, 316);
            this.tb_time_value.Name = "tb_time_value";
            this.tb_time_value.ReadOnly = true;
            this.tb_time_value.Size = new System.Drawing.Size(112, 16);
            this.tb_time_value.TabIndex = 7;
            // 
            // grpb_thongtinphim
            // 
            this.grpb_thongtinphim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpb_thongtinphim.Controls.Add(this.off_star5);
            this.grpb_thongtinphim.Controls.Add(this.lb_rate);
            this.grpb_thongtinphim.Controls.Add(this.lb_lanxem);
            this.grpb_thongtinphim.Controls.Add(this.lb_thoidiem);
            this.grpb_thongtinphim.Controls.Add(this.lb_thoiluong);
            this.grpb_thongtinphim.Controls.Add(this.on_star5);
            this.grpb_thongtinphim.Controls.Add(this.tb_lanxem_value);
            this.grpb_thongtinphim.Controls.Add(this.tb_thoidiem_value);
            this.grpb_thongtinphim.Controls.Add(this.tb_time_value);
            this.grpb_thongtinphim.Controls.Add(this.off_star4);
            this.grpb_thongtinphim.Controls.Add(this.lb_moviename);
            this.grpb_thongtinphim.Controls.Add(this.on_star4);
            this.grpb_thongtinphim.Controls.Add(this.pic_mvimage);
            this.grpb_thongtinphim.Controls.Add(this.off_star3);
            this.grpb_thongtinphim.Controls.Add(this.off_star2);
            this.grpb_thongtinphim.Controls.Add(this.on_star3);
            this.grpb_thongtinphim.Controls.Add(this.off_star1);
            this.grpb_thongtinphim.Controls.Add(this.on_star1);
            this.grpb_thongtinphim.Controls.Add(this.on_star2);
            this.grpb_thongtinphim.Location = new System.Drawing.Point(789, 128);
            this.grpb_thongtinphim.Name = "grpb_thongtinphim";
            this.grpb_thongtinphim.Size = new System.Drawing.Size(224, 420);
            this.grpb_thongtinphim.TabIndex = 9;
            this.grpb_thongtinphim.TabStop = false;
            // 
            // off_star5
            // 
            this.off_star5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.off_star5.BackColor = System.Drawing.Color.Transparent;
            this.off_star5.Image = ((System.Drawing.Image)(resources.GetObject("off_star5.Image")));
            this.off_star5.Location = new System.Drawing.Point(194, 257);
            this.off_star5.Name = "off_star5";
            this.off_star5.Size = new System.Drawing.Size(22, 22);
            this.off_star5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.off_star5.TabIndex = 16;
            this.off_star5.TabStop = false;
            // 
            // lb_rate
            // 
            this.lb_rate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_rate.AutoSize = true;
            this.lb_rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lb_rate.Location = new System.Drawing.Point(6, 257);
            this.lb_rate.Name = "lb_rate";
            this.lb_rate.Size = new System.Drawing.Size(0, 17);
            this.lb_rate.TabIndex = 12;
            // 
            // lb_thoidiem
            // 
            this.lb_thoidiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_thoidiem.AutoSize = true;
            this.lb_thoidiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thoidiem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lb_thoidiem.Location = new System.Drawing.Point(6, 351);
            this.lb_thoidiem.Name = "lb_thoidiem";
            this.lb_thoidiem.Size = new System.Drawing.Size(0, 17);
            this.lb_thoidiem.TabIndex = 12;
            // 
            // lb_thoiluong
            // 
            this.lb_thoiluong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_thoiluong.AutoSize = true;
            this.lb_thoiluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thoiluong.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lb_thoiluong.Location = new System.Drawing.Point(6, 315);
            this.lb_thoiluong.Name = "lb_thoiluong";
            this.lb_thoiluong.Size = new System.Drawing.Size(0, 17);
            this.lb_thoiluong.TabIndex = 12;
            // 
            // on_star5
            // 
            this.on_star5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.on_star5.Image = ((System.Drawing.Image)(resources.GetObject("on_star5.Image")));
            this.on_star5.Location = new System.Drawing.Point(194, 257);
            this.on_star5.Name = "on_star5";
            this.on_star5.Size = new System.Drawing.Size(22, 22);
            this.on_star5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.on_star5.TabIndex = 21;
            this.on_star5.TabStop = false;
            this.on_star5.Tag = "";
            // 
            // tb_thoidiem_value
            // 
            this.tb_thoidiem_value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_thoidiem_value.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_thoidiem_value.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_thoidiem_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_thoidiem_value.ForeColor = System.Drawing.Color.White;
            this.tb_thoidiem_value.Location = new System.Drawing.Point(106, 352);
            this.tb_thoidiem_value.Name = "tb_thoidiem_value";
            this.tb_thoidiem_value.ReadOnly = true;
            this.tb_thoidiem_value.Size = new System.Drawing.Size(112, 16);
            this.tb_thoidiem_value.TabIndex = 7;
            // 
            // off_star4
            // 
            this.off_star4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.off_star4.BackColor = System.Drawing.Color.Transparent;
            this.off_star4.Image = ((System.Drawing.Image)(resources.GetObject("off_star4.Image")));
            this.off_star4.Location = new System.Drawing.Point(166, 257);
            this.off_star4.Name = "off_star4";
            this.off_star4.Size = new System.Drawing.Size(22, 22);
            this.off_star4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.off_star4.TabIndex = 17;
            this.off_star4.TabStop = false;
            // 
            // on_star4
            // 
            this.on_star4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.on_star4.Image = ((System.Drawing.Image)(resources.GetObject("on_star4.Image")));
            this.on_star4.Location = new System.Drawing.Point(166, 257);
            this.on_star4.Name = "on_star4";
            this.on_star4.Size = new System.Drawing.Size(22, 22);
            this.on_star4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.on_star4.TabIndex = 22;
            this.on_star4.TabStop = false;
            this.on_star4.Tag = "";
            // 
            // off_star3
            // 
            this.off_star3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.off_star3.BackColor = System.Drawing.Color.Transparent;
            this.off_star3.Image = ((System.Drawing.Image)(resources.GetObject("off_star3.Image")));
            this.off_star3.Location = new System.Drawing.Point(138, 257);
            this.off_star3.Name = "off_star3";
            this.off_star3.Size = new System.Drawing.Size(22, 22);
            this.off_star3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.off_star3.TabIndex = 18;
            this.off_star3.TabStop = false;
            // 
            // off_star2
            // 
            this.off_star2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.off_star2.BackColor = System.Drawing.Color.Transparent;
            this.off_star2.Image = ((System.Drawing.Image)(resources.GetObject("off_star2.Image")));
            this.off_star2.Location = new System.Drawing.Point(110, 257);
            this.off_star2.Name = "off_star2";
            this.off_star2.Size = new System.Drawing.Size(22, 22);
            this.off_star2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.off_star2.TabIndex = 19;
            this.off_star2.TabStop = false;
            // 
            // on_star3
            // 
            this.on_star3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.on_star3.Image = ((System.Drawing.Image)(resources.GetObject("on_star3.Image")));
            this.on_star3.Location = new System.Drawing.Point(138, 257);
            this.on_star3.Name = "on_star3";
            this.on_star3.Size = new System.Drawing.Size(22, 22);
            this.on_star3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.on_star3.TabIndex = 23;
            this.on_star3.TabStop = false;
            this.on_star3.Tag = "";
            // 
            // off_star1
            // 
            this.off_star1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.off_star1.BackColor = System.Drawing.Color.Transparent;
            this.off_star1.Image = ((System.Drawing.Image)(resources.GetObject("off_star1.Image")));
            this.off_star1.Location = new System.Drawing.Point(82, 257);
            this.off_star1.Name = "off_star1";
            this.off_star1.Size = new System.Drawing.Size(22, 22);
            this.off_star1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.off_star1.TabIndex = 20;
            this.off_star1.TabStop = false;
            // 
            // on_star1
            // 
            this.on_star1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.on_star1.Image = ((System.Drawing.Image)(resources.GetObject("on_star1.Image")));
            this.on_star1.Location = new System.Drawing.Point(82, 257);
            this.on_star1.Name = "on_star1";
            this.on_star1.Size = new System.Drawing.Size(22, 22);
            this.on_star1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.on_star1.TabIndex = 25;
            this.on_star1.TabStop = false;
            this.on_star1.Tag = "";
            // 
            // on_star2
            // 
            this.on_star2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.on_star2.Image = ((System.Drawing.Image)(resources.GetObject("on_star2.Image")));
            this.on_star2.Location = new System.Drawing.Point(110, 257);
            this.on_star2.Name = "on_star2";
            this.on_star2.Size = new System.Drawing.Size(22, 22);
            this.on_star2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.on_star2.TabIndex = 24;
            this.on_star2.TabStop = false;
            this.on_star2.Tag = "";
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
            this.MovieList.Location = new System.Drawing.Point(49, 111);
            this.MovieList.Name = "MovieList";
            this.MovieList.Size = new System.Drawing.Size(723, 437);
            this.MovieList.TabIndex = 6;
            this.MovieList.UseCompatibleStateImageBehavior = false;
            this.MovieList.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.MovieList_ItemMouseHover);
            this.MovieList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MovieList_MouseClick);
            // 
            // lbHistory
            // 
            this.lbHistory.AutoSize = true;
            this.lbHistory.Font = new System.Drawing.Font("Forte", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHistory.ForeColor = System.Drawing.Color.Yellow;
            this.lbHistory.Location = new System.Drawing.Point(369, 12);
            this.lbHistory.Name = "lbHistory";
            this.lbHistory.Size = new System.Drawing.Size(251, 58);
            this.lbHistory.TabIndex = 11;
            this.lbHistory.Text = "HISTORY";
            // 
            // tb_lanxem_value
            // 
            this.tb_lanxem_value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_lanxem_value.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_lanxem_value.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_lanxem_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_lanxem_value.ForeColor = System.Drawing.Color.White;
            this.tb_lanxem_value.Location = new System.Drawing.Point(106, 388);
            this.tb_lanxem_value.Name = "tb_lanxem_value";
            this.tb_lanxem_value.ReadOnly = true;
            this.tb_lanxem_value.Size = new System.Drawing.Size(112, 16);
            this.tb_lanxem_value.TabIndex = 7;
            // 
            // lb_lanxem
            // 
            this.lb_lanxem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_lanxem.AutoSize = true;
            this.lb_lanxem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lanxem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lb_lanxem.Location = new System.Drawing.Point(6, 387);
            this.lb_lanxem.Name = "lb_lanxem";
            this.lb_lanxem.Size = new System.Drawing.Size(0, 17);
            this.lb_lanxem.TabIndex = 12;
            // 
            // frmHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1040, 555);
            this.Controls.Add(this.lbHistory);
            this.Controls.Add(this.thongtinphim);
            this.Controls.Add(this.MovieList);
            this.Controls.Add(this.grpb_thongtinphim);
            this.Controls.Add(this.Home);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1056, 594);
            this.Name = "frmHistory";
            this.Text = "History";
            this.Load += new System.EventHandler(this.frmHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mvimage)).EndInit();
            this.grpb_thongtinphim.ResumeLayout(false);
            this.grpb_thongtinphim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.off_star5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.on_star5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.off_star4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.on_star4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.off_star3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.off_star2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.on_star3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.off_star1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.on_star1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.on_star2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Home;
        private System.Windows.Forms.TextBox thongtinphim;
        private System.Windows.Forms.PictureBox pic_mvimage;
        private System.Windows.Forms.Label lb_moviename;
        private System.Windows.Forms.TextBox tb_time_value;
        private System.Windows.Forms.GroupBox grpb_thongtinphim;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView MovieList;
        private System.Windows.Forms.Label lbHistory;
        private System.Windows.Forms.Label lb_thoiluong;
        private System.Windows.Forms.Label lb_rate;
        private System.Windows.Forms.PictureBox off_star5;
        private System.Windows.Forms.PictureBox on_star5;
        private System.Windows.Forms.PictureBox off_star4;
        private System.Windows.Forms.PictureBox on_star4;
        private System.Windows.Forms.PictureBox off_star3;
        private System.Windows.Forms.PictureBox off_star2;
        private System.Windows.Forms.PictureBox on_star3;
        private System.Windows.Forms.PictureBox off_star1;
        private System.Windows.Forms.PictureBox on_star1;
        private System.Windows.Forms.PictureBox on_star2;
        private System.Windows.Forms.TextBox tb_thoidiem_value;
        private System.Windows.Forms.Label lb_thoidiem;
        private System.Windows.Forms.Label lb_lanxem;
        private System.Windows.Forms.TextBox tb_lanxem_value;
    }
}